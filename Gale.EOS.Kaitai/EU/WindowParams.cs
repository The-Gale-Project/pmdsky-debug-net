// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union window_params defined within pmdsky-debug.
    /// </summary>
    public partial class WindowParams : KaitaiStruct
    {
        public static WindowParams FromFile(string fileName)
        {
            return new WindowParams(new KaitaiStream(fileName));
        }

        public WindowParams(KaitaiStream p__io, KaitaiStruct p__parent = null, WindowParams p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _update = new Pointer(m_io);
            _xOffset = m_io.ReadU1();
            _yOffset = m_io.ReadU1();
            _width = m_io.ReadU1();
            _height = m_io.ReadU1();
            _screen = new Screen8(m_io);
            _boxType = new BoxType8(m_io);
            _field0xa = m_io.ReadU1();
            _field0xb = m_io.ReadU1();
            _contents = new Pointer(m_io);
        }
        private Pointer _update;
        private byte _xOffset;
        private byte _yOffset;
        private byte _width;
        private byte _height;
        private Screen8 _screen;
        private BoxType8 _boxType;
        private byte _field0xa;
        private byte _field0xb;
        private Pointer _contents;
        private WindowParams m_root;
        private KaitaiStruct m_parent;
        public Pointer Update { get { return _update; } }
        public byte XOffset { get { return _xOffset; } }
        public byte YOffset { get { return _yOffset; } }
        public byte Width { get { return _width; } }
        public byte Height { get { return _height; } }
        public Screen8 Screen { get { return _screen; } }
        public BoxType8 BoxType { get { return _boxType; } }
        public byte Field0xa { get { return _field0xa; } }
        public byte Field0xb { get { return _field0xb; } }
        public Pointer Contents { get { return _contents; } }
        public WindowParams M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
