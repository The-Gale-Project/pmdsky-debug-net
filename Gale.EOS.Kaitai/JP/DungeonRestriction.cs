// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents a struct or union dungeon_restriction defined within pmdsky-debug.
    /// </summary>
    public partial class DungeonRestriction : KaitaiStruct
    {
        public static DungeonRestriction FromFile(string fileName)
        {
            return new DungeonRestriction(new KaitaiStream(fileName));
        }

        public DungeonRestriction(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonRestriction p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _fDungeonGoesUp = m_io.ReadBitsIntLe(1) != 0;
            _fEnemiesEvolve = m_io.ReadBitsIntLe(1) != 0;
            _fEnemiesGiveExp = m_io.ReadBitsIntLe(1) != 0;
            _fRecruitmentAllowed = m_io.ReadBitsIntLe(1) != 0;
            _fResetToLevel1 = m_io.ReadBitsIntLe(1) != 0;
            _fMoneyAllowed = m_io.ReadBitsIntLe(1) != 0;
            _fLeaderChangeEnabled = m_io.ReadBitsIntLe(1) != 0;
            _fEnterWithoutSaving = m_io.ReadBitsIntLe(1) != 0;
            _fDisableIqSkills = m_io.ReadBitsIntLe(1) != 0;
            _fNoTrapUncovering = m_io.ReadBitsIntLe(1) != 0;
            _fTreasureBoxDrops = m_io.ReadBitsIntLe(1) != 0;
            _flagsUnused = m_io.ReadBitsIntLe(5);
            m_io.AlignToByte();
            _unused = m_io.ReadU2le();
            _maxRescueAttempts = m_io.ReadU1();
            _maxItemsAllowed = m_io.ReadU1();
            _maxPartySize = m_io.ReadU1();
            _field0x7 = m_io.ReadU1();
            _turnLimitPerFloor = m_io.ReadU2le();
            _randomMovementChance = m_io.ReadS2le();
        }
        private bool _fDungeonGoesUp;
        private bool _fEnemiesEvolve;
        private bool _fEnemiesGiveExp;
        private bool _fRecruitmentAllowed;
        private bool _fResetToLevel1;
        private bool _fMoneyAllowed;
        private bool _fLeaderChangeEnabled;
        private bool _fEnterWithoutSaving;
        private bool _fDisableIqSkills;
        private bool _fNoTrapUncovering;
        private bool _fTreasureBoxDrops;
        private ulong _flagsUnused;
        private ushort _unused;
        private byte _maxRescueAttempts;
        private byte _maxItemsAllowed;
        private byte _maxPartySize;
        private byte _field0x7;
        private ushort _turnLimitPerFloor;
        private short _randomMovementChance;
        private DungeonRestriction m_root;
        private KaitaiStruct m_parent;
        public bool FDungeonGoesUp { get { return _fDungeonGoesUp; } }
        public bool FEnemiesEvolve { get { return _fEnemiesEvolve; } }
        public bool FEnemiesGiveExp { get { return _fEnemiesGiveExp; } }
        public bool FRecruitmentAllowed { get { return _fRecruitmentAllowed; } }
        public bool FResetToLevel1 { get { return _fResetToLevel1; } }
        public bool FMoneyAllowed { get { return _fMoneyAllowed; } }
        public bool FLeaderChangeEnabled { get { return _fLeaderChangeEnabled; } }
        public bool FEnterWithoutSaving { get { return _fEnterWithoutSaving; } }
        public bool FDisableIqSkills { get { return _fDisableIqSkills; } }
        public bool FNoTrapUncovering { get { return _fNoTrapUncovering; } }
        public bool FTreasureBoxDrops { get { return _fTreasureBoxDrops; } }
        public ulong FlagsUnused { get { return _flagsUnused; } }
        public ushort Unused { get { return _unused; } }
        public byte MaxRescueAttempts { get { return _maxRescueAttempts; } }
        public byte MaxItemsAllowed { get { return _maxItemsAllowed; } }
        public byte MaxPartySize { get { return _maxPartySize; } }
        public byte Field0x7 { get { return _field0x7; } }
        public ushort TurnLimitPerFloor { get { return _turnLimitPerFloor; } }
        public short RandomMovementChance { get { return _randomMovementChance; } }
        public DungeonRestriction M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
