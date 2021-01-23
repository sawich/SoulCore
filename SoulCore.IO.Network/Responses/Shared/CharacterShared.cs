﻿using SoulCore.Types;
using System.Collections.Generic;

namespace SoulCore.IO.Network.Responses.Shared
{
    public record CharacterShared
    {
        public readonly struct StatsInfo
        {
            public uint MaxStamina { get; init; }
            public uint CurrentHp { get; init; }
            public uint MaxHp { get; init; }
            public uint CurrentSg { get; init; }
            public uint MaxSg { get; init; }
            public float AttackSpeed { get; init; }
            public float MoveSpeed { get; init; }
        }

        public readonly struct AppearanceInfo
        {
            public readonly struct HairInfo
            {
                public ushort Style { get; init; }
                public ushort Color { get; init; }
            }

            public HairInfo Hair { get; init; }
            public ushort EyeColor { get; init; }
            public ushort SkinColor { get; init; }
            public HairInfo EquippedHair { get; init; }
            public ushort EquippedEyeColor { get; init; }
            public ushort EquippedSkinColor { get; init; }
        }

        public sealed record EquippedGearInfo
        {
            public byte UpgradeLevel { get; init; }
            public int PrototypeId { get; init; } = -1;
        }

        public readonly struct EquippedCostumeInfos
        {
            public sealed record CostumeInfo
            {
                public int PrototypeId { get; init; }
                public uint Color { get; init; }
            }

            public IEnumerable<CostumeInfo?> View { get; init; }
            public IEnumerable<CostumeInfo?> Battle { get; init; }
        }

        public int Id { get; init; }
        public byte Slot { get; init; }
        public byte Level { get; init; }
        public Class Class { get; init; }
        public ClassAdvancement Advancement { get; init; }
        public uint Photo { get; init; }
        public string Name { get; init; } = default!;
        public AppearanceInfo Appearance { get; init; }
        public StatsInfo Stats { get; init; }
        public EquippedGearInfo WeaponItem { get; init; } = default!;
        public EquippedCostumeInfos EquippedItems { get; init; }
    }
}