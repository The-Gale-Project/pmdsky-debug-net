// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents a struct or union quiz_answer_points_entry defined within pmdsky-debug.
    /// </summary>
    public partial class QuizAnswerPointsEntry : KaitaiStruct
    {
        public static QuizAnswerPointsEntry FromFile(string fileName)
        {
            return new QuizAnswerPointsEntry(new KaitaiStream(fileName));
        }

        public QuizAnswerPointsEntry(KaitaiStream p__io, KaitaiStruct p__parent = null, QuizAnswerPointsEntry p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _field0x0 = m_io.ReadU1();
            _field0x1 = m_io.ReadU1();
            _field0x2 = m_io.ReadU1();
            _field0x3 = m_io.ReadU1();
            _field0x4 = m_io.ReadU1();
            _field0x5 = m_io.ReadU1();
            _field0x6 = m_io.ReadU1();
            _field0x7 = m_io.ReadU1();
            _field0x8 = m_io.ReadU1();
            _field0x9 = m_io.ReadU1();
            _field0xa = m_io.ReadU1();
            _field0xb = m_io.ReadU1();
            _field0xc = m_io.ReadU1();
            _field0xd = m_io.ReadU1();
            _field0xe = m_io.ReadU1();
            _field0xf = m_io.ReadU1();
        }
        private byte _field0x0;
        private byte _field0x1;
        private byte _field0x2;
        private byte _field0x3;
        private byte _field0x4;
        private byte _field0x5;
        private byte _field0x6;
        private byte _field0x7;
        private byte _field0x8;
        private byte _field0x9;
        private byte _field0xa;
        private byte _field0xb;
        private byte _field0xc;
        private byte _field0xd;
        private byte _field0xe;
        private byte _field0xf;
        private QuizAnswerPointsEntry m_root;
        private KaitaiStruct m_parent;
        public byte Field0x0 { get { return _field0x0; } }
        public byte Field0x1 { get { return _field0x1; } }
        public byte Field0x2 { get { return _field0x2; } }
        public byte Field0x3 { get { return _field0x3; } }
        public byte Field0x4 { get { return _field0x4; } }
        public byte Field0x5 { get { return _field0x5; } }
        public byte Field0x6 { get { return _field0x6; } }
        public byte Field0x7 { get { return _field0x7; } }
        public byte Field0x8 { get { return _field0x8; } }
        public byte Field0x9 { get { return _field0x9; } }
        public byte Field0xa { get { return _field0xa; } }
        public byte Field0xb { get { return _field0xb; } }
        public byte Field0xc { get { return _field0xc; } }
        public byte Field0xd { get { return _field0xd; } }
        public byte Field0xe { get { return _field0xe; } }
        public byte Field0xf { get { return _field0xf; } }
        public QuizAnswerPointsEntry M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
