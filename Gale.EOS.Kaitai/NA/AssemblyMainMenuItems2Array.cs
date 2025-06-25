// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array ASSEMBLY_MAIN_MENU_ITEMS_2 defined within pmdsky.
    /// </summary>
    public partial class AssemblyMainMenuItems2Array : KaitaiStruct
    {
        public static AssemblyMainMenuItems2Array FromFile(string fileName)
        {
            return new AssemblyMainMenuItems2Array(new KaitaiStream(fileName));
        }

        public AssemblyMainMenuItems2Array(KaitaiStream p__io, KaitaiStruct p__parent = null, AssemblyMainMenuItems2Array p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new AssemblyMainMenuItems2ArrayDim0(m_io, this, m_root);
        }
        public partial class AssemblyMainMenuItems2ArrayDim0 : KaitaiStruct
        {
            public static AssemblyMainMenuItems2ArrayDim0 FromFile(string fileName)
            {
                return new AssemblyMainMenuItems2ArrayDim0(new KaitaiStream(fileName));
            }

            public AssemblyMainMenuItems2ArrayDim0(KaitaiStream p__io, AssemblyMainMenuItems2Array p__parent = null, AssemblyMainMenuItems2Array p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<SimpleMenuIdItem>();
                for (var i = 0; i < 4; i++)
                {
                    _entries.Add(new SimpleMenuIdItem(m_io));
                }
            }
            private List<SimpleMenuIdItem> _entries;
            private AssemblyMainMenuItems2Array m_root;
            private AssemblyMainMenuItems2Array m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public AssemblyMainMenuItems2Array M_Root { get { return m_root; } }
            public AssemblyMainMenuItems2Array M_Parent { get { return m_parent; } }
        }
        private AssemblyMainMenuItems2ArrayDim0 _entries;
        private AssemblyMainMenuItems2Array m_root;
        private KaitaiStruct m_parent;
        public AssemblyMainMenuItems2ArrayDim0 Entries { get { return _entries; } }
        public AssemblyMainMenuItems2Array M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
