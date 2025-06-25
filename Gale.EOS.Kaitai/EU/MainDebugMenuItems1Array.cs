// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array MAIN_DEBUG_MENU_ITEMS_1 defined within pmdsky.
    /// </summary>
    public partial class MainDebugMenuItems1Array : KaitaiStruct
    {
        public static MainDebugMenuItems1Array FromFile(string fileName)
        {
            return new MainDebugMenuItems1Array(new KaitaiStream(fileName));
        }

        public MainDebugMenuItems1Array(KaitaiStream p__io, KaitaiStruct p__parent = null, MainDebugMenuItems1Array p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MainDebugMenuItems1ArrayDim0(m_io, this, m_root);
        }
        public partial class MainDebugMenuItems1ArrayDim0 : KaitaiStruct
        {
            public static MainDebugMenuItems1ArrayDim0 FromFile(string fileName)
            {
                return new MainDebugMenuItems1ArrayDim0(new KaitaiStream(fileName));
            }

            public MainDebugMenuItems1ArrayDim0(KaitaiStream p__io, MainDebugMenuItems1Array p__parent = null, MainDebugMenuItems1Array p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<SimpleMenuIdItem>();
                for (var i = 0; i < 12; i++)
                {
                    _entries.Add(new SimpleMenuIdItem(m_io));
                }
            }
            private List<SimpleMenuIdItem> _entries;
            private MainDebugMenuItems1Array m_root;
            private MainDebugMenuItems1Array m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public MainDebugMenuItems1Array M_Root { get { return m_root; } }
            public MainDebugMenuItems1Array M_Parent { get { return m_parent; } }
        }
        private MainDebugMenuItems1ArrayDim0 _entries;
        private MainDebugMenuItems1Array m_root;
        private KaitaiStruct m_parent;
        public MainDebugMenuItems1ArrayDim0 Entries { get { return _entries; } }
        public MainDebugMenuItems1Array M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
