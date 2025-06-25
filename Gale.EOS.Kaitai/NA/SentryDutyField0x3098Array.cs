// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array sentry_duty_field_0x3098 defined within pmdsky.
    /// </summary>
    public partial class SentryDutyField0x3098Array : KaitaiStruct
    {
        public static SentryDutyField0x3098Array FromFile(string fileName)
        {
            return new SentryDutyField0x3098Array(new KaitaiStream(fileName));
        }

        public SentryDutyField0x3098Array(KaitaiStream p__io, KaitaiStruct p__parent = null, SentryDutyField0x3098Array p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new SentryDutyField0x3098ArrayDim0(m_io, this, m_root);
        }
        public partial class SentryDutyField0x3098ArrayDim0 : KaitaiStruct
        {
            public static SentryDutyField0x3098ArrayDim0 FromFile(string fileName)
            {
                return new SentryDutyField0x3098ArrayDim0(new KaitaiStream(fileName));
            }

            public SentryDutyField0x3098ArrayDim0(KaitaiStream p__io, SentryDutyField0x3098Array p__parent = null, SentryDutyField0x3098Array p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<Animation>();
                for (var i = 0; i < 4; i++)
                {
                    _entries.Add(new Animation(m_io));
                }
            }
            private List<Animation> _entries;
            private SentryDutyField0x3098Array m_root;
            private SentryDutyField0x3098Array m_parent;
            public List<Animation> Entries { get { return _entries; } }
            public SentryDutyField0x3098Array M_Root { get { return m_root; } }
            public SentryDutyField0x3098Array M_Parent { get { return m_parent; } }
        }
        private SentryDutyField0x3098ArrayDim0 _entries;
        private SentryDutyField0x3098Array m_root;
        private KaitaiStruct m_parent;
        public SentryDutyField0x3098ArrayDim0 Entries { get { return _entries; } }
        public SentryDutyField0x3098Array M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
