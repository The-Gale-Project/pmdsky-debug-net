// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array STATUS_NAME_STRING_IDS defined within pmdsky.
    /// </summary>
    public partial class StatusNameStringIdsArray : KaitaiStruct
    {
        public static StatusNameStringIdsArray FromFile(string fileName)
        {
            return new StatusNameStringIdsArray(new KaitaiStream(fileName));
        }

        public StatusNameStringIdsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, StatusNameStringIdsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StatusNameStringIdsArrayDim0(m_io, this, m_root);
        }
        public partial class StatusNameStringIdsArrayDim0 : KaitaiStruct
        {
            public static StatusNameStringIdsArrayDim0 FromFile(string fileName)
            {
                return new StatusNameStringIdsArrayDim0(new KaitaiStream(fileName));
            }

            public StatusNameStringIdsArrayDim0(KaitaiStream p__io, StatusNameStringIdsArray p__parent = null, StatusNameStringIdsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<short>();
                for (var i = 0; i < 102; i++)
                {
                    _entries.Add(m_io.ReadS2le());
                }
            }
            private List<short> _entries;
            private StatusNameStringIdsArray m_root;
            private StatusNameStringIdsArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public StatusNameStringIdsArray M_Root { get { return m_root; } }
            public StatusNameStringIdsArray M_Parent { get { return m_parent; } }
        }
        private StatusNameStringIdsArrayDim0 _entries;
        private StatusNameStringIdsArray m_root;
        private KaitaiStruct m_parent;
        public StatusNameStringIdsArrayDim0 Entries { get { return _entries; } }
        public StatusNameStringIdsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
