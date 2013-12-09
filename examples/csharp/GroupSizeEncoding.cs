/* Generated SBE (Simple Binary Encoding) message codec */

using System;
using Adaptive.SimpleBinaryEncoding;

namespace Baseline
{
    public class GroupSizeEncoding : IFixedFlyweight
    {
        private DirectBuffer _buffer;
        private int _offset;
        private int _actingVersion;

        public void Wrap(DirectBuffer buffer, int offset, int actingVersion)
        {
            _offset = offset;
            _actingVersion = actingVersion;
            _buffer = buffer;
        }

        public const int Size = 3;

    public ushort BlockLength
    {
        get
        {
            return _buffer.Uint16GetLittleEndian(_offset + 0);
        }
        set
        {
            _buffer.Uint16PutLittleEndian(_offset + 0, value);
        }
    }


    public byte NumInGroup
    {
        get
        {
            return _buffer.Uint8Get(_offset + 2);
        }
        set
        {
            _buffer.Uint8Put(_offset + 2, value);
        }
    }

    }
}