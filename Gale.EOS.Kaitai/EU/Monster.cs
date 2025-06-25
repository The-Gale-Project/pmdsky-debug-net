// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union monster defined within pmdsky-debug.
    /// </summary>
    public partial class Monster : KaitaiStruct
    {
        public static Monster FromFile(string fileName)
        {
            return new Monster(new KaitaiStream(fileName));
        }

        public Monster(KaitaiStream p__io, KaitaiStruct p__parent = null, Monster p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _fAiUnk = m_io.ReadBitsIntLe(1) != 0;
            _fAiSkipTurn = m_io.ReadBitsIntLe(1) != 0;
            _flagsUnk2 = m_io.ReadBitsIntLe(3);
            _fSwappingPlaces = m_io.ReadBitsIntLe(1) != 0;
            _flagsUnk6 = m_io.ReadBitsIntLe(3);
            _fWalking = m_io.ReadBitsIntLe(1) != 0;
            _flagsUnk10 = m_io.ReadBitsIntLe(5);
            _fSwappingPlacesPetrifiedAlly = m_io.ReadBitsIntLe(1) != 0;
            m_io.AlignToByte();
            _id = new MonsterId16(m_io);
            _apparentId = new MonsterId16(m_io);
            _isNotTeamMember = m_io.ReadU1();
            _isTeamLeader = m_io.ReadU1();
            _isAlly = m_io.ReadU1();
            _shopkeeper = new ShopkeeperMode8(m_io);
            _level = m_io.ReadU1();
            _field0xb = m_io.ReadU1();
            _teamIndex = m_io.ReadS2le();
            _iq = m_io.ReadS2le();
            _hp = m_io.ReadS2le();
            _maxHpStat = m_io.ReadS2le();
            _field0x14 = m_io.ReadU1();
            _field0x15 = m_io.ReadU1();
            _maxHpBoost = m_io.ReadS2le();
            _field0x18 = m_io.ReadU1();
            _field0x19 = m_io.ReadU1();
            _offensiveStats = new MonsterOffensiveStatsArray(m_io);
            _defensiveStats = new MonsterDefensiveStatsArray(m_io);
            _field0x1e = m_io.ReadU1();
            _field0x1f = m_io.ReadU1();
            _exp = m_io.ReadS4le();
            _statModifiers = new MonsterStatModifiers(m_io);
            _hiddenPowerBasePower = m_io.ReadS2le();
            _hiddenPowerType = new TypeId8(m_io);
            _field0x47 = m_io.ReadU1();
            _joinedAt = new DungeonId8(m_io);
            _joinedAtFloor = m_io.ReadU1();
            _action = new ActionData(m_io);
            _types = new MonsterTypesArray(m_io);
            _abilities = new MonsterAbilitiesArray(m_io);
            _heldItem = new Item(m_io);
            _previousHeldItemId = new ItemId16(m_io);
            _prevPos = new Position(m_io);
            _prevPos2 = new Position(m_io);
            _prevPos3 = new Position(m_io);
            _prevPos4 = new Position(m_io);
            _field0x7a = m_io.ReadU1();
            _field0x7b = m_io.ReadU1();
            _aiObjective = new AiObjective8(m_io);
            _aiNotNextToTarget = m_io.ReadU1();
            _aiTargetingEnemy = m_io.ReadU1();
            _aiTurningAround = m_io.ReadU1();
            _aiTargetSpawnGenid = m_io.ReadU2le();
            _field0x82 = m_io.ReadU1();
            _field0x83 = m_io.ReadU1();
            _aiTarget = new Pointer(m_io);
            _field0x88 = m_io.ReadU1();
            _field0x89 = m_io.ReadU1();
            _field0x8a = m_io.ReadU1();
            _field0x8b = m_io.ReadU1();
            _aiTargetPos = new Position(m_io);
            _iqSkillMenuFlags = new MonsterIqSkillMenuFlagsArray(m_io);
            _iqSkillFlags = new MonsterIqSkillFlagsArray(m_io);
            _tactic = new TacticId8(m_io);
            _statuses = new Statuses(m_io);
            _field0x11f = m_io.ReadU1();
            _randomMovement = m_io.ReadS4le();
            _moves = new MonsterMovesArray(m_io);
            _struggleMoveFlags = m_io.ReadU1();
            _field0x145 = m_io.ReadU1();
            _belly = m_io.ReadS2le();
            _bellyThousandths = m_io.ReadS2le();
            _maxBelly = m_io.ReadS2le();
            _maxBellyThousandths = m_io.ReadS2le();
            _aiAllySkip = m_io.ReadU1();
            _aiNextToTarget = m_io.ReadU1();
            _famished = m_io.ReadU1();
            _waiting = m_io.ReadU1();
            _alreadyActed = m_io.ReadU1();
            _shouldEvolve = m_io.ReadU1();
            _usingChargedMove = m_io.ReadU1();
            _hitGrudgeMonster = m_io.ReadU1();
            _field0x156 = m_io.ReadU1();
            _field0x157 = m_io.ReadU1();
            _stateFlags = m_io.ReadU2le();
            _prevStateFlags = m_io.ReadU2le();
            _applyFlashFireBoost = m_io.ReadU1();
            _rolloutHitCounter = m_io.ReadU1();
            _mementoWarpFlag = m_io.ReadU1();
            _overheatSpecialAttackDropFlag = m_io.ReadU1();
            _displayShadow = m_io.ReadU1();
            _cannotGiveItems = m_io.ReadU1();
            _field0x162 = m_io.ReadU1();
            _field0x163 = m_io.ReadU1();
            _tookDamageFlag = m_io.ReadU1();
            _field0x165 = m_io.ReadU1();
            _practiceSwingerFlag = m_io.ReadU1();
            _angerPointFlag = m_io.ReadU1();
            _field0x168 = m_io.ReadU1();
            _field0x169 = m_io.ReadU1();
            _forceTurn = new DirectionId8(m_io);
            _field0x16b = m_io.ReadU1();
            _field0x16c = m_io.ReadU1();
            _field0x16d = m_io.ReadU1();
            _field0x16e = m_io.ReadU1();
            _field0x16f = m_io.ReadU1();
            _uturnHideMonsterFlag = m_io.ReadU1();
            _field0x171 = m_io.ReadU1();
            _pitfallTrapFlag0x172 = m_io.ReadU1();
            _field0x173 = m_io.ReadU1();
            _pitfallTrapFlag0x174 = m_io.ReadU1();
            _field0x175 = m_io.ReadU1();
            _field0x176 = m_io.ReadU1();
            _sleepTalkDirection = new DirectionId8(m_io);
            _snoreDirection = new DirectionId8(m_io);
            _field0x179 = m_io.ReadU1();
            _field0x17a = m_io.ReadU1();
            _field0x17b = m_io.ReadU1();
            _turnsSinceLastWarpScarf = m_io.ReadU1();
            _field0x17d = m_io.ReadU1();
            _targetPos = new Position(m_io);
            _pixelPos = new Position(m_io);
            _field0x186 = m_io.ReadU1();
            _field0x187 = m_io.ReadU1();
            _field0x188 = m_io.ReadU1();
            _field0x189 = m_io.ReadU1();
            _field0x18a = m_io.ReadU1();
            _field0x18b = m_io.ReadU1();
            _exclusiveItemTriggerBitflags = m_io.ReadU4le();
            _field0x190 = m_io.ReadS2le();
            _contactAbilityTriggerBitflags = m_io.ReadU2le();
            _field0x194 = m_io.ReadU1();
            _field0x195 = m_io.ReadU1();
            _field0x196 = m_io.ReadU1();
            _field0x197 = m_io.ReadU1();
            _field0x198 = m_io.ReadU1();
            _field0x199 = m_io.ReadU1();
            _field0x19a = m_io.ReadU1();
            _field0x19b = m_io.ReadU1();
            _pos = new Position(m_io);
            _field0x1a0 = m_io.ReadU1();
            _field0x1a1 = m_io.ReadU1();
            _field0x1a2 = m_io.ReadU1();
            _field0x1a3 = m_io.ReadU1();
            _field0x1a4 = m_io.ReadU1();
            _field0x1a5 = m_io.ReadU1();
            _field0x1a6 = m_io.ReadU1();
            _field0x1a7 = m_io.ReadU1();
            _field0x1a8 = m_io.ReadU1();
            _field0x1a9 = m_io.ReadU1();
            _field0x1aa = m_io.ReadU1();
            _field0x1ab = m_io.ReadU1();
            _field0x1ac = m_io.ReadU1();
            _field0x1ad = m_io.ReadU1();
            _field0x1ae = m_io.ReadU1();
            _field0x1af = m_io.ReadU1();
            _field0x1b0 = m_io.ReadU1();
            _field0x1b1 = m_io.ReadU1();
            _field0x1b2 = m_io.ReadU1();
            _field0x1b3 = m_io.ReadU1();
            _walkAnimFramesLeft = m_io.ReadU2le();
            _field0x1b6 = m_io.ReadU1();
            _field0x1b7 = m_io.ReadU1();
            _field0x1b8 = m_io.ReadU1();
            _field0x1b9 = m_io.ReadU1();
            _field0x1ba = m_io.ReadU1();
            _field0x1bb = m_io.ReadU1();
            _field0x1bc = m_io.ReadU1();
            _field0x1bd = m_io.ReadU1();
            _field0x1be = m_io.ReadU1();
            _field0x1bf = m_io.ReadU1();
            _field0x1c0 = m_io.ReadU1();
            _field0x1c1 = m_io.ReadU1();
            _field0x1c2 = m_io.ReadU1();
            _field0x1c3 = m_io.ReadU1();
            _field0x1c4 = m_io.ReadU1();
            _field0x1c5 = m_io.ReadU1();
            _field0x1c6 = m_io.ReadU1();
            _field0x1c7 = m_io.ReadU1();
            _field0x1c8 = m_io.ReadU1();
            _field0x1c9 = m_io.ReadU1();
            _field0x1ca = m_io.ReadU1();
            _field0x1cb = m_io.ReadU1();
            _field0x1cc = m_io.ReadU1();
            _field0x1cd = m_io.ReadU1();
            _field0x1ce = m_io.ReadU1();
            _field0x1cf = m_io.ReadU1();
            _field0x1d0 = m_io.ReadU1();
            _field0x1d1 = m_io.ReadU1();
            _field0x1d2 = m_io.ReadU1();
            _field0x1d3 = m_io.ReadU1();
            _field0x1d4 = m_io.ReadU1();
            _field0x1d5 = m_io.ReadU1();
            _field0x1d6 = m_io.ReadU1();
            _field0x1d7 = m_io.ReadU1();
            _field0x1d8 = m_io.ReadU1();
            _field0x1d9 = m_io.ReadU1();
            _field0x1da = m_io.ReadU1();
            _field0x1db = m_io.ReadU1();
            _field0x1dc = m_io.ReadU1();
            _field0x1dd = m_io.ReadU1();
            _field0x1de = m_io.ReadU1();
            _field0x1df = m_io.ReadU1();
            _field0x1e0 = m_io.ReadU1();
            _field0x1e1 = m_io.ReadU1();
            _field0x1e2 = m_io.ReadU1();
            _field0x1e3 = m_io.ReadU1();
            _field0x1e4 = m_io.ReadU1();
            _field0x1e5 = m_io.ReadU1();
            _field0x1e6 = m_io.ReadU1();
            _field0x1e7 = m_io.ReadU1();
            _field0x1e8 = m_io.ReadU1();
            _field0x1e9 = m_io.ReadU1();
            _field0x1ea = m_io.ReadU1();
            _field0x1eb = m_io.ReadU1();
            _field0x1ec = m_io.ReadU1();
            _field0x1ed = m_io.ReadU1();
            _field0x1ee = m_io.ReadU1();
            _field0x1ef = m_io.ReadU1();
            _field0x1f0 = m_io.ReadU1();
            _field0x1f1 = m_io.ReadU1();
            _field0x1f2 = m_io.ReadU1();
            _field0x1f3 = m_io.ReadU1();
            _field0x1f4 = m_io.ReadU1();
            _field0x1f5 = m_io.ReadU1();
            _field0x1f6 = m_io.ReadU1();
            _field0x1f7 = m_io.ReadU1();
            _field0x1f8 = m_io.ReadU1();
            _field0x1f9 = m_io.ReadU1();
            _field0x1fa = m_io.ReadU1();
            _field0x1fb = m_io.ReadU1();
            _field0x1fc = m_io.ReadU1();
            _field0x1fd = m_io.ReadU1();
            _field0x1fe = m_io.ReadU1();
            _field0x1ff = m_io.ReadU1();
            _field0x200 = m_io.ReadU1();
            _field0x201 = m_io.ReadU1();
            _field0x202 = m_io.ReadU1();
            _field0x203 = m_io.ReadU1();
            _field0x204 = m_io.ReadU1();
            _field0x205 = m_io.ReadU1();
            _field0x206 = m_io.ReadU1();
            _field0x207 = m_io.ReadU1();
            _field0x208 = m_io.ReadU1();
            _field0x209 = m_io.ReadU1();
            _field0x20a = m_io.ReadU1();
            _field0x20b = m_io.ReadU1();
            _field0x20c = m_io.ReadU1();
            _field0x20d = m_io.ReadU1();
            _field0x20e = m_io.ReadU1();
            _field0x20f = m_io.ReadU1();
            _hpFractional = m_io.ReadU1();
            _field0x211 = m_io.ReadU1();
            _field0x212 = m_io.ReadU1();
            _field0x213 = m_io.ReadU1();
            _unkExpTracker = m_io.ReadU4le();
            _statusIcons = new StatusIconFlags(m_io);
            _waterShadowRippleTracker = m_io.ReadU1();
            _meFirstFlag = m_io.ReadU1();
            _field0x222 = m_io.ReadU1();
            _field0x223 = m_io.ReadU1();
            _exclusiveItemOffenseBoosts = new MonsterExclusiveItemOffenseBoostsArray(m_io);
            _exclusiveItemDefenseBoosts = new MonsterExclusiveItemDefenseBoostsArray(m_io);
            _exclusiveItemEffectFlags = new MonsterExclusiveItemEffectFlagsArray(m_io);
            _field0x23c = m_io.ReadU1();
            _unkReviveVisualTracker = m_io.ReadU1();
            _field0x23e = m_io.ReadU1();
            _shouldNotLosePp = m_io.ReadU1();
        }
        private bool _fAiUnk;
        private bool _fAiSkipTurn;
        private ulong _flagsUnk2;
        private bool _fSwappingPlaces;
        private ulong _flagsUnk6;
        private bool _fWalking;
        private ulong _flagsUnk10;
        private bool _fSwappingPlacesPetrifiedAlly;
        private MonsterId16 _id;
        private MonsterId16 _apparentId;
        private byte _isNotTeamMember;
        private byte _isTeamLeader;
        private byte _isAlly;
        private ShopkeeperMode8 _shopkeeper;
        private byte _level;
        private byte _field0xb;
        private short _teamIndex;
        private short _iq;
        private short _hp;
        private short _maxHpStat;
        private byte _field0x14;
        private byte _field0x15;
        private short _maxHpBoost;
        private byte _field0x18;
        private byte _field0x19;
        private MonsterOffensiveStatsArray _offensiveStats;
        private MonsterDefensiveStatsArray _defensiveStats;
        private byte _field0x1e;
        private byte _field0x1f;
        private int _exp;
        private MonsterStatModifiers _statModifiers;
        private short _hiddenPowerBasePower;
        private TypeId8 _hiddenPowerType;
        private byte _field0x47;
        private DungeonId8 _joinedAt;
        private byte _joinedAtFloor;
        private ActionData _action;
        private MonsterTypesArray _types;
        private MonsterAbilitiesArray _abilities;
        private Item _heldItem;
        private ItemId16 _previousHeldItemId;
        private Position _prevPos;
        private Position _prevPos2;
        private Position _prevPos3;
        private Position _prevPos4;
        private byte _field0x7a;
        private byte _field0x7b;
        private AiObjective8 _aiObjective;
        private byte _aiNotNextToTarget;
        private byte _aiTargetingEnemy;
        private byte _aiTurningAround;
        private ushort _aiTargetSpawnGenid;
        private byte _field0x82;
        private byte _field0x83;
        private Pointer _aiTarget;
        private byte _field0x88;
        private byte _field0x89;
        private byte _field0x8a;
        private byte _field0x8b;
        private Position _aiTargetPos;
        private MonsterIqSkillMenuFlagsArray _iqSkillMenuFlags;
        private MonsterIqSkillFlagsArray _iqSkillFlags;
        private TacticId8 _tactic;
        private Statuses _statuses;
        private byte _field0x11f;
        private int _randomMovement;
        private MonsterMovesArray _moves;
        private byte _struggleMoveFlags;
        private byte _field0x145;
        private short _belly;
        private short _bellyThousandths;
        private short _maxBelly;
        private short _maxBellyThousandths;
        private byte _aiAllySkip;
        private byte _aiNextToTarget;
        private byte _famished;
        private byte _waiting;
        private byte _alreadyActed;
        private byte _shouldEvolve;
        private byte _usingChargedMove;
        private byte _hitGrudgeMonster;
        private byte _field0x156;
        private byte _field0x157;
        private ushort _stateFlags;
        private ushort _prevStateFlags;
        private byte _applyFlashFireBoost;
        private byte _rolloutHitCounter;
        private byte _mementoWarpFlag;
        private byte _overheatSpecialAttackDropFlag;
        private byte _displayShadow;
        private byte _cannotGiveItems;
        private byte _field0x162;
        private byte _field0x163;
        private byte _tookDamageFlag;
        private byte _field0x165;
        private byte _practiceSwingerFlag;
        private byte _angerPointFlag;
        private byte _field0x168;
        private byte _field0x169;
        private DirectionId8 _forceTurn;
        private byte _field0x16b;
        private byte _field0x16c;
        private byte _field0x16d;
        private byte _field0x16e;
        private byte _field0x16f;
        private byte _uturnHideMonsterFlag;
        private byte _field0x171;
        private byte _pitfallTrapFlag0x172;
        private byte _field0x173;
        private byte _pitfallTrapFlag0x174;
        private byte _field0x175;
        private byte _field0x176;
        private DirectionId8 _sleepTalkDirection;
        private DirectionId8 _snoreDirection;
        private byte _field0x179;
        private byte _field0x17a;
        private byte _field0x17b;
        private byte _turnsSinceLastWarpScarf;
        private byte _field0x17d;
        private Position _targetPos;
        private Position _pixelPos;
        private byte _field0x186;
        private byte _field0x187;
        private byte _field0x188;
        private byte _field0x189;
        private byte _field0x18a;
        private byte _field0x18b;
        private uint _exclusiveItemTriggerBitflags;
        private short _field0x190;
        private ushort _contactAbilityTriggerBitflags;
        private byte _field0x194;
        private byte _field0x195;
        private byte _field0x196;
        private byte _field0x197;
        private byte _field0x198;
        private byte _field0x199;
        private byte _field0x19a;
        private byte _field0x19b;
        private Position _pos;
        private byte _field0x1a0;
        private byte _field0x1a1;
        private byte _field0x1a2;
        private byte _field0x1a3;
        private byte _field0x1a4;
        private byte _field0x1a5;
        private byte _field0x1a6;
        private byte _field0x1a7;
        private byte _field0x1a8;
        private byte _field0x1a9;
        private byte _field0x1aa;
        private byte _field0x1ab;
        private byte _field0x1ac;
        private byte _field0x1ad;
        private byte _field0x1ae;
        private byte _field0x1af;
        private byte _field0x1b0;
        private byte _field0x1b1;
        private byte _field0x1b2;
        private byte _field0x1b3;
        private ushort _walkAnimFramesLeft;
        private byte _field0x1b6;
        private byte _field0x1b7;
        private byte _field0x1b8;
        private byte _field0x1b9;
        private byte _field0x1ba;
        private byte _field0x1bb;
        private byte _field0x1bc;
        private byte _field0x1bd;
        private byte _field0x1be;
        private byte _field0x1bf;
        private byte _field0x1c0;
        private byte _field0x1c1;
        private byte _field0x1c2;
        private byte _field0x1c3;
        private byte _field0x1c4;
        private byte _field0x1c5;
        private byte _field0x1c6;
        private byte _field0x1c7;
        private byte _field0x1c8;
        private byte _field0x1c9;
        private byte _field0x1ca;
        private byte _field0x1cb;
        private byte _field0x1cc;
        private byte _field0x1cd;
        private byte _field0x1ce;
        private byte _field0x1cf;
        private byte _field0x1d0;
        private byte _field0x1d1;
        private byte _field0x1d2;
        private byte _field0x1d3;
        private byte _field0x1d4;
        private byte _field0x1d5;
        private byte _field0x1d6;
        private byte _field0x1d7;
        private byte _field0x1d8;
        private byte _field0x1d9;
        private byte _field0x1da;
        private byte _field0x1db;
        private byte _field0x1dc;
        private byte _field0x1dd;
        private byte _field0x1de;
        private byte _field0x1df;
        private byte _field0x1e0;
        private byte _field0x1e1;
        private byte _field0x1e2;
        private byte _field0x1e3;
        private byte _field0x1e4;
        private byte _field0x1e5;
        private byte _field0x1e6;
        private byte _field0x1e7;
        private byte _field0x1e8;
        private byte _field0x1e9;
        private byte _field0x1ea;
        private byte _field0x1eb;
        private byte _field0x1ec;
        private byte _field0x1ed;
        private byte _field0x1ee;
        private byte _field0x1ef;
        private byte _field0x1f0;
        private byte _field0x1f1;
        private byte _field0x1f2;
        private byte _field0x1f3;
        private byte _field0x1f4;
        private byte _field0x1f5;
        private byte _field0x1f6;
        private byte _field0x1f7;
        private byte _field0x1f8;
        private byte _field0x1f9;
        private byte _field0x1fa;
        private byte _field0x1fb;
        private byte _field0x1fc;
        private byte _field0x1fd;
        private byte _field0x1fe;
        private byte _field0x1ff;
        private byte _field0x200;
        private byte _field0x201;
        private byte _field0x202;
        private byte _field0x203;
        private byte _field0x204;
        private byte _field0x205;
        private byte _field0x206;
        private byte _field0x207;
        private byte _field0x208;
        private byte _field0x209;
        private byte _field0x20a;
        private byte _field0x20b;
        private byte _field0x20c;
        private byte _field0x20d;
        private byte _field0x20e;
        private byte _field0x20f;
        private byte _hpFractional;
        private byte _field0x211;
        private byte _field0x212;
        private byte _field0x213;
        private uint _unkExpTracker;
        private StatusIconFlags _statusIcons;
        private byte _waterShadowRippleTracker;
        private byte _meFirstFlag;
        private byte _field0x222;
        private byte _field0x223;
        private MonsterExclusiveItemOffenseBoostsArray _exclusiveItemOffenseBoosts;
        private MonsterExclusiveItemDefenseBoostsArray _exclusiveItemDefenseBoosts;
        private MonsterExclusiveItemEffectFlagsArray _exclusiveItemEffectFlags;
        private byte _field0x23c;
        private byte _unkReviveVisualTracker;
        private byte _field0x23e;
        private byte _shouldNotLosePp;
        private Monster m_root;
        private KaitaiStruct m_parent;
        public bool FAiUnk { get { return _fAiUnk; } }
        public bool FAiSkipTurn { get { return _fAiSkipTurn; } }
        public ulong FlagsUnk2 { get { return _flagsUnk2; } }
        public bool FSwappingPlaces { get { return _fSwappingPlaces; } }
        public ulong FlagsUnk6 { get { return _flagsUnk6; } }
        public bool FWalking { get { return _fWalking; } }
        public ulong FlagsUnk10 { get { return _flagsUnk10; } }
        public bool FSwappingPlacesPetrifiedAlly { get { return _fSwappingPlacesPetrifiedAlly; } }
        public MonsterId16 Id { get { return _id; } }
        public MonsterId16 ApparentId { get { return _apparentId; } }
        public byte IsNotTeamMember { get { return _isNotTeamMember; } }
        public byte IsTeamLeader { get { return _isTeamLeader; } }
        public byte IsAlly { get { return _isAlly; } }
        public ShopkeeperMode8 Shopkeeper { get { return _shopkeeper; } }
        public byte Level { get { return _level; } }
        public byte Field0xb { get { return _field0xb; } }
        public short TeamIndex { get { return _teamIndex; } }
        public short Iq { get { return _iq; } }
        public short Hp { get { return _hp; } }
        public short MaxHpStat { get { return _maxHpStat; } }
        public byte Field0x14 { get { return _field0x14; } }
        public byte Field0x15 { get { return _field0x15; } }
        public short MaxHpBoost { get { return _maxHpBoost; } }
        public byte Field0x18 { get { return _field0x18; } }
        public byte Field0x19 { get { return _field0x19; } }
        public MonsterOffensiveStatsArray OffensiveStats { get { return _offensiveStats; } }
        public MonsterDefensiveStatsArray DefensiveStats { get { return _defensiveStats; } }
        public byte Field0x1e { get { return _field0x1e; } }
        public byte Field0x1f { get { return _field0x1f; } }
        public int Exp { get { return _exp; } }
        public MonsterStatModifiers StatModifiers { get { return _statModifiers; } }
        public short HiddenPowerBasePower { get { return _hiddenPowerBasePower; } }
        public TypeId8 HiddenPowerType { get { return _hiddenPowerType; } }
        public byte Field0x47 { get { return _field0x47; } }
        public DungeonId8 JoinedAt { get { return _joinedAt; } }
        public byte JoinedAtFloor { get { return _joinedAtFloor; } }
        public ActionData Action { get { return _action; } }
        public MonsterTypesArray Types { get { return _types; } }
        public MonsterAbilitiesArray Abilities { get { return _abilities; } }
        public Item HeldItem { get { return _heldItem; } }
        public ItemId16 PreviousHeldItemId { get { return _previousHeldItemId; } }
        public Position PrevPos { get { return _prevPos; } }
        public Position PrevPos2 { get { return _prevPos2; } }
        public Position PrevPos3 { get { return _prevPos3; } }
        public Position PrevPos4 { get { return _prevPos4; } }
        public byte Field0x7a { get { return _field0x7a; } }
        public byte Field0x7b { get { return _field0x7b; } }
        public AiObjective8 AiObjective { get { return _aiObjective; } }
        public byte AiNotNextToTarget { get { return _aiNotNextToTarget; } }
        public byte AiTargetingEnemy { get { return _aiTargetingEnemy; } }
        public byte AiTurningAround { get { return _aiTurningAround; } }
        public ushort AiTargetSpawnGenid { get { return _aiTargetSpawnGenid; } }
        public byte Field0x82 { get { return _field0x82; } }
        public byte Field0x83 { get { return _field0x83; } }
        public Pointer AiTarget { get { return _aiTarget; } }
        public byte Field0x88 { get { return _field0x88; } }
        public byte Field0x89 { get { return _field0x89; } }
        public byte Field0x8a { get { return _field0x8a; } }
        public byte Field0x8b { get { return _field0x8b; } }
        public Position AiTargetPos { get { return _aiTargetPos; } }
        public MonsterIqSkillMenuFlagsArray IqSkillMenuFlags { get { return _iqSkillMenuFlags; } }
        public MonsterIqSkillFlagsArray IqSkillFlags { get { return _iqSkillFlags; } }
        public TacticId8 Tactic { get { return _tactic; } }
        public Statuses Statuses { get { return _statuses; } }
        public byte Field0x11f { get { return _field0x11f; } }
        public int RandomMovement { get { return _randomMovement; } }
        public MonsterMovesArray Moves { get { return _moves; } }
        public byte StruggleMoveFlags { get { return _struggleMoveFlags; } }
        public byte Field0x145 { get { return _field0x145; } }
        public short Belly { get { return _belly; } }
        public short BellyThousandths { get { return _bellyThousandths; } }
        public short MaxBelly { get { return _maxBelly; } }
        public short MaxBellyThousandths { get { return _maxBellyThousandths; } }
        public byte AiAllySkip { get { return _aiAllySkip; } }
        public byte AiNextToTarget { get { return _aiNextToTarget; } }
        public byte Famished { get { return _famished; } }
        public byte Waiting { get { return _waiting; } }
        public byte AlreadyActed { get { return _alreadyActed; } }
        public byte ShouldEvolve { get { return _shouldEvolve; } }
        public byte UsingChargedMove { get { return _usingChargedMove; } }
        public byte HitGrudgeMonster { get { return _hitGrudgeMonster; } }
        public byte Field0x156 { get { return _field0x156; } }
        public byte Field0x157 { get { return _field0x157; } }
        public ushort StateFlags { get { return _stateFlags; } }
        public ushort PrevStateFlags { get { return _prevStateFlags; } }
        public byte ApplyFlashFireBoost { get { return _applyFlashFireBoost; } }
        public byte RolloutHitCounter { get { return _rolloutHitCounter; } }
        public byte MementoWarpFlag { get { return _mementoWarpFlag; } }
        public byte OverheatSpecialAttackDropFlag { get { return _overheatSpecialAttackDropFlag; } }
        public byte DisplayShadow { get { return _displayShadow; } }
        public byte CannotGiveItems { get { return _cannotGiveItems; } }
        public byte Field0x162 { get { return _field0x162; } }
        public byte Field0x163 { get { return _field0x163; } }
        public byte TookDamageFlag { get { return _tookDamageFlag; } }
        public byte Field0x165 { get { return _field0x165; } }
        public byte PracticeSwingerFlag { get { return _practiceSwingerFlag; } }
        public byte AngerPointFlag { get { return _angerPointFlag; } }
        public byte Field0x168 { get { return _field0x168; } }
        public byte Field0x169 { get { return _field0x169; } }
        public DirectionId8 ForceTurn { get { return _forceTurn; } }
        public byte Field0x16b { get { return _field0x16b; } }
        public byte Field0x16c { get { return _field0x16c; } }
        public byte Field0x16d { get { return _field0x16d; } }
        public byte Field0x16e { get { return _field0x16e; } }
        public byte Field0x16f { get { return _field0x16f; } }
        public byte UturnHideMonsterFlag { get { return _uturnHideMonsterFlag; } }
        public byte Field0x171 { get { return _field0x171; } }
        public byte PitfallTrapFlag0x172 { get { return _pitfallTrapFlag0x172; } }
        public byte Field0x173 { get { return _field0x173; } }
        public byte PitfallTrapFlag0x174 { get { return _pitfallTrapFlag0x174; } }
        public byte Field0x175 { get { return _field0x175; } }
        public byte Field0x176 { get { return _field0x176; } }
        public DirectionId8 SleepTalkDirection { get { return _sleepTalkDirection; } }
        public DirectionId8 SnoreDirection { get { return _snoreDirection; } }
        public byte Field0x179 { get { return _field0x179; } }
        public byte Field0x17a { get { return _field0x17a; } }
        public byte Field0x17b { get { return _field0x17b; } }
        public byte TurnsSinceLastWarpScarf { get { return _turnsSinceLastWarpScarf; } }
        public byte Field0x17d { get { return _field0x17d; } }
        public Position TargetPos { get { return _targetPos; } }
        public Position PixelPos { get { return _pixelPos; } }
        public byte Field0x186 { get { return _field0x186; } }
        public byte Field0x187 { get { return _field0x187; } }
        public byte Field0x188 { get { return _field0x188; } }
        public byte Field0x189 { get { return _field0x189; } }
        public byte Field0x18a { get { return _field0x18a; } }
        public byte Field0x18b { get { return _field0x18b; } }
        public uint ExclusiveItemTriggerBitflags { get { return _exclusiveItemTriggerBitflags; } }
        public short Field0x190 { get { return _field0x190; } }
        public ushort ContactAbilityTriggerBitflags { get { return _contactAbilityTriggerBitflags; } }
        public byte Field0x194 { get { return _field0x194; } }
        public byte Field0x195 { get { return _field0x195; } }
        public byte Field0x196 { get { return _field0x196; } }
        public byte Field0x197 { get { return _field0x197; } }
        public byte Field0x198 { get { return _field0x198; } }
        public byte Field0x199 { get { return _field0x199; } }
        public byte Field0x19a { get { return _field0x19a; } }
        public byte Field0x19b { get { return _field0x19b; } }
        public Position Pos { get { return _pos; } }
        public byte Field0x1a0 { get { return _field0x1a0; } }
        public byte Field0x1a1 { get { return _field0x1a1; } }
        public byte Field0x1a2 { get { return _field0x1a2; } }
        public byte Field0x1a3 { get { return _field0x1a3; } }
        public byte Field0x1a4 { get { return _field0x1a4; } }
        public byte Field0x1a5 { get { return _field0x1a5; } }
        public byte Field0x1a6 { get { return _field0x1a6; } }
        public byte Field0x1a7 { get { return _field0x1a7; } }
        public byte Field0x1a8 { get { return _field0x1a8; } }
        public byte Field0x1a9 { get { return _field0x1a9; } }
        public byte Field0x1aa { get { return _field0x1aa; } }
        public byte Field0x1ab { get { return _field0x1ab; } }
        public byte Field0x1ac { get { return _field0x1ac; } }
        public byte Field0x1ad { get { return _field0x1ad; } }
        public byte Field0x1ae { get { return _field0x1ae; } }
        public byte Field0x1af { get { return _field0x1af; } }
        public byte Field0x1b0 { get { return _field0x1b0; } }
        public byte Field0x1b1 { get { return _field0x1b1; } }
        public byte Field0x1b2 { get { return _field0x1b2; } }
        public byte Field0x1b3 { get { return _field0x1b3; } }
        public ushort WalkAnimFramesLeft { get { return _walkAnimFramesLeft; } }
        public byte Field0x1b6 { get { return _field0x1b6; } }
        public byte Field0x1b7 { get { return _field0x1b7; } }
        public byte Field0x1b8 { get { return _field0x1b8; } }
        public byte Field0x1b9 { get { return _field0x1b9; } }
        public byte Field0x1ba { get { return _field0x1ba; } }
        public byte Field0x1bb { get { return _field0x1bb; } }
        public byte Field0x1bc { get { return _field0x1bc; } }
        public byte Field0x1bd { get { return _field0x1bd; } }
        public byte Field0x1be { get { return _field0x1be; } }
        public byte Field0x1bf { get { return _field0x1bf; } }
        public byte Field0x1c0 { get { return _field0x1c0; } }
        public byte Field0x1c1 { get { return _field0x1c1; } }
        public byte Field0x1c2 { get { return _field0x1c2; } }
        public byte Field0x1c3 { get { return _field0x1c3; } }
        public byte Field0x1c4 { get { return _field0x1c4; } }
        public byte Field0x1c5 { get { return _field0x1c5; } }
        public byte Field0x1c6 { get { return _field0x1c6; } }
        public byte Field0x1c7 { get { return _field0x1c7; } }
        public byte Field0x1c8 { get { return _field0x1c8; } }
        public byte Field0x1c9 { get { return _field0x1c9; } }
        public byte Field0x1ca { get { return _field0x1ca; } }
        public byte Field0x1cb { get { return _field0x1cb; } }
        public byte Field0x1cc { get { return _field0x1cc; } }
        public byte Field0x1cd { get { return _field0x1cd; } }
        public byte Field0x1ce { get { return _field0x1ce; } }
        public byte Field0x1cf { get { return _field0x1cf; } }
        public byte Field0x1d0 { get { return _field0x1d0; } }
        public byte Field0x1d1 { get { return _field0x1d1; } }
        public byte Field0x1d2 { get { return _field0x1d2; } }
        public byte Field0x1d3 { get { return _field0x1d3; } }
        public byte Field0x1d4 { get { return _field0x1d4; } }
        public byte Field0x1d5 { get { return _field0x1d5; } }
        public byte Field0x1d6 { get { return _field0x1d6; } }
        public byte Field0x1d7 { get { return _field0x1d7; } }
        public byte Field0x1d8 { get { return _field0x1d8; } }
        public byte Field0x1d9 { get { return _field0x1d9; } }
        public byte Field0x1da { get { return _field0x1da; } }
        public byte Field0x1db { get { return _field0x1db; } }
        public byte Field0x1dc { get { return _field0x1dc; } }
        public byte Field0x1dd { get { return _field0x1dd; } }
        public byte Field0x1de { get { return _field0x1de; } }
        public byte Field0x1df { get { return _field0x1df; } }
        public byte Field0x1e0 { get { return _field0x1e0; } }
        public byte Field0x1e1 { get { return _field0x1e1; } }
        public byte Field0x1e2 { get { return _field0x1e2; } }
        public byte Field0x1e3 { get { return _field0x1e3; } }
        public byte Field0x1e4 { get { return _field0x1e4; } }
        public byte Field0x1e5 { get { return _field0x1e5; } }
        public byte Field0x1e6 { get { return _field0x1e6; } }
        public byte Field0x1e7 { get { return _field0x1e7; } }
        public byte Field0x1e8 { get { return _field0x1e8; } }
        public byte Field0x1e9 { get { return _field0x1e9; } }
        public byte Field0x1ea { get { return _field0x1ea; } }
        public byte Field0x1eb { get { return _field0x1eb; } }
        public byte Field0x1ec { get { return _field0x1ec; } }
        public byte Field0x1ed { get { return _field0x1ed; } }
        public byte Field0x1ee { get { return _field0x1ee; } }
        public byte Field0x1ef { get { return _field0x1ef; } }
        public byte Field0x1f0 { get { return _field0x1f0; } }
        public byte Field0x1f1 { get { return _field0x1f1; } }
        public byte Field0x1f2 { get { return _field0x1f2; } }
        public byte Field0x1f3 { get { return _field0x1f3; } }
        public byte Field0x1f4 { get { return _field0x1f4; } }
        public byte Field0x1f5 { get { return _field0x1f5; } }
        public byte Field0x1f6 { get { return _field0x1f6; } }
        public byte Field0x1f7 { get { return _field0x1f7; } }
        public byte Field0x1f8 { get { return _field0x1f8; } }
        public byte Field0x1f9 { get { return _field0x1f9; } }
        public byte Field0x1fa { get { return _field0x1fa; } }
        public byte Field0x1fb { get { return _field0x1fb; } }
        public byte Field0x1fc { get { return _field0x1fc; } }
        public byte Field0x1fd { get { return _field0x1fd; } }
        public byte Field0x1fe { get { return _field0x1fe; } }
        public byte Field0x1ff { get { return _field0x1ff; } }
        public byte Field0x200 { get { return _field0x200; } }
        public byte Field0x201 { get { return _field0x201; } }
        public byte Field0x202 { get { return _field0x202; } }
        public byte Field0x203 { get { return _field0x203; } }
        public byte Field0x204 { get { return _field0x204; } }
        public byte Field0x205 { get { return _field0x205; } }
        public byte Field0x206 { get { return _field0x206; } }
        public byte Field0x207 { get { return _field0x207; } }
        public byte Field0x208 { get { return _field0x208; } }
        public byte Field0x209 { get { return _field0x209; } }
        public byte Field0x20a { get { return _field0x20a; } }
        public byte Field0x20b { get { return _field0x20b; } }
        public byte Field0x20c { get { return _field0x20c; } }
        public byte Field0x20d { get { return _field0x20d; } }
        public byte Field0x20e { get { return _field0x20e; } }
        public byte Field0x20f { get { return _field0x20f; } }
        public byte HpFractional { get { return _hpFractional; } }
        public byte Field0x211 { get { return _field0x211; } }
        public byte Field0x212 { get { return _field0x212; } }
        public byte Field0x213 { get { return _field0x213; } }
        public uint UnkExpTracker { get { return _unkExpTracker; } }
        public StatusIconFlags StatusIcons { get { return _statusIcons; } }
        public byte WaterShadowRippleTracker { get { return _waterShadowRippleTracker; } }
        public byte MeFirstFlag { get { return _meFirstFlag; } }
        public byte Field0x222 { get { return _field0x222; } }
        public byte Field0x223 { get { return _field0x223; } }
        public MonsterExclusiveItemOffenseBoostsArray ExclusiveItemOffenseBoosts { get { return _exclusiveItemOffenseBoosts; } }
        public MonsterExclusiveItemDefenseBoostsArray ExclusiveItemDefenseBoosts { get { return _exclusiveItemDefenseBoosts; } }
        public MonsterExclusiveItemEffectFlagsArray ExclusiveItemEffectFlags { get { return _exclusiveItemEffectFlags; } }
        public byte Field0x23c { get { return _field0x23c; } }
        public byte UnkReviveVisualTracker { get { return _unkReviveVisualTracker; } }
        public byte Field0x23e { get { return _field0x23e; } }
        public byte ShouldNotLosePp { get { return _shouldNotLosePp; } }
        public Monster M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
