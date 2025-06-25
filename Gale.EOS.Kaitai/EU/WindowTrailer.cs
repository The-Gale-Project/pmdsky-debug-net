// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union window_trailer defined within pmdsky-debug.
    /// </summary>
    public partial class WindowTrailer : KaitaiStruct
    {
        public static WindowTrailer FromFile(string fileName)
        {
            return new WindowTrailer(new KaitaiStream(fileName));
        }

        public WindowTrailer(KaitaiStream p__io, KaitaiStruct p__parent = null, WindowTrailer p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _field0x0 = m_io.ReadS4le();
            _field0x4 = m_io.ReadU1();
            _field0x5 = m_io.ReadU1();
            _field0x6 = m_io.ReadU1();
            _field0x7 = m_io.ReadU1();
            _field0x8 = m_io.ReadU1();
            _field0x9 = m_io.ReadU1();
            _field0xa = m_io.ReadU1();
            _field0xb = m_io.ReadU1();
            _field0xc = m_io.ReadU1();
            _field0xd = m_io.ReadU1();
            _field0xe = m_io.ReadU1();
            _field0xf = m_io.ReadU1();
            _field0x10 = m_io.ReadU1();
            _field0x11 = m_io.ReadU1();
            _field0x12 = m_io.ReadU1();
            _field0x13 = m_io.ReadU1();
            _field0x14 = m_io.ReadU1();
            _field0x15 = m_io.ReadU1();
            _field0x16 = m_io.ReadU1();
            _field0x17 = m_io.ReadU1();
            _field0x18 = m_io.ReadU1();
            _field0x19 = m_io.ReadU1();
            _field0x1a = m_io.ReadU1();
            _field0x1b = m_io.ReadU1();
            _field0x1c = m_io.ReadU1();
            _field0x1d = m_io.ReadU1();
            _field0x1e = m_io.ReadU1();
            _field0x1f = m_io.ReadU1();
            _field0x20 = m_io.ReadU1();
            _field0x21 = m_io.ReadU1();
            _field0x22 = m_io.ReadU1();
            _field0x23 = m_io.ReadU1();
        }
        private int _field0x0;
        private byte _field0x4;
        private byte _field0x5;
        private byte _field0x6;
        private byte _field0x7;
        private byte _field0x8;
        private byte _field0x9;
        private byte _field0xa;
        private byte _field0xb;
        private byte _field0xc;
        private byte _field0xd;
        private byte _field0xe;
        private byte _field0xf;
        private byte _field0x10;
        private byte _field0x11;
        private byte _field0x12;
        private byte _field0x13;
        private byte _field0x14;
        private byte _field0x15;
        private byte _field0x16;
        private byte _field0x17;
        private byte _field0x18;
        private byte _field0x19;
        private byte _field0x1a;
        private byte _field0x1b;
        private byte _field0x1c;
        private byte _field0x1d;
        private byte _field0x1e;
        private byte _field0x1f;
        private byte _field0x20;
        private byte _field0x21;
        private byte _field0x22;
        private byte _field0x23;
        private WindowTrailer m_root;
        private KaitaiStruct m_parent;
        public int Field0x0 { get { return _field0x0; } }
        public byte Field0x4 { get { return _field0x4; } }
        public byte Field0x5 { get { return _field0x5; } }
        public byte Field0x6 { get { return _field0x6; } }
        public byte Field0x7 { get { return _field0x7; } }
        public byte Field0x8 { get { return _field0x8; } }
        public byte Field0x9 { get { return _field0x9; } }
        public byte Field0xa { get { return _field0xa; } }
        public byte Field0xb { get { return _field0xb; } }
        public byte Field0xc { get { return _field0xc; } }
        public byte Field0xd { get { return _field0xd; } }
        public byte Field0xe { get { return _field0xe; } }
        public byte Field0xf { get { return _field0xf; } }
        public byte Field0x10 { get { return _field0x10; } }
        public byte Field0x11 { get { return _field0x11; } }
        public byte Field0x12 { get { return _field0x12; } }
        public byte Field0x13 { get { return _field0x13; } }
        public byte Field0x14 { get { return _field0x14; } }
        public byte Field0x15 { get { return _field0x15; } }
        public byte Field0x16 { get { return _field0x16; } }
        public byte Field0x17 { get { return _field0x17; } }
        public byte Field0x18 { get { return _field0x18; } }
        public byte Field0x19 { get { return _field0x19; } }
        public byte Field0x1a { get { return _field0x1a; } }
        public byte Field0x1b { get { return _field0x1b; } }
        public byte Field0x1c { get { return _field0x1c; } }
        public byte Field0x1d { get { return _field0x1d; } }
        public byte Field0x1e { get { return _field0x1e; } }
        public byte Field0x1f { get { return _field0x1f; } }
        public byte Field0x20 { get { return _field0x20; } }
        public byte Field0x21 { get { return _field0x21; } }
        public byte Field0x22 { get { return _field0x22; } }
        public byte Field0x23 { get { return _field0x23; } }
        public WindowTrailer M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
