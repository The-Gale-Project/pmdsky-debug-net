// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array dungeon_spawn_table_entries_chosen defined within pmdsky.
    /// </summary>
    public partial class DungeonSpawnTableEntriesChosenArray : KaitaiStruct
    {
        public static DungeonSpawnTableEntriesChosenArray FromFile(string fileName)
        {
            return new DungeonSpawnTableEntriesChosenArray(new KaitaiStream(fileName));
        }

        public DungeonSpawnTableEntriesChosenArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonSpawnTableEntriesChosenArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonSpawnTableEntriesChosenArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonSpawnTableEntriesChosenArrayDim0 : KaitaiStruct
        {
            public static DungeonSpawnTableEntriesChosenArrayDim0 FromFile(string fileName)
            {
                return new DungeonSpawnTableEntriesChosenArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonSpawnTableEntriesChosenArrayDim0(KaitaiStream p__io, DungeonSpawnTableEntriesChosenArray p__parent = null, DungeonSpawnTableEntriesChosenArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<ushort>();
                for (var i = 0; i < 16; i++)
                {
                    _entries.Add(m_io.ReadU2le());
                }
            }
            private List<ushort> _entries;
            private DungeonSpawnTableEntriesChosenArray m_root;
            private DungeonSpawnTableEntriesChosenArray m_parent;
            public List<ushort> Entries { get { return _entries; } }
            public DungeonSpawnTableEntriesChosenArray M_Root { get { return m_root; } }
            public DungeonSpawnTableEntriesChosenArray M_Parent { get { return m_parent; } }
        }
        private DungeonSpawnTableEntriesChosenArrayDim0 _entries;
        private DungeonSpawnTableEntriesChosenArray m_root;
        private KaitaiStruct m_parent;
        public DungeonSpawnTableEntriesChosenArrayDim0 Entries { get { return _entries; } }
        public DungeonSpawnTableEntriesChosenArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
