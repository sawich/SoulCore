﻿using Microsoft.Extensions.Logging;
using NetCoreServer;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace SoulWorkerResearch.SoulCore.IO.Network
{
    internal sealed class InternalSession<TServer, TSession> : TcpSession
        where TServer : BaseServer<TServer, TSession>
        where TSession : BaseSession<TServer, TSession>
    {
        internal readonly TSession Session;

        private readonly ILogger<InternalSession<TServer, TSession>> _logger;

        protected override void OnDisconnected() => Session.OnDisconnected();

        protected override void OnReceived(byte[] buffer, long offset, long size)
        {
            _logger.LogDebug("Recv packet");

            Task task = Task.Run(async () =>
            {
                using BinaryReader br = new(new MemoryStream(buffer, (int)offset, (int)size, false, true), Encoding.ASCII, false);

                try
                {
                    await Session.OnRawPacketReceived(br).ConfigureAwait(false);

                    do
                    {
                        PacketHeader header = new(br);

                        // Begin packet body position
                        int startPosition = (int)br.BaseStream.Position;

                        // End packet body position
                        int endPosition = startPosition + header.BodySize + CommonDefines.PacketHeaderSize;

                        // Check if end position beyond end of stream
                        Debug.Assert(((MemoryStream)br.BaseStream).GetBuffer().Length > endPosition);

                        // Decode packet body
                        Session.Server.OnPacketExchange(((MemoryStream)br.BaseStream).GetBuffer().AsSpan(startPosition, endPosition));

                        // Call sesion packet handler
                        await Session.OnPacketReceived(header, br).ConfigureAwait(false);
                    } while (br.BaseStream.Position < br.BaseStream.Length);
                }
                catch (Exception e)
                {
                    _logger.LogError(e, "Session exception happened");
#if !DEBUG
                    Disconnect();
#endif
                }
            });

            task.Wait();
        }

        internal InternalSession(InternalServer<TServer, TSession> server, TSession session, ILogger<InternalSession<TServer, TSession>> logger) :
            base(server)
        {
            Session = session;
            _logger = logger;
        }
    }
}

// https://youtu.be/UnIhRpIT7nc
// https://youtu.be/iceS6BvhuQ8