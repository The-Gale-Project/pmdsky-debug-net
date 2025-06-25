// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array dungeon_fainted_monster_cause_entity_name defined within pmdsky.
    /// </summary>
    public partial class DungeonFaintedMonsterCauseEntityNameArray : KaitaiStruct
    {
        public static DungeonFaintedMonsterCauseEntityNameArray FromFile(string fileName)
        {
            return new DungeonFaintedMonsterCauseEntityNameArray(new KaitaiStream(fileName));
        }

        public DungeonFaintedMonsterCauseEntityNameArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonFaintedMonsterCauseEntityNameArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonFaintedMonsterCauseEntityNameArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonFaintedMonsterCauseEntityNameArrayDim0 : KaitaiStruct
        {
            public static DungeonFaintedMonsterCauseEntityNameArrayDim0 FromFile(string fileName)
            {
                return new DungeonFaintedMonsterCauseEntityNameArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonFaintedMonsterCauseEntityNameArrayDim0(KaitaiStream p__io, DungeonFaintedMonsterCauseEntityNameArray p__parent = null, DungeonFaintedMonsterCauseEntityNameArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<sbyte>();
                for (var i = 0; i < 30; i++)
                {
                    _entries.Add(m_io.ReadS1());
                }
            }
            private List<sbyte> _entries;
            private DungeonFaintedMonsterCauseEntityNameArray m_root;
            private DungeonFaintedMonsterCauseEntityNameArray m_parent;
            public List<sbyte> Entries { get { return _entries; } }
            public DungeonFaintedMonsterCauseEntityNameArray M_Root { get { return m_root; } }
            public DungeonFaintedMonsterCauseEntityNameArray M_Parent { get { return m_parent; } }
        }
        private DungeonFaintedMonsterCauseEntityNameArrayDim0 _entries;
        private DungeonFaintedMonsterCauseEntityNameArray m_root;
        private KaitaiStruct m_parent;
        public DungeonFaintedMonsterCauseEntityNameArrayDim0 Entries { get { return _entries; } }
        public DungeonFaintedMonsterCauseEntityNameArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
