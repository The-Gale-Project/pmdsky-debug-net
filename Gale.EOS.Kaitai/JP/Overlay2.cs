// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Controls the Nintendo WFC Settings interface, accessed from the top menu (Other &gt; Nintendo WFC &gt; Nintendo WFC Settings). Presumably contains code for Nintendo Wi-Fi setup.
    /// </summary>
    public partial class Overlay2 : KaitaiStruct
    {
        public static Overlay2 FromFile(string fileName)
        {
            return new Overlay2(new KaitaiStream(fileName));
        }

        public Overlay2(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay2 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
        }
        private Overlay2 m_root;
        private KaitaiStruct m_parent;
        public Overlay2 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
