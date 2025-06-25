// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Unused; all zeroes.
    /// </summary>
    public partial class Overlay32 : KaitaiStruct
    {
        public static Overlay32 FromFile(string fileName)
        {
            return new Overlay32(new KaitaiStream(fileName));
        }

        public Overlay32(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay32 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
        }
        private Overlay32 m_root;
        private KaitaiStruct m_parent;
        public Overlay32 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
