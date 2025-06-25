// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents a struct or union common_routine_table defined within pmdsky-debug.
    /// </summary>
    public partial class CommonRoutineTable : KaitaiStruct
    {
        public static CommonRoutineTable FromFile(string fileName)
        {
            return new CommonRoutineTable(new KaitaiStream(fileName));
        }

        public CommonRoutineTable(KaitaiStream p__io, KaitaiStruct p__parent = null, CommonRoutineTable p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _routines = new CommonRoutineTableRoutinesArray(m_io);
        }
        private CommonRoutineTableRoutinesArray _routines;
        private CommonRoutineTable m_root;
        private KaitaiStruct m_parent;
        public CommonRoutineTableRoutinesArray Routines { get { return _routines; } }
        public CommonRoutineTable M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
