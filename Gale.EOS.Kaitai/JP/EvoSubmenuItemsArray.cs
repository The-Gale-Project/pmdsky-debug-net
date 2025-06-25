// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array EVO_SUBMENU_ITEMS defined within pmdsky.
    /// </summary>
    public partial class EvoSubmenuItemsArray : KaitaiStruct
    {
        public static EvoSubmenuItemsArray FromFile(string fileName)
        {
            return new EvoSubmenuItemsArray(new KaitaiStream(fileName));
        }

        public EvoSubmenuItemsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, EvoSubmenuItemsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new EvoSubmenuItemsArrayDim0(m_io, this, m_root);
        }
        public partial class EvoSubmenuItemsArrayDim0 : KaitaiStruct
        {
            public static EvoSubmenuItemsArrayDim0 FromFile(string fileName)
            {
                return new EvoSubmenuItemsArrayDim0(new KaitaiStream(fileName));
            }

            public EvoSubmenuItemsArrayDim0(KaitaiStream p__io, EvoSubmenuItemsArray p__parent = null, EvoSubmenuItemsArray p__root = null) : base(p__io)
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
            private EvoSubmenuItemsArray m_root;
            private EvoSubmenuItemsArray m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public EvoSubmenuItemsArray M_Root { get { return m_root; } }
            public EvoSubmenuItemsArray M_Parent { get { return m_parent; } }
        }
        private EvoSubmenuItemsArrayDim0 _entries;
        private EvoSubmenuItemsArray m_root;
        private KaitaiStruct m_parent;
        public EvoSubmenuItemsArrayDim0 Entries { get { return _entries; } }
        public EvoSubmenuItemsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
