﻿using SoulCore.IO.Network.Attributes;
using System.IO;

namespace SoulCore.IO.Network.Requests
{
    [Request]
    public readonly struct SCharacterChangeBackgroundRequest
    {
        public int AccountId { get; }
        public uint BackgroundId { get; }
        private readonly uint _1;

        public SCharacterChangeBackgroundRequest(BinaryReader br)
        {
            AccountId = br.ReadInt32();
            BackgroundId = br.ReadUInt32();
            _1 = br.ReadUInt32();
        }
    }
}