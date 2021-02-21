﻿using SoulCore.Extensions;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulCore.IO.Network.Requests.Chat
{
    [Request(CategoryCommand.Chat, ChatCommand.Megaphone)]
    public readonly struct ChatMegaphoneRequest
    {
        public readonly byte InventoryType;
        public readonly short Slot;
        public readonly int CharacterId;
        public readonly string CharacterName;
        public readonly string Message;

        internal ChatMegaphoneRequest(BinaryReader br)
        {
            InventoryType = br.ReadByte();
            Slot = br.ReadInt16();
            CharacterId = br.ReadInt32();
            CharacterName = br.ReadCharacterLengthUnicodeString();
            Message = br.ReadCharacterLengthUnicodeString();
        }
    }
}