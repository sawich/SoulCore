﻿using System.Collections.Generic;
using System.Diagnostics;

namespace SoulWorkerResearch.SoulCore.IO.Network.Utils
{
    public static class PacketUtils
    {
        #region Constants

        private static IReadOnlyList<byte> KeyTable { get; } = new byte[]
        {
            //0x57, 0x19, 0xC6, 0x2D, 0x56, 0x68, 0x3A, 0xCC,
            //0x60, 0x3B, 0x0B, 0xB1, 0x90, 0x5C, 0x4A, 0xF8,
            //0x80, 0x28, 0xB1, 0x45, 0xB6, 0x85, 0xE7, 0x4C,
            //0x06, 0x2D, 0x55, 0x83, 0xAF, 0x44, 0x99, 0x95,
            //0xD9, 0x98, 0xBF, 0xAE, 0x53, 0x43, 0x63, 0xC8,
            //0x4A, 0x71, 0x80, 0x9D, 0x0B, 0xA1, 0x70, 0x8A,
            //0x0F, 0x54, 0x9C, 0x1B, 0x06, 0xC0, 0xEA, 0x3C,
            //0xC0, 0x88, 0x71, 0x48, 0xB3, 0xB9, 0x45, 0x78,
            //0xFF, 0xFF, 0xFF, 0xFF, 0x7F, 0x7F, 0x7F, 0xFF,
            //0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0xFF, 0xFF,
            //0x00, 0xFF, 0xFF, 0xFF, 0x00, 0xFF, 0x00, 0xFF,
            //0xFF, 0xFF, 0x00, 0xFF, 0xFF, 0x00, 0x00, 0xFF,
            //0xFF, 0x00, 0xFF, 0xFF

            0xEE, 0x1B, 0xDE, 0xA6, 0x46, 0xE9, 0x2A, 0xDB,
            0x97, 0x67, 0x9C, 0x02, 0x3C, 0xCE, 0x9A
        };

        #endregion Constants

        #region Encypt/Decrypt

        public static void Exchange(ref byte[] encryptedBuffer) =>
            Exchange(ref encryptedBuffer, 0x0, encryptedBuffer.Length);

        public static void Exchange(ref byte[] encryptedBuffer, int offset) =>
            Exchange(ref encryptedBuffer, offset, encryptedBuffer.Length - offset);

        public static void Exchange(ref byte[] encryptedBuffer, int offset, int size)
        {
            Debug.Assert(size > 0);
            Debug.Assert(offset >= 0);
            Debug.Assert(offset <= encryptedBuffer.Length);

            for (int i = 0; i < size; ++i)
            {
                encryptedBuffer[offset + i] ^= KeyTable[i % KeyTable.Count];
            }
        }

        public static void Exchange(byte[] encryptedBuffer, int offset, int size) =>
            Exchange(ref encryptedBuffer, offset, size);

        #endregion Encypt/Decrypt

        #region Pack

        public static byte[] Pack(PacketWriter writer)
        {
            byte[] response = writer.GetBuffer();
            Exchange(ref response, CommonDefines.PacketHeaderSize + CommonDefines.PacketOpcodeSize, (int)writer.BaseStream.Length - (CommonDefines.PacketHeaderSize + CommonDefines.PacketOpcodeSize));

            return response;
        }

        #endregion Pack
    }
}