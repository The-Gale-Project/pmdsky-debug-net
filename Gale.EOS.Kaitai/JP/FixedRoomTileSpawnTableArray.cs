// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array FIXED_ROOM_TILE_SPAWN_TABLE defined within pmdsky.
    /// </summary>
    public partial class FixedRoomTileSpawnTableArray : KaitaiStruct
    {
        public static FixedRoomTileSpawnTableArray FromFile(string fileName)
        {
            return new FixedRoomTileSpawnTableArray(new KaitaiStream(fileName));
        }

        public FixedRoomTileSpawnTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, FixedRoomTileSpawnTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new FixedRoomTileSpawnTableArrayDim0(m_io, this, m_root);
        }
        public partial class FixedRoomTileSpawnTableArrayDim0 : KaitaiStruct
        {
            public static FixedRoomTileSpawnTableArrayDim0 FromFile(string fileName)
            {
                return new FixedRoomTileSpawnTableArrayDim0(new KaitaiStream(fileName));
            }

            public FixedRoomTileSpawnTableArrayDim0(KaitaiStream p__io, FixedRoomTileSpawnTableArray p__parent = null, FixedRoomTileSpawnTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<FixedRoomTileSpawnEntry>();
                for (var i = 0; i < 11; i++)
                {
                    _entries.Add(new FixedRoomTileSpawnEntry(m_io));
                }
            }
            private List<FixedRoomTileSpawnEntry> _entries;
            private FixedRoomTileSpawnTableArray m_root;
            private FixedRoomTileSpawnTableArray m_parent;
            public List<FixedRoomTileSpawnEntry> Entries { get { return _entries; } }
            public FixedRoomTileSpawnTableArray M_Root { get { return m_root; } }
            public FixedRoomTileSpawnTableArray M_Parent { get { return m_parent; } }
        }
        private FixedRoomTileSpawnTableArrayDim0 _entries;
        private FixedRoomTileSpawnTableArray m_root;
        private KaitaiStruct m_parent;
        public FixedRoomTileSpawnTableArrayDim0 Entries { get { return _entries; } }
        public FixedRoomTileSpawnTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
