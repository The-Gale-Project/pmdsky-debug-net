// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array sentry_duty_field_0x282c defined within pmdsky.
    /// </summary>
    public partial class SentryDutyField0x282cArray : KaitaiStruct
    {
        public static SentryDutyField0x282cArray FromFile(string fileName)
        {
            return new SentryDutyField0x282cArray(new KaitaiStream(fileName));
        }

        public SentryDutyField0x282cArray(KaitaiStream p__io, KaitaiStruct p__parent = null, SentryDutyField0x282cArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new SentryDutyField0x282cArrayDim0(m_io, this, m_root);
        }
        public partial class SentryDutyField0x282cArrayDim0 : KaitaiStruct
        {
            public static SentryDutyField0x282cArrayDim0 FromFile(string fileName)
            {
                return new SentryDutyField0x282cArrayDim0(new KaitaiStream(fileName));
            }

            public SentryDutyField0x282cArrayDim0(KaitaiStream p__io, SentryDutyField0x282cArray p__parent = null, SentryDutyField0x282cArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<Animation>();
                for (var i = 0; i < 2; i++)
                {
                    _entries.Add(new Animation(m_io));
                }
            }
            private List<Animation> _entries;
            private SentryDutyField0x282cArray m_root;
            private SentryDutyField0x282cArray m_parent;
            public List<Animation> Entries { get { return _entries; } }
            public SentryDutyField0x282cArray M_Root { get { return m_root; } }
            public SentryDutyField0x282cArray M_Parent { get { return m_parent; } }
        }
        private SentryDutyField0x282cArrayDim0 _entries;
        private SentryDutyField0x282cArray m_root;
        private KaitaiStruct m_parent;
        public SentryDutyField0x282cArrayDim0 Entries { get { return _entries; } }
        public SentryDutyField0x282cArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
