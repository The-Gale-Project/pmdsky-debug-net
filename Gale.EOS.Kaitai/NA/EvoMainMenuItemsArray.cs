// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array EVO_MAIN_MENU_ITEMS defined within pmdsky.
    /// </summary>
    public partial class EvoMainMenuItemsArray : KaitaiStruct
    {
        public static EvoMainMenuItemsArray FromFile(string fileName)
        {
            return new EvoMainMenuItemsArray(new KaitaiStream(fileName));
        }

        public EvoMainMenuItemsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, EvoMainMenuItemsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new EvoMainMenuItemsArrayDim0(m_io, this, m_root);
        }
        public partial class EvoMainMenuItemsArrayDim0 : KaitaiStruct
        {
            public static EvoMainMenuItemsArrayDim0 FromFile(string fileName)
            {
                return new EvoMainMenuItemsArrayDim0(new KaitaiStream(fileName));
            }

            public EvoMainMenuItemsArrayDim0(KaitaiStream p__io, EvoMainMenuItemsArray p__parent = null, EvoMainMenuItemsArray p__root = null) : base(p__io)
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
            private EvoMainMenuItemsArray m_root;
            private EvoMainMenuItemsArray m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public EvoMainMenuItemsArray M_Root { get { return m_root; } }
            public EvoMainMenuItemsArray M_Parent { get { return m_parent; } }
        }
        private EvoMainMenuItemsArrayDim0 _entries;
        private EvoMainMenuItemsArray m_root;
        private KaitaiStruct m_parent;
        public EvoMainMenuItemsArrayDim0 Entries { get { return _entries; } }
        public EvoMainMenuItemsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
