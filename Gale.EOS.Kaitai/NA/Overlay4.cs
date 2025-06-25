// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Controls the Trade Items submenu within the top menu.
    /// </summary>
    public partial class Overlay4 : KaitaiStruct
    {
        public static Overlay4 FromFile(string fileName)
        {
            return new Overlay4(new KaitaiStream(fileName));
        }

        public Overlay4(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay4 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
        }
        private Overlay4 m_root;
        private KaitaiStruct m_parent;
        public Overlay4 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
