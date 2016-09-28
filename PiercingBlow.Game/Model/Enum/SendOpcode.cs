﻿namespace PiercingBlow.Game.Model.Enum
{
    public enum SendOpcode
    {
        PROTOCOL_BASE_OPTION_SAVE_ACK = 531,
        PROTOCOL_BASE_SELECT_CHANNEL_ACK = 543,
        PROTOCOL_BASE_CONNECT_ACK = 514,
        PROTOCOL_BASE_USER_ENTER_ACK = 539,
        PROTOCOL_LOBBY_ENTER_ACK = 3074,
        PROTOCOL_LOBBY_ROOMLIST_ACK = 3078,
        PROTOCOL_LOBBY_CHATTING_ACK = 3087,
        PROTOCOL_INVENTORY_ENTER_ACK = 3330,
        PROTOCOL_INVENTORY_LEAVE_ACK = 3332,
        PROTOCOL_AUTH_SHOP_ITEMLIST_ACK = 1038,
        PROTOCOL_AUTH_SHOP_GOODSLIST_ACK = 1036,
        PROTOCOL_AUTH_SHOP_REPAIRLIST_ACK = 1070,
        PROTOCOL_AUTH_SHOP_MATCHINGLIST_ACK = 1040,
        PROTOCOL_SHOP_ENTER_ACK = 1026,
        PROTOCOL_SHOP_LEAVE_ACK = 1028,
        PROTOCOL_SHOP_GET_SAILLIST_ACK = 1030,
        PROTOCOL_ROOM_CREATE_ACK = 3842,
        PROTOCOL_BASE_DAILY_RECORD_ACK = 623,
        PROTOCOL_BASE_LOGOUT_ACK = 516,
        PROTOCOL_CLAN_ENTER_ACK = 1794,
        PROTOCOL_CLAN_LEAVE_ACK = 1796,
        PROTOCOL_CLAN_LIST_ACK = 1798,
        /// <summary>
        /// Пакеты Боя.
        /// </summary>
        PROTOCOL_BATTLE_START_GAME_ACK = 4103,
        PROTOCOL_ROOM_GET_SLOTINFO_ACK = 3848,
        PROTOCOL_BATTLE_PRESTARTBATTLE_ACK = 4106,
        PROTOCOL_BATTLE_STARTBATTLE_ACK = 4108,
        PROTOCOL_BATTLE_MISSION_ROUND_PRE_START_ACK = 4127,
        PROTOCOL_BATTLE_MISSION_ROUND_START_ACK = 4129,
        PROTOCOL_BATTLE_RESPAWN_ACK = 4114,
        PROTOCOL_BATTLE_RESPAWN_FOR_AI_ACK = 4151,
        PROTOCOL_BATTLE_DEATH_ACK = 4112,
        PROTOCOL_BATTLE_CHANGE_DIFFICULTY_LEVEL_ACK = 4149,
        /// 
        /// TEst
        ///
        PROTOCOL_TEST_BOT_ACK = 3848,
        PROTOCOL_BATTLE_UNKNOWN_ACK = 3857,
        PROTOCOL_BATTLE_UNKNOWN_1_ACK = 3857,
        PROTOCOL_BATTLE_SLOTSTATE_PRE_ACK = 3848,
    }
}
