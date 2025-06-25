// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Holds bitsized data for the parent enum move_ai_condition.
    /// </summary>
    public partial class MoveAiCondition4 : KaitaiStruct
    {
        public static MoveAiCondition4 FromFile(string fileName)
        {
            return new MoveAiCondition4(new KaitaiStream(fileName));
        }


        public enum MoveAiCondition4Enum
        {
            AiConditionNone = 0,
            AiConditionRandom = 1,
            AiConditionHp25 = 2,
            AiConditionStatus = 3,
            AiConditionAsleep = 4,
            AiConditionGhost = 5,
            AiConditionHp25OrStatus = 6,
        }
        public MoveAiCondition4(KaitaiStream p__io, KaitaiStruct p__parent = null, MoveAiCondition4 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _moveAiCondition4Value = ((MoveAiCondition4Enum) m_io.ReadBitsIntLe(4));
        }
        private MoveAiCondition4Enum _moveAiCondition4Value;
        private MoveAiCondition4 m_root;
        private KaitaiStruct m_parent;
        public MoveAiCondition4Enum MoveAiCondition4Value { get { return _moveAiCondition4Value; } }
        public MoveAiCondition4 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
