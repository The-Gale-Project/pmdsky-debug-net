// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array SENTRY_DUTY_STATE_HANDLER_TABLE defined within pmdsky.
    /// </summary>
    public partial class SentryDutyStateHandlerTableArray : KaitaiStruct
    {
        public static SentryDutyStateHandlerTableArray FromFile(string fileName)
        {
            return new SentryDutyStateHandlerTableArray(new KaitaiStream(fileName));
        }

        public SentryDutyStateHandlerTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, SentryDutyStateHandlerTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new SentryDutyStateHandlerTableArrayDim0(m_io, this, m_root);
        }
        public partial class SentryDutyStateHandlerTableArrayDim0 : KaitaiStruct
        {
            public static SentryDutyStateHandlerTableArrayDim0 FromFile(string fileName)
            {
                return new SentryDutyStateHandlerTableArrayDim0(new KaitaiStream(fileName));
            }

            public SentryDutyStateHandlerTableArrayDim0(KaitaiStream p__io, SentryDutyStateHandlerTableArray p__parent = null, SentryDutyStateHandlerTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<Pointer>();
                for (var i = 0; i < 35; i++)
                {
                    _entries.Add(new Pointer(m_io));
                }
            }
            private List<Pointer> _entries;
            private SentryDutyStateHandlerTableArray m_root;
            private SentryDutyStateHandlerTableArray m_parent;
            public List<Pointer> Entries { get { return _entries; } }
            public SentryDutyStateHandlerTableArray M_Root { get { return m_root; } }
            public SentryDutyStateHandlerTableArray M_Parent { get { return m_parent; } }
        }
        private SentryDutyStateHandlerTableArrayDim0 _entries;
        private SentryDutyStateHandlerTableArray m_root;
        private KaitaiStruct m_parent;
        public SentryDutyStateHandlerTableArrayDim0 Entries { get { return _entries; } }
        public SentryDutyStateHandlerTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
