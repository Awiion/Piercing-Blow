﻿namespace PiercingBlow.Commons.Crypto
{
    public class BitShift
    {
        public static void Shift(byte[] buffer, int bits)
        {
            int length = buffer.Length;
            byte first = buffer[0];
            byte current;

            for (int i = 0; i < length; i++)
            {
                if (i >= (length - 1))
                {
                    current = first;
                }
                else
                {
                    current = buffer[i + 1];
                }

                buffer[i] = (byte)(current >> (8 - bits) | (buffer[i] << bits));
            }
        }

        public static void Unshift(byte[] buffer, int bits)
        {
            int length = buffer.Length;
            byte last = buffer[length - 1];
            byte current;

            for (int i = length - 1; (i & 0x80000000) == 0; i--)
            {
                if (i <= 0)
                {
                    current = last;
                }
                else
                {
                    current = buffer[i - 1];
                }

                buffer[i] = (byte)(current << (8 - bits) | buffer[i] >> bits);
            }
        }
    }
}
