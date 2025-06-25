// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array BAR_MENU_ITEMS_CONFIRM_1 defined within pmdsky.
    /// </summary>
    public partial class BarMenuItemsConfirm1Array : KaitaiStruct
    {
        public static BarMenuItemsConfirm1Array FromFile(string fileName)
        {
            return new BarMenuItemsConfirm1Array(new KaitaiStream(fileName));
        }

        public BarMenuItemsConfirm1Array(KaitaiStream p__io, KaitaiStruct p__parent = null, BarMenuItemsConfirm1Array p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new BarMenuItemsConfirm1ArrayDim0(m_io, this, m_root);
        }
        public partial class BarMenuItemsConfirm1ArrayDim0 : KaitaiStruct
        {
            public static BarMenuItemsConfirm1ArrayDim0 FromFile(string fileName)
            {
                return new BarMenuItemsConfirm1ArrayDim0(new KaitaiStream(fileName));
            }

            public BarMenuItemsConfirm1ArrayDim0(KaitaiStream p__io, BarMenuItemsConfirm1Array p__parent = null, BarMenuItemsConfirm1Array p__root = null) : base(p__io)
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
            private BarMenuItemsConfirm1Array m_root;
            private BarMenuItemsConfirm1Array m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public BarMenuItemsConfirm1Array M_Root { get { return m_root; } }
            public BarMenuItemsConfirm1Array M_Parent { get { return m_parent; } }
        }
        private BarMenuItemsConfirm1ArrayDim0 _entries;
        private BarMenuItemsConfirm1Array m_root;
        private KaitaiStruct m_parent;
        public BarMenuItemsConfirm1ArrayDim0 Entries { get { return _entries; } }
        public BarMenuItemsConfirm1Array M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
