﻿using SoulWorkerResearch.SoulCore.IO.Network.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Network.Commands
{
    [CategoryCommand(CategoryCommand.ServerUser)]
    public enum ServerUserCommand : byte
    {
        SelectCharacter = 0x1,
        Login = 0x2,
        Logout = 0x3,
        UpdateMap = 0x4,
        ExitMaze = 0x6,
        KickOut = 0x7,
        LevelUp = 0x8,
        WhisperReq = 0x9,
        WhisperRes = 0x10,
        Notice = 0x11,
        GobackLobby = 0x12,
        MoneyLog = 0x13,
        EnterServer = 0x14,
        CommunityInit = 0x15,
        EnterPartyMaze = 0x16,
        Megaphone = 0x17,
        EnterForceMaze = 0x20,
        TradePasswordStateSync = 0x26,
        TradePasswordState = 0x27,
        ExchangePriceHistoryList = 0x28,
        ExchangePriceHistoryUpdate = 0x29,
        ExchangePost = 0x30,
        NameChange = 0x31,
        CheckSessionId = 0x32,
        Option = 0x33,
        MyroomPollenSync = 0x34,
        UpdateAuthType = 0x35,
        UpdateAwaken = 0x36,
        GfBillingPostReload = 0x37,
        ProfilePhotoUpdate = 0x38,
    }
}
