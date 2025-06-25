// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union team_member defined within pmdsky-debug.
    /// </summary>
    public partial class TeamMember : KaitaiStruct
    {
        public static TeamMember FromFile(string fileName)
        {
            return new TeamMember(new KaitaiStream(fileName));
        }

        public TeamMember(KaitaiStream p__io, KaitaiStruct p__parent = null, TeamMember p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _fIsValid = m_io.ReadBitsIntLe(1) != 0;
            _flagsUnk1 = m_io.ReadBitsIntLe(7);
            m_io.AlignToByte();
            _isLeader = m_io.ReadU1();
            _level = m_io.ReadU1();
            _joinedAt = new DungeonId8(m_io);
            _joinedAtFloor = m_io.ReadU1();
            _field0x5 = m_io.ReadU1();
            _iq = m_io.ReadU2le();
            _memberIndex = m_io.ReadS2le();
            _teamIndex = m_io.ReadS2le();
            _id = new MonsterId16(m_io);
            _currentHp = m_io.ReadU2le();
            _maxHp = m_io.ReadU2le();
            _offensiveStats = new TeamMemberOffensiveStatsArray(m_io);
            _defensiveStats = new TeamMemberDefensiveStatsArray(m_io);
            _field0x16 = m_io.ReadU1();
            _field0x17 = m_io.ReadU1();
            _exp = m_io.ReadS4le();
            _moves = new TeamMemberMovesArray(m_io);
            _field0x3c = m_io.ReadU1();
            _field0x3d = m_io.ReadU1();
            _heldItem = new Item(m_io);
            _belly = m_io.ReadS2le();
            _bellyThousandths = m_io.ReadS2le();
            _maxBelly = m_io.ReadS2le();
            _maxBellyThousandths = m_io.ReadS2le();
            _iqSkillFlags = new TeamMemberIqSkillFlagsArray(m_io);
            _tactic = new TacticId8(m_io);
            _field0x59 = m_io.ReadU1();
            _hiddenPowerBasePower = m_io.ReadS2le();
            _hiddenPowerType = new TypeId8(m_io);
            _field0x5d = m_io.ReadU1();
            _name = new TeamMemberNameArray(m_io);
        }
        private bool _fIsValid;
        private ulong _flagsUnk1;
        private byte _isLeader;
        private byte _level;
        private DungeonId8 _joinedAt;
        private byte _joinedAtFloor;
        private byte _field0x5;
        private ushort _iq;
        private short _memberIndex;
        private short _teamIndex;
        private MonsterId16 _id;
        private ushort _currentHp;
        private ushort _maxHp;
        private TeamMemberOffensiveStatsArray _offensiveStats;
        private TeamMemberDefensiveStatsArray _defensiveStats;
        private byte _field0x16;
        private byte _field0x17;
        private int _exp;
        private TeamMemberMovesArray _moves;
        private byte _field0x3c;
        private byte _field0x3d;
        private Item _heldItem;
        private short _belly;
        private short _bellyThousandths;
        private short _maxBelly;
        private short _maxBellyThousandths;
        private TeamMemberIqSkillFlagsArray _iqSkillFlags;
        private TacticId8 _tactic;
        private byte _field0x59;
        private short _hiddenPowerBasePower;
        private TypeId8 _hiddenPowerType;
        private byte _field0x5d;
        private TeamMemberNameArray _name;
        private TeamMember m_root;
        private KaitaiStruct m_parent;
        public bool FIsValid { get { return _fIsValid; } }
        public ulong FlagsUnk1 { get { return _flagsUnk1; } }
        public byte IsLeader { get { return _isLeader; } }
        public byte Level { get { return _level; } }
        public DungeonId8 JoinedAt { get { return _joinedAt; } }
        public byte JoinedAtFloor { get { return _joinedAtFloor; } }
        public byte Field0x5 { get { return _field0x5; } }
        public ushort Iq { get { return _iq; } }
        public short MemberIndex { get { return _memberIndex; } }
        public short TeamIndex { get { return _teamIndex; } }
        public MonsterId16 Id { get { return _id; } }
        public ushort CurrentHp { get { return _currentHp; } }
        public ushort MaxHp { get { return _maxHp; } }
        public TeamMemberOffensiveStatsArray OffensiveStats { get { return _offensiveStats; } }
        public TeamMemberDefensiveStatsArray DefensiveStats { get { return _defensiveStats; } }
        public byte Field0x16 { get { return _field0x16; } }
        public byte Field0x17 { get { return _field0x17; } }
        public int Exp { get { return _exp; } }
        public TeamMemberMovesArray Moves { get { return _moves; } }
        public byte Field0x3c { get { return _field0x3c; } }
        public byte Field0x3d { get { return _field0x3d; } }
        public Item HeldItem { get { return _heldItem; } }
        public short Belly { get { return _belly; } }
        public short BellyThousandths { get { return _bellyThousandths; } }
        public short MaxBelly { get { return _maxBelly; } }
        public short MaxBellyThousandths { get { return _maxBellyThousandths; } }
        public TeamMemberIqSkillFlagsArray IqSkillFlags { get { return _iqSkillFlags; } }
        public TacticId8 Tactic { get { return _tactic; } }
        public byte Field0x59 { get { return _field0x59; } }
        public short HiddenPowerBasePower { get { return _hiddenPowerBasePower; } }
        public TypeId8 HiddenPowerType { get { return _hiddenPowerType; } }
        public byte Field0x5d { get { return _field0x5d; } }
        public TeamMemberNameArray Name { get { return _name; } }
        public TeamMember M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
