// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Controls the Friend Rescue submenu within the top menu.
    /// </summary>
    public partial class Overlay3 : KaitaiStruct
    {
        public static Overlay3 FromFile(string fileName)
        {
            return new Overlay3(new KaitaiStream(fileName));
        }

        public Overlay3(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay3 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
        }
        private Overlay3 m_root;
        private KaitaiStruct m_parent;
        public Overlay3 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
