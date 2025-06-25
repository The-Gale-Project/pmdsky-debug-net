// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array ASSEMBLY_SUBMENU_ITEMS_7 defined within pmdsky.
    /// </summary>
    public partial class AssemblySubmenuItems7Array : KaitaiStruct
    {
        public static AssemblySubmenuItems7Array FromFile(string fileName)
        {
            return new AssemblySubmenuItems7Array(new KaitaiStream(fileName));
        }

        public AssemblySubmenuItems7Array(KaitaiStream p__io, KaitaiStruct p__parent = null, AssemblySubmenuItems7Array p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new AssemblySubmenuItems7ArrayDim0(m_io, this, m_root);
        }
        public partial class AssemblySubmenuItems7ArrayDim0 : KaitaiStruct
        {
            public static AssemblySubmenuItems7ArrayDim0 FromFile(string fileName)
            {
                return new AssemblySubmenuItems7ArrayDim0(new KaitaiStream(fileName));
            }

            public AssemblySubmenuItems7ArrayDim0(KaitaiStream p__io, AssemblySubmenuItems7Array p__parent = null, AssemblySubmenuItems7Array p__root = null) : base(p__io)
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
            private AssemblySubmenuItems7Array m_root;
            private AssemblySubmenuItems7Array m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public AssemblySubmenuItems7Array M_Root { get { return m_root; } }
            public AssemblySubmenuItems7Array M_Parent { get { return m_parent; } }
        }
        private AssemblySubmenuItems7ArrayDim0 _entries;
        private AssemblySubmenuItems7Array m_root;
        private KaitaiStruct m_parent;
        public AssemblySubmenuItems7ArrayDim0 Entries { get { return _entries; } }
        public AssemblySubmenuItems7Array M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
