﻿using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.Types;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SoulWorkerResearch.SoulCore.IO.Datas.Bin.Table.Entities
{
    using KeyType = Class;

    [Table("tb_Customize_Hair")]
    public sealed class CustomizeHairEntity : ITableEntity<KeyType>
    {
        public KeyType Id { get; set; }
        public List<uint> Unknown1 { get; set; }
        public List<uint> Style { get; set; }
        public List<uint> Unknown2 { get; set; }
        public List<string> Icons { get; set; }
        public List<uint> Color { get; set; }

        public CustomizeHairEntity(BinaryReader br)
        {
            Id = br.ReadClass();
            Unknown1 = br.ReadUInt32Enumerable(ItemsCount).ToList();
            Style = br.ReadUInt32Enumerable(ItemsCount).ToList();
            Unknown2 = br.ReadUInt32Enumerable(ItemsCount).ToList();
            Icons = br.ReadByteLengthUnicodeStringEnumerable(ItemsCount).ToList();
            Color = br.ReadUInt32Enumerable(ItemsCount).ToList();
        }

        private const byte ItemsCount = 10;
    }
}
