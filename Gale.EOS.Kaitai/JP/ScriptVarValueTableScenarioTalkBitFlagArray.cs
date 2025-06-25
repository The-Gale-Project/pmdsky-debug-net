// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array script_var_value_table_scenario_talk_bit_flag defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTableScenarioTalkBitFlagArray : KaitaiStruct
    {
        public static ScriptVarValueTableScenarioTalkBitFlagArray FromFile(string fileName)
        {
            return new ScriptVarValueTableScenarioTalkBitFlagArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTableScenarioTalkBitFlagArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTableScenarioTalkBitFlagArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTableScenarioTalkBitFlagArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTableScenarioTalkBitFlagArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTableScenarioTalkBitFlagArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTableScenarioTalkBitFlagArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTableScenarioTalkBitFlagArrayDim0(KaitaiStream p__io, ScriptVarValueTableScenarioTalkBitFlagArray p__parent = null, ScriptVarValueTableScenarioTalkBitFlagArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<byte>();
                for (var i = 0; i < 32; i++)
                {
                    _entries.Add(m_io.ReadU1());
                }
            }
            private List<byte> _entries;
            private ScriptVarValueTableScenarioTalkBitFlagArray m_root;
            private ScriptVarValueTableScenarioTalkBitFlagArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public ScriptVarValueTableScenarioTalkBitFlagArray M_Root { get { return m_root; } }
            public ScriptVarValueTableScenarioTalkBitFlagArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTableScenarioTalkBitFlagArrayDim0 _entries;
        private ScriptVarValueTableScenarioTalkBitFlagArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTableScenarioTalkBitFlagArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTableScenarioTalkBitFlagArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
