// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Holds bitsized data for the parent enum script_routine_kind.
    /// </summary>
    public partial class ScriptRoutineKind16 : KaitaiStruct
    {
        public static ScriptRoutineKind16 FromFile(string fileName)
        {
            return new ScriptRoutineKind16(new KaitaiStream(fileName));
        }


        public enum ScriptRoutineKind16Enum
        {
            RoutineMain = 1,
            Routine0x2 = 2,
            RoutineActor = 3,
            RoutineObject = 4,
            RoutinePerformer = 5,
            Routine0x6 = 6,
            Routine0x7 = 7,
            Routine0x8 = 8,
            RoutineUnionall = 9,
        }
        public ScriptRoutineKind16(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptRoutineKind16 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _scriptRoutineKind16Value = ((ScriptRoutineKind16Enum) m_io.ReadBitsIntLe(16));
        }
        private ScriptRoutineKind16Enum _scriptRoutineKind16Value;
        private ScriptRoutineKind16 m_root;
        private KaitaiStruct m_parent;
        public ScriptRoutineKind16Enum ScriptRoutineKind16Value { get { return _scriptRoutineKind16Value; } }
        public ScriptRoutineKind16 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
