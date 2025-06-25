// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array sentry_duty_choices defined within pmdsky.
    /// </summary>
    public partial class SentryDutyChoicesArray : KaitaiStruct
    {
        public static SentryDutyChoicesArray FromFile(string fileName)
        {
            return new SentryDutyChoicesArray(new KaitaiStream(fileName));
        }

        public SentryDutyChoicesArray(KaitaiStream p__io, KaitaiStruct p__parent = null, SentryDutyChoicesArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new SentryDutyChoicesArrayDim0(m_io, this, m_root);
        }
        public partial class SentryDutyChoicesArrayDim0 : KaitaiStruct
        {
            public static SentryDutyChoicesArrayDim0 FromFile(string fileName)
            {
                return new SentryDutyChoicesArrayDim0(new KaitaiStream(fileName));
            }

            public SentryDutyChoicesArrayDim0(KaitaiStream p__io, SentryDutyChoicesArray p__parent = null, SentryDutyChoicesArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<MonsterId16>();
                for (var i = 0; i < 4; i++)
                {
                    _entries.Add(new MonsterId16(m_io));
                }
            }
            private List<MonsterId16> _entries;
            private SentryDutyChoicesArray m_root;
            private SentryDutyChoicesArray m_parent;
            public List<MonsterId16> Entries { get { return _entries; } }
            public SentryDutyChoicesArray M_Root { get { return m_root; } }
            public SentryDutyChoicesArray M_Parent { get { return m_parent; } }
        }
        private SentryDutyChoicesArrayDim0 _entries;
        private SentryDutyChoicesArray m_root;
        private KaitaiStruct m_parent;
        public SentryDutyChoicesArrayDim0 Entries { get { return _entries; } }
        public SentryDutyChoicesArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
