// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array script_var_value_table_scenario_side defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTableScenarioSideArray : KaitaiStruct
    {
        public static ScriptVarValueTableScenarioSideArray FromFile(string fileName)
        {
            return new ScriptVarValueTableScenarioSideArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTableScenarioSideArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTableScenarioSideArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTableScenarioSideArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTableScenarioSideArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTableScenarioSideArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTableScenarioSideArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTableScenarioSideArrayDim0(KaitaiStream p__io, ScriptVarValueTableScenarioSideArray p__parent = null, ScriptVarValueTableScenarioSideArray p__root = null) : base(p__io)
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
            private ScriptVarValueTableScenarioSideArray m_root;
            private ScriptVarValueTableScenarioSideArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public ScriptVarValueTableScenarioSideArray M_Root { get { return m_root; } }
            public ScriptVarValueTableScenarioSideArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTableScenarioSideArrayDim0 _entries;
        private ScriptVarValueTableScenarioSideArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTableScenarioSideArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTableScenarioSideArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
