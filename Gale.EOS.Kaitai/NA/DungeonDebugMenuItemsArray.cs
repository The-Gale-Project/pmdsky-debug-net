// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array DUNGEON_DEBUG_MENU_ITEMS defined within pmdsky.
    /// </summary>
    public partial class DungeonDebugMenuItemsArray : KaitaiStruct
    {
        public static DungeonDebugMenuItemsArray FromFile(string fileName)
        {
            return new DungeonDebugMenuItemsArray(new KaitaiStream(fileName));
        }

        public DungeonDebugMenuItemsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonDebugMenuItemsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonDebugMenuItemsArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonDebugMenuItemsArrayDim0 : KaitaiStruct
        {
            public static DungeonDebugMenuItemsArrayDim0 FromFile(string fileName)
            {
                return new DungeonDebugMenuItemsArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonDebugMenuItemsArrayDim0(KaitaiStream p__io, DungeonDebugMenuItemsArray p__parent = null, DungeonDebugMenuItemsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<SimpleMenuIdItem>();
                for (var i = 0; i < 5; i++)
                {
                    _entries.Add(new SimpleMenuIdItem(m_io));
                }
            }
            private List<SimpleMenuIdItem> _entries;
            private DungeonDebugMenuItemsArray m_root;
            private DungeonDebugMenuItemsArray m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public DungeonDebugMenuItemsArray M_Root { get { return m_root; } }
            public DungeonDebugMenuItemsArray M_Parent { get { return m_parent; } }
        }
        private DungeonDebugMenuItemsArrayDim0 _entries;
        private DungeonDebugMenuItemsArray m_root;
        private KaitaiStruct m_parent;
        public DungeonDebugMenuItemsArrayDim0 Entries { get { return _entries; } }
        public DungeonDebugMenuItemsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
