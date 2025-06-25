// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union monster_stat_modifiers defined within pmdsky-debug.
    /// </summary>
    public partial class MonsterStatModifiers : KaitaiStruct
    {
        public static MonsterStatModifiers FromFile(string fileName)
        {
            return new MonsterStatModifiers(new KaitaiStream(fileName));
        }

        public MonsterStatModifiers(KaitaiStream p__io, KaitaiStruct p__parent = null, MonsterStatModifiers p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _offensiveStages = new MonsterStatModifiersOffensiveStagesArray(m_io);
            _defensiveStages = new MonsterStatModifiersDefensiveStagesArray(m_io);
            _hitChanceStages = new MonsterStatModifiersHitChanceStagesArray(m_io);
            _flashFireBoost = m_io.ReadS2le();
            _field0xe = m_io.ReadU1();
            _field0xf = m_io.ReadU1();
            _offensiveMultipliers = new MonsterStatModifiersOffensiveMultipliersArray(m_io);
            _defensiveMultipliers = new MonsterStatModifiersDefensiveMultipliersArray(m_io);
        }
        private MonsterStatModifiersOffensiveStagesArray _offensiveStages;
        private MonsterStatModifiersDefensiveStagesArray _defensiveStages;
        private MonsterStatModifiersHitChanceStagesArray _hitChanceStages;
        private short _flashFireBoost;
        private byte _field0xe;
        private byte _field0xf;
        private MonsterStatModifiersOffensiveMultipliersArray _offensiveMultipliers;
        private MonsterStatModifiersDefensiveMultipliersArray _defensiveMultipliers;
        private MonsterStatModifiers m_root;
        private KaitaiStruct m_parent;
        public MonsterStatModifiersOffensiveStagesArray OffensiveStages { get { return _offensiveStages; } }
        public MonsterStatModifiersDefensiveStagesArray DefensiveStages { get { return _defensiveStages; } }
        public MonsterStatModifiersHitChanceStagesArray HitChanceStages { get { return _hitChanceStages; } }
        public short FlashFireBoost { get { return _flashFireBoost; } }
        public byte Field0xe { get { return _field0xe; } }
        public byte Field0xf { get { return _field0xf; } }
        public MonsterStatModifiersOffensiveMultipliersArray OffensiveMultipliers { get { return _offensiveMultipliers; } }
        public MonsterStatModifiersDefensiveMultipliersArray DefensiveMultipliers { get { return _defensiveMultipliers; } }
        public MonsterStatModifiers M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
