// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array script_local_var_table_vars defined within pmdsky.
    /// </summary>
    public partial class ScriptLocalVarTableVarsArray : KaitaiStruct
    {
        public static ScriptLocalVarTableVarsArray FromFile(string fileName)
        {
            return new ScriptLocalVarTableVarsArray(new KaitaiStream(fileName));
        }

        public ScriptLocalVarTableVarsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptLocalVarTableVarsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptLocalVarTableVarsArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptLocalVarTableVarsArrayDim0 : KaitaiStruct
        {
            public static ScriptLocalVarTableVarsArrayDim0 FromFile(string fileName)
            {
                return new ScriptLocalVarTableVarsArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptLocalVarTableVarsArrayDim0(KaitaiStream p__io, ScriptLocalVarTableVarsArray p__parent = null, ScriptLocalVarTableVarsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<ScriptVar>();
                for (var i = 0; i < 4; i++)
                {
                    _entries.Add(new ScriptVar(m_io));
                }
            }
            private List<ScriptVar> _entries;
            private ScriptLocalVarTableVarsArray m_root;
            private ScriptLocalVarTableVarsArray m_parent;
            public List<ScriptVar> Entries { get { return _entries; } }
            public ScriptLocalVarTableVarsArray M_Root { get { return m_root; } }
            public ScriptLocalVarTableVarsArray M_Parent { get { return m_parent; } }
        }
        private ScriptLocalVarTableVarsArrayDim0 _entries;
        private ScriptLocalVarTableVarsArray m_root;
        private KaitaiStruct m_parent;
        public ScriptLocalVarTableVarsArrayDim0 Entries { get { return _entries; } }
        public ScriptLocalVarTableVarsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
