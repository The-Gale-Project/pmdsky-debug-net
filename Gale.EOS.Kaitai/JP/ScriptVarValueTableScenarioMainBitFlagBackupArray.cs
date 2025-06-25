// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array script_var_value_table_scenario_main_bit_flag_backup defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTableScenarioMainBitFlagBackupArray : KaitaiStruct
    {
        public static ScriptVarValueTableScenarioMainBitFlagBackupArray FromFile(string fileName)
        {
            return new ScriptVarValueTableScenarioMainBitFlagBackupArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTableScenarioMainBitFlagBackupArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTableScenarioMainBitFlagBackupArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTableScenarioMainBitFlagBackupArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTableScenarioMainBitFlagBackupArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTableScenarioMainBitFlagBackupArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTableScenarioMainBitFlagBackupArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTableScenarioMainBitFlagBackupArrayDim0(KaitaiStream p__io, ScriptVarValueTableScenarioMainBitFlagBackupArray p__parent = null, ScriptVarValueTableScenarioMainBitFlagBackupArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<byte>();
                for (var i = 0; i < 64; i++)
                {
                    _entries.Add(m_io.ReadU1());
                }
            }
            private List<byte> _entries;
            private ScriptVarValueTableScenarioMainBitFlagBackupArray m_root;
            private ScriptVarValueTableScenarioMainBitFlagBackupArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public ScriptVarValueTableScenarioMainBitFlagBackupArray M_Root { get { return m_root; } }
            public ScriptVarValueTableScenarioMainBitFlagBackupArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTableScenarioMainBitFlagBackupArrayDim0 _entries;
        private ScriptVarValueTableScenarioMainBitFlagBackupArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTableScenarioMainBitFlagBackupArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTableScenarioMainBitFlagBackupArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
