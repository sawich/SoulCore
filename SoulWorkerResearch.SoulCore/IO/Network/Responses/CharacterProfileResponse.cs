﻿using SoulWorkerResearch.SoulCore.Types;

namespace SoulWorkerResearch.SoulCore.IO.Network.Responses
{
    public sealed record CharacterProfileResponse
    {
        public ProfileStatus Status { get; init; }
        public string About { get; init; } = default!;
        public string Note { get; init; } = default!;
    }
}
