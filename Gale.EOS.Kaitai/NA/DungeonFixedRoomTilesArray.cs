// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array dungeon_fixed_room_tiles defined within pmdsky.
    /// </summary>
    public partial class DungeonFixedRoomTilesArray : KaitaiStruct
    {
        public static DungeonFixedRoomTilesArray FromFile(string fileName)
        {
            return new DungeonFixedRoomTilesArray(new KaitaiStream(fileName));
        }

        public DungeonFixedRoomTilesArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonFixedRoomTilesArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonFixedRoomTilesArrayDim1(m_io, this, m_root);
        }
        public partial class DungeonFixedRoomTilesArrayDim0 : KaitaiStruct
        {
            public static DungeonFixedRoomTilesArrayDim0 FromFile(string fileName)
            {
                return new DungeonFixedRoomTilesArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonFixedRoomTilesArrayDim0(KaitaiStream p__io, DungeonFixedRoomTilesArray.DungeonFixedRoomTilesArrayDim1 p__parent = null, DungeonFixedRoomTilesArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<Tile>();
                for (var i = 0; i < 8; i++)
                {
                    _entries.Add(new Tile(m_io));
                }
            }
            private List<Tile> _entries;
            private DungeonFixedRoomTilesArray m_root;
            private DungeonFixedRoomTilesArray.DungeonFixedRoomTilesArrayDim1 m_parent;
            public List<Tile> Entries { get { return _entries; } }
            public DungeonFixedRoomTilesArray M_Root { get { return m_root; } }
            public DungeonFixedRoomTilesArray.DungeonFixedRoomTilesArrayDim1 M_Parent { get { return m_parent; } }
        }
        public partial class DungeonFixedRoomTilesArrayDim1 : KaitaiStruct
        {
            public static DungeonFixedRoomTilesArrayDim1 FromFile(string fileName)
            {
                return new DungeonFixedRoomTilesArrayDim1(new KaitaiStream(fileName));
            }

            public DungeonFixedRoomTilesArrayDim1(KaitaiStream p__io, DungeonFixedRoomTilesArray p__parent = null, DungeonFixedRoomTilesArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<DungeonFixedRoomTilesArrayDim0>();
                for (var i = 0; i < 8; i++)
                {
                    _entries.Add(new DungeonFixedRoomTilesArrayDim0(m_io, this, m_root));
                }
            }
            private List<DungeonFixedRoomTilesArrayDim0> _entries;
            private DungeonFixedRoomTilesArray m_root;
            private DungeonFixedRoomTilesArray m_parent;
            public List<DungeonFixedRoomTilesArrayDim0> Entries { get { return _entries; } }
            public DungeonFixedRoomTilesArray M_Root { get { return m_root; } }
            public DungeonFixedRoomTilesArray M_Parent { get { return m_parent; } }
        }
        private DungeonFixedRoomTilesArrayDim1 _entries;
        private DungeonFixedRoomTilesArray m_root;
        private KaitaiStruct m_parent;
        public DungeonFixedRoomTilesArrayDim1 Entries { get { return _entries; } }
        public DungeonFixedRoomTilesArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
