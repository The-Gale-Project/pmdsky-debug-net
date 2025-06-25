// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array script_var_value_table_scenario_sub8 defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTableScenarioSub8Array : KaitaiStruct
    {
        public static ScriptVarValueTableScenarioSub8Array FromFile(string fileName)
        {
            return new ScriptVarValueTableScenarioSub8Array(new KaitaiStream(fileName));
        }

        public ScriptVarValueTableScenarioSub8Array(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTableScenarioSub8Array p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTableScenarioSub8ArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTableScenarioSub8ArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTableScenarioSub8ArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTableScenarioSub8ArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTableScenarioSub8ArrayDim0(KaitaiStream p__io, ScriptVarValueTableScenarioSub8Array p__parent = null, ScriptVarValueTableScenarioSub8Array p__root = null) : base(p__io)
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
            private ScriptVarValueTableScenarioSub8Array m_root;
            private ScriptVarValueTableScenarioSub8Array m_parent;
            public List<byte> Entries { get { return _entries; } }
            public ScriptVarValueTableScenarioSub8Array M_Root { get { return m_root; } }
            public ScriptVarValueTableScenarioSub8Array M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTableScenarioSub8ArrayDim0 _entries;
        private ScriptVarValueTableScenarioSub8Array m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTableScenarioSub8ArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTableScenarioSub8Array M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
