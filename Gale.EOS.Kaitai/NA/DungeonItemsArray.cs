// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array dungeon_items defined within pmdsky.
    /// </summary>
    public partial class DungeonItemsArray : KaitaiStruct
    {
        public static DungeonItemsArray FromFile(string fileName)
        {
            return new DungeonItemsArray(new KaitaiStream(fileName));
        }

        public DungeonItemsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonItemsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonItemsArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonItemsArrayDim0 : KaitaiStruct
        {
            public static DungeonItemsArrayDim0 FromFile(string fileName)
            {
                return new DungeonItemsArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonItemsArrayDim0(KaitaiStream p__io, DungeonItemsArray p__parent = null, DungeonItemsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<Item>();
                for (var i = 0; i < 64; i++)
                {
                    _entries.Add(new Item(m_io));
                }
            }
            private List<Item> _entries;
            private DungeonItemsArray m_root;
            private DungeonItemsArray m_parent;
            public List<Item> Entries { get { return _entries; } }
            public DungeonItemsArray M_Root { get { return m_root; } }
            public DungeonItemsArray M_Parent { get { return m_parent; } }
        }
        private DungeonItemsArrayDim0 _entries;
        private DungeonItemsArray m_root;
        private KaitaiStruct m_parent;
        public DungeonItemsArrayDim0 Entries { get { return _entries; } }
        public DungeonItemsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
