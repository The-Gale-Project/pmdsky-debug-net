// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union script_entity defined within pmdsky-debug.
    /// </summary>
    public partial class ScriptEntity : KaitaiStruct
    {
        public static ScriptEntity FromFile(string fileName)
        {
            return new ScriptEntity(new KaitaiStream(fileName));
        }

        public ScriptEntity(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptEntity p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _type = m_io.ReadU2le();
            _entid = m_io.ReadU2le();
            _name = new Pointer(m_io);
            _field0x8 = m_io.ReadU2le();
            _field0xa = m_io.ReadU1();
            _field0xb = m_io.ReadU1();
        }
        private ushort _type;
        private ushort _entid;
        private Pointer _name;
        private ushort _field0x8;
        private byte _field0xa;
        private byte _field0xb;
        private ScriptEntity m_root;
        private KaitaiStruct m_parent;
        public ushort Type { get { return _type; } }
        public ushort Entid { get { return _entid; } }
        public Pointer Name { get { return _name; } }
        public ushort Field0x8 { get { return _field0x8; } }
        public byte Field0xa { get { return _field0xa; } }
        public byte Field0xb { get { return _field0xb; } }
        public ScriptEntity M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
