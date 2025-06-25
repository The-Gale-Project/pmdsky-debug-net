// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union pixel_position defined within pmdsky-debug.
    /// </summary>
    public partial class PixelPosition : KaitaiStruct
    {
        public static PixelPosition FromFile(string fileName)
        {
            return new PixelPosition(new KaitaiStream(fileName));
        }

        public PixelPosition(KaitaiStream p__io, KaitaiStruct p__parent = null, PixelPosition p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _x = m_io.ReadS4le();
            _y = m_io.ReadS4le();
        }
        private int _x;
        private int _y;
        private PixelPosition m_root;
        private KaitaiStruct m_parent;
        public int X { get { return _x; } }
        public int Y { get { return _y; } }
        public PixelPosition M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
