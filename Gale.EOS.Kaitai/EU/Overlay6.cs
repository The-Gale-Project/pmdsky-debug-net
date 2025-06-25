// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Controls the Wonder Mail S submenu within the top menu.
    /// </summary>
    public partial class Overlay6 : KaitaiStruct
    {
        public static Overlay6 FromFile(string fileName)
        {
            return new Overlay6(new KaitaiStream(fileName));
        }

        public Overlay6(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay6 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
        }
        private Overlay6 m_root;
        private KaitaiStruct m_parent;
        public Overlay6 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
