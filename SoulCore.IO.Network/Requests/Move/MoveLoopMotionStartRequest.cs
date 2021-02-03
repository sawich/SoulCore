﻿using SoulCore.Extensions;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.IO;
using System.Numerics;

namespace SoulCore.IO.Network.Requests
{
    [Request(CategoryCommand.Move, MoveCommand.LoopMotionStart)]
    public readonly struct MoveLoopMotionStartRequest
    {
        public readonly int CharacterId;
        public readonly Vector3 Pos;
        public readonly float fYaw;
        public readonly uint StartAniId;
        public readonly uint LoopAniId;
        public readonly uint EndAniId;
        public readonly uint IdleAniId;

        public MoveLoopMotionStartRequest(BinaryReader br)
        {
            CharacterId = br.ReadInt32();
            Pos = br.ReadVector3();
            fYaw = br.ReadSingle();
            StartAniId = br.ReadUInt32();
            LoopAniId = br.ReadUInt32();
            EndAniId = br.ReadUInt32();
            IdleAniId = br.ReadUInt32();
        }
    }
}