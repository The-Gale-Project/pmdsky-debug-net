// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array QUIZ_QUESTION_STRINGS defined within pmdsky.
    /// </summary>
    public partial class QuizQuestionStringsArray : KaitaiStruct
    {
        public static QuizQuestionStringsArray FromFile(string fileName)
        {
            return new QuizQuestionStringsArray(new KaitaiStream(fileName));
        }

        public QuizQuestionStringsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, QuizQuestionStringsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new QuizQuestionStringsArrayDim0(m_io, this, m_root);
        }
        public partial class QuizQuestionStringsArrayDim0 : KaitaiStruct
        {
            public static QuizQuestionStringsArrayDim0 FromFile(string fileName)
            {
                return new QuizQuestionStringsArrayDim0(new KaitaiStream(fileName));
            }

            public QuizQuestionStringsArrayDim0(KaitaiStream p__io, QuizQuestionStringsArray p__parent = null, QuizQuestionStringsArray p__root = null) : base(p__io)
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
            private QuizQuestionStringsArray m_root;
            private QuizQuestionStringsArray m_parent;
            public List<ushort> Entries { get { return _entries; } }
            public QuizQuestionStringsArray M_Root { get { return m_root; } }
            public QuizQuestionStringsArray M_Parent { get { return m_parent; } }
        }
        private QuizQuestionStringsArrayDim0 _entries;
        private QuizQuestionStringsArray m_root;
        private KaitaiStruct m_parent;
        public QuizQuestionStringsArrayDim0 Entries { get { return _entries; } }
        public QuizQuestionStringsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
