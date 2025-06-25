// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array script_var_value_table_dungeon_enter_frequency_backup defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTableDungeonEnterFrequencyBackupArray : KaitaiStruct
    {
        public static ScriptVarValueTableDungeonEnterFrequencyBackupArray FromFile(string fileName)
        {
            return new ScriptVarValueTableDungeonEnterFrequencyBackupArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTableDungeonEnterFrequencyBackupArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTableDungeonEnterFrequencyBackupArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTableDungeonEnterFrequencyBackupArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTableDungeonEnterFrequencyBackupArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTableDungeonEnterFrequencyBackupArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTableDungeonEnterFrequencyBackupArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTableDungeonEnterFrequencyBackupArrayDim0(KaitaiStream p__io, ScriptVarValueTableDungeonEnterFrequencyBackupArray p__parent = null, ScriptVarValueTableDungeonEnterFrequencyBackupArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<ushort>();
                for (var i = 0; i < 5; i++)
                {
                    _entries.Add(m_io.ReadU2le());
                }
            }
            private List<ushort> _entries;
            private ScriptVarValueTableDungeonEnterFrequencyBackupArray m_root;
            private ScriptVarValueTableDungeonEnterFrequencyBackupArray m_parent;
            public List<ushort> Entries { get { return _entries; } }
            public ScriptVarValueTableDungeonEnterFrequencyBackupArray M_Root { get { return m_root; } }
            public ScriptVarValueTableDungeonEnterFrequencyBackupArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTableDungeonEnterFrequencyBackupArrayDim0 _entries;
        private ScriptVarValueTableDungeonEnterFrequencyBackupArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTableDungeonEnterFrequencyBackupArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTableDungeonEnterFrequencyBackupArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
