// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union render_3d_global defined within pmdsky-debug.
    /// </summary>
    public partial class Render3dGlobal : KaitaiStruct
    {
        public static Render3dGlobal FromFile(string fileName)
        {
            return new Render3dGlobal(new KaitaiStream(fileName));
        }

        public Render3dGlobal(KaitaiStream p__io, KaitaiStruct p__parent = null, Render3dGlobal p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _currentIndex = m_io.ReadS2le();
            _maxIndex = m_io.ReadS2le();
            _paletteBaseAddr = m_io.ReadS4le();
            _textureVramOffset = m_io.ReadS4le();
            _field40xc = m_io.ReadU1();
            _field50xd = m_io.ReadU1();
            _field60xe = m_io.ReadU1();
            _field70xf = m_io.ReadU1();
            _field80x10 = m_io.ReadU1();
            _field90x11 = m_io.ReadU1();
            _field100x12 = m_io.ReadU1();
            _field110x13 = m_io.ReadU1();
            _field120x14 = m_io.ReadU1();
            _field130x15 = m_io.ReadU1();
            _field140x16 = m_io.ReadU1();
            _field150x17 = m_io.ReadU1();
            _field160x18 = m_io.ReadU1();
            _field170x19 = m_io.ReadU1();
            _field180x1a = m_io.ReadU1();
            _field190x1b = m_io.ReadU1();
            _field200x1c = m_io.ReadU1();
            _field210x1d = m_io.ReadU1();
            _field220x1e = m_io.ReadU1();
            _field230x1f = m_io.ReadU1();
            _field240x20 = m_io.ReadU1();
            _field250x21 = m_io.ReadU1();
            _field260x22 = m_io.ReadU1();
            _field270x23 = m_io.ReadU1();
            _field280x24 = m_io.ReadU1();
            _field290x25 = m_io.ReadU1();
            _field300x26 = m_io.ReadU1();
            _field310x27 = m_io.ReadU1();
            _field320x28 = m_io.ReadU1();
            _field330x29 = m_io.ReadU1();
            _field340x2a = m_io.ReadU1();
            _field350x2b = m_io.ReadU1();
            _field360x2c = m_io.ReadU1();
            _field370x2d = m_io.ReadU1();
            _field380x2e = m_io.ReadU1();
            _field390x2f = m_io.ReadU1();
            _field400x30 = m_io.ReadU1();
            _field410x31 = m_io.ReadU1();
            _field420x32 = m_io.ReadU1();
            _field430x33 = m_io.ReadU1();
            _field440x34 = m_io.ReadU1();
            _field450x35 = m_io.ReadU1();
            _field460x36 = m_io.ReadU1();
            _field470x37 = m_io.ReadU1();
            _field480x38 = m_io.ReadU1();
            _field490x39 = m_io.ReadU1();
            _field500x3a = m_io.ReadU1();
            _field510x3b = m_io.ReadU1();
            _field520x3c = m_io.ReadU1();
            _field530x3d = m_io.ReadU1();
            _field540x3e = m_io.ReadU1();
            _field550x3f = m_io.ReadU1();
            _renderQueue = new Pointer(m_io);
        }
        private short _currentIndex;
        private short _maxIndex;
        private int _paletteBaseAddr;
        private int _textureVramOffset;
        private byte _field40xc;
        private byte _field50xd;
        private byte _field60xe;
        private byte _field70xf;
        private byte _field80x10;
        private byte _field90x11;
        private byte _field100x12;
        private byte _field110x13;
        private byte _field120x14;
        private byte _field130x15;
        private byte _field140x16;
        private byte _field150x17;
        private byte _field160x18;
        private byte _field170x19;
        private byte _field180x1a;
        private byte _field190x1b;
        private byte _field200x1c;
        private byte _field210x1d;
        private byte _field220x1e;
        private byte _field230x1f;
        private byte _field240x20;
        private byte _field250x21;
        private byte _field260x22;
        private byte _field270x23;
        private byte _field280x24;
        private byte _field290x25;
        private byte _field300x26;
        private byte _field310x27;
        private byte _field320x28;
        private byte _field330x29;
        private byte _field340x2a;
        private byte _field350x2b;
        private byte _field360x2c;
        private byte _field370x2d;
        private byte _field380x2e;
        private byte _field390x2f;
        private byte _field400x30;
        private byte _field410x31;
        private byte _field420x32;
        private byte _field430x33;
        private byte _field440x34;
        private byte _field450x35;
        private byte _field460x36;
        private byte _field470x37;
        private byte _field480x38;
        private byte _field490x39;
        private byte _field500x3a;
        private byte _field510x3b;
        private byte _field520x3c;
        private byte _field530x3d;
        private byte _field540x3e;
        private byte _field550x3f;
        private Pointer _renderQueue;
        private Render3dGlobal m_root;
        private KaitaiStruct m_parent;
        public short CurrentIndex { get { return _currentIndex; } }
        public short MaxIndex { get { return _maxIndex; } }
        public int PaletteBaseAddr { get { return _paletteBaseAddr; } }
        public int TextureVramOffset { get { return _textureVramOffset; } }
        public byte Field40xc { get { return _field40xc; } }
        public byte Field50xd { get { return _field50xd; } }
        public byte Field60xe { get { return _field60xe; } }
        public byte Field70xf { get { return _field70xf; } }
        public byte Field80x10 { get { return _field80x10; } }
        public byte Field90x11 { get { return _field90x11; } }
        public byte Field100x12 { get { return _field100x12; } }
        public byte Field110x13 { get { return _field110x13; } }
        public byte Field120x14 { get { return _field120x14; } }
        public byte Field130x15 { get { return _field130x15; } }
        public byte Field140x16 { get { return _field140x16; } }
        public byte Field150x17 { get { return _field150x17; } }
        public byte Field160x18 { get { return _field160x18; } }
        public byte Field170x19 { get { return _field170x19; } }
        public byte Field180x1a { get { return _field180x1a; } }
        public byte Field190x1b { get { return _field190x1b; } }
        public byte Field200x1c { get { return _field200x1c; } }
        public byte Field210x1d { get { return _field210x1d; } }
        public byte Field220x1e { get { return _field220x1e; } }
        public byte Field230x1f { get { return _field230x1f; } }
        public byte Field240x20 { get { return _field240x20; } }
        public byte Field250x21 { get { return _field250x21; } }
        public byte Field260x22 { get { return _field260x22; } }
        public byte Field270x23 { get { return _field270x23; } }
        public byte Field280x24 { get { return _field280x24; } }
        public byte Field290x25 { get { return _field290x25; } }
        public byte Field300x26 { get { return _field300x26; } }
        public byte Field310x27 { get { return _field310x27; } }
        public byte Field320x28 { get { return _field320x28; } }
        public byte Field330x29 { get { return _field330x29; } }
        public byte Field340x2a { get { return _field340x2a; } }
        public byte Field350x2b { get { return _field350x2b; } }
        public byte Field360x2c { get { return _field360x2c; } }
        public byte Field370x2d { get { return _field370x2d; } }
        public byte Field380x2e { get { return _field380x2e; } }
        public byte Field390x2f { get { return _field390x2f; } }
        public byte Field400x30 { get { return _field400x30; } }
        public byte Field410x31 { get { return _field410x31; } }
        public byte Field420x32 { get { return _field420x32; } }
        public byte Field430x33 { get { return _field430x33; } }
        public byte Field440x34 { get { return _field440x34; } }
        public byte Field450x35 { get { return _field450x35; } }
        public byte Field460x36 { get { return _field460x36; } }
        public byte Field470x37 { get { return _field470x37; } }
        public byte Field480x38 { get { return _field480x38; } }
        public byte Field490x39 { get { return _field490x39; } }
        public byte Field500x3a { get { return _field500x3a; } }
        public byte Field510x3b { get { return _field510x3b; } }
        public byte Field520x3c { get { return _field520x3c; } }
        public byte Field530x3d { get { return _field530x3d; } }
        public byte Field540x3e { get { return _field540x3e; } }
        public byte Field550x3f { get { return _field550x3f; } }
        public Pointer RenderQueue { get { return _renderQueue; } }
        public Render3dGlobal M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
