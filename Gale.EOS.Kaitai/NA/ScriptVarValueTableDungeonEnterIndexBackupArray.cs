// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array script_var_value_table_dungeon_enter_index_backup defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTableDungeonEnterIndexBackupArray : KaitaiStruct
    {
        public static ScriptVarValueTableDungeonEnterIndexBackupArray FromFile(string fileName)
        {
            return new ScriptVarValueTableDungeonEnterIndexBackupArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTableDungeonEnterIndexBackupArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTableDungeonEnterIndexBackupArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTableDungeonEnterIndexBackupArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTableDungeonEnterIndexBackupArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTableDungeonEnterIndexBackupArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTableDungeonEnterIndexBackupArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTableDungeonEnterIndexBackupArrayDim0(KaitaiStream p__io, ScriptVarValueTableDungeonEnterIndexBackupArray p__parent = null, ScriptVarValueTableDungeonEnterIndexBackupArray p__root = null) : base(p__io)
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
            private ScriptVarValueTableDungeonEnterIndexBackupArray m_root;
            private ScriptVarValueTableDungeonEnterIndexBackupArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public ScriptVarValueTableDungeonEnterIndexBackupArray M_Root { get { return m_root; } }
            public ScriptVarValueTableDungeonEnterIndexBackupArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTableDungeonEnterIndexBackupArrayDim0 _entries;
        private ScriptVarValueTableDungeonEnterIndexBackupArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTableDungeonEnterIndexBackupArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTableDungeonEnterIndexBackupArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
