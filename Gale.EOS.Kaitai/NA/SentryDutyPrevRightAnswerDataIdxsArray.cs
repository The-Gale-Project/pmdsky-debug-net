// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array sentry_duty_prev_right_answer_data_idxs defined within pmdsky.
    /// </summary>
    public partial class SentryDutyPrevRightAnswerDataIdxsArray : KaitaiStruct
    {
        public static SentryDutyPrevRightAnswerDataIdxsArray FromFile(string fileName)
        {
            return new SentryDutyPrevRightAnswerDataIdxsArray(new KaitaiStream(fileName));
        }

        public SentryDutyPrevRightAnswerDataIdxsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, SentryDutyPrevRightAnswerDataIdxsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new SentryDutyPrevRightAnswerDataIdxsArrayDim0(m_io, this, m_root);
        }
        public partial class SentryDutyPrevRightAnswerDataIdxsArrayDim0 : KaitaiStruct
        {
            public static SentryDutyPrevRightAnswerDataIdxsArrayDim0 FromFile(string fileName)
            {
                return new SentryDutyPrevRightAnswerDataIdxsArrayDim0(new KaitaiStream(fileName));
            }

            public SentryDutyPrevRightAnswerDataIdxsArrayDim0(KaitaiStream p__io, SentryDutyPrevRightAnswerDataIdxsArray p__parent = null, SentryDutyPrevRightAnswerDataIdxsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<int>();
                for (var i = 0; i < 6; i++)
                {
                    _entries.Add(m_io.ReadS4le());
                }
            }
            private List<int> _entries;
            private SentryDutyPrevRightAnswerDataIdxsArray m_root;
            private SentryDutyPrevRightAnswerDataIdxsArray m_parent;
            public List<int> Entries { get { return _entries; } }
            public SentryDutyPrevRightAnswerDataIdxsArray M_Root { get { return m_root; } }
            public SentryDutyPrevRightAnswerDataIdxsArray M_Parent { get { return m_parent; } }
        }
        private SentryDutyPrevRightAnswerDataIdxsArrayDim0 _entries;
        private SentryDutyPrevRightAnswerDataIdxsArray m_root;
        private KaitaiStruct m_parent;
        public SentryDutyPrevRightAnswerDataIdxsArrayDim0 Entries { get { return _entries; } }
        public SentryDutyPrevRightAnswerDataIdxsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
