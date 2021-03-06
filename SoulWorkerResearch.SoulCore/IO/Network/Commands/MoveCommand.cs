﻿using SoulWorkerResearch.SoulCore.IO.Network.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Network.Commands
{
    [CategoryCommand(CategoryCommand.Move)]
    public enum MoveCommand : byte
    {
        Move = 0x1,
        MoveBt = 0x2,
        Stop = 0x3,
        StopBt = 0x4,
        Jump = 0x5,
        JumpBt = 0x6,
        Battle = 0x7,
        BattleBt = 0x8,
        Gaze = 0x9,
        GazeBt = 0xA,
        TraceBt = 0xb,
        IdleBt = 0xC,
        InfoBt = 0xD,
        IdlesBt = 0xF,
        Motion = 0x10,
        MotionBt = 0x11,
        StiffenBt = 0x12,
        IgnoreMotionDelta = 0x13,
        UpdateDir = 0x14,
        Drop = 0x15,
        TransportTake = 0x16,
        TransportOff = 0x17,
        Grap = 0x20,
        Rotation = 0x21,
        Position = 0x22,
        LoopMotionStart = 0x30,
        LoopMotionStartBt = 0x31,
        LoopMotionEnd = 0x32,
        LoopMotionEndBt = 0x33,
        AttacedBt = 0x34,
        AttacedEndBt = 0x35,
        AttacedEnd = 0x36,
        GroundStatus = 0x40,
        JumpQuickDown = 0x50,
    }
}
