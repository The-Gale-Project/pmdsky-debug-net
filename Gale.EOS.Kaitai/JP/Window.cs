// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents a struct or union window defined within pmdsky-debug.
    /// </summary>
    public partial class Window : KaitaiStruct
    {
        public static Window FromFile(string fileName)
        {
            return new Window(new KaitaiStream(fileName));
        }

        public Window(KaitaiStream p__io, KaitaiStruct p__parent = null, Window p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _params = new WindowParams(m_io);
            _subwindowId = m_io.ReadS1();
            _field0x11 = m_io.ReadU1();
            _field0x12 = m_io.ReadU2le();
            _field0x14 = new Pointer(m_io);
            _field0x18 = m_io.ReadS4le();
            _field0x1c = m_io.ReadS4le();
            _field0x20 = m_io.ReadU4le();
            _field0x24 = m_io.ReadU1();
            _field0x25 = m_io.ReadU1();
            _field0x26 = m_io.ReadU1();
            _field0x27 = m_io.ReadU1();
            _field0x28 = m_io.ReadS4le();
            _field0x2c = m_io.ReadU1();
            _field0x2d = m_io.ReadU1();
            _field0x2e = m_io.ReadU1();
            _field0x2f = m_io.ReadU1();
            _field0x30 = m_io.ReadU2le();
            _field0x32 = m_io.ReadU1();
            _field0x33 = m_io.ReadU1();
            _backdrop = new Render3dElement64(m_io);
            _frame = new Render3dElement64(m_io);
            _field0xb4 = m_io.ReadU1();
            _field0xb5 = m_io.ReadU1();
            _valid = m_io.ReadS1();
            _field0xb7 = m_io.ReadU1();
            _field0xb8 = m_io.ReadS4le();
            _trailer = new WindowTrailer(m_io);
        }
        private WindowParams _params;
        private sbyte _subwindowId;
        private byte _field0x11;
        private ushort _field0x12;
        private Pointer _field0x14;
        private int _field0x18;
        private int _field0x1c;
        private uint _field0x20;
        private byte _field0x24;
        private byte _field0x25;
        private byte _field0x26;
        private byte _field0x27;
        private int _field0x28;
        private byte _field0x2c;
        private byte _field0x2d;
        private byte _field0x2e;
        private byte _field0x2f;
        private ushort _field0x30;
        private byte _field0x32;
        private byte _field0x33;
        private Render3dElement64 _backdrop;
        private Render3dElement64 _frame;
        private byte _field0xb4;
        private byte _field0xb5;
        private sbyte _valid;
        private byte _field0xb7;
        private int _field0xb8;
        private WindowTrailer _trailer;
        private Window m_root;
        private KaitaiStruct m_parent;
        public WindowParams Params { get { return _params; } }
        public sbyte SubwindowId { get { return _subwindowId; } }
        public byte Field0x11 { get { return _field0x11; } }
        public ushort Field0x12 { get { return _field0x12; } }
        public Pointer Field0x14 { get { return _field0x14; } }
        public int Field0x18 { get { return _field0x18; } }
        public int Field0x1c { get { return _field0x1c; } }
        public uint Field0x20 { get { return _field0x20; } }
        public byte Field0x24 { get { return _field0x24; } }
        public byte Field0x25 { get { return _field0x25; } }
        public byte Field0x26 { get { return _field0x26; } }
        public byte Field0x27 { get { return _field0x27; } }
        public int Field0x28 { get { return _field0x28; } }
        public byte Field0x2c { get { return _field0x2c; } }
        public byte Field0x2d { get { return _field0x2d; } }
        public byte Field0x2e { get { return _field0x2e; } }
        public byte Field0x2f { get { return _field0x2f; } }
        public ushort Field0x30 { get { return _field0x30; } }
        public byte Field0x32 { get { return _field0x32; } }
        public byte Field0x33 { get { return _field0x33; } }
        public Render3dElement64 Backdrop { get { return _backdrop; } }
        public Render3dElement64 Frame { get { return _frame; } }
        public byte Field0xb4 { get { return _field0xb4; } }
        public byte Field0xb5 { get { return _field0xb5; } }
        public sbyte Valid { get { return _valid; } }
        public byte Field0xb7 { get { return _field0xb7; } }
        public int Field0xb8 { get { return _field0xb8; } }
        public WindowTrailer Trailer { get { return _trailer; } }
        public Window M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
