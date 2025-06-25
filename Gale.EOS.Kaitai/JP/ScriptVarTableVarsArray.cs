// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array script_var_table_vars defined within pmdsky.
    /// </summary>
    public partial class ScriptVarTableVarsArray : KaitaiStruct
    {
        public static ScriptVarTableVarsArray FromFile(string fileName)
        {
            return new ScriptVarTableVarsArray(new KaitaiStream(fileName));
        }

        public ScriptVarTableVarsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarTableVarsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarTableVarsArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarTableVarsArrayDim0 : KaitaiStruct
        {
            public static ScriptVarTableVarsArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarTableVarsArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarTableVarsArrayDim0(KaitaiStream p__io, ScriptVarTableVarsArray p__parent = null, ScriptVarTableVarsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<ScriptVar>();
                for (var i = 0; i < 115; i++)
                {
                    _entries.Add(new ScriptVar(m_io));
                }
            }
            private List<ScriptVar> _entries;
            private ScriptVarTableVarsArray m_root;
            private ScriptVarTableVarsArray m_parent;
            public List<ScriptVar> Entries { get { return _entries; } }
            public ScriptVarTableVarsArray M_Root { get { return m_root; } }
            public ScriptVarTableVarsArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarTableVarsArrayDim0 _entries;
        private ScriptVarTableVarsArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarTableVarsArrayDim0 Entries { get { return _entries; } }
        public ScriptVarTableVarsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
