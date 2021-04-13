﻿using SoulWorkerResearch.SoulCore.IO.Datas.World.Table.Types;
using System.Xml;
using SoulWorkerResearch.SoulCore.IO.Datas.World.Table.Extensions;

namespace SoulWorkerResearch.SoulCore.IO.Datas.World.Table.EventBox
{
    public sealed record VStartEventBox : VEntity
    {
        /// <summary>
        ///
        /// </summary>
        public SpawnType SpawnType { get; set; }

        internal VStartEventBox(XmlNode xml) : base(xml) =>
            SpawnType = xml.GetEnum<SpawnType>("m_eSpawnType");
    }
}
