﻿using System.Collections.Generic;
using System.Numerics;

namespace SoulWorkerResearch.SoulCore.IO.Network.Responses
{
    public sealed record NpcOthersInfosResponse
    {
        public sealed record Entity
        {
            public uint Id { get; init; }
            public Vector3 Position { get; init; }
            public float Rotation { get; init; }
            public uint Waypoint { get; init; }
            public uint CreatureId { get; init; }
        }

        public IEnumerable<Entity> Values { get; init; } = default!;
    }
}
