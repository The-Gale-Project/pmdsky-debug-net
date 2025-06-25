// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union position defined within pmdsky-debug.
    /// </summary>
    public partial class Position : KaitaiStruct
    {
        public static Position FromFile(string fileName)
        {
            return new Position(new KaitaiStream(fileName));
        }

        public Position(KaitaiStream p__io, KaitaiStruct p__parent = null, Position p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _x = m_io.ReadS2le();
            _y = m_io.ReadS2le();
        }
        private short _x;
        private short _y;
        private Position m_root;
        private KaitaiStruct m_parent;
        public short X { get { return _x; } }
        public short Y { get { return _y; } }
        public Position M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
