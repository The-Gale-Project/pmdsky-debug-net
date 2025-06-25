// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array ASSEMBLY_SUBMENU_ITEMS_1 defined within pmdsky.
    /// </summary>
    public partial class AssemblySubmenuItems1Array : KaitaiStruct
    {
        public static AssemblySubmenuItems1Array FromFile(string fileName)
        {
            return new AssemblySubmenuItems1Array(new KaitaiStream(fileName));
        }

        public AssemblySubmenuItems1Array(KaitaiStream p__io, KaitaiStruct p__parent = null, AssemblySubmenuItems1Array p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new AssemblySubmenuItems1ArrayDim0(m_io, this, m_root);
        }
        public partial class AssemblySubmenuItems1ArrayDim0 : KaitaiStruct
        {
            public static AssemblySubmenuItems1ArrayDim0 FromFile(string fileName)
            {
                return new AssemblySubmenuItems1ArrayDim0(new KaitaiStream(fileName));
            }

            public AssemblySubmenuItems1ArrayDim0(KaitaiStream p__io, AssemblySubmenuItems1Array p__parent = null, AssemblySubmenuItems1Array p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<SimpleMenuIdItem>();
                for (var i = 0; i < 5; i++)
                {
                    _entries.Add(new SimpleMenuIdItem(m_io));
                }
            }
            private List<SimpleMenuIdItem> _entries;
            private AssemblySubmenuItems1Array m_root;
            private AssemblySubmenuItems1Array m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public AssemblySubmenuItems1Array M_Root { get { return m_root; } }
            public AssemblySubmenuItems1Array M_Parent { get { return m_parent; } }
        }
        private AssemblySubmenuItems1ArrayDim0 _entries;
        private AssemblySubmenuItems1Array m_root;
        private KaitaiStruct m_parent;
        public AssemblySubmenuItems1ArrayDim0 Entries { get { return _entries; } }
        public AssemblySubmenuItems1Array M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
