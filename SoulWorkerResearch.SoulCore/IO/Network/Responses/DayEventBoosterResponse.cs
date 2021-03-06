﻿using System.Collections.Generic;

namespace SoulWorkerResearch.SoulCore.IO.Network.Responses
{
    public sealed record DayEventBoosterResponse
    {
        public sealed record Entity
        {
            public ushort Id { get; init; }
            public ushort Maze { get; init; }
        }

        public IReadOnlyList<Entity> Values { get; init; } = default!;
    }
}
