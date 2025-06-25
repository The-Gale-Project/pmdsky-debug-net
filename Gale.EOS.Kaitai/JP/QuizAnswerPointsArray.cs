// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array QUIZ_ANSWER_POINTS defined within pmdsky.
    /// </summary>
    public partial class QuizAnswerPointsArray : KaitaiStruct
    {
        public static QuizAnswerPointsArray FromFile(string fileName)
        {
            return new QuizAnswerPointsArray(new KaitaiStream(fileName));
        }

        public QuizAnswerPointsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, QuizAnswerPointsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new QuizAnswerPointsArrayDim0(m_io, this, m_root);
        }
        public partial class QuizAnswerPointsArrayDim0 : KaitaiStruct
        {
            public static QuizAnswerPointsArrayDim0 FromFile(string fileName)
            {
                return new QuizAnswerPointsArrayDim0(new KaitaiStream(fileName));
            }

            public QuizAnswerPointsArrayDim0(KaitaiStream p__io, QuizAnswerPointsArray p__parent = null, QuizAnswerPointsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<QuizAnswerPointsEntry>();
                for (var i = 0; i < 174; i++)
                {
                    _entries.Add(new QuizAnswerPointsEntry(m_io));
                }
            }
            private List<QuizAnswerPointsEntry> _entries;
            private QuizAnswerPointsArray m_root;
            private QuizAnswerPointsArray m_parent;
            public List<QuizAnswerPointsEntry> Entries { get { return _entries; } }
            public QuizAnswerPointsArray M_Root { get { return m_root; } }
            public QuizAnswerPointsArray M_Parent { get { return m_parent; } }
        }
        private QuizAnswerPointsArrayDim0 _entries;
        private QuizAnswerPointsArray m_root;
        private KaitaiStruct m_parent;
        public QuizAnswerPointsArrayDim0 Entries { get { return _entries; } }
        public QuizAnswerPointsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
