// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array dungeon_fainted_monster_name defined within pmdsky.
    /// </summary>
    public partial class DungeonFaintedMonsterNameArray : KaitaiStruct
    {
        public static DungeonFaintedMonsterNameArray FromFile(string fileName)
        {
            return new DungeonFaintedMonsterNameArray(new KaitaiStream(fileName));
        }

        public DungeonFaintedMonsterNameArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonFaintedMonsterNameArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonFaintedMonsterNameArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonFaintedMonsterNameArrayDim0 : KaitaiStruct
        {
            public static DungeonFaintedMonsterNameArrayDim0 FromFile(string fileName)
            {
                return new DungeonFaintedMonsterNameArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonFaintedMonsterNameArrayDim0(KaitaiStream p__io, DungeonFaintedMonsterNameArray p__parent = null, DungeonFaintedMonsterNameArray p__root = null) : base(p__io)
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
            private DungeonFaintedMonsterNameArray m_root;
            private DungeonFaintedMonsterNameArray m_parent;
            public List<sbyte> Entries { get { return _entries; } }
            public DungeonFaintedMonsterNameArray M_Root { get { return m_root; } }
            public DungeonFaintedMonsterNameArray M_Parent { get { return m_parent; } }
        }
        private DungeonFaintedMonsterNameArrayDim0 _entries;
        private DungeonFaintedMonsterNameArray m_root;
        private KaitaiStruct m_parent;
        public DungeonFaintedMonsterNameArrayDim0 Entries { get { return _entries; } }
        public DungeonFaintedMonsterNameArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
