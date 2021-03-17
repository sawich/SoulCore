﻿using System.Collections.Generic;

namespace SoulCore.IO.Network.Responses
{
    public sealed record CharacterPostInfoResponse
    {
        public IEnumerable<object> Values { get; init; } = default!;
    }
}