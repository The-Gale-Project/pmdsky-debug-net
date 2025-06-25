// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{
    public partial class MoveEffectsData : KaitaiStruct
    {
        public static MoveEffectsData FromFile(string fileName)
        {
            return new MoveEffectsData(new KaitaiStream(fileName));
        }

        public MoveEffectsData(KaitaiStream p__io, KaitaiStruct p__parent = null, MoveEffectsData p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
        }
        private MoveEffectsData m_root;
        private KaitaiStruct m_parent;
        public MoveEffectsData M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
