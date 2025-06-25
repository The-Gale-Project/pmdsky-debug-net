// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array DUNGEON_SUBMENU_ITEMS_3 defined within pmdsky.
    /// </summary>
    public partial class DungeonSubmenuItems3Array : KaitaiStruct
    {
        public static DungeonSubmenuItems3Array FromFile(string fileName)
        {
            return new DungeonSubmenuItems3Array(new KaitaiStream(fileName));
        }

        public DungeonSubmenuItems3Array(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonSubmenuItems3Array p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonSubmenuItems3ArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonSubmenuItems3ArrayDim0 : KaitaiStruct
        {
            public static DungeonSubmenuItems3ArrayDim0 FromFile(string fileName)
            {
                return new DungeonSubmenuItems3ArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonSubmenuItems3ArrayDim0(KaitaiStream p__io, DungeonSubmenuItems3Array p__parent = null, DungeonSubmenuItems3Array p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<SimpleMenuIdItem>();
                for (var i = 0; i < 4; i++)
                {
                    _entries.Add(new SimpleMenuIdItem(m_io));
                }
            }
            private List<SimpleMenuIdItem> _entries;
            private DungeonSubmenuItems3Array m_root;
            private DungeonSubmenuItems3Array m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public DungeonSubmenuItems3Array M_Root { get { return m_root; } }
            public DungeonSubmenuItems3Array M_Parent { get { return m_parent; } }
        }
        private DungeonSubmenuItems3ArrayDim0 _entries;
        private DungeonSubmenuItems3Array m_root;
        private KaitaiStruct m_parent;
        public DungeonSubmenuItems3ArrayDim0 Entries { get { return _entries; } }
        public DungeonSubmenuItems3Array M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
