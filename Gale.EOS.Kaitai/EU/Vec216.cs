// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union vec2_16 defined within pmdsky-debug.
    /// </summary>
    public partial class Vec216 : KaitaiStruct
    {
        public static Vec216 FromFile(string fileName)
        {
            return new Vec216(new KaitaiStream(fileName));
        }

        public Vec216(KaitaiStream p__io, KaitaiStruct p__parent = null, Vec216 p__root = null) : base(p__io)
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
        private Vec216 m_root;
        private KaitaiStruct m_parent;
        public short X { get { return _x; } }
        public short Y { get { return _y; } }
        public Vec216 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
