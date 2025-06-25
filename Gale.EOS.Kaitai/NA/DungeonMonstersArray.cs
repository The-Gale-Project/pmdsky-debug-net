// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array dungeon_monsters defined within pmdsky.
    /// </summary>
    public partial class DungeonMonstersArray : KaitaiStruct
    {
        public static DungeonMonstersArray FromFile(string fileName)
        {
            return new DungeonMonstersArray(new KaitaiStream(fileName));
        }

        public DungeonMonstersArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonMonstersArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonMonstersArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonMonstersArrayDim0 : KaitaiStruct
        {
            public static DungeonMonstersArrayDim0 FromFile(string fileName)
            {
                return new DungeonMonstersArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonMonstersArrayDim0(KaitaiStream p__io, DungeonMonstersArray p__parent = null, DungeonMonstersArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<Monster>();
                for (var i = 0; i < 20; i++)
                {
                    _entries.Add(new Monster(m_io));
                }
            }
            private List<Monster> _entries;
            private DungeonMonstersArray m_root;
            private DungeonMonstersArray m_parent;
            public List<Monster> Entries { get { return _entries; } }
            public DungeonMonstersArray M_Root { get { return m_root; } }
            public DungeonMonstersArray M_Parent { get { return m_parent; } }
        }
        private DungeonMonstersArrayDim0 _entries;
        private DungeonMonstersArray m_root;
        private KaitaiStruct m_parent;
        public DungeonMonstersArrayDim0 Entries { get { return _entries; } }
        public DungeonMonstersArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
