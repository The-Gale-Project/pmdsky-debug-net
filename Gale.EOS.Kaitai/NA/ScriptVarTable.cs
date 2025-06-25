// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union script_var_table defined within pmdsky-debug.
    /// </summary>
    public partial class ScriptVarTable : KaitaiStruct
    {
        public static ScriptVarTable FromFile(string fileName)
        {
            return new ScriptVarTable(new KaitaiStream(fileName));
        }

        public ScriptVarTable(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarTable p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _vars = new ScriptVarTableVarsArray(m_io);
        }
        private ScriptVarTableVarsArray _vars;
        private ScriptVarTable m_root;
        private KaitaiStruct m_parent;
        public ScriptVarTableVarsArray Vars { get { return _vars; } }
        public ScriptVarTable M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
