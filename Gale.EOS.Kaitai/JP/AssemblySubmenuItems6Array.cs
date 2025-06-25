// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array ASSEMBLY_SUBMENU_ITEMS_6 defined within pmdsky.
    /// </summary>
    public partial class AssemblySubmenuItems6Array : KaitaiStruct
    {
        public static AssemblySubmenuItems6Array FromFile(string fileName)
        {
            return new AssemblySubmenuItems6Array(new KaitaiStream(fileName));
        }

        public AssemblySubmenuItems6Array(KaitaiStream p__io, KaitaiStruct p__parent = null, AssemblySubmenuItems6Array p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new AssemblySubmenuItems6ArrayDim0(m_io, this, m_root);
        }
        public partial class AssemblySubmenuItems6ArrayDim0 : KaitaiStruct
        {
            public static AssemblySubmenuItems6ArrayDim0 FromFile(string fileName)
            {
                return new AssemblySubmenuItems6ArrayDim0(new KaitaiStream(fileName));
            }

            public AssemblySubmenuItems6ArrayDim0(KaitaiStream p__io, AssemblySubmenuItems6Array p__parent = null, AssemblySubmenuItems6Array p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<SimpleMenuIdItem>();
                for (var i = 0; i < 7; i++)
                {
                    _entries.Add(new SimpleMenuIdItem(m_io));
                }
            }
            private List<SimpleMenuIdItem> _entries;
            private AssemblySubmenuItems6Array m_root;
            private AssemblySubmenuItems6Array m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public AssemblySubmenuItems6Array M_Root { get { return m_root; } }
            public AssemblySubmenuItems6Array M_Parent { get { return m_parent; } }
        }
        private AssemblySubmenuItems6ArrayDim0 _entries;
        private AssemblySubmenuItems6Array m_root;
        private KaitaiStruct m_parent;
        public AssemblySubmenuItems6ArrayDim0 Entries { get { return _entries; } }
        public AssemblySubmenuItems6Array M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
