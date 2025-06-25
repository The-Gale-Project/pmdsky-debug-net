// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array script_var_value_table_dungeon_enter_backup defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTableDungeonEnterBackupArray : KaitaiStruct
    {
        public static ScriptVarValueTableDungeonEnterBackupArray FromFile(string fileName)
        {
            return new ScriptVarValueTableDungeonEnterBackupArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTableDungeonEnterBackupArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTableDungeonEnterBackupArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTableDungeonEnterBackupArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTableDungeonEnterBackupArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTableDungeonEnterBackupArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTableDungeonEnterBackupArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTableDungeonEnterBackupArrayDim0(KaitaiStream p__io, ScriptVarValueTableDungeonEnterBackupArray p__parent = null, ScriptVarValueTableDungeonEnterBackupArray p__root = null) : base(p__io)
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
            private ScriptVarValueTableDungeonEnterBackupArray m_root;
            private ScriptVarValueTableDungeonEnterBackupArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public ScriptVarValueTableDungeonEnterBackupArray M_Root { get { return m_root; } }
            public ScriptVarValueTableDungeonEnterBackupArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTableDungeonEnterBackupArrayDim0 _entries;
        private ScriptVarValueTableDungeonEnterBackupArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTableDungeonEnterBackupArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTableDungeonEnterBackupArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
