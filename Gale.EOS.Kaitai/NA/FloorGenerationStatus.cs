// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union floor_generation_status defined within pmdsky-debug.
    /// </summary>
    public partial class FloorGenerationStatus : KaitaiStruct
    {
        public static FloorGenerationStatus FromFile(string fileName)
        {
            return new FloorGenerationStatus(new KaitaiStream(fileName));
        }

        public FloorGenerationStatus(KaitaiStream p__io, KaitaiStruct p__parent = null, FloorGenerationStatus p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _secondSpawn = m_io.ReadU1();
            _hasMonsterHouse = m_io.ReadU1();
            _stairsRoom = m_io.ReadU1();
            _hasKecleonShop = m_io.ReadU1();
            _hasChasmsAsSecondaryTerrain = m_io.ReadU1();
            _isInvalid = m_io.ReadU1();
            _floorSize = new FloorSize8(m_io);
            _hasMaze = m_io.ReadU1();
            _noEnemySpawns = m_io.ReadU1();
            _field0x9 = m_io.ReadU1();
            _field0xa = m_io.ReadU1();
            _field0xb = m_io.ReadU1();
            _kecleonShopSpawnChance = m_io.ReadS2le();
            _field0xe = m_io.ReadU1();
            _field0xf = m_io.ReadU1();
            _monsterHouseSpawnChance = m_io.ReadS2le();
            _field0x12 = m_io.ReadU1();
            _field0x13 = m_io.ReadU1();
            _nRooms = m_io.ReadS4le();
            _secondaryStructuresBudget = m_io.ReadS4le();
            _hiddenStairsSpawn = new Position(m_io);
            _kecleonShopMiddle = new Position(m_io);
            _nTilesReachableFromStairs = m_io.ReadS4le();
            _layout = new FloorLayout(m_io);
            _hiddenStairsType = new HiddenStairsType(m_io);
            _kecleonShopMinX = m_io.ReadS4le();
            _kecleonShopMinY = m_io.ReadS4le();
            _kecleonShopMaxX = m_io.ReadS4le();
            _kecleonShopMaxY = m_io.ReadS4le();
        }
        private byte _secondSpawn;
        private byte _hasMonsterHouse;
        private byte _stairsRoom;
        private byte _hasKecleonShop;
        private byte _hasChasmsAsSecondaryTerrain;
        private byte _isInvalid;
        private FloorSize8 _floorSize;
        private byte _hasMaze;
        private byte _noEnemySpawns;
        private byte _field0x9;
        private byte _field0xa;
        private byte _field0xb;
        private short _kecleonShopSpawnChance;
        private byte _field0xe;
        private byte _field0xf;
        private short _monsterHouseSpawnChance;
        private byte _field0x12;
        private byte _field0x13;
        private int _nRooms;
        private int _secondaryStructuresBudget;
        private Position _hiddenStairsSpawn;
        private Position _kecleonShopMiddle;
        private int _nTilesReachableFromStairs;
        private FloorLayout _layout;
        private HiddenStairsType _hiddenStairsType;
        private int _kecleonShopMinX;
        private int _kecleonShopMinY;
        private int _kecleonShopMaxX;
        private int _kecleonShopMaxY;
        private FloorGenerationStatus m_root;
        private KaitaiStruct m_parent;
        public byte SecondSpawn { get { return _secondSpawn; } }
        public byte HasMonsterHouse { get { return _hasMonsterHouse; } }
        public byte StairsRoom { get { return _stairsRoom; } }
        public byte HasKecleonShop { get { return _hasKecleonShop; } }
        public byte HasChasmsAsSecondaryTerrain { get { return _hasChasmsAsSecondaryTerrain; } }
        public byte IsInvalid { get { return _isInvalid; } }
        public FloorSize8 FloorSize { get { return _floorSize; } }
        public byte HasMaze { get { return _hasMaze; } }
        public byte NoEnemySpawns { get { return _noEnemySpawns; } }
        public byte Field0x9 { get { return _field0x9; } }
        public byte Field0xa { get { return _field0xa; } }
        public byte Field0xb { get { return _field0xb; } }
        public short KecleonShopSpawnChance { get { return _kecleonShopSpawnChance; } }
        public byte Field0xe { get { return _field0xe; } }
        public byte Field0xf { get { return _field0xf; } }
        public short MonsterHouseSpawnChance { get { return _monsterHouseSpawnChance; } }
        public byte Field0x12 { get { return _field0x12; } }
        public byte Field0x13 { get { return _field0x13; } }
        public int NRooms { get { return _nRooms; } }
        public int SecondaryStructuresBudget { get { return _secondaryStructuresBudget; } }
        public Position HiddenStairsSpawn { get { return _hiddenStairsSpawn; } }
        public Position KecleonShopMiddle { get { return _kecleonShopMiddle; } }
        public int NTilesReachableFromStairs { get { return _nTilesReachableFromStairs; } }
        public FloorLayout Layout { get { return _layout; } }
        public HiddenStairsType HiddenStairsType { get { return _hiddenStairsType; } }
        public int KecleonShopMinX { get { return _kecleonShopMinX; } }
        public int KecleonShopMinY { get { return _kecleonShopMinY; } }
        public int KecleonShopMaxX { get { return _kecleonShopMaxX; } }
        public int KecleonShopMaxY { get { return _kecleonShopMaxY; } }
        public FloorGenerationStatus M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
