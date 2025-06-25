// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array dungeon_fallen_escort_monster_name defined within pmdsky.
    /// </summary>
    public partial class DungeonFallenEscortMonsterNameArray : KaitaiStruct
    {
        public static DungeonFallenEscortMonsterNameArray FromFile(string fileName)
        {
            return new DungeonFallenEscortMonsterNameArray(new KaitaiStream(fileName));
        }

        public DungeonFallenEscortMonsterNameArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonFallenEscortMonsterNameArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonFallenEscortMonsterNameArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonFallenEscortMonsterNameArrayDim0 : KaitaiStruct
        {
            public static DungeonFallenEscortMonsterNameArrayDim0 FromFile(string fileName)
            {
                return new DungeonFallenEscortMonsterNameArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonFallenEscortMonsterNameArrayDim0(KaitaiStream p__io, DungeonFallenEscortMonsterNameArray p__parent = null, DungeonFallenEscortMonsterNameArray p__root = null) : base(p__io)
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
            private DungeonFallenEscortMonsterNameArray m_root;
            private DungeonFallenEscortMonsterNameArray m_parent;
            public List<sbyte> Entries { get { return _entries; } }
            public DungeonFallenEscortMonsterNameArray M_Root { get { return m_root; } }
            public DungeonFallenEscortMonsterNameArray M_Parent { get { return m_parent; } }
        }
        private DungeonFallenEscortMonsterNameArrayDim0 _entries;
        private DungeonFallenEscortMonsterNameArray m_root;
        private KaitaiStruct m_parent;
        public DungeonFallenEscortMonsterNameArrayDim0 Entries { get { return _entries; } }
        public DungeonFallenEscortMonsterNameArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
