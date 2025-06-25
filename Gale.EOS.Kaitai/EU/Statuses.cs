// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union statuses defined within pmdsky-debug.
    /// </summary>
    public partial class Statuses : KaitaiStruct
    {
        public static Statuses FromFile(string fileName)
        {
            return new Statuses(new KaitaiStream(fileName));
        }

        public Statuses(KaitaiStream p__io, KaitaiStruct p__parent = null, Statuses p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _roost = m_io.ReadU1();
            _originalTypes = new StatusesOriginalTypesArray(m_io);
            _bideMoveId = m_io.ReadU1();
            _field0x4 = m_io.ReadU1();
            _field0x5 = m_io.ReadU1();
            _field0x6 = m_io.ReadU1();
            _uniqueId = m_io.ReadU4le();
            _wrapPairUniqueId = m_io.ReadU4le();
            _bideDamageTally = m_io.ReadU4le();
            _monsterBehavior = new MonsterBehavior8(m_io);
            _sleep = new StatusSleepId8(m_io);
            _sleepTurns = m_io.ReadU1();
            _burn = new StatusBurnId8(m_io);
            _burnTurns = m_io.ReadU1();
            _burnDamageCountdown = m_io.ReadU1();
            _badlyPoisonedDamageCount = m_io.ReadU1();
            _field0x1a = m_io.ReadU1();
            _freeze = new StatusFrozenId8(m_io);
            _field0x1c = m_io.ReadU1();
            _field0x1d = m_io.ReadU1();
            _field0x1e = m_io.ReadU1();
            _constrictionAnimation = m_io.ReadU4le();
            _freezeTurns = m_io.ReadU1();
            _freezeDamageCountdown = m_io.ReadU1();
            _field0x25 = m_io.ReadU1();
            _field0x26 = m_io.ReadU1();
            _cringe = new StatusCringeId8(m_io);
            _cringeTurns = m_io.ReadU1();
            _bide = new StatusTwoTurnId8(m_io);
            _bideTurns = m_io.ReadU1();
            _bideMoveSlot = m_io.ReadU1();
            _reflect = new StatusReflectId8(m_io);
            _reflectTurns = m_io.ReadU1();
            _reflectDamageCountdown = m_io.ReadU1();
            _curse = new StatusCurseId8(m_io);
            _curseApplierNonTeamMemberFlag = m_io.ReadU1();
            _unkDecoyTracker = m_io.ReadU1();
            _curseTurns = m_io.ReadU1();
            _curseDamageCountdown = m_io.ReadU1();
            _field0x34 = m_io.ReadU1();
            _field0x35 = m_io.ReadU1();
            _field0x36 = m_io.ReadU1();
            _leechSeed = new StatusLeechSeedId8(m_io);
            _field0x38 = m_io.ReadU1();
            _field0x39 = m_io.ReadU1();
            _field0x3a = m_io.ReadU1();
            _statusesApplierId = m_io.ReadU4le();
            _leechSeedSourceMonsterIndex = m_io.ReadU1();
            _leechSeedTurns = m_io.ReadU1();
            _leechSeedDamageCountdown = m_io.ReadU1();
            _field0x42 = m_io.ReadU1();
            _sureShot = new StatusSureShotId8(m_io);
            _sureShotTurns = m_io.ReadU1();
            _longToss = new StatusLongTossId8(m_io);
            _invisible = new StatusInvisibleId8(m_io);
            _invisibleTurns = m_io.ReadU1();
            _blinded = new StatusBlinkerId8(m_io);
            _blindedTurns = m_io.ReadU1();
            _muzzled = m_io.ReadU1();
            _muzzledTurns = m_io.ReadU1();
            _miracleEye = m_io.ReadU1();
            _miracleEyeTurns = m_io.ReadU1();
            _magnetRise = m_io.ReadU1();
            _magnetRiseTurns = m_io.ReadU1();
            _powerEars = m_io.ReadU1();
            _scanning = m_io.ReadU1();
            _stairSpotter = m_io.ReadU1();
            _pickupFlag = m_io.ReadU1();
            _grudge = m_io.ReadU1();
            _exposed = m_io.ReadU1();
            _typeChanged = m_io.ReadU1();
            _bossFlag = m_io.ReadU1();
            _unkSpedUpTracker = m_io.ReadU1();
            _field0x59 = m_io.ReadU1();
            _inAction = m_io.ReadU1();
            _terrified = m_io.ReadU1();
            _terrifiedTurns = m_io.ReadU1();
            _perishSongTurns = m_io.ReadU1();
            _noSlipCapCounter = m_io.ReadU1();
            _expYield = m_io.ReadU1();
            _useHeldItem = m_io.ReadU1();
            _field0x61 = m_io.ReadU1();
            _twoTurnMoveInvincible = m_io.ReadU1();
            _decoyAiTracker = m_io.ReadU1();
            _field0x64 = m_io.ReadU1();
            _field0x65 = m_io.ReadU1();
            _field0x66 = m_io.ReadU1();
            _speedStage = m_io.ReadS4le();
            _speedUpCounters = new StatusesSpeedUpCountersArray(m_io);
            _speedDownCounters = new StatusesSpeedDownCountersArray(m_io);
            _stockpileStage = m_io.ReadU1();
        }
        private byte _roost;
        private StatusesOriginalTypesArray _originalTypes;
        private byte _bideMoveId;
        private byte _field0x4;
        private byte _field0x5;
        private byte _field0x6;
        private uint _uniqueId;
        private uint _wrapPairUniqueId;
        private uint _bideDamageTally;
        private MonsterBehavior8 _monsterBehavior;
        private StatusSleepId8 _sleep;
        private byte _sleepTurns;
        private StatusBurnId8 _burn;
        private byte _burnTurns;
        private byte _burnDamageCountdown;
        private byte _badlyPoisonedDamageCount;
        private byte _field0x1a;
        private StatusFrozenId8 _freeze;
        private byte _field0x1c;
        private byte _field0x1d;
        private byte _field0x1e;
        private uint _constrictionAnimation;
        private byte _freezeTurns;
        private byte _freezeDamageCountdown;
        private byte _field0x25;
        private byte _field0x26;
        private StatusCringeId8 _cringe;
        private byte _cringeTurns;
        private StatusTwoTurnId8 _bide;
        private byte _bideTurns;
        private byte _bideMoveSlot;
        private StatusReflectId8 _reflect;
        private byte _reflectTurns;
        private byte _reflectDamageCountdown;
        private StatusCurseId8 _curse;
        private byte _curseApplierNonTeamMemberFlag;
        private byte _unkDecoyTracker;
        private byte _curseTurns;
        private byte _curseDamageCountdown;
        private byte _field0x34;
        private byte _field0x35;
        private byte _field0x36;
        private StatusLeechSeedId8 _leechSeed;
        private byte _field0x38;
        private byte _field0x39;
        private byte _field0x3a;
        private uint _statusesApplierId;
        private byte _leechSeedSourceMonsterIndex;
        private byte _leechSeedTurns;
        private byte _leechSeedDamageCountdown;
        private byte _field0x42;
        private StatusSureShotId8 _sureShot;
        private byte _sureShotTurns;
        private StatusLongTossId8 _longToss;
        private StatusInvisibleId8 _invisible;
        private byte _invisibleTurns;
        private StatusBlinkerId8 _blinded;
        private byte _blindedTurns;
        private byte _muzzled;
        private byte _muzzledTurns;
        private byte _miracleEye;
        private byte _miracleEyeTurns;
        private byte _magnetRise;
        private byte _magnetRiseTurns;
        private byte _powerEars;
        private byte _scanning;
        private byte _stairSpotter;
        private byte _pickupFlag;
        private byte _grudge;
        private byte _exposed;
        private byte _typeChanged;
        private byte _bossFlag;
        private byte _unkSpedUpTracker;
        private byte _field0x59;
        private byte _inAction;
        private byte _terrified;
        private byte _terrifiedTurns;
        private byte _perishSongTurns;
        private byte _noSlipCapCounter;
        private byte _expYield;
        private byte _useHeldItem;
        private byte _field0x61;
        private byte _twoTurnMoveInvincible;
        private byte _decoyAiTracker;
        private byte _field0x64;
        private byte _field0x65;
        private byte _field0x66;
        private int _speedStage;
        private StatusesSpeedUpCountersArray _speedUpCounters;
        private StatusesSpeedDownCountersArray _speedDownCounters;
        private byte _stockpileStage;
        private Statuses m_root;
        private KaitaiStruct m_parent;
        public byte Roost { get { return _roost; } }
        public StatusesOriginalTypesArray OriginalTypes { get { return _originalTypes; } }
        public byte BideMoveId { get { return _bideMoveId; } }
        public byte Field0x4 { get { return _field0x4; } }
        public byte Field0x5 { get { return _field0x5; } }
        public byte Field0x6 { get { return _field0x6; } }
        public uint UniqueId { get { return _uniqueId; } }
        public uint WrapPairUniqueId { get { return _wrapPairUniqueId; } }
        public uint BideDamageTally { get { return _bideDamageTally; } }
        public MonsterBehavior8 MonsterBehavior { get { return _monsterBehavior; } }
        public StatusSleepId8 Sleep { get { return _sleep; } }
        public byte SleepTurns { get { return _sleepTurns; } }
        public StatusBurnId8 Burn { get { return _burn; } }
        public byte BurnTurns { get { return _burnTurns; } }
        public byte BurnDamageCountdown { get { return _burnDamageCountdown; } }
        public byte BadlyPoisonedDamageCount { get { return _badlyPoisonedDamageCount; } }
        public byte Field0x1a { get { return _field0x1a; } }
        public StatusFrozenId8 Freeze { get { return _freeze; } }
        public byte Field0x1c { get { return _field0x1c; } }
        public byte Field0x1d { get { return _field0x1d; } }
        public byte Field0x1e { get { return _field0x1e; } }
        public uint ConstrictionAnimation { get { return _constrictionAnimation; } }
        public byte FreezeTurns { get { return _freezeTurns; } }
        public byte FreezeDamageCountdown { get { return _freezeDamageCountdown; } }
        public byte Field0x25 { get { return _field0x25; } }
        public byte Field0x26 { get { return _field0x26; } }
        public StatusCringeId8 Cringe { get { return _cringe; } }
        public byte CringeTurns { get { return _cringeTurns; } }
        public StatusTwoTurnId8 Bide { get { return _bide; } }
        public byte BideTurns { get { return _bideTurns; } }
        public byte BideMoveSlot { get { return _bideMoveSlot; } }
        public StatusReflectId8 Reflect { get { return _reflect; } }
        public byte ReflectTurns { get { return _reflectTurns; } }
        public byte ReflectDamageCountdown { get { return _reflectDamageCountdown; } }
        public StatusCurseId8 Curse { get { return _curse; } }
        public byte CurseApplierNonTeamMemberFlag { get { return _curseApplierNonTeamMemberFlag; } }
        public byte UnkDecoyTracker { get { return _unkDecoyTracker; } }
        public byte CurseTurns { get { return _curseTurns; } }
        public byte CurseDamageCountdown { get { return _curseDamageCountdown; } }
        public byte Field0x34 { get { return _field0x34; } }
        public byte Field0x35 { get { return _field0x35; } }
        public byte Field0x36 { get { return _field0x36; } }
        public StatusLeechSeedId8 LeechSeed { get { return _leechSeed; } }
        public byte Field0x38 { get { return _field0x38; } }
        public byte Field0x39 { get { return _field0x39; } }
        public byte Field0x3a { get { return _field0x3a; } }
        public uint StatusesApplierId { get { return _statusesApplierId; } }
        public byte LeechSeedSourceMonsterIndex { get { return _leechSeedSourceMonsterIndex; } }
        public byte LeechSeedTurns { get { return _leechSeedTurns; } }
        public byte LeechSeedDamageCountdown { get { return _leechSeedDamageCountdown; } }
        public byte Field0x42 { get { return _field0x42; } }
        public StatusSureShotId8 SureShot { get { return _sureShot; } }
        public byte SureShotTurns { get { return _sureShotTurns; } }
        public StatusLongTossId8 LongToss { get { return _longToss; } }
        public StatusInvisibleId8 Invisible { get { return _invisible; } }
        public byte InvisibleTurns { get { return _invisibleTurns; } }
        public StatusBlinkerId8 Blinded { get { return _blinded; } }
        public byte BlindedTurns { get { return _blindedTurns; } }
        public byte Muzzled { get { return _muzzled; } }
        public byte MuzzledTurns { get { return _muzzledTurns; } }
        public byte MiracleEye { get { return _miracleEye; } }
        public byte MiracleEyeTurns { get { return _miracleEyeTurns; } }
        public byte MagnetRise { get { return _magnetRise; } }
        public byte MagnetRiseTurns { get { return _magnetRiseTurns; } }
        public byte PowerEars { get { return _powerEars; } }
        public byte Scanning { get { return _scanning; } }
        public byte StairSpotter { get { return _stairSpotter; } }
        public byte PickupFlag { get { return _pickupFlag; } }
        public byte Grudge { get { return _grudge; } }
        public byte Exposed { get { return _exposed; } }
        public byte TypeChanged { get { return _typeChanged; } }
        public byte BossFlag { get { return _bossFlag; } }
        public byte UnkSpedUpTracker { get { return _unkSpedUpTracker; } }
        public byte Field0x59 { get { return _field0x59; } }
        public byte InAction { get { return _inAction; } }
        public byte Terrified { get { return _terrified; } }
        public byte TerrifiedTurns { get { return _terrifiedTurns; } }
        public byte PerishSongTurns { get { return _perishSongTurns; } }
        public byte NoSlipCapCounter { get { return _noSlipCapCounter; } }
        public byte ExpYield { get { return _expYield; } }
        public byte UseHeldItem { get { return _useHeldItem; } }
        public byte Field0x61 { get { return _field0x61; } }
        public byte TwoTurnMoveInvincible { get { return _twoTurnMoveInvincible; } }
        public byte DecoyAiTracker { get { return _decoyAiTracker; } }
        public byte Field0x64 { get { return _field0x64; } }
        public byte Field0x65 { get { return _field0x65; } }
        public byte Field0x66 { get { return _field0x66; } }
        public int SpeedStage { get { return _speedStage; } }
        public StatusesSpeedUpCountersArray SpeedUpCounters { get { return _speedUpCounters; } }
        public StatusesSpeedDownCountersArray SpeedDownCounters { get { return _speedDownCounters; } }
        public byte StockpileStage { get { return _stockpileStage; } }
        public Statuses M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
