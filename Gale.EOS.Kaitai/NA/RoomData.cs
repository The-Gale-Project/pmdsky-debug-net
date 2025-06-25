// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union room_data defined within pmdsky-debug.
    /// </summary>
    public partial class RoomData : KaitaiStruct
    {
        public static RoomData FromFile(string fileName)
        {
            return new RoomData(new KaitaiStream(fileName));
        }

        public RoomData(KaitaiStream p__io, KaitaiStruct p__parent = null, RoomData p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _roomId = m_io.ReadU1();
            _field0x1 = m_io.ReadU1();
            _topLeftCorner = new Position(m_io);
            _bottomRightCorner = new Position(m_io);
            _field0xa = m_io.ReadU1();
            _field0xb = m_io.ReadU1();
            _field0xc = m_io.ReadU4le();
            _field0x10 = m_io.ReadU4le();
            _field0x14 = m_io.ReadU4le();
            _field0x18 = m_io.ReadU4le();
        }
        private byte _roomId;
        private byte _field0x1;
        private Position _topLeftCorner;
        private Position _bottomRightCorner;
        private byte _field0xa;
        private byte _field0xb;
        private uint _field0xc;
        private uint _field0x10;
        private uint _field0x14;
        private uint _field0x18;
        private RoomData m_root;
        private KaitaiStruct m_parent;
        public byte RoomId { get { return _roomId; } }
        public byte Field0x1 { get { return _field0x1; } }
        public Position TopLeftCorner { get { return _topLeftCorner; } }
        public Position BottomRightCorner { get { return _bottomRightCorner; } }
        public byte Field0xa { get { return _field0xa; } }
        public byte Field0xb { get { return _field0xb; } }
        public uint Field0xc { get { return _field0xc; } }
        public uint Field0x10 { get { return _field0x10; } }
        public uint Field0x14 { get { return _field0x14; } }
        public uint Field0x18 { get { return _field0x18; } }
        public RoomData M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
