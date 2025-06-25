// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array QUIZ_QUESTION_ANSWER_ASSOCIATIONS defined within pmdsky.
    /// </summary>
    public partial class QuizQuestionAnswerAssociationsArray : KaitaiStruct
    {
        public static QuizQuestionAnswerAssociationsArray FromFile(string fileName)
        {
            return new QuizQuestionAnswerAssociationsArray(new KaitaiStream(fileName));
        }

        public QuizQuestionAnswerAssociationsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, QuizQuestionAnswerAssociationsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new QuizQuestionAnswerAssociationsArrayDim0(m_io, this, m_root);
        }
        public partial class QuizQuestionAnswerAssociationsArrayDim0 : KaitaiStruct
        {
            public static QuizQuestionAnswerAssociationsArrayDim0 FromFile(string fileName)
            {
                return new QuizQuestionAnswerAssociationsArrayDim0(new KaitaiStream(fileName));
            }

            public QuizQuestionAnswerAssociationsArrayDim0(KaitaiStream p__io, QuizQuestionAnswerAssociationsArray p__parent = null, QuizQuestionAnswerAssociationsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<ushort>();
                for (var i = 0; i < 66; i++)
                {
                    _entries.Add(m_io.ReadU2le());
                }
            }
            private List<ushort> _entries;
            private QuizQuestionAnswerAssociationsArray m_root;
            private QuizQuestionAnswerAssociationsArray m_parent;
            public List<ushort> Entries { get { return _entries; } }
            public QuizQuestionAnswerAssociationsArray M_Root { get { return m_root; } }
            public QuizQuestionAnswerAssociationsArray M_Parent { get { return m_parent; } }
        }
        private QuizQuestionAnswerAssociationsArrayDim0 _entries;
        private QuizQuestionAnswerAssociationsArray m_root;
        private KaitaiStruct m_parent;
        public QuizQuestionAnswerAssociationsArrayDim0 Entries { get { return _entries; } }
        public QuizQuestionAnswerAssociationsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
