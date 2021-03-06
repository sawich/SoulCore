﻿using SoulWorkerResearch.SoulCore.IO.Network.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Network.Commands
{
    [CategoryCommand(CategoryCommand.ServerParty)]
    public enum ServerPartyCommand : byte
    {
        Create = 0x1,
        Join_member = 0x2,
        Leave_member = 0x3,
        Change_master = 0x4,
        Update_member = 0x5,
        Delete = 0x6,
        Enter_maze = 0x8,
        Update_info = 0x9,
        Enter_server = 0x10,
        Invite = 0x11,
        Accept = 0x12,
        Cancel = 0x13,
        Message = 0x14,
        Matching_enter = 0x20,
        Matching_exit = 0x21,
        Matching_check = 0x22,
        Matching_reset = 0x23,
        Matching_wait = 0x24,
        Recruit_add = 0x25,
        Recruit_del = 0x26,
        Recruit_apply = 0x27,
        Recruit_apply_accept = 0x28,
        Recruit_apply_reject = 0x29,
        Recruit_update = 0x2A,
        Recruit_list = 0x2B,
        Recruit_my_apply_list = 0x2C,
        Recruit_applylist = 0x2D,
        Recruit_info = 0x2E,
        Recruit_apply_del = 0x2F,
        Recruit_apply_info = 0x30,
        Recruit_apply_notice = 0x31,
        Recruit_apply_accept_check = 0x32,
        Info = 0x40,
        Name_change = 0x41,
        Matching_maze = 0x42,
        Maze_clear = 0x43,
    }
}
