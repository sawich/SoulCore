﻿using System;
using System.Collections.Generic;

namespace SoulWorkerResearch.SoulCore.IO.Network.Responses.Character
{
    public sealed partial record SCTitleAddResponse
    {
        public int CharacterId { get; init; }
        public IEnumerable<Entity> Values { get; init; } = Array.Empty<Entity>();
    }
}
