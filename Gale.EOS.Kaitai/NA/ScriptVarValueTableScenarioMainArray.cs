// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array script_var_value_table_scenario_main defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTableScenarioMainArray : KaitaiStruct
    {
        public static ScriptVarValueTableScenarioMainArray FromFile(string fileName)
        {
            return new ScriptVarValueTableScenarioMainArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTableScenarioMainArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTableScenarioMainArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTableScenarioMainArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTableScenarioMainArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTableScenarioMainArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTableScenarioMainArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTableScenarioMainArrayDim0(KaitaiStream p__io, ScriptVarValueTableScenarioMainArray p__parent = null, ScriptVarValueTableScenarioMainArray p__root = null) : base(p__io)
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
            private ScriptVarValueTableScenarioMainArray m_root;
            private ScriptVarValueTableScenarioMainArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public ScriptVarValueTableScenarioMainArray M_Root { get { return m_root; } }
            public ScriptVarValueTableScenarioMainArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTableScenarioMainArrayDim0 _entries;
        private ScriptVarValueTableScenarioMainArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTableScenarioMainArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTableScenarioMainArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
