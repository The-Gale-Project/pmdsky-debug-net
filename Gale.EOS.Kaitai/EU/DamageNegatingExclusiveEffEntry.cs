// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union damage_negating_exclusive_eff_entry defined within pmdsky-debug.
    /// </summary>
    public partial class DamageNegatingExclusiveEffEntry : KaitaiStruct
    {
        public static DamageNegatingExclusiveEffEntry FromFile(string fileName)
        {
            return new DamageNegatingExclusiveEffEntry(new KaitaiStream(fileName));
        }

        public DamageNegatingExclusiveEffEntry(KaitaiStream p__io, KaitaiStruct p__parent = null, DamageNegatingExclusiveEffEntry p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _type = new TypeId(m_io);
            _effect = new ExclusiveItemEffectId(m_io);
        }
        private TypeId _type;
        private ExclusiveItemEffectId _effect;
        private DamageNegatingExclusiveEffEntry m_root;
        private KaitaiStruct m_parent;
        public TypeId Type { get { return _type; } }
        public ExclusiveItemEffectId Effect { get { return _effect; } }
        public DamageNegatingExclusiveEffEntry M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
