// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array script_var_value_table_scenario_select defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTableScenarioSelectArray : KaitaiStruct
    {
        public static ScriptVarValueTableScenarioSelectArray FromFile(string fileName)
        {
            return new ScriptVarValueTableScenarioSelectArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTableScenarioSelectArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTableScenarioSelectArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTableScenarioSelectArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTableScenarioSelectArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTableScenarioSelectArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTableScenarioSelectArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTableScenarioSelectArrayDim0(KaitaiStream p__io, ScriptVarValueTableScenarioSelectArray p__parent = null, ScriptVarValueTableScenarioSelectArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<byte>();
                for (var i = 0; i < 2; i++)
                {
                    _entries.Add(m_io.ReadU1());
                }
            }
            private List<byte> _entries;
            private ScriptVarValueTableScenarioSelectArray m_root;
            private ScriptVarValueTableScenarioSelectArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public ScriptVarValueTableScenarioSelectArray M_Root { get { return m_root; } }
            public ScriptVarValueTableScenarioSelectArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTableScenarioSelectArrayDim0 _entries;
        private ScriptVarValueTableScenarioSelectArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTableScenarioSelectArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTableScenarioSelectArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
