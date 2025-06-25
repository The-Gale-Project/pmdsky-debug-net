// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Holds bitsized data for the parent enum ai_objective.
    /// </summary>
    public partial class AiObjective8 : KaitaiStruct
    {
        public static AiObjective8 FromFile(string fileName)
        {
            return new AiObjective8(new KaitaiStream(fileName));
        }


        public enum AiObjective8Enum
        {
            AiUnknown = 0,
            AiChaseTarget = 1,
            AiChaseRememberedTarget = 2,
            AiRoam = 3,
            AiLeaveRoom = 4,
            AiRunAway = 5,
            AiStandStill = 6,
            AiTakeItem = 7,
        }
        public AiObjective8(KaitaiStream p__io, KaitaiStruct p__parent = null, AiObjective8 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _aiObjective8Value = ((AiObjective8Enum) m_io.ReadBitsIntLe(8));
        }
        private AiObjective8Enum _aiObjective8Value;
        private AiObjective8 m_root;
        private KaitaiStruct m_parent;
        public AiObjective8Enum AiObjective8Value { get { return _aiObjective8Value; } }
        public AiObjective8 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
