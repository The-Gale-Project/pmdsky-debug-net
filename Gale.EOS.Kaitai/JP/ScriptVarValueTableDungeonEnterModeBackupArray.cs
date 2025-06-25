// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array script_var_value_table_dungeon_enter_mode_backup defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTableDungeonEnterModeBackupArray : KaitaiStruct
    {
        public static ScriptVarValueTableDungeonEnterModeBackupArray FromFile(string fileName)
        {
            return new ScriptVarValueTableDungeonEnterModeBackupArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTableDungeonEnterModeBackupArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTableDungeonEnterModeBackupArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTableDungeonEnterModeBackupArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTableDungeonEnterModeBackupArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTableDungeonEnterModeBackupArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTableDungeonEnterModeBackupArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTableDungeonEnterModeBackupArrayDim0(KaitaiStream p__io, ScriptVarValueTableDungeonEnterModeBackupArray p__parent = null, ScriptVarValueTableDungeonEnterModeBackupArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<short>();
                for (var i = 0; i < 5; i++)
                {
                    _entries.Add(m_io.ReadS2le());
                }
            }
            private List<short> _entries;
            private ScriptVarValueTableDungeonEnterModeBackupArray m_root;
            private ScriptVarValueTableDungeonEnterModeBackupArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public ScriptVarValueTableDungeonEnterModeBackupArray M_Root { get { return m_root; } }
            public ScriptVarValueTableDungeonEnterModeBackupArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTableDungeonEnterModeBackupArrayDim0 _entries;
        private ScriptVarValueTableDungeonEnterModeBackupArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTableDungeonEnterModeBackupArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTableDungeonEnterModeBackupArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
