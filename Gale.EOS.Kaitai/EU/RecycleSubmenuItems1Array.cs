// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array RECYCLE_SUBMENU_ITEMS_1 defined within pmdsky.
    /// </summary>
    public partial class RecycleSubmenuItems1Array : KaitaiStruct
    {
        public static RecycleSubmenuItems1Array FromFile(string fileName)
        {
            return new RecycleSubmenuItems1Array(new KaitaiStream(fileName));
        }

        public RecycleSubmenuItems1Array(KaitaiStream p__io, KaitaiStruct p__parent = null, RecycleSubmenuItems1Array p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new RecycleSubmenuItems1ArrayDim0(m_io, this, m_root);
        }
        public partial class RecycleSubmenuItems1ArrayDim0 : KaitaiStruct
        {
            public static RecycleSubmenuItems1ArrayDim0 FromFile(string fileName)
            {
                return new RecycleSubmenuItems1ArrayDim0(new KaitaiStream(fileName));
            }

            public RecycleSubmenuItems1ArrayDim0(KaitaiStream p__io, RecycleSubmenuItems1Array p__parent = null, RecycleSubmenuItems1Array p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<SimpleMenuIdItem>();
                for (var i = 0; i < 3; i++)
                {
                    _entries.Add(new SimpleMenuIdItem(m_io));
                }
            }
            private List<SimpleMenuIdItem> _entries;
            private RecycleSubmenuItems1Array m_root;
            private RecycleSubmenuItems1Array m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public RecycleSubmenuItems1Array M_Root { get { return m_root; } }
            public RecycleSubmenuItems1Array M_Parent { get { return m_parent; } }
        }
        private RecycleSubmenuItems1ArrayDim0 _entries;
        private RecycleSubmenuItems1Array m_root;
        private KaitaiStruct m_parent;
        public RecycleSubmenuItems1ArrayDim0 Entries { get { return _entries; } }
        public RecycleSubmenuItems1Array M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
