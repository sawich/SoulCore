﻿using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.League
{
    [Request(CategoryCommand.League, LeagueCommand.Withdraw)]
    public readonly struct LeagueWithdrawRequest
    {
        internal LeagueWithdrawRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}
