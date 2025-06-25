// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents a struct or union ground_monster defined within pmdsky-debug.
    /// </summary>
    public partial class GroundMonster : KaitaiStruct
    {
        public static GroundMonster FromFile(string fileName)
        {
            return new GroundMonster(new KaitaiStream(fileName));
        }

        public GroundMonster(KaitaiStream p__io, KaitaiStruct p__parent = null, GroundMonster p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _isValid = m_io.ReadU1();
            _level = m_io.ReadS1();
            _joinedAt = new DungeonId8(m_io);
            _joinedAtFloor = m_io.ReadU1();
            _id = new MonsterId16(m_io);
            _levelAtFirstEvo = m_io.ReadS1();
            _levelAtSecondEvo = m_io.ReadS1();
            _iq = m_io.ReadU2le();
            _maxHp = m_io.ReadU2le();
            _offensiveStats = new GroundMonsterOffensiveStatsArray(m_io);
            _defensiveStats = new GroundMonsterDefensiveStatsArray(m_io);
            _exp = m_io.ReadS4le();
            _iqSkillFlags = new GroundMonsterIqSkillFlagsArray(m_io);
            _tactic = new TacticId8(m_io);
            _field0x21 = m_io.ReadU1();
            _moves = new GroundMonsterMovesArray(m_io);
            _name = new GroundMonsterNameArray(m_io);
        }
        private byte _isValid;
        private sbyte _level;
        private DungeonId8 _joinedAt;
        private byte _joinedAtFloor;
        private MonsterId16 _id;
        private sbyte _levelAtFirstEvo;
        private sbyte _levelAtSecondEvo;
        private ushort _iq;
        private ushort _maxHp;
        private GroundMonsterOffensiveStatsArray _offensiveStats;
        private GroundMonsterDefensiveStatsArray _defensiveStats;
        private int _exp;
        private GroundMonsterIqSkillFlagsArray _iqSkillFlags;
        private TacticId8 _tactic;
        private byte _field0x21;
        private GroundMonsterMovesArray _moves;
        private GroundMonsterNameArray _name;
        private GroundMonster m_root;
        private KaitaiStruct m_parent;
        public byte IsValid { get { return _isValid; } }
        public sbyte Level { get { return _level; } }
        public DungeonId8 JoinedAt { get { return _joinedAt; } }
        public byte JoinedAtFloor { get { return _joinedAtFloor; } }
        public MonsterId16 Id { get { return _id; } }
        public sbyte LevelAtFirstEvo { get { return _levelAtFirstEvo; } }
        public sbyte LevelAtSecondEvo { get { return _levelAtSecondEvo; } }
        public ushort Iq { get { return _iq; } }
        public ushort MaxHp { get { return _maxHp; } }
        public GroundMonsterOffensiveStatsArray OffensiveStats { get { return _offensiveStats; } }
        public GroundMonsterDefensiveStatsArray DefensiveStats { get { return _defensiveStats; } }
        public int Exp { get { return _exp; } }
        public GroundMonsterIqSkillFlagsArray IqSkillFlags { get { return _iqSkillFlags; } }
        public TacticId8 Tactic { get { return _tactic; } }
        public byte Field0x21 { get { return _field0x21; } }
        public GroundMonsterMovesArray Moves { get { return _moves; } }
        public GroundMonsterNameArray Name { get { return _name; } }
        public GroundMonster M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
