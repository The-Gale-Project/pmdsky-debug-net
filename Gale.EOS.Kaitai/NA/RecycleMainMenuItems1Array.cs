// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array RECYCLE_MAIN_MENU_ITEMS_1 defined within pmdsky.
    /// </summary>
    public partial class RecycleMainMenuItems1Array : KaitaiStruct
    {
        public static RecycleMainMenuItems1Array FromFile(string fileName)
        {
            return new RecycleMainMenuItems1Array(new KaitaiStream(fileName));
        }

        public RecycleMainMenuItems1Array(KaitaiStream p__io, KaitaiStruct p__parent = null, RecycleMainMenuItems1Array p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new RecycleMainMenuItems1ArrayDim0(m_io, this, m_root);
        }
        public partial class RecycleMainMenuItems1ArrayDim0 : KaitaiStruct
        {
            public static RecycleMainMenuItems1ArrayDim0 FromFile(string fileName)
            {
                return new RecycleMainMenuItems1ArrayDim0(new KaitaiStream(fileName));
            }

            public RecycleMainMenuItems1ArrayDim0(KaitaiStream p__io, RecycleMainMenuItems1Array p__parent = null, RecycleMainMenuItems1Array p__root = null) : base(p__io)
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
            private RecycleMainMenuItems1Array m_root;
            private RecycleMainMenuItems1Array m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public RecycleMainMenuItems1Array M_Root { get { return m_root; } }
            public RecycleMainMenuItems1Array M_Parent { get { return m_parent; } }
        }
        private RecycleMainMenuItems1ArrayDim0 _entries;
        private RecycleMainMenuItems1Array m_root;
        private KaitaiStruct m_parent;
        public RecycleMainMenuItems1ArrayDim0 Entries { get { return _entries; } }
        public RecycleMainMenuItems1Array M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
