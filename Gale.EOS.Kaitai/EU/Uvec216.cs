// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union uvec2_16 defined within pmdsky-debug.
    /// </summary>
    public partial class Uvec216 : KaitaiStruct
    {
        public static Uvec216 FromFile(string fileName)
        {
            return new Uvec216(new KaitaiStream(fileName));
        }

        public Uvec216(KaitaiStream p__io, KaitaiStruct p__parent = null, Uvec216 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _x = m_io.ReadU2le();
            _y = m_io.ReadU2le();
        }
        private ushort _x;
        private ushort _y;
        private Uvec216 m_root;
        private KaitaiStruct m_parent;
        public ushort X { get { return _x; } }
        public ushort Y { get { return _y; } }
        public Uvec216 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
