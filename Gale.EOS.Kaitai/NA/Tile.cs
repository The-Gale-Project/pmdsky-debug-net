// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union tile defined within pmdsky-debug.
    /// </summary>
    public partial class Tile : KaitaiStruct
    {
        public static Tile FromFile(string fileName)
        {
            return new Tile(new KaitaiStream(fileName));
        }

        public Tile(KaitaiStream p__io, KaitaiStruct p__parent = null, Tile p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _terrainType = new TerrainType2(m_io);
            _fCornerCuttable = m_io.ReadBitsIntLe(1) != 0;
            _fNaturalJunction = m_io.ReadBitsIntLe(1) != 0;
            _fImpassableWall = m_io.ReadBitsIntLe(1) != 0;
            _fInKecleonShop = m_io.ReadBitsIntLe(1) != 0;
            _fInMonsterHouse = m_io.ReadBitsIntLe(1) != 0;
            _terrainFlagsUnk7 = m_io.ReadBitsIntLe(1) != 0;
            _fUnbreakable = m_io.ReadBitsIntLe(1) != 0;
            _fStairs = m_io.ReadBitsIntLe(1) != 0;
            _terrainFlagsUnk10 = m_io.ReadBitsIntLe(1) != 0;
            _fKeyDoor = m_io.ReadBitsIntLe(1) != 0;
            _fKeyDoorKeyLocked = m_io.ReadBitsIntLe(1) != 0;
            _fKeyDoorEscortLocked = m_io.ReadBitsIntLe(1) != 0;
            _terrainFlagsUnk14 = m_io.ReadBitsIntLe(1) != 0;
            _fUnreachableFromStairs = m_io.ReadBitsIntLe(1) != 0;
            m_io.AlignToByte();
            _spawnOrVisibilityFlags = new SpawnOrVisibilityFlags(m_io);
            _textureId = m_io.ReadU2le();
            _field0x6 = m_io.ReadU1();
            _room = m_io.ReadU1();
            _walkableNeighborFlags = new TileWalkableNeighborFlagsArray(m_io);
            _monster = new Pointer(m_io);
            _object = new Pointer(m_io);
        }
        private TerrainType2 _terrainType;
        private bool _fCornerCuttable;
        private bool _fNaturalJunction;
        private bool _fImpassableWall;
        private bool _fInKecleonShop;
        private bool _fInMonsterHouse;
        private bool _terrainFlagsUnk7;
        private bool _fUnbreakable;
        private bool _fStairs;
        private bool _terrainFlagsUnk10;
        private bool _fKeyDoor;
        private bool _fKeyDoorKeyLocked;
        private bool _fKeyDoorEscortLocked;
        private bool _terrainFlagsUnk14;
        private bool _fUnreachableFromStairs;
        private SpawnOrVisibilityFlags _spawnOrVisibilityFlags;
        private ushort _textureId;
        private byte _field0x6;
        private byte _room;
        private TileWalkableNeighborFlagsArray _walkableNeighborFlags;
        private Pointer _monster;
        private Pointer _object;
        private Tile m_root;
        private KaitaiStruct m_parent;
        public TerrainType2 TerrainType { get { return _terrainType; } }
        public bool FCornerCuttable { get { return _fCornerCuttable; } }
        public bool FNaturalJunction { get { return _fNaturalJunction; } }
        public bool FImpassableWall { get { return _fImpassableWall; } }
        public bool FInKecleonShop { get { return _fInKecleonShop; } }
        public bool FInMonsterHouse { get { return _fInMonsterHouse; } }
        public bool TerrainFlagsUnk7 { get { return _terrainFlagsUnk7; } }
        public bool FUnbreakable { get { return _fUnbreakable; } }
        public bool FStairs { get { return _fStairs; } }
        public bool TerrainFlagsUnk10 { get { return _terrainFlagsUnk10; } }
        public bool FKeyDoor { get { return _fKeyDoor; } }
        public bool FKeyDoorKeyLocked { get { return _fKeyDoorKeyLocked; } }
        public bool FKeyDoorEscortLocked { get { return _fKeyDoorEscortLocked; } }
        public bool TerrainFlagsUnk14 { get { return _terrainFlagsUnk14; } }
        public bool FUnreachableFromStairs { get { return _fUnreachableFromStairs; } }
        public SpawnOrVisibilityFlags SpawnOrVisibilityFlags { get { return _spawnOrVisibilityFlags; } }
        public ushort TextureId { get { return _textureId; } }
        public byte Field0x6 { get { return _field0x6; } }
        public byte Room { get { return _room; } }
        public TileWalkableNeighborFlagsArray WalkableNeighborFlags { get { return _walkableNeighborFlags; } }
        public Pointer Monster { get { return _monster; } }
        public Pointer Object { get { return _object; } }
        public Tile M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
