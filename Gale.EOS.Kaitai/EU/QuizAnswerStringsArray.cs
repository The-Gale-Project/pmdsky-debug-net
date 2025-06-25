// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array QUIZ_ANSWER_STRINGS defined within pmdsky.
    /// </summary>
    public partial class QuizAnswerStringsArray : KaitaiStruct
    {
        public static QuizAnswerStringsArray FromFile(string fileName)
        {
            return new QuizAnswerStringsArray(new KaitaiStream(fileName));
        }

        public QuizAnswerStringsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, QuizAnswerStringsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new QuizAnswerStringsArrayDim0(m_io, this, m_root);
        }
        public partial class QuizAnswerStringsArrayDim0 : KaitaiStruct
        {
            public static QuizAnswerStringsArrayDim0 FromFile(string fileName)
            {
                return new QuizAnswerStringsArrayDim0(new KaitaiStream(fileName));
            }

            public QuizAnswerStringsArrayDim0(KaitaiStream p__io, QuizAnswerStringsArray p__parent = null, QuizAnswerStringsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<ushort>();
                for (var i = 0; i < 176; i++)
                {
                    _entries.Add(m_io.ReadU2le());
                }
            }
            private List<ushort> _entries;
            private QuizAnswerStringsArray m_root;
            private QuizAnswerStringsArray m_parent;
            public List<ushort> Entries { get { return _entries; } }
            public QuizAnswerStringsArray M_Root { get { return m_root; } }
            public QuizAnswerStringsArray M_Parent { get { return m_parent; } }
        }
        private QuizAnswerStringsArrayDim0 _entries;
        private QuizAnswerStringsArray m_root;
        private KaitaiStruct m_parent;
        public QuizAnswerStringsArrayDim0 Entries { get { return _entries; } }
        public QuizAnswerStringsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
