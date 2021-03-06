﻿using SoulWorkerResearch.SoulCore.IO.Network.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Network.Commands
{
    [CategoryCommand(CategoryCommand.Vaccum)]
    public enum VaccumCommand : byte
    {
        ClickStart = 0x1,
        ClickCancel = 0x2,
        ClickComplete = 0x3,
        In = 0x11,
        Out = 0x12,
        Infos = 0x13,
    }
}
