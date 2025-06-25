// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array ASSEMBLY_MENU_ITEMS_CONFIRM defined within pmdsky.
    /// </summary>
    public partial class AssemblyMenuItemsConfirmArray : KaitaiStruct
    {
        public static AssemblyMenuItemsConfirmArray FromFile(string fileName)
        {
            return new AssemblyMenuItemsConfirmArray(new KaitaiStream(fileName));
        }

        public AssemblyMenuItemsConfirmArray(KaitaiStream p__io, KaitaiStruct p__parent = null, AssemblyMenuItemsConfirmArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new AssemblyMenuItemsConfirmArrayDim0(m_io, this, m_root);
        }
        public partial class AssemblyMenuItemsConfirmArrayDim0 : KaitaiStruct
        {
            public static AssemblyMenuItemsConfirmArrayDim0 FromFile(string fileName)
            {
                return new AssemblyMenuItemsConfirmArrayDim0(new KaitaiStream(fileName));
            }

            public AssemblyMenuItemsConfirmArrayDim0(KaitaiStream p__io, AssemblyMenuItemsConfirmArray p__parent = null, AssemblyMenuItemsConfirmArray p__root = null) : base(p__io)
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
            private AssemblyMenuItemsConfirmArray m_root;
            private AssemblyMenuItemsConfirmArray m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public AssemblyMenuItemsConfirmArray M_Root { get { return m_root; } }
            public AssemblyMenuItemsConfirmArray M_Parent { get { return m_parent; } }
        }
        private AssemblyMenuItemsConfirmArrayDim0 _entries;
        private AssemblyMenuItemsConfirmArray m_root;
        private KaitaiStruct m_parent;
        public AssemblyMenuItemsConfirmArrayDim0 Entries { get { return _entries; } }
        public AssemblyMenuItemsConfirmArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
