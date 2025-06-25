// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array DUNGEON_MAIN_MENU_ITEMS defined within pmdsky.
    /// </summary>
    public partial class DungeonMainMenuItemsArray : KaitaiStruct
    {
        public static DungeonMainMenuItemsArray FromFile(string fileName)
        {
            return new DungeonMainMenuItemsArray(new KaitaiStream(fileName));
        }

        public DungeonMainMenuItemsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonMainMenuItemsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonMainMenuItemsArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonMainMenuItemsArrayDim0 : KaitaiStruct
        {
            public static DungeonMainMenuItemsArrayDim0 FromFile(string fileName)
            {
                return new DungeonMainMenuItemsArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonMainMenuItemsArrayDim0(KaitaiStream p__io, DungeonMainMenuItemsArray p__parent = null, DungeonMainMenuItemsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<SimpleMenuIdItem>();
                for (var i = 0; i < 8; i++)
                {
                    _entries.Add(new SimpleMenuIdItem(m_io));
                }
            }
            private List<SimpleMenuIdItem> _entries;
            private DungeonMainMenuItemsArray m_root;
            private DungeonMainMenuItemsArray m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public DungeonMainMenuItemsArray M_Root { get { return m_root; } }
            public DungeonMainMenuItemsArray M_Parent { get { return m_parent; } }
        }
        private DungeonMainMenuItemsArrayDim0 _entries;
        private DungeonMainMenuItemsArray m_root;
        private KaitaiStruct m_parent;
        public DungeonMainMenuItemsArrayDim0 Entries { get { return _entries; } }
        public DungeonMainMenuItemsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
