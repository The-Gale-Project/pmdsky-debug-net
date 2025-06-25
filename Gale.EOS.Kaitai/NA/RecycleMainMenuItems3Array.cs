// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array RECYCLE_MAIN_MENU_ITEMS_3 defined within pmdsky.
    /// </summary>
    public partial class RecycleMainMenuItems3Array : KaitaiStruct
    {
        public static RecycleMainMenuItems3Array FromFile(string fileName)
        {
            return new RecycleMainMenuItems3Array(new KaitaiStream(fileName));
        }

        public RecycleMainMenuItems3Array(KaitaiStream p__io, KaitaiStruct p__parent = null, RecycleMainMenuItems3Array p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new RecycleMainMenuItems3ArrayDim0(m_io, this, m_root);
        }
        public partial class RecycleMainMenuItems3ArrayDim0 : KaitaiStruct
        {
            public static RecycleMainMenuItems3ArrayDim0 FromFile(string fileName)
            {
                return new RecycleMainMenuItems3ArrayDim0(new KaitaiStream(fileName));
            }

            public RecycleMainMenuItems3ArrayDim0(KaitaiStream p__io, RecycleMainMenuItems3Array p__parent = null, RecycleMainMenuItems3Array p__root = null) : base(p__io)
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
            private RecycleMainMenuItems3Array m_root;
            private RecycleMainMenuItems3Array m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public RecycleMainMenuItems3Array M_Root { get { return m_root; } }
            public RecycleMainMenuItems3Array M_Parent { get { return m_parent; } }
        }
        private RecycleMainMenuItems3ArrayDim0 _entries;
        private RecycleMainMenuItems3Array m_root;
        private KaitaiStruct m_parent;
        public RecycleMainMenuItems3ArrayDim0 Entries { get { return _entries; } }
        public RecycleMainMenuItems3Array M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
