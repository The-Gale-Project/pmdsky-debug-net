// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union monster_summary defined within pmdsky-debug.
    /// </summary>
    public partial class MonsterSummary : KaitaiStruct
    {
        public static MonsterSummary FromFile(string fileName)
        {
            return new MonsterSummary(new KaitaiStream(fileName));
        }

        public MonsterSummary(KaitaiStream p__io, KaitaiStruct p__parent = null, MonsterSummary p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _id = new MonsterId16(m_io);
            _monsterName = new MonsterSummaryMonsterNameArray(m_io);
            _field0xc = m_io.ReadU1();
            _field0xd = m_io.ReadU1();
            _field0xe = m_io.ReadU1();
            _field0xf = m_io.ReadU1();
            _field0x10 = m_io.ReadU1();
            _field0x11 = m_io.ReadU1();
            _field0x12 = m_io.ReadU1();
            _field0x13 = m_io.ReadU1();
            _field0x14 = m_io.ReadU1();
            _field0x15 = m_io.ReadU1();
            _types = new MonsterSummaryTypesArray(m_io);
            _abilities = new MonsterSummaryAbilitiesArray(m_io);
            _joinedAt = new DungeonId8(m_io);
            _joinedAtFloor = m_io.ReadU1();
            _heldItem = new Item(m_io);
            _field0x22 = m_io.ReadU1();
            _field0x23 = m_io.ReadU1();
            _hp = m_io.ReadS4le();
            _maxHp = m_io.ReadS4le();
            _level = m_io.ReadU4le();
            _exp = m_io.ReadS4le();
            _offensiveStats = new MonsterSummaryOffensiveStatsArray(m_io);
            _defensiveStats = new MonsterSummaryDefensiveStatsArray(m_io);
            _isTeamLeader = m_io.ReadU1();
            _attackBoost = m_io.ReadU1();
            _specialAttackBoost = m_io.ReadU1();
            _defenseBoost = m_io.ReadU1();
            _specialDefenseBoost = m_io.ReadU1();
            _field0x3d = m_io.ReadU1();
            _iq = m_io.ReadS2le();
            _field0x40 = m_io.ReadU1();
            _field0x41 = m_io.ReadU1();
            _levelAtFirstEvo = m_io.ReadU1();
            _levelAtSecondEvo = m_io.ReadU1();
            _evoStatus = m_io.ReadU1();
            _inflictedWithGastroAcid = m_io.ReadU1();
            _field0x46 = m_io.ReadU1();
            _field0x47 = m_io.ReadU1();
            _iqSkillFlags = new MonsterSummaryIqSkillFlagsArray(m_io);
            _tactic = new TacticId8(m_io);
            _field0x55 = m_io.ReadU1();
            _field0x56 = m_io.ReadU1();
            _field0x57 = m_io.ReadU1();
            _activeStatuses = new MonsterSummaryActiveStatusesArray(m_io);
            _padding0x76 = m_io.ReadU2le();
        }
        private MonsterId16 _id;
        private MonsterSummaryMonsterNameArray _monsterName;
        private byte _field0xc;
        private byte _field0xd;
        private byte _field0xe;
        private byte _field0xf;
        private byte _field0x10;
        private byte _field0x11;
        private byte _field0x12;
        private byte _field0x13;
        private byte _field0x14;
        private byte _field0x15;
        private MonsterSummaryTypesArray _types;
        private MonsterSummaryAbilitiesArray _abilities;
        private DungeonId8 _joinedAt;
        private byte _joinedAtFloor;
        private Item _heldItem;
        private byte _field0x22;
        private byte _field0x23;
        private int _hp;
        private int _maxHp;
        private uint _level;
        private int _exp;
        private MonsterSummaryOffensiveStatsArray _offensiveStats;
        private MonsterSummaryDefensiveStatsArray _defensiveStats;
        private byte _isTeamLeader;
        private byte _attackBoost;
        private byte _specialAttackBoost;
        private byte _defenseBoost;
        private byte _specialDefenseBoost;
        private byte _field0x3d;
        private short _iq;
        private byte _field0x40;
        private byte _field0x41;
        private byte _levelAtFirstEvo;
        private byte _levelAtSecondEvo;
        private byte _evoStatus;
        private byte _inflictedWithGastroAcid;
        private byte _field0x46;
        private byte _field0x47;
        private MonsterSummaryIqSkillFlagsArray _iqSkillFlags;
        private TacticId8 _tactic;
        private byte _field0x55;
        private byte _field0x56;
        private byte _field0x57;
        private MonsterSummaryActiveStatusesArray _activeStatuses;
        private ushort _padding0x76;
        private MonsterSummary m_root;
        private KaitaiStruct m_parent;
        public MonsterId16 Id { get { return _id; } }
        public MonsterSummaryMonsterNameArray MonsterName { get { return _monsterName; } }
        public byte Field0xc { get { return _field0xc; } }
        public byte Field0xd { get { return _field0xd; } }
        public byte Field0xe { get { return _field0xe; } }
        public byte Field0xf { get { return _field0xf; } }
        public byte Field0x10 { get { return _field0x10; } }
        public byte Field0x11 { get { return _field0x11; } }
        public byte Field0x12 { get { return _field0x12; } }
        public byte Field0x13 { get { return _field0x13; } }
        public byte Field0x14 { get { return _field0x14; } }
        public byte Field0x15 { get { return _field0x15; } }
        public MonsterSummaryTypesArray Types { get { return _types; } }
        public MonsterSummaryAbilitiesArray Abilities { get { return _abilities; } }
        public DungeonId8 JoinedAt { get { return _joinedAt; } }
        public byte JoinedAtFloor { get { return _joinedAtFloor; } }
        public Item HeldItem { get { return _heldItem; } }
        public byte Field0x22 { get { return _field0x22; } }
        public byte Field0x23 { get { return _field0x23; } }
        public int Hp { get { return _hp; } }
        public int MaxHp { get { return _maxHp; } }
        public uint Level { get { return _level; } }
        public int Exp { get { return _exp; } }
        public MonsterSummaryOffensiveStatsArray OffensiveStats { get { return _offensiveStats; } }
        public MonsterSummaryDefensiveStatsArray DefensiveStats { get { return _defensiveStats; } }
        public byte IsTeamLeader { get { return _isTeamLeader; } }
        public byte AttackBoost { get { return _attackBoost; } }
        public byte SpecialAttackBoost { get { return _specialAttackBoost; } }
        public byte DefenseBoost { get { return _defenseBoost; } }
        public byte SpecialDefenseBoost { get { return _specialDefenseBoost; } }
        public byte Field0x3d { get { return _field0x3d; } }
        public short Iq { get { return _iq; } }
        public byte Field0x40 { get { return _field0x40; } }
        public byte Field0x41 { get { return _field0x41; } }
        public byte LevelAtFirstEvo { get { return _levelAtFirstEvo; } }
        public byte LevelAtSecondEvo { get { return _levelAtSecondEvo; } }
        public byte EvoStatus { get { return _evoStatus; } }
        public byte InflictedWithGastroAcid { get { return _inflictedWithGastroAcid; } }
        public byte Field0x46 { get { return _field0x46; } }
        public byte Field0x47 { get { return _field0x47; } }
        public MonsterSummaryIqSkillFlagsArray IqSkillFlags { get { return _iqSkillFlags; } }
        public TacticId8 Tactic { get { return _tactic; } }
        public byte Field0x55 { get { return _field0x55; } }
        public byte Field0x56 { get { return _field0x56; } }
        public byte Field0x57 { get { return _field0x57; } }
        public MonsterSummaryActiveStatusesArray ActiveStatuses { get { return _activeStatuses; } }
        public ushort Padding0x76 { get { return _padding0x76; } }
        public MonsterSummary M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
