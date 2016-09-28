﻿///
/// Create by Kirito
///

using PiercingBlow.Commons.Network;

namespace PiercingBlow.Login.Network.Send
{
    class PROTOCOL_BASE_MAP_MATCHINGLIST_PART_2_ACK : ServerPacket
    {
        public PROTOCOL_BASE_MAP_MATCHINGLIST_PART_2_ACK()
        {
        }

        public override void WriteImpl()
        {
            WriteB(new byte[]
{
    0x00, 0x00, 0x64, 0x08, 0x00, 0x00, 0x00, 0x05, 0x20, 0x00, 0x04, 0x10, 0x00, 0x00, 0x00, 0x08,
    0x00, 0x00, 0x00, 0x06, 0x20, 0x00, 0x04, 0x10, 0x00, 0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x07,
    0x20, 0x00, 0x04, 0x10, 0x00, 0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x08, 0x20, 0x00, 0x04, 0x10,
    0x00, 0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x09, 0x20, 0x00, 0x04, 0x08, 0x00, 0x00, 0x00, 0x08,
    0x00, 0x00, 0x00, 0x0a, 0x20, 0x00, 0x04, 0x08, 0x00, 0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x0b,
    0x20, 0x00, 0x04, 0x10, 0x00, 0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x0c, 0x20, 0x00, 0x04, 0x10,
    0x00, 0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x0d, 0x20, 0x00, 0x04, 0x10, 0x00, 0x00, 0x00, 0x08,
    0x00, 0x00, 0x00, 0x0e, 0x20, 0x00, 0x04, 0x10, 0x00, 0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x0f,
    0x20, 0x00, 0x04, 0x10, 0x00, 0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x11, 0x20, 0x00, 0x04, 0x10,
    0x00, 0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x12, 0x20, 0x00, 0x04, 0x10, 0x00, 0x00, 0x00, 0x08,
    0x00, 0x00, 0x00, 0x13, 0x20, 0x00, 0x04, 0x10, 0x00, 0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x14,
    0x20, 0x00, 0x04, 0x10, 0x00, 0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x15, 0x20, 0x00, 0x04, 0x10,
    0x00, 0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x16, 0x20, 0x00, 0x04, 0x10, 0x00, 0x00, 0x00, 0x08,
    0x00, 0x00, 0x00, 0x17, 0x20, 0x00, 0x04, 0x10, 0x00, 0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x18,
    0x20, 0x00, 0x04, 0x10, 0x00, 0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x19, 0x20, 0x00, 0x04, 0x10,
    0x00, 0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x1a, 0x20, 0x00, 0x04, 0x10, 0x00, 0x00, 0x00, 0x08,
    0x00, 0x00, 0x00, 0x1b, 0x20, 0x00, 0x04, 0x10, 0x00, 0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x1c,
    0x20, 0x00, 0x04, 0x10, 0x00, 0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x1d, 0x20, 0x00, 0x04, 0x10,
    0x00, 0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x1e, 0x20, 0x00, 0x04, 0x10, 0x00, 0x00, 0x00, 0x08,
    0x00, 0x00, 0x00, 0x1f, 0x20, 0x00, 0x04, 0x10, 0x00, 0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x20,
    0x20, 0x00, 0x04, 0x10, 0x00, 0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x21, 0x20, 0x00, 0x04, 0x10,
    0x00, 0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x22, 0x20, 0x00, 0x04, 0x10, 0x00, 0x00, 0x00, 0x08,
    0x00, 0x00, 0x00, 0x23, 0x20, 0x00, 0x04, 0x10, 0x00, 0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x24,
    0x20, 0x00, 0x04, 0x10, 0x00, 0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x25, 0x20, 0x00, 0x04, 0x10,
    0x00, 0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x26, 0x20, 0x00, 0x04, 0x10, 0x00, 0x00, 0x00, 0x08,
    0x00, 0x00, 0x00, 0x27, 0x20, 0x00, 0x04, 0x10, 0x00, 0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x29,
    0x20, 0x00, 0x04, 0x10, 0x00, 0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x2a, 0x20, 0x00, 0x04, 0x10,
    0x00, 0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x42, 0x20, 0x00, 0x04, 0x10, 0x00, 0x00, 0x00, 0x08,
    0x00, 0x00, 0x00, 0x43, 0x20, 0x00, 0x04, 0x10, 0x00, 0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x46,
    0x20, 0x00, 0x04, 0x10, 0x00, 0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x4d, 0x20, 0x00, 0x04, 0x08,
    0x00, 0x00, 0x00, 0x0a, 0x00, 0x00, 0x00, 0x39, 0x00, 0x00, 0x28, 0x10, 0x00, 0x00, 0x00, 0x10,
    0x00, 0x00, 0x00, 0x01, 0x00, 0x02, 0x04, 0x10, 0x00, 0x00, 0x00, 0x12, 0x00, 0x00, 0x00, 0x4e,
    0x00, 0x06, 0x04, 0x10, 0x00, 0x00, 0x00, 0x13, 0x00, 0x00, 0x00, 0x01, 0x00, 0x60, 0x04, 0x10,
    0x00, 0x00, 0x00, 0x13, 0x00, 0x00, 0x00, 0x02, 0x00, 0x60, 0x04, 0x10, 0x00, 0x00, 0x00, 0x13,
    0x00, 0x00, 0x00, 0x03, 0x00, 0x60, 0x04, 0x10, 0x00, 0x00, 0x00, 0x13, 0x00, 0x00, 0x00, 0x04,
    0x00, 0x60, 0x04, 0x10, 0x00, 0x00, 0x00, 0x13, 0x00, 0x00, 0x00, 0x05, 0x00, 0x60, 0x04, 0x10,
    0x00, 0x00, 0x00, 0x13, 0x00, 0x00, 0x00, 0x06, 0x00, 0x60, 0x04, 0x10, 0x00, 0x00, 0x00, 0x13,
    0x00, 0x00, 0x00, 0x07, 0x00, 0x60, 0x04, 0x10, 0x00, 0x00, 0x00, 0x13, 0x00, 0x00, 0x00, 0x08,
    0x00, 0x60, 0x04, 0x10, 0x00, 0x00, 0x00, 0x13, 0x00, 0x00, 0x00, 0x09, 0x00, 0x60, 0x04, 0x08,
    0x00, 0x00, 0x00, 0x13, 0x00, 0x00, 0x00, 0x0a, 0x00, 0x60, 0x04, 0x08, 0x00, 0x00, 0x00, 0x13,
    0x00, 0x00, 0x00, 0x0b, 0x00, 0x60, 0x04, 0x10, 0x00, 0x00, 0x00, 0x13, 0x00, 0x00, 0x00, 0x0c,
    0x00, 0x60, 0x04, 0x10, 0x00, 0x00, 0x00, 0x13, 0x00, 0x00, 0x00, 0x0d, 0x00, 0x60, 0x04, 0x10,
    0x00, 0x00, 0x00, 0x13, 0x00, 0x00, 0x00, 0x0e, 0x00, 0x60, 0x04, 0x10, 0x00, 0x00, 0x00, 0x13,
    0x00, 0x00, 0x00, 0x0f, 0x00, 0x60, 0x04, 0x10, 0x00, 0x00, 0x00, 0x13, 0x00, 0x00, 0x00, 0x11,
    0x00, 0x60, 0x04, 0x10, 0x00, 0x00, 0x00, 0x13, 0x00, 0x00, 0x00, 0x12, 0x00, 0x60, 0x04, 0x10,
    0x00, 0x00, 0x00, 0x13, 0x00, 0x00, 0x00, 0x13, 0x00, 0x60, 0x04, 0x10, 0x00, 0x00, 0x00, 0x13,
    0x00, 0x00, 0x00, 0x14, 0x00, 0x60, 0x04, 0x10, 0x00, 0x00, 0x00, 0x13, 0x00, 0x00, 0x00, 0x15,
    0x00, 0x60, 0x04, 0x10, 0x00, 0x00, 0x00, 0x13, 0x00, 0x00, 0x00, 0x16, 0x00, 0x60, 0x04, 0x10,
    0x00, 0x00, 0x00, 0x13, 0x00, 0x00, 0x00, 0x17, 0x00, 0x60, 0x04, 0x10, 0x00, 0x00, 0x00, 0x13,
    0x00, 0x00, 0x00, 0x25, 0x00, 0x60, 0x04, 0x10, 0x00, 0x00, 0x00, 0x13, 0x00, 0x00, 0x00, 0x26,
    0x00, 0x60, 0x04, 0x10, 0x00, 0x00, 0x00, 0x13, 0x00, 0x00, 0x00, 0x27, 0x00, 0x60, 0x04, 0x10,
    0x00, 0x00, 0x00, 0x13, 0x00, 0x00, 0x00, 0x29, 0x00, 0x60, 0x04, 0x10, 0x00, 0x00, 0x00, 0x13,
    0x00, 0x00, 0x00, 0x2a, 0x00, 0x60, 0x04, 0x10, 0x00, 0x00, 0x00, 0x13, 0x00, 0x00, 0x00, 0x42,
    0x00, 0x60, 0x04, 0x10, 0x00, 0x00, 0x00, 0x13, 0x00, 0x00, 0x00, 0x43, 0x00, 0x60, 0x04, 0x10,
    0x00, 0x00, 0x00, 0x13, 0x00, 0x00, 0x00, 0x46, 0x00, 0x60, 0x04, 0x10, 0x00, 0x00, 0x00, 0x13,
    0x00, 0x00, 0x00, 0x4a, 0x00, 0x60, 0x04, 0x08, 0x00, 0x00, 0x00, 0x13, 0x00, 0x00, 0x00, 0x4d,
    0x00, 0x60, 0x04, 0x08, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x01, 0x00, 0x80, 0x04, 0x10,
    0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x02, 0x00, 0x80, 0x04, 0x10, 0x00, 0x00, 0x00, 0x14,
    0x00, 0x00, 0x00, 0x03, 0x00, 0x80, 0x04, 0x10, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x04,
    0x00, 0x80, 0x04, 0x10, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x05, 0x00, 0x80, 0x04, 0x10,
    0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x06, 0x00, 0x80, 0x04, 0x10, 0x00, 0x00, 0x00, 0x14,
    0x00, 0x00, 0x00, 0x07, 0x00, 0x80, 0x04, 0x10, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x08,
    0x00, 0x80, 0x04, 0x10, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x09, 0x00, 0x80, 0x04, 0x08,
    0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x0a, 0x00, 0x80, 0x04, 0x08, 0x00, 0x00, 0x00, 0x14,
    0x00, 0x00, 0x00, 0x0b, 0x00, 0x80, 0x04, 0x10, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x0c,
    0x00, 0x80, 0x04, 0x10, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x0d, 0x00, 0x80, 0x04, 0x10,
    0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x0e, 0x00, 0x80, 0x04, 0x10, 0x00, 0x00, 0x00, 0x14,
    0x00, 0x00, 0x00, 0x0f, 0x00, 0x80, 0x04, 0x10, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x11,
    0x00, 0x80, 0x04, 0x10, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x12, 0x00, 0x80, 0x04, 0x10,
    0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x13, 0x00, 0x80, 0x04, 0x10, 0x00, 0x00, 0x00, 0x14,
    0x00, 0x00, 0x00, 0x14, 0x00, 0x80, 0x04, 0x10, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x15,
    0x00, 0x80, 0x04, 0x10, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x16, 0x00, 0x80, 0x04, 0x10,
    0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x17, 0x00, 0x80, 0x04, 0x10, 0x00, 0x00, 0x00, 0x14,
    0x00, 0x00, 0x00, 0x23, 0x00, 0x80, 0x04, 0x10, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x24,
    0x00, 0x80, 0x04, 0x10, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x25, 0x00, 0x80, 0x04, 0x10,
    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x64, 0x00, 0x13, 0x01
});
        }
    }
}
