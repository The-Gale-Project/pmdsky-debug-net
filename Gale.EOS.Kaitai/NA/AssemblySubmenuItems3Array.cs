// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array ASSEMBLY_SUBMENU_ITEMS_3 defined within pmdsky.
    /// </summary>
    public partial class AssemblySubmenuItems3Array : KaitaiStruct
    {
        public static AssemblySubmenuItems3Array FromFile(string fileName)
        {
            return new AssemblySubmenuItems3Array(new KaitaiStream(fileName));
        }

        public AssemblySubmenuItems3Array(KaitaiStream p__io, KaitaiStruct p__parent = null, AssemblySubmenuItems3Array p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new AssemblySubmenuItems3ArrayDim0(m_io, this, m_root);
        }
        public partial class AssemblySubmenuItems3ArrayDim0 : KaitaiStruct
        {
            public static AssemblySubmenuItems3ArrayDim0 FromFile(string fileName)
            {
                return new AssemblySubmenuItems3ArrayDim0(new KaitaiStream(fileName));
            }

            public AssemblySubmenuItems3ArrayDim0(KaitaiStream p__io, AssemblySubmenuItems3Array p__parent = null, AssemblySubmenuItems3Array p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<SimpleMenuIdItem>();
                for (var i = 0; i < 6; i++)
                {
                    _entries.Add(new SimpleMenuIdItem(m_io));
                }
            }
            private List<SimpleMenuIdItem> _entries;
            private AssemblySubmenuItems3Array m_root;
            private AssemblySubmenuItems3Array m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public AssemblySubmenuItems3Array M_Root { get { return m_root; } }
            public AssemblySubmenuItems3Array M_Parent { get { return m_parent; } }
        }
        private AssemblySubmenuItems3ArrayDim0 _entries;
        private AssemblySubmenuItems3Array m_root;
        private KaitaiStruct m_parent;
        public AssemblySubmenuItems3ArrayDim0 Entries { get { return _entries; } }
        public AssemblySubmenuItems3Array M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
