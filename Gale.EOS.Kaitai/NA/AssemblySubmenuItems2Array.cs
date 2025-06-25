// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array ASSEMBLY_SUBMENU_ITEMS_2 defined within pmdsky.
    /// </summary>
    public partial class AssemblySubmenuItems2Array : KaitaiStruct
    {
        public static AssemblySubmenuItems2Array FromFile(string fileName)
        {
            return new AssemblySubmenuItems2Array(new KaitaiStream(fileName));
        }

        public AssemblySubmenuItems2Array(KaitaiStream p__io, KaitaiStruct p__parent = null, AssemblySubmenuItems2Array p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new AssemblySubmenuItems2ArrayDim0(m_io, this, m_root);
        }
        public partial class AssemblySubmenuItems2ArrayDim0 : KaitaiStruct
        {
            public static AssemblySubmenuItems2ArrayDim0 FromFile(string fileName)
            {
                return new AssemblySubmenuItems2ArrayDim0(new KaitaiStream(fileName));
            }

            public AssemblySubmenuItems2ArrayDim0(KaitaiStream p__io, AssemblySubmenuItems2Array p__parent = null, AssemblySubmenuItems2Array p__root = null) : base(p__io)
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
            private AssemblySubmenuItems2Array m_root;
            private AssemblySubmenuItems2Array m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public AssemblySubmenuItems2Array M_Root { get { return m_root; } }
            public AssemblySubmenuItems2Array M_Parent { get { return m_parent; } }
        }
        private AssemblySubmenuItems2ArrayDim0 _entries;
        private AssemblySubmenuItems2Array m_root;
        private KaitaiStruct m_parent;
        public AssemblySubmenuItems2ArrayDim0 Entries { get { return _entries; } }
        public AssemblySubmenuItems2Array M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
