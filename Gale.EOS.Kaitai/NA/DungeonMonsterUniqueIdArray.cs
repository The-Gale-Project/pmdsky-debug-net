// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array dungeon_monster_unique_id defined within pmdsky.
    /// </summary>
    public partial class DungeonMonsterUniqueIdArray : KaitaiStruct
    {
        public static DungeonMonsterUniqueIdArray FromFile(string fileName)
        {
            return new DungeonMonsterUniqueIdArray(new KaitaiStream(fileName));
        }

        public DungeonMonsterUniqueIdArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonMonsterUniqueIdArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonMonsterUniqueIdArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonMonsterUniqueIdArrayDim0 : KaitaiStruct
        {
            public static DungeonMonsterUniqueIdArrayDim0 FromFile(string fileName)
            {
                return new DungeonMonsterUniqueIdArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonMonsterUniqueIdArrayDim0(KaitaiStream p__io, DungeonMonsterUniqueIdArray p__parent = null, DungeonMonsterUniqueIdArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<uint>();
                for (var i = 0; i < 20; i++)
                {
                    _entries.Add(m_io.ReadU4le());
                }
            }
            private List<uint> _entries;
            private DungeonMonsterUniqueIdArray m_root;
            private DungeonMonsterUniqueIdArray m_parent;
            public List<uint> Entries { get { return _entries; } }
            public DungeonMonsterUniqueIdArray M_Root { get { return m_root; } }
            public DungeonMonsterUniqueIdArray M_Parent { get { return m_parent; } }
        }
        private DungeonMonsterUniqueIdArrayDim0 _entries;
        private DungeonMonsterUniqueIdArray m_root;
        private KaitaiStruct m_parent;
        public DungeonMonsterUniqueIdArrayDim0 Entries { get { return _entries; } }
        public DungeonMonsterUniqueIdArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
