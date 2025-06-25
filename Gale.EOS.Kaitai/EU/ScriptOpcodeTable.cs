// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union script_opcode_table defined within pmdsky-debug.
    /// </summary>
    public partial class ScriptOpcodeTable : KaitaiStruct
    {
        public static ScriptOpcodeTable FromFile(string fileName)
        {
            return new ScriptOpcodeTable(new KaitaiStream(fileName));
        }

        public ScriptOpcodeTable(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptOpcodeTable p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _ops = new ScriptOpcodeTableOpsArray(m_io);
        }
        private ScriptOpcodeTableOpsArray _ops;
        private ScriptOpcodeTable m_root;
        private KaitaiStruct m_parent;
        public ScriptOpcodeTableOpsArray Ops { get { return _ops; } }
        public ScriptOpcodeTable M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
