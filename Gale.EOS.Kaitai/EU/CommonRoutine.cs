// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union common_routine defined within pmdsky-debug.
    /// </summary>
    public partial class CommonRoutine : KaitaiStruct
    {
        public static CommonRoutine FromFile(string fileName)
        {
            return new CommonRoutine(new KaitaiStream(fileName));
        }

        public CommonRoutine(KaitaiStream p__io, KaitaiStruct p__parent = null, CommonRoutine p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _id = new CommonRoutineId16(m_io);
            _field0x2 = m_io.ReadS2le();
            _name = new Pointer(m_io);
        }
        private CommonRoutineId16 _id;
        private short _field0x2;
        private Pointer _name;
        private CommonRoutine m_root;
        private KaitaiStruct m_parent;
        public CommonRoutineId16 Id { get { return _id; } }
        public short Field0x2 { get { return _field0x2; } }
        public Pointer Name { get { return _name; } }
        public CommonRoutine M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
