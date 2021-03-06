﻿using System;
using System.Collections.Generic;

namespace SoulWorkerResearch.SoulCore.IO.Network.Responses
{
    public sealed partial record CharacterStatsUpdateResponse
    {
        public int Character { get; init; }
        public IEnumerable<CSUREntity> Values { get; init; } = Array.Empty<CSUREntity>();
    }
}
