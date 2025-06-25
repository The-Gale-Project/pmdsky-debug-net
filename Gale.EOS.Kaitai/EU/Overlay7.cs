// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Controls the Nintendo WFC submenu within the top menu (under &quot;Other&quot;).
    /// </summary>
    public partial class Overlay7 : KaitaiStruct
    {
        public static Overlay7 FromFile(string fileName)
        {
            return new Overlay7(new KaitaiStream(fileName));
        }

        public Overlay7(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay7 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
        }
        private Overlay7 m_root;
        private KaitaiStruct m_parent;
        public Overlay7 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
