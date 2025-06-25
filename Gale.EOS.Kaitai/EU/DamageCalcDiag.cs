// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union damage_calc_diag defined within pmdsky-debug.
    /// </summary>
    public partial class DamageCalcDiag : KaitaiStruct
    {
        public static DamageCalcDiag FromFile(string fileName)
        {
            return new DamageCalcDiag(new KaitaiStream(fileName));
        }

        public DamageCalcDiag(KaitaiStream p__io, KaitaiStruct p__parent = null, DamageCalcDiag p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _moveType = new TypeId8(m_io);
            _field0x1 = m_io.ReadU1();
            _field0x2 = m_io.ReadU1();
            _field0x3 = m_io.ReadU1();
            _moveCategory = new MoveCategory(m_io);
            _moveIndivTypeMatchups = new DamageCalcDiagMoveIndivTypeMatchupsArray(m_io);
            _offensiveStatStage = m_io.ReadU1();
            _defensiveStatStage = m_io.ReadU1();
            _offensiveStat = m_io.ReadU2le();
            _defensiveStat = m_io.ReadU2le();
            _flashFireBoost = m_io.ReadU2le();
            _offenseCalc = m_io.ReadU2le();
            _defenseCalc = m_io.ReadU2le();
            _attackerLevel = m_io.ReadU2le();
            _damageCalcAt = m_io.ReadU2le();
            _damageCalcDef = m_io.ReadU2le();
            _damageCalcFlv = m_io.ReadU2le();
            _field0x1e = m_io.ReadU1();
            _field0x1f = m_io.ReadU1();
            _damageCalc = m_io.ReadS4le();
            _damageCalcBase = m_io.ReadS4le();
            _damageCalcRandomMultPct = m_io.ReadS4le();
            _staticDamageMult = m_io.ReadS4le();
            _itemAtkModifier = m_io.ReadS1();
            _itemSpAtkModifier = m_io.ReadS1();
            _abilityOffenseModifier = m_io.ReadS1();
            _abilityDefenseModifier = m_io.ReadS1();
            _iqSkillOffenseModifier = m_io.ReadS1();
            _iqSkillDefenseModifier = m_io.ReadS1();
            _itemDefModifier = m_io.ReadS1();
            _itemSpDefModifier = m_io.ReadS1();
            _scopeLensOrSharpshooterActivated = m_io.ReadU1();
            _patsyBandActivated = m_io.ReadU1();
            _halfPhysicalDamageActivated = m_io.ReadU1();
            _halfSpecialDamageActivated = m_io.ReadU1();
            _focusEnergyActivated = m_io.ReadU1();
            _typeAdvantageMasterActivated = m_io.ReadU1();
            _cloudyDropActivated = m_io.ReadU1();
            _rainMultiplierActivated = m_io.ReadU1();
            _sunnyMultiplierActivated = m_io.ReadU1();
            _fireMoveAbilityDropActivated = m_io.ReadU1();
            _flashFireActivated = m_io.ReadU1();
            _levitateActivated = m_io.ReadU1();
            _torrentBoostActivated = m_io.ReadU1();
            _overgrowBoostActivated = m_io.ReadU1();
            _swarmBoostActivated = m_io.ReadU1();
            _fireMoveAbilityBoostActivated = m_io.ReadU1();
            _scrappyActivated = m_io.ReadU1();
            _superLuckActivated = m_io.ReadU1();
            _sniperActivated = m_io.ReadU1();
            _stabBoostActivated = m_io.ReadU1();
            _electricMoveDampened = m_io.ReadU1();
            _waterSportDropActivated = m_io.ReadU1();
            _chargeBoostActivated = m_io.ReadU1();
            _field0x4f = m_io.ReadU1();
            _ghostImmunityActivated = m_io.ReadU1();
            _skullBashDefenseBoostActivated = m_io.ReadU1();
            _field0x52 = m_io.ReadU1();
            _field0x53 = m_io.ReadU1();
        }
        private TypeId8 _moveType;
        private byte _field0x1;
        private byte _field0x2;
        private byte _field0x3;
        private MoveCategory _moveCategory;
        private DamageCalcDiagMoveIndivTypeMatchupsArray _moveIndivTypeMatchups;
        private byte _offensiveStatStage;
        private byte _defensiveStatStage;
        private ushort _offensiveStat;
        private ushort _defensiveStat;
        private ushort _flashFireBoost;
        private ushort _offenseCalc;
        private ushort _defenseCalc;
        private ushort _attackerLevel;
        private ushort _damageCalcAt;
        private ushort _damageCalcDef;
        private ushort _damageCalcFlv;
        private byte _field0x1e;
        private byte _field0x1f;
        private int _damageCalc;
        private int _damageCalcBase;
        private int _damageCalcRandomMultPct;
        private int _staticDamageMult;
        private sbyte _itemAtkModifier;
        private sbyte _itemSpAtkModifier;
        private sbyte _abilityOffenseModifier;
        private sbyte _abilityDefenseModifier;
        private sbyte _iqSkillOffenseModifier;
        private sbyte _iqSkillDefenseModifier;
        private sbyte _itemDefModifier;
        private sbyte _itemSpDefModifier;
        private byte _scopeLensOrSharpshooterActivated;
        private byte _patsyBandActivated;
        private byte _halfPhysicalDamageActivated;
        private byte _halfSpecialDamageActivated;
        private byte _focusEnergyActivated;
        private byte _typeAdvantageMasterActivated;
        private byte _cloudyDropActivated;
        private byte _rainMultiplierActivated;
        private byte _sunnyMultiplierActivated;
        private byte _fireMoveAbilityDropActivated;
        private byte _flashFireActivated;
        private byte _levitateActivated;
        private byte _torrentBoostActivated;
        private byte _overgrowBoostActivated;
        private byte _swarmBoostActivated;
        private byte _fireMoveAbilityBoostActivated;
        private byte _scrappyActivated;
        private byte _superLuckActivated;
        private byte _sniperActivated;
        private byte _stabBoostActivated;
        private byte _electricMoveDampened;
        private byte _waterSportDropActivated;
        private byte _chargeBoostActivated;
        private byte _field0x4f;
        private byte _ghostImmunityActivated;
        private byte _skullBashDefenseBoostActivated;
        private byte _field0x52;
        private byte _field0x53;
        private DamageCalcDiag m_root;
        private KaitaiStruct m_parent;
        public TypeId8 MoveType { get { return _moveType; } }
        public byte Field0x1 { get { return _field0x1; } }
        public byte Field0x2 { get { return _field0x2; } }
        public byte Field0x3 { get { return _field0x3; } }
        public MoveCategory MoveCategory { get { return _moveCategory; } }
        public DamageCalcDiagMoveIndivTypeMatchupsArray MoveIndivTypeMatchups { get { return _moveIndivTypeMatchups; } }
        public byte OffensiveStatStage { get { return _offensiveStatStage; } }
        public byte DefensiveStatStage { get { return _defensiveStatStage; } }
        public ushort OffensiveStat { get { return _offensiveStat; } }
        public ushort DefensiveStat { get { return _defensiveStat; } }
        public ushort FlashFireBoost { get { return _flashFireBoost; } }
        public ushort OffenseCalc { get { return _offenseCalc; } }
        public ushort DefenseCalc { get { return _defenseCalc; } }
        public ushort AttackerLevel { get { return _attackerLevel; } }
        public ushort DamageCalcAt { get { return _damageCalcAt; } }
        public ushort DamageCalcDef { get { return _damageCalcDef; } }
        public ushort DamageCalcFlv { get { return _damageCalcFlv; } }
        public byte Field0x1e { get { return _field0x1e; } }
        public byte Field0x1f { get { return _field0x1f; } }
        public int DamageCalc { get { return _damageCalc; } }
        public int DamageCalcBase { get { return _damageCalcBase; } }
        public int DamageCalcRandomMultPct { get { return _damageCalcRandomMultPct; } }
        public int StaticDamageMult { get { return _staticDamageMult; } }
        public sbyte ItemAtkModifier { get { return _itemAtkModifier; } }
        public sbyte ItemSpAtkModifier { get { return _itemSpAtkModifier; } }
        public sbyte AbilityOffenseModifier { get { return _abilityOffenseModifier; } }
        public sbyte AbilityDefenseModifier { get { return _abilityDefenseModifier; } }
        public sbyte IqSkillOffenseModifier { get { return _iqSkillOffenseModifier; } }
        public sbyte IqSkillDefenseModifier { get { return _iqSkillDefenseModifier; } }
        public sbyte ItemDefModifier { get { return _itemDefModifier; } }
        public sbyte ItemSpDefModifier { get { return _itemSpDefModifier; } }
        public byte ScopeLensOrSharpshooterActivated { get { return _scopeLensOrSharpshooterActivated; } }
        public byte PatsyBandActivated { get { return _patsyBandActivated; } }
        public byte HalfPhysicalDamageActivated { get { return _halfPhysicalDamageActivated; } }
        public byte HalfSpecialDamageActivated { get { return _halfSpecialDamageActivated; } }
        public byte FocusEnergyActivated { get { return _focusEnergyActivated; } }
        public byte TypeAdvantageMasterActivated { get { return _typeAdvantageMasterActivated; } }
        public byte CloudyDropActivated { get { return _cloudyDropActivated; } }
        public byte RainMultiplierActivated { get { return _rainMultiplierActivated; } }
        public byte SunnyMultiplierActivated { get { return _sunnyMultiplierActivated; } }
        public byte FireMoveAbilityDropActivated { get { return _fireMoveAbilityDropActivated; } }
        public byte FlashFireActivated { get { return _flashFireActivated; } }
        public byte LevitateActivated { get { return _levitateActivated; } }
        public byte TorrentBoostActivated { get { return _torrentBoostActivated; } }
        public byte OvergrowBoostActivated { get { return _overgrowBoostActivated; } }
        public byte SwarmBoostActivated { get { return _swarmBoostActivated; } }
        public byte FireMoveAbilityBoostActivated { get { return _fireMoveAbilityBoostActivated; } }
        public byte ScrappyActivated { get { return _scrappyActivated; } }
        public byte SuperLuckActivated { get { return _superLuckActivated; } }
        public byte SniperActivated { get { return _sniperActivated; } }
        public byte StabBoostActivated { get { return _stabBoostActivated; } }
        public byte ElectricMoveDampened { get { return _electricMoveDampened; } }
        public byte WaterSportDropActivated { get { return _waterSportDropActivated; } }
        public byte ChargeBoostActivated { get { return _chargeBoostActivated; } }
        public byte Field0x4f { get { return _field0x4f; } }
        public byte GhostImmunityActivated { get { return _ghostImmunityActivated; } }
        public byte SkullBashDefenseBoostActivated { get { return _skullBashDefenseBoostActivated; } }
        public byte Field0x52 { get { return _field0x52; } }
        public byte Field0x53 { get { return _field0x53; } }
        public DamageCalcDiag M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
