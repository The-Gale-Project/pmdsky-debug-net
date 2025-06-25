// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union damage_source_16 defined within pmdsky-debug.
    /// </summary>
    public partial class DamageSource16 : KaitaiStruct
    {
        public static DamageSource16 FromFile(string fileName)
        {
            return new DamageSource16(new KaitaiStream(fileName));
        }

        public DamageSource16(KaitaiStream p__io, KaitaiStruct p__parent = null, DamageSource16 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _move = new MoveId16(m_io);
            _other = new DamageSourceNonMove16(m_io);
        }
        private MoveId16 _move;
        private DamageSourceNonMove16 _other;
        private DamageSource16 m_root;
        private KaitaiStruct m_parent;
        public MoveId16 Move { get { return _move; } }
        public DamageSourceNonMove16 Other { get { return _other; } }
        public DamageSource16 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
