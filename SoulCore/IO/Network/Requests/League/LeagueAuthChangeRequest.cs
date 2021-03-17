﻿using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.League
{
    [Request(CategoryCommand.League, LeagueCommand.AuthChange)]
    public readonly struct LeagueAuthChangeRequest
    {
        internal LeagueAuthChangeRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}