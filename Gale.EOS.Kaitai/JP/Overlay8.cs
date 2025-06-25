// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Controls the Send Demo Dungeon submenu within the top menu (under &quot;Other&quot;).
    /// </summary>
    public partial class Overlay8 : KaitaiStruct
    {
        public static Overlay8 FromFile(string fileName)
        {
            return new Overlay8(new KaitaiStream(fileName));
        }

        public Overlay8(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay8 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
        }
        private Overlay8 m_root;
        private KaitaiStruct m_parent;
        public Overlay8 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
