﻿using NetCoreServer;
using SoulWorkerResearch.SoulCore.IO.Network.Utils;
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

        protected override void OnDisconnected() => Session.OnDisconnected();

        protected override void OnReceived(byte[] buffer, long offset, long size)
        {
            Task task = Task.Run(async () =>
            {
                using BinaryReader br = new(new MemoryStream(buffer, (int)offset, (int)size, false), Encoding.ASCII, false);

                try
                {
                    do
                    {
                        PacketHeader header = new(br);

                        // Begin packet body position
                        int startPosition = (int)br.BaseStream.Position;

                        // End packet body position
                        int endPosition = (int)(br.BaseStream.Position - (header.BodySize + CommonDefines.PacketHeaderSize));

                        // Check if end position beyond end of stream
                        Debug.Assert(((MemoryStream)br.BaseStream).GetBuffer().Length > endPosition);

                        // Decode packet body
                        PacketUtils.Exchange(((MemoryStream)br.BaseStream).GetBuffer(), startPosition, endPosition);

                        // Call sesion packet handler
                        await Session.OnPacketReceived(header, br).ConfigureAwait(false);
                    } while (br.BaseStream.Position < br.BaseStream.Length);
                }
                catch
                {
#if !DEBUG
                    Disconnect();
#endif
                }
            });

            task.Wait();
        }

        internal InternalSession(InternalServer<TServer, TSession> server, TSession session) : base(server) => Session = session;
    }
}

// https://youtu.be/UnIhRpIT7nc
// https://youtu.be/iceS6BvhuQ8