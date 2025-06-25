// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union thread_info defined within pmdsky-debug.
    /// </summary>
    public partial class ThreadInfo : KaitaiStruct
    {
        public static ThreadInfo FromFile(string fileName)
        {
            return new ThreadInfo(new KaitaiStream(fileName));
        }

        public ThreadInfo(KaitaiStream p__io, KaitaiStruct p__parent = null, ThreadInfo p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _field0x0 = m_io.ReadU1();
            _field0x1 = m_io.ReadU1();
            _field0x2 = m_io.ReadU1();
            _field0x3 = m_io.ReadU1();
            _field0x4 = m_io.ReadU1();
            _field0x5 = m_io.ReadU1();
            _field0x6 = m_io.ReadU1();
            _field0x7 = m_io.ReadU1();
            _field0x8 = new Pointer(m_io);
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
            _threadCount = m_io.ReadS4le();
            _field0x24 = m_io.ReadU1();
            _field0x25 = m_io.ReadU1();
            _field0x26 = m_io.ReadU1();
            _field0x27 = m_io.ReadU1();
            _field0x28 = new Pointer(m_io);
            _threadListHead = new Pointer(m_io);
            _field0x30 = m_io.ReadU1();
            _field0x31 = m_io.ReadU1();
            _field0x32 = m_io.ReadU1();
            _field0x33 = m_io.ReadU1();
        }
        private byte _field0x0;
        private byte _field0x1;
        private byte _field0x2;
        private byte _field0x3;
        private byte _field0x4;
        private byte _field0x5;
        private byte _field0x6;
        private byte _field0x7;
        private Pointer _field0x8;
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
        private int _threadCount;
        private byte _field0x24;
        private byte _field0x25;
        private byte _field0x26;
        private byte _field0x27;
        private Pointer _field0x28;
        private Pointer _threadListHead;
        private byte _field0x30;
        private byte _field0x31;
        private byte _field0x32;
        private byte _field0x33;
        private ThreadInfo m_root;
        private KaitaiStruct m_parent;
        public byte Field0x0 { get { return _field0x0; } }
        public byte Field0x1 { get { return _field0x1; } }
        public byte Field0x2 { get { return _field0x2; } }
        public byte Field0x3 { get { return _field0x3; } }
        public byte Field0x4 { get { return _field0x4; } }
        public byte Field0x5 { get { return _field0x5; } }
        public byte Field0x6 { get { return _field0x6; } }
        public byte Field0x7 { get { return _field0x7; } }
        public Pointer Field0x8 { get { return _field0x8; } }
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
        public int ThreadCount { get { return _threadCount; } }
        public byte Field0x24 { get { return _field0x24; } }
        public byte Field0x25 { get { return _field0x25; } }
        public byte Field0x26 { get { return _field0x26; } }
        public byte Field0x27 { get { return _field0x27; } }
        public Pointer Field0x28 { get { return _field0x28; } }
        public Pointer ThreadListHead { get { return _threadListHead; } }
        public byte Field0x30 { get { return _field0x30; } }
        public byte Field0x31 { get { return _field0x31; } }
        public byte Field0x32 { get { return _field0x32; } }
        public byte Field0x33 { get { return _field0x33; } }
        public ThreadInfo M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
