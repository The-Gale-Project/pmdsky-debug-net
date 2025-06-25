// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union floor_properties defined within pmdsky-debug.
    /// </summary>
    public partial class FloorProperties : KaitaiStruct
    {
        public static FloorProperties FromFile(string fileName)
        {
            return new FloorProperties(new KaitaiStream(fileName));
        }

        public FloorProperties(KaitaiStream p__io, KaitaiStruct p__parent = null, FloorProperties p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _layout = new FloorLayout8(m_io);
            _roomDensity = m_io.ReadS1();
            _tileset = m_io.ReadU1();
            _musicTableIdx = m_io.ReadU1();
            _weather = new WeatherId8(m_io);
            _floorConnectivity = m_io.ReadU1();
            _enemyDensity = m_io.ReadU1();
            _kecleonShopSpawnChance = m_io.ReadU1();
            _monsterHouseSpawnChance = m_io.ReadU1();
            _mazeRoomChance = m_io.ReadU1();
            _stickyItemChance = m_io.ReadU1();
            _allowDeadEnds = m_io.ReadU1();
            _maxSecondaryStructures = m_io.ReadU1();
            _fSecondaryStructures = m_io.ReadBitsIntLe(1) != 0;
            _roomFlagsUnk1 = m_io.ReadBitsIntLe(1) != 0;
            _fRoomImperfections = m_io.ReadBitsIntLe(1) != 0;
            _roomFlagsUnk3 = m_io.ReadBitsIntLe(5);
            m_io.AlignToByte();
            _field0xe = m_io.ReadU1();
            _itemDensity = m_io.ReadU1();
            _trapDensity = m_io.ReadU1();
            _floorNumber = m_io.ReadU1();
            _fixedRoomId = new FixedRoomId8(m_io);
            _extraHallways = m_io.ReadU1();
            _buriedItemDensity = m_io.ReadU1();
            _secondaryTerrainDensity = m_io.ReadU1();
            _visibilityRange = m_io.ReadU1();
            _maxMoneyAmountDiv5 = m_io.ReadU1();
            _shopItemPositions = new ShopItemPositions8(m_io);
            _itemlessMonsterHouseChance = m_io.ReadU1();
            _hiddenStairsType = new HiddenStairsType(m_io);
            _hiddenStairsSpawnChance = m_io.ReadU1();
            _enemyIq = m_io.ReadS2le();
            _iqBoosterValue = m_io.ReadS2le();
        }
        private FloorLayout8 _layout;
        private sbyte _roomDensity;
        private byte _tileset;
        private byte _musicTableIdx;
        private WeatherId8 _weather;
        private byte _floorConnectivity;
        private byte _enemyDensity;
        private byte _kecleonShopSpawnChance;
        private byte _monsterHouseSpawnChance;
        private byte _mazeRoomChance;
        private byte _stickyItemChance;
        private byte _allowDeadEnds;
        private byte _maxSecondaryStructures;
        private bool _fSecondaryStructures;
        private bool _roomFlagsUnk1;
        private bool _fRoomImperfections;
        private ulong _roomFlagsUnk3;
        private byte _field0xe;
        private byte _itemDensity;
        private byte _trapDensity;
        private byte _floorNumber;
        private FixedRoomId8 _fixedRoomId;
        private byte _extraHallways;
        private byte _buriedItemDensity;
        private byte _secondaryTerrainDensity;
        private byte _visibilityRange;
        private byte _maxMoneyAmountDiv5;
        private ShopItemPositions8 _shopItemPositions;
        private byte _itemlessMonsterHouseChance;
        private HiddenStairsType _hiddenStairsType;
        private byte _hiddenStairsSpawnChance;
        private short _enemyIq;
        private short _iqBoosterValue;
        private FloorProperties m_root;
        private KaitaiStruct m_parent;
        public FloorLayout8 Layout { get { return _layout; } }
        public sbyte RoomDensity { get { return _roomDensity; } }
        public byte Tileset { get { return _tileset; } }
        public byte MusicTableIdx { get { return _musicTableIdx; } }
        public WeatherId8 Weather { get { return _weather; } }
        public byte FloorConnectivity { get { return _floorConnectivity; } }
        public byte EnemyDensity { get { return _enemyDensity; } }
        public byte KecleonShopSpawnChance { get { return _kecleonShopSpawnChance; } }
        public byte MonsterHouseSpawnChance { get { return _monsterHouseSpawnChance; } }
        public byte MazeRoomChance { get { return _mazeRoomChance; } }
        public byte StickyItemChance { get { return _stickyItemChance; } }
        public byte AllowDeadEnds { get { return _allowDeadEnds; } }
        public byte MaxSecondaryStructures { get { return _maxSecondaryStructures; } }
        public bool FSecondaryStructures { get { return _fSecondaryStructures; } }
        public bool RoomFlagsUnk1 { get { return _roomFlagsUnk1; } }
        public bool FRoomImperfections { get { return _fRoomImperfections; } }
        public ulong RoomFlagsUnk3 { get { return _roomFlagsUnk3; } }
        public byte Field0xe { get { return _field0xe; } }
        public byte ItemDensity { get { return _itemDensity; } }
        public byte TrapDensity { get { return _trapDensity; } }
        public byte FloorNumber { get { return _floorNumber; } }
        public FixedRoomId8 FixedRoomId { get { return _fixedRoomId; } }
        public byte ExtraHallways { get { return _extraHallways; } }
        public byte BuriedItemDensity { get { return _buriedItemDensity; } }
        public byte SecondaryTerrainDensity { get { return _secondaryTerrainDensity; } }
        public byte VisibilityRange { get { return _visibilityRange; } }
        public byte MaxMoneyAmountDiv5 { get { return _maxMoneyAmountDiv5; } }
        public ShopItemPositions8 ShopItemPositions { get { return _shopItemPositions; } }
        public byte ItemlessMonsterHouseChance { get { return _itemlessMonsterHouseChance; } }
        public HiddenStairsType HiddenStairsType { get { return _hiddenStairsType; } }
        public byte HiddenStairsSpawnChance { get { return _hiddenStairsSpawnChance; } }
        public short EnemyIq { get { return _enemyIq; } }
        public short IqBoosterValue { get { return _iqBoosterValue; } }
        public FloorProperties M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
