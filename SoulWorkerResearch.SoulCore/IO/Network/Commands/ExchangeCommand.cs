﻿using SoulWorkerResearch.SoulCore.IO.Network.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Network.Commands
{
    [CategoryCommand(CategoryCommand.Exchange)]
    public enum ExchangeCommand : byte
    {
        Search = 0x1,
        PriceHistory = 0x2,
        InterestList = 0x3,
        InterestItem = 0x4,
        SellRegister = 0x5,
        ItemBuy = 0x6,
        ItemRecall = 0x7,
        MyList = 0x8,
        End = 0x80
    }
}
