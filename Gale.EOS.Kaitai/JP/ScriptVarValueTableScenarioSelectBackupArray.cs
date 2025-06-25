// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array script_var_value_table_scenario_select_backup defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTableScenarioSelectBackupArray : KaitaiStruct
    {
        public static ScriptVarValueTableScenarioSelectBackupArray FromFile(string fileName)
        {
            return new ScriptVarValueTableScenarioSelectBackupArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTableScenarioSelectBackupArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTableScenarioSelectBackupArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTableScenarioSelectBackupArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTableScenarioSelectBackupArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTableScenarioSelectBackupArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTableScenarioSelectBackupArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTableScenarioSelectBackupArrayDim0(KaitaiStream p__io, ScriptVarValueTableScenarioSelectBackupArray p__parent = null, ScriptVarValueTableScenarioSelectBackupArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<byte>();
                for (var i = 0; i < 8; i++)
                {
                    _entries.Add(m_io.ReadU1());
                }
            }
            private List<byte> _entries;
            private ScriptVarValueTableScenarioSelectBackupArray m_root;
            private ScriptVarValueTableScenarioSelectBackupArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public ScriptVarValueTableScenarioSelectBackupArray M_Root { get { return m_root; } }
            public ScriptVarValueTableScenarioSelectBackupArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTableScenarioSelectBackupArrayDim0 _entries;
        private ScriptVarValueTableScenarioSelectBackupArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTableScenarioSelectBackupArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTableScenarioSelectBackupArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
