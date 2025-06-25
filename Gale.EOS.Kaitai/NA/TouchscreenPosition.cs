// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union touchscreen_position defined within pmdsky-debug.
    /// </summary>
    public partial class TouchscreenPosition : KaitaiStruct
    {
        public static TouchscreenPosition FromFile(string fileName)
        {
            return new TouchscreenPosition(new KaitaiStream(fileName));
        }

        public TouchscreenPosition(KaitaiStream p__io, KaitaiStruct p__parent = null, TouchscreenPosition p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _xPos = m_io.ReadS4le();
            _yPos = m_io.ReadS4le();
            _isValid = m_io.ReadS4le();
        }
        private int _xPos;
        private int _yPos;
        private int _isValid;
        private TouchscreenPosition m_root;
        private KaitaiStruct m_parent;
        public int XPos { get { return _xPos; } }
        public int YPos { get { return _yPos; } }
        public int IsValid { get { return _isValid; } }
        public TouchscreenPosition M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
