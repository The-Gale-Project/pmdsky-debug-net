// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Unused; all zeroes.
    /// </summary>
    public partial class Overlay33 : KaitaiStruct
    {
        public static Overlay33 FromFile(string fileName)
        {
            return new Overlay33(new KaitaiStream(fileName));
        }

        public Overlay33(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay33 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
        }
        private Overlay33 m_root;
        private KaitaiStruct m_parent;
        public Overlay33 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
