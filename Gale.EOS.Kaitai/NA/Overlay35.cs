// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Unused; all zeroes.
    /// </summary>
    public partial class Overlay35 : KaitaiStruct
    {
        public static Overlay35 FromFile(string fileName)
        {
            return new Overlay35(new KaitaiStream(fileName));
        }

        public Overlay35(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay35 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
        }
        private Overlay35 m_root;
        private KaitaiStruct m_parent;
        public Overlay35 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
