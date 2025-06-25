// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array script_var_value_table_scenario_main_bit_flag defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTableScenarioMainBitFlagArray : KaitaiStruct
    {
        public static ScriptVarValueTableScenarioMainBitFlagArray FromFile(string fileName)
        {
            return new ScriptVarValueTableScenarioMainBitFlagArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTableScenarioMainBitFlagArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTableScenarioMainBitFlagArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTableScenarioMainBitFlagArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTableScenarioMainBitFlagArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTableScenarioMainBitFlagArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTableScenarioMainBitFlagArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTableScenarioMainBitFlagArrayDim0(KaitaiStream p__io, ScriptVarValueTableScenarioMainBitFlagArray p__parent = null, ScriptVarValueTableScenarioMainBitFlagArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<byte>();
                for (var i = 0; i < 16; i++)
                {
                    _entries.Add(m_io.ReadU1());
                }
            }
            private List<byte> _entries;
            private ScriptVarValueTableScenarioMainBitFlagArray m_root;
            private ScriptVarValueTableScenarioMainBitFlagArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public ScriptVarValueTableScenarioMainBitFlagArray M_Root { get { return m_root; } }
            public ScriptVarValueTableScenarioMainBitFlagArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTableScenarioMainBitFlagArrayDim0 _entries;
        private ScriptVarValueTableScenarioMainBitFlagArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTableScenarioMainBitFlagArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTableScenarioMainBitFlagArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
