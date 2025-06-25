// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array EVO_MENU_ITEMS_CONFIRM defined within pmdsky.
    /// </summary>
    public partial class EvoMenuItemsConfirmArray : KaitaiStruct
    {
        public static EvoMenuItemsConfirmArray FromFile(string fileName)
        {
            return new EvoMenuItemsConfirmArray(new KaitaiStream(fileName));
        }

        public EvoMenuItemsConfirmArray(KaitaiStream p__io, KaitaiStruct p__parent = null, EvoMenuItemsConfirmArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new EvoMenuItemsConfirmArrayDim0(m_io, this, m_root);
        }
        public partial class EvoMenuItemsConfirmArrayDim0 : KaitaiStruct
        {
            public static EvoMenuItemsConfirmArrayDim0 FromFile(string fileName)
            {
                return new EvoMenuItemsConfirmArrayDim0(new KaitaiStream(fileName));
            }

            public EvoMenuItemsConfirmArrayDim0(KaitaiStream p__io, EvoMenuItemsConfirmArray p__parent = null, EvoMenuItemsConfirmArray p__root = null) : base(p__io)
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
            private EvoMenuItemsConfirmArray m_root;
            private EvoMenuItemsConfirmArray m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public EvoMenuItemsConfirmArray M_Root { get { return m_root; } }
            public EvoMenuItemsConfirmArray M_Parent { get { return m_parent; } }
        }
        private EvoMenuItemsConfirmArrayDim0 _entries;
        private EvoMenuItemsConfirmArray m_root;
        private KaitaiStruct m_parent;
        public EvoMenuItemsConfirmArrayDim0 Entries { get { return _entries; } }
        public EvoMenuItemsConfirmArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
