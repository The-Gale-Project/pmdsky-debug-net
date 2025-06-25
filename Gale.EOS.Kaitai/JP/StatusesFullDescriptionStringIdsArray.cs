// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array STATUSES_FULL_DESCRIPTION_STRING_IDS defined within pmdsky.
    /// </summary>
    public partial class StatusesFullDescriptionStringIdsArray : KaitaiStruct
    {
        public static StatusesFullDescriptionStringIdsArray FromFile(string fileName)
        {
            return new StatusesFullDescriptionStringIdsArray(new KaitaiStream(fileName));
        }

        public StatusesFullDescriptionStringIdsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, StatusesFullDescriptionStringIdsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StatusesFullDescriptionStringIdsArrayDim0(m_io, this, m_root);
        }
        public partial class StatusesFullDescriptionStringIdsArrayDim0 : KaitaiStruct
        {
            public static StatusesFullDescriptionStringIdsArrayDim0 FromFile(string fileName)
            {
                return new StatusesFullDescriptionStringIdsArrayDim0(new KaitaiStream(fileName));
            }

            public StatusesFullDescriptionStringIdsArrayDim0(KaitaiStream p__io, StatusesFullDescriptionStringIdsArray p__parent = null, StatusesFullDescriptionStringIdsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<StatusDescription>();
                for (var i = 0; i < 103; i++)
                {
                    _entries.Add(new StatusDescription(m_io));
                }
            }
            private List<StatusDescription> _entries;
            private StatusesFullDescriptionStringIdsArray m_root;
            private StatusesFullDescriptionStringIdsArray m_parent;
            public List<StatusDescription> Entries { get { return _entries; } }
            public StatusesFullDescriptionStringIdsArray M_Root { get { return m_root; } }
            public StatusesFullDescriptionStringIdsArray M_Parent { get { return m_parent; } }
        }
        private StatusesFullDescriptionStringIdsArrayDim0 _entries;
        private StatusesFullDescriptionStringIdsArray m_root;
        private KaitaiStruct m_parent;
        public StatusesFullDescriptionStringIdsArrayDim0 Entries { get { return _entries; } }
        public StatusesFullDescriptionStringIdsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
