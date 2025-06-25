// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union fixed_room_tile_spawn_entry defined within pmdsky-debug.
    /// </summary>
    public partial class FixedRoomTileSpawnEntry : KaitaiStruct
    {
        public static FixedRoomTileSpawnEntry FromFile(string fileName)
        {
            return new FixedRoomTileSpawnEntry(new KaitaiStream(fileName));
        }

        public FixedRoomTileSpawnEntry(KaitaiStream p__io, KaitaiStruct p__parent = null, FixedRoomTileSpawnEntry p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _id = new TrapId8(m_io);
            _flags = m_io.ReadU1();
            _room = m_io.ReadU1();
            _fTrapVisible = m_io.ReadBitsIntLe(1) != 0;
            _flags3Unk1 = m_io.ReadBitsIntLe(2);
            _fSecondaryTerrain = m_io.ReadBitsIntLe(1) != 0;
            _flags3Unk4 = m_io.ReadBitsIntLe(4);
        }
        private TrapId8 _id;
        private byte _flags;
        private byte _room;
        private bool _fTrapVisible;
        private ulong _flags3Unk1;
        private bool _fSecondaryTerrain;
        private ulong _flags3Unk4;
        private FixedRoomTileSpawnEntry m_root;
        private KaitaiStruct m_parent;
        public TrapId8 Id { get { return _id; } }
        public byte Flags { get { return _flags; } }
        public byte Room { get { return _room; } }
        public bool FTrapVisible { get { return _fTrapVisible; } }
        public ulong Flags3Unk1 { get { return _flags3Unk1; } }
        public bool FSecondaryTerrain { get { return _fSecondaryTerrain; } }
        public ulong Flags3Unk4 { get { return _flags3Unk4; } }
        public FixedRoomTileSpawnEntry M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
