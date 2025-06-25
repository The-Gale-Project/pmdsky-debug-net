// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{
    public partial class Overlay26Data : KaitaiStruct
    {
        public static Overlay26Data FromFile(string fileName)
        {
            return new Overlay26Data(new KaitaiStream(fileName));
        }

        public Overlay26Data(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay26Data p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
        }
        private Overlay26Data m_root;
        private KaitaiStruct m_parent;
        public Overlay26Data M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
