// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union script_opcode defined within pmdsky-debug.
    /// </summary>
    public partial class ScriptOpcode : KaitaiStruct
    {
        public static ScriptOpcode FromFile(string fileName)
        {
            return new ScriptOpcode(new KaitaiStream(fileName));
        }

        public ScriptOpcode(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptOpcode p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _nParams = m_io.ReadS1();
            _stringIdx = m_io.ReadS1();
            _field0x2 = m_io.ReadU1();
            _field0x3 = m_io.ReadU1();
            _name = new Pointer(m_io);
        }
        private sbyte _nParams;
        private sbyte _stringIdx;
        private byte _field0x2;
        private byte _field0x3;
        private Pointer _name;
        private ScriptOpcode m_root;
        private KaitaiStruct m_parent;
        public sbyte NParams { get { return _nParams; } }
        public sbyte StringIdx { get { return _stringIdx; } }
        public byte Field0x2 { get { return _field0x2; } }
        public byte Field0x3 { get { return _field0x3; } }
        public Pointer Name { get { return _name; } }
        public ScriptOpcode M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
