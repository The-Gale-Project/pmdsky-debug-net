// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Controls the staff credits sequence.
    /// </summary>
    public partial class Overlay28 : KaitaiStruct
    {
        public static Overlay28 FromFile(string fileName)
        {
            return new Overlay28(new KaitaiStream(fileName));
        }

        public Overlay28(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay28 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
        }
        private Overlay28 m_root;
        private KaitaiStruct m_parent;
        public Overlay28 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
