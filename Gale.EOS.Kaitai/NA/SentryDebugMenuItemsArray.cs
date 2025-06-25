// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array SENTRY_DEBUG_MENU_ITEMS defined within pmdsky.
    /// </summary>
    public partial class SentryDebugMenuItemsArray : KaitaiStruct
    {
        public static SentryDebugMenuItemsArray FromFile(string fileName)
        {
            return new SentryDebugMenuItemsArray(new KaitaiStream(fileName));
        }

        public SentryDebugMenuItemsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, SentryDebugMenuItemsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new SentryDebugMenuItemsArrayDim0(m_io, this, m_root);
        }
        public partial class SentryDebugMenuItemsArrayDim0 : KaitaiStruct
        {
            public static SentryDebugMenuItemsArrayDim0 FromFile(string fileName)
            {
                return new SentryDebugMenuItemsArrayDim0(new KaitaiStream(fileName));
            }

            public SentryDebugMenuItemsArrayDim0(KaitaiStream p__io, SentryDebugMenuItemsArray p__parent = null, SentryDebugMenuItemsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<SimpleMenuIdItem>();
                for (var i = 0; i < 9; i++)
                {
                    _entries.Add(new SimpleMenuIdItem(m_io));
                }
            }
            private List<SimpleMenuIdItem> _entries;
            private SentryDebugMenuItemsArray m_root;
            private SentryDebugMenuItemsArray m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public SentryDebugMenuItemsArray M_Root { get { return m_root; } }
            public SentryDebugMenuItemsArray M_Parent { get { return m_parent; } }
        }
        private SentryDebugMenuItemsArrayDim0 _entries;
        private SentryDebugMenuItemsArray m_root;
        private KaitaiStruct m_parent;
        public SentryDebugMenuItemsArrayDim0 Entries { get { return _entries; } }
        public SentryDebugMenuItemsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
