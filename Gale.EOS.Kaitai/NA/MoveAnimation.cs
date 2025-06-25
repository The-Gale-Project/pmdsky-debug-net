// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union move_animation defined within pmdsky-debug.
    /// </summary>
    public partial class MoveAnimation : KaitaiStruct
    {
        public static MoveAnimation FromFile(string fileName)
        {
            return new MoveAnimation(new KaitaiStream(fileName));
        }

        public MoveAnimation(KaitaiStream p__io, KaitaiStruct p__parent = null, MoveAnimation p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _field0x0 = m_io.ReadS2le();
            _field0x2 = m_io.ReadS2le();
            _field0x4 = m_io.ReadS2le();
            _field0x6 = m_io.ReadS2le();
            _field0x8 = m_io.ReadU1();
            _field0x9 = m_io.ReadU1();
            _field0xa = m_io.ReadU1();
            _field0xb = m_io.ReadU1();
            _field0xc = m_io.ReadU1();
            _field0xd = m_io.ReadU1();
            _field0xe = m_io.ReadU1();
            _field0xf = m_io.ReadU1();
            _field0x10 = m_io.ReadU1();
            _field0x11 = m_io.ReadS1();
            _field0x12 = m_io.ReadU2le();
            _field0x14 = m_io.ReadS2le();
            _field0x16 = m_io.ReadU2le();
        }
        private short _field0x0;
        private short _field0x2;
        private short _field0x4;
        private short _field0x6;
        private byte _field0x8;
        private byte _field0x9;
        private byte _field0xa;
        private byte _field0xb;
        private byte _field0xc;
        private byte _field0xd;
        private byte _field0xe;
        private byte _field0xf;
        private byte _field0x10;
        private sbyte _field0x11;
        private ushort _field0x12;
        private short _field0x14;
        private ushort _field0x16;
        private MoveAnimation m_root;
        private KaitaiStruct m_parent;
        public short Field0x0 { get { return _field0x0; } }
        public short Field0x2 { get { return _field0x2; } }
        public short Field0x4 { get { return _field0x4; } }
        public short Field0x6 { get { return _field0x6; } }
        public byte Field0x8 { get { return _field0x8; } }
        public byte Field0x9 { get { return _field0x9; } }
        public byte Field0xa { get { return _field0xa; } }
        public byte Field0xb { get { return _field0xb; } }
        public byte Field0xc { get { return _field0xc; } }
        public byte Field0xd { get { return _field0xd; } }
        public byte Field0xe { get { return _field0xe; } }
        public byte Field0xf { get { return _field0xf; } }
        public byte Field0x10 { get { return _field0x10; } }
        public sbyte Field0x11 { get { return _field0x11; } }
        public ushort Field0x12 { get { return _field0x12; } }
        public short Field0x14 { get { return _field0x14; } }
        public ushort Field0x16 { get { return _field0x16; } }
        public MoveAnimation M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
