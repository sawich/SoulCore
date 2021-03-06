﻿using SoulWorkerResearch.SoulCore.IO.Datas.World.Table.Extensions;
using SoulWorkerResearch.SoulCore.IO.Datas.World.Table.Types;
using System.Xml;

namespace SoulWorkerResearch.SoulCore.IO.Datas.World.Table.EventBox
{
    public sealed record VLuaFunctionBox : VEntity
    {
        /// <summary>
        /// Type of Target
        /// </summary>
        public LuaFunctionType Type { get; set; }

        /// <summary>
        /// LuaFunction
        /// </summary>
        public string Function { get; set; } = string.Empty;

        /// <summary>
        /// ID of Monster or NPC for check.
        /// </summary>
        public uint CheckId { get; set; }

        public VLuaFunctionBox()
        {
        }

        public VLuaFunctionBox(XmlNode xml) : base(xml)
        {
            Type = xml.GetEnum<LuaFunctionType>("m_eType");
            Function = xml.GetString("m_szFunction");
            CheckId = xml.GetUInt32("m_iCheckID");
        }
    }
}
