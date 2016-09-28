﻿///
/// Create by Kirito
///

using PiercingBlow.Commons.Network;

namespace PiercingBlow.Login.Network.Send
{
    class PROTOCOL_BASE_MAP_MATCHINGLIST_PART_3_ACK : ServerPacket
    {
        public PROTOCOL_BASE_MAP_MATCHINGLIST_PART_3_ACK()
        {
        }

        public override void WriteImpl()
        {
            WriteB(new byte[]
{
    0x00, 0x00, 0x4b, 0x14, 0x00, 0x00, 0x00, 0x26, 0x00, 0x80, 0x04, 0x10, 0x00, 0x00, 0x00, 0x14,
    0x00, 0x00, 0x00, 0x27, 0x00, 0x80, 0x04, 0x10, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x29,
    0x00, 0x80, 0x04, 0x10, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x2a, 0x00, 0x80, 0x04, 0x10,
    0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x42, 0x00, 0x80, 0x04, 0x10, 0x00, 0x00, 0x00, 0x14,
    0x00, 0x00, 0x00, 0x43, 0x00, 0x80, 0x04, 0x10, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x46,
    0x00, 0x80, 0x04, 0x10, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x4a, 0x00, 0x80, 0x04, 0x08,
    0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x4d, 0x00, 0x80, 0x04, 0x08, 0x00, 0x00, 0x00, 0x15,
    0x00, 0x00, 0x00, 0x01, 0x00, 0xe0, 0x04, 0x10, 0x00, 0x00, 0x00, 0x15, 0x00, 0x00, 0x00, 0x02,
    0x00, 0xe0, 0x04, 0x10, 0x00, 0x00, 0x00, 0x15, 0x00, 0x00, 0x00, 0x03, 0x00, 0xe0, 0x04, 0x10,
    0x00, 0x00, 0x00, 0x15, 0x00, 0x00, 0x00, 0x04, 0x00, 0xe0, 0x04, 0x10, 0x00, 0x00, 0x00, 0x15,
    0x00, 0x00, 0x00, 0x05, 0x00, 0xe0, 0x04, 0x10, 0x00, 0x00, 0x00, 0x15, 0x00, 0x00, 0x00, 0x06,
    0x00, 0xe0, 0x04, 0x10, 0x00, 0x00, 0x00, 0x15, 0x00, 0x00, 0x00, 0x07, 0x00, 0xe0, 0x04, 0x10,
    0x00, 0x00, 0x00, 0x15, 0x00, 0x00, 0x00, 0x08, 0x00, 0xe0, 0x04, 0x10, 0x00, 0x00, 0x00, 0x15,
    0x00, 0x00, 0x00, 0x09, 0x00, 0xe0, 0x04, 0x08, 0x00, 0x00, 0x00, 0x15, 0x00, 0x00, 0x00, 0x0a,
    0x00, 0xe0, 0x04, 0x08, 0x00, 0x00, 0x00, 0x15, 0x00, 0x00, 0x00, 0x0b, 0x00, 0xe0, 0x04, 0x10,
    0x00, 0x00, 0x00, 0x15, 0x00, 0x00, 0x00, 0x0c, 0x00, 0xe0, 0x04, 0x10, 0x00, 0x00, 0x00, 0x15,
    0x00, 0x00, 0x00, 0x0d, 0x00, 0xe0, 0x04, 0x10, 0x00, 0x00, 0x00, 0x15, 0x00, 0x00, 0x00, 0x0e,
    0x00, 0xe0, 0x04, 0x10, 0x00, 0x00, 0x00, 0x15, 0x00, 0x00, 0x00, 0x0f, 0x00, 0xe0, 0x04, 0x10,
    0x00, 0x00, 0x00, 0x15, 0x00, 0x00, 0x00, 0x11, 0x00, 0xe0, 0x04, 0x10, 0x00, 0x00, 0x00, 0x15,
    0x00, 0x00, 0x00, 0x12, 0x00, 0xe0, 0x04, 0x10, 0x00, 0x00, 0x00, 0x15, 0x00, 0x00, 0x00, 0x13,
    0x00, 0xe0, 0x04, 0x10, 0x00, 0x00, 0x00, 0x15, 0x00, 0x00, 0x00, 0x14, 0x00, 0xe0, 0x04, 0x10,
    0x00, 0x00, 0x00, 0x15, 0x00, 0x00, 0x00, 0x15, 0x00, 0xe0, 0x04, 0x10, 0x00, 0x00, 0x00, 0x15,
    0x00, 0x00, 0x00, 0x16, 0x00, 0xe0, 0x04, 0x10, 0x00, 0x00, 0x00, 0x15, 0x00, 0x00, 0x00, 0x17,
    0x00, 0xe0, 0x04, 0x10, 0x00, 0x00, 0x00, 0x15, 0x00, 0x00, 0x00, 0x25, 0x00, 0xe0, 0x04, 0x10,
    0x00, 0x00, 0x00, 0x15, 0x00, 0x00, 0x00, 0x26, 0x00, 0xe0, 0x04, 0x10, 0x00, 0x00, 0x00, 0x15,
    0x00, 0x00, 0x00, 0x27, 0x00, 0xe0, 0x04, 0x10, 0x00, 0x00, 0x00, 0x15, 0x00, 0x00, 0x00, 0x29,
    0x00, 0xe0, 0x04, 0x10, 0x00, 0x00, 0x00, 0x15, 0x00, 0x00, 0x00, 0x2a, 0x00, 0xe0, 0x04, 0x10,
    0x00, 0x00, 0x00, 0x15, 0x00, 0x00, 0x00, 0x42, 0x00, 0xe0, 0x04, 0x10, 0x00, 0x00, 0x00, 0x15,
    0x00, 0x00, 0x00, 0x43, 0x00, 0xe0, 0x04, 0x10, 0x00, 0x00, 0x00, 0x15, 0x00, 0x00, 0x00, 0x46,
    0x00, 0xe0, 0x04, 0x10, 0x00, 0x00, 0x00, 0x15, 0x00, 0x00, 0x00, 0x4a, 0x00, 0xe0, 0x04, 0x08,
    0x00, 0x00, 0x00, 0x15, 0x00, 0x00, 0x00, 0x4d, 0x00, 0xe0, 0x04, 0x08, 0x00, 0x00, 0x00, 0x16,
    0x00, 0x00, 0x00, 0x0c, 0x80, 0x60, 0x08, 0x10, 0x00, 0x00, 0x00, 0x16, 0x00, 0x00, 0x00, 0x0d,
    0x80, 0x60, 0x08, 0x10, 0x00, 0x00, 0x00, 0x16, 0x00, 0x00, 0x00, 0x0e, 0x80, 0x60, 0x08, 0x10,
    0x00, 0x00, 0x00, 0x16, 0x00, 0x00, 0x00, 0x0f, 0x80, 0x60, 0x08, 0x10, 0x00, 0x00, 0x00, 0x16,
    0x00, 0x00, 0x00, 0x13, 0x80, 0x60, 0x08, 0x10, 0x00, 0x00, 0x00, 0x16, 0x00, 0x00, 0x00, 0x19,
    0x80, 0x60, 0x08, 0x10, 0x00, 0x00, 0x00, 0x16, 0x00, 0x00, 0x00, 0x2b, 0x80, 0x60, 0x08, 0x10,
    0x00, 0x00, 0x00, 0x16, 0x00, 0x00, 0x00, 0x2d, 0x80, 0x60, 0x08, 0x10, 0x00, 0x00, 0x00, 0x16,
    0x00, 0x00, 0x00, 0x30, 0x80, 0x60, 0x08, 0x10, 0x00, 0x00, 0x00, 0x16, 0x00, 0x00, 0x00, 0x4c,
    0x80, 0x60, 0x08, 0x10, 0x00, 0x00, 0x00, 0x17, 0x00, 0x00, 0x00, 0x0c, 0x80, 0x80, 0x08, 0x10,
    0x00, 0x00, 0x00, 0x17, 0x00, 0x00, 0x00, 0x0d, 0x80, 0x80, 0x08, 0x10, 0x00, 0x00, 0x00, 0x17,
    0x00, 0x00, 0x00, 0x0e, 0x80, 0x80, 0x08, 0x10, 0x00, 0x00, 0x00, 0x17, 0x00, 0x00, 0x00, 0x0f,
    0x80, 0x80, 0x08, 0x10, 0x00, 0x00, 0x00, 0x17, 0x00, 0x00, 0x00, 0x13, 0x80, 0x80, 0x08, 0x10,
    0x00, 0x00, 0x00, 0x17, 0x00, 0x00, 0x00, 0x19, 0x80, 0x80, 0x08, 0x10, 0x00, 0x00, 0x00, 0x17,
    0x00, 0x00, 0x00, 0x2b, 0x80, 0x80, 0x08, 0x10, 0x00, 0x00, 0x00, 0x17, 0x00, 0x00, 0x00, 0x2c,
    0x80, 0x80, 0x08, 0x10, 0x00, 0x00, 0x00, 0x17, 0x00, 0x00, 0x00, 0x2d, 0x80, 0x80, 0x08, 0x10,
    0x00, 0x00, 0x00, 0x17, 0x00, 0x00, 0x00, 0x30, 0x80, 0x80, 0x08, 0x10, 0x00, 0x00, 0x00, 0x17,
    0x00, 0x00, 0x00, 0x4c, 0x80, 0x80, 0x08, 0x10, 0x00, 0x00, 0x00, 0x18, 0x00, 0x00, 0x00, 0x0c,
    0x80, 0xe0, 0x08, 0x10, 0x00, 0x00, 0x00, 0x18, 0x00, 0x00, 0x00, 0x0d, 0x80, 0xe0, 0x08, 0x10,
    0x00, 0x00, 0x00, 0x18, 0x00, 0x00, 0x00, 0x0e, 0x80, 0xe0, 0x08, 0x10, 0x00, 0x00, 0x00, 0x18,
    0x00, 0x00, 0x00, 0x0f, 0x80, 0xe0, 0x08, 0x10, 0x00, 0x00, 0x00, 0x18, 0x00, 0x00, 0x00, 0x13,
    0x80, 0xe0, 0x08, 0x10, 0x00, 0x00, 0x00, 0x18, 0x00, 0x00, 0x00, 0x19, 0x80, 0xe0, 0x08, 0x10,
    0x00, 0x00, 0x00, 0x18, 0x00, 0x00, 0x00, 0x2b, 0x80, 0xe0, 0x08, 0x10, 0x00, 0x00, 0x00, 0x18,
    0x00, 0x00, 0x00, 0x2d, 0x80, 0xe0, 0x08, 0x10, 0x00, 0x00, 0x00, 0x18, 0x00, 0x00, 0x00, 0x30,
    0x80, 0xe0, 0x08, 0x10, 0x00, 0x00, 0x00, 0x18, 0x00, 0x00, 0x00, 0x4c, 0x80, 0xe0, 0x08, 0x10,
    0x00, 0x00, 0x00, 0x25, 0x00, 0x00, 0x00, 0x28, 0x00, 0x60, 0x34, 0x10, 0x00, 0x00, 0x00, 0x26,
    0x00, 0x00, 0x00, 0x28, 0x00, 0x80, 0x34, 0x10, 0x00, 0x00, 0x00, 0x27, 0x00, 0x00, 0x00, 0x28,
    0x00, 0xe0, 0x34, 0x10, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0xc8, 0x00, 0x13, 0x01
});
        }
    }
}
