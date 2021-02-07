﻿using System;
using System.Net;

namespace SoulCore.IO.Network
{
    public abstract class ServerBase<TServer, TSession>
        where TServer : ServerBase<TServer, TSession>
        where TSession : SessionBase<TServer, TSession>
    {
        internal readonly InternalServer<TServer, TSession> InternalServer;

        public bool Start() => InternalServer.Start();

        public bool Stop() => InternalServer.Stop();

        protected ServerBase(IServiceProvider services, string ip, ushort port) =>
            InternalServer = new((TServer)this, services, new(IPAddress.Parse(ip), port));
    }
}