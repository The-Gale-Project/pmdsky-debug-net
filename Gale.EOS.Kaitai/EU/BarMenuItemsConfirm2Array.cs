// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array BAR_MENU_ITEMS_CONFIRM_2 defined within pmdsky.
    /// </summary>
    public partial class BarMenuItemsConfirm2Array : KaitaiStruct
    {
        public static BarMenuItemsConfirm2Array FromFile(string fileName)
        {
            return new BarMenuItemsConfirm2Array(new KaitaiStream(fileName));
        }

        public BarMenuItemsConfirm2Array(KaitaiStream p__io, KaitaiStruct p__parent = null, BarMenuItemsConfirm2Array p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new BarMenuItemsConfirm2ArrayDim0(m_io, this, m_root);
        }
        public partial class BarMenuItemsConfirm2ArrayDim0 : KaitaiStruct
        {
            public static BarMenuItemsConfirm2ArrayDim0 FromFile(string fileName)
            {
                return new BarMenuItemsConfirm2ArrayDim0(new KaitaiStream(fileName));
            }

            public BarMenuItemsConfirm2ArrayDim0(KaitaiStream p__io, BarMenuItemsConfirm2Array p__parent = null, BarMenuItemsConfirm2Array p__root = null) : base(p__io)
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
            private BarMenuItemsConfirm2Array m_root;
            private BarMenuItemsConfirm2Array m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public BarMenuItemsConfirm2Array M_Root { get { return m_root; } }
            public BarMenuItemsConfirm2Array M_Parent { get { return m_parent; } }
        }
        private BarMenuItemsConfirm2ArrayDim0 _entries;
        private BarMenuItemsConfirm2Array m_root;
        private KaitaiStruct m_parent;
        public BarMenuItemsConfirm2ArrayDim0 Entries { get { return _entries; } }
        public BarMenuItemsConfirm2Array M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
