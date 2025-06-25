// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union dungeon_generation_info defined within pmdsky-debug.
    /// </summary>
    public partial class DungeonGenerationInfo : KaitaiStruct
    {
        public static DungeonGenerationInfo FromFile(string fileName)
        {
            return new DungeonGenerationInfo(new KaitaiStream(fileName));
        }

        public DungeonGenerationInfo(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonGenerationInfo p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _forceCreateMonsterHouse = m_io.ReadU1();
            _lockedDoorOpened = m_io.ReadU1();
            _kecleonShopSpawned = m_io.ReadU1();
            _unkOneRoomFlag = m_io.ReadU1();
            _doughSeedExtraPokeFlag = m_io.ReadU1();
            _monsterHouseRoom = m_io.ReadU1();
            _fixedRoomBossTracker = m_io.ReadU1();
            _field0x7 = m_io.ReadU1();
            _hiddenStairsType = new HiddenStairsType(m_io);
            _hiddenFloorType = new HiddenStairsType(m_io);
            _tilesetId = m_io.ReadS2le();
            _musicTableIdx = m_io.ReadU2le();
            _staircaseVisualIdx = m_io.ReadU2le();
            _fixedRoomId = new FixedRoomId8(m_io);
            _field0x17 = m_io.ReadU1();
            _field0x18 = m_io.ReadU1();
            _field0x19 = m_io.ReadU1();
            _floorGenerationAttempts = m_io.ReadU2le();
            _tiles = new DungeonGenerationInfoTilesArray(m_io);
            _teamSpawnPos = new Position(m_io);
            _stairsPos = new Position(m_io);
            _hiddenStairsPos = new Position(m_io);
            _individualTeamSpawnPositions = new DungeonGenerationInfoIndividualTeamSpawnPositionsArray(m_io);
        }
        private byte _forceCreateMonsterHouse;
        private byte _lockedDoorOpened;
        private byte _kecleonShopSpawned;
        private byte _unkOneRoomFlag;
        private byte _doughSeedExtraPokeFlag;
        private byte _monsterHouseRoom;
        private byte _fixedRoomBossTracker;
        private byte _field0x7;
        private HiddenStairsType _hiddenStairsType;
        private HiddenStairsType _hiddenFloorType;
        private short _tilesetId;
        private ushort _musicTableIdx;
        private ushort _staircaseVisualIdx;
        private FixedRoomId8 _fixedRoomId;
        private byte _field0x17;
        private byte _field0x18;
        private byte _field0x19;
        private ushort _floorGenerationAttempts;
        private DungeonGenerationInfoTilesArray _tiles;
        private Position _teamSpawnPos;
        private Position _stairsPos;
        private Position _hiddenStairsPos;
        private DungeonGenerationInfoIndividualTeamSpawnPositionsArray _individualTeamSpawnPositions;
        private DungeonGenerationInfo m_root;
        private KaitaiStruct m_parent;
        public byte ForceCreateMonsterHouse { get { return _forceCreateMonsterHouse; } }
        public byte LockedDoorOpened { get { return _lockedDoorOpened; } }
        public byte KecleonShopSpawned { get { return _kecleonShopSpawned; } }
        public byte UnkOneRoomFlag { get { return _unkOneRoomFlag; } }
        public byte DoughSeedExtraPokeFlag { get { return _doughSeedExtraPokeFlag; } }
        public byte MonsterHouseRoom { get { return _monsterHouseRoom; } }
        public byte FixedRoomBossTracker { get { return _fixedRoomBossTracker; } }
        public byte Field0x7 { get { return _field0x7; } }
        public HiddenStairsType HiddenStairsType { get { return _hiddenStairsType; } }
        public HiddenStairsType HiddenFloorType { get { return _hiddenFloorType; } }
        public short TilesetId { get { return _tilesetId; } }
        public ushort MusicTableIdx { get { return _musicTableIdx; } }
        public ushort StaircaseVisualIdx { get { return _staircaseVisualIdx; } }
        public FixedRoomId8 FixedRoomId { get { return _fixedRoomId; } }
        public byte Field0x17 { get { return _field0x17; } }
        public byte Field0x18 { get { return _field0x18; } }
        public byte Field0x19 { get { return _field0x19; } }
        public ushort FloorGenerationAttempts { get { return _floorGenerationAttempts; } }
        public DungeonGenerationInfoTilesArray Tiles { get { return _tiles; } }
        public Position TeamSpawnPos { get { return _teamSpawnPos; } }
        public Position StairsPos { get { return _stairsPos; } }
        public Position HiddenStairsPos { get { return _hiddenStairsPos; } }
        public DungeonGenerationInfoIndividualTeamSpawnPositionsArray IndividualTeamSpawnPositions { get { return _individualTeamSpawnPositions; } }
        public DungeonGenerationInfo M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
