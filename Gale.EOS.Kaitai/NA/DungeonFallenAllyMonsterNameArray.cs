// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array dungeon_fallen_ally_monster_name defined within pmdsky.
    /// </summary>
    public partial class DungeonFallenAllyMonsterNameArray : KaitaiStruct
    {
        public static DungeonFallenAllyMonsterNameArray FromFile(string fileName)
        {
            return new DungeonFallenAllyMonsterNameArray(new KaitaiStream(fileName));
        }

        public DungeonFallenAllyMonsterNameArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonFallenAllyMonsterNameArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonFallenAllyMonsterNameArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonFallenAllyMonsterNameArrayDim0 : KaitaiStruct
        {
            public static DungeonFallenAllyMonsterNameArrayDim0 FromFile(string fileName)
            {
                return new DungeonFallenAllyMonsterNameArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonFallenAllyMonsterNameArrayDim0(KaitaiStream p__io, DungeonFallenAllyMonsterNameArray p__parent = null, DungeonFallenAllyMonsterNameArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<sbyte>();
                for (var i = 0; i < 10; i++)
                {
                    _entries.Add(m_io.ReadS1());
                }
            }
            private List<sbyte> _entries;
            private DungeonFallenAllyMonsterNameArray m_root;
            private DungeonFallenAllyMonsterNameArray m_parent;
            public List<sbyte> Entries { get { return _entries; } }
            public DungeonFallenAllyMonsterNameArray M_Root { get { return m_root; } }
            public DungeonFallenAllyMonsterNameArray M_Parent { get { return m_parent; } }
        }
        private DungeonFallenAllyMonsterNameArrayDim0 _entries;
        private DungeonFallenAllyMonsterNameArray m_root;
        private KaitaiStruct m_parent;
        public DungeonFallenAllyMonsterNameArrayDim0 Entries { get { return _entries; } }
        public DungeonFallenAllyMonsterNameArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
