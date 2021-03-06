﻿using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System.Numerics;

namespace SoulWorkerResearch.SoulCore.IO.Network.Responses.Gesture
{
    [Response(CategoryCommand.Gesture, GestureCommand.Show)]
    public readonly struct GestureShowResponse
    {
        public int CharacterId { get; init; }
        public uint GestureId { get; init; }
        public Vector3 Position { get; init; }
        public float Yaw { get; init; }
        public float Pitch { get; init; }
    }
}
