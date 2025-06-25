// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union script_local_var_table defined within pmdsky-debug.
    /// </summary>
    public partial class ScriptLocalVarTable : KaitaiStruct
    {
        public static ScriptLocalVarTable FromFile(string fileName)
        {
            return new ScriptLocalVarTable(new KaitaiStream(fileName));
        }

        public ScriptLocalVarTable(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptLocalVarTable p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _vars = new ScriptLocalVarTableVarsArray(m_io);
        }
        private ScriptLocalVarTableVarsArray _vars;
        private ScriptLocalVarTable m_root;
        private KaitaiStruct m_parent;
        public ScriptLocalVarTableVarsArray Vars { get { return _vars; } }
        public ScriptLocalVarTable M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
