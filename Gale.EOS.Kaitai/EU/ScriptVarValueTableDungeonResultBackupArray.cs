// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array script_var_value_table_dungeon_result_backup defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTableDungeonResultBackupArray : KaitaiStruct
    {
        public static ScriptVarValueTableDungeonResultBackupArray FromFile(string fileName)
        {
            return new ScriptVarValueTableDungeonResultBackupArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTableDungeonResultBackupArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTableDungeonResultBackupArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTableDungeonResultBackupArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTableDungeonResultBackupArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTableDungeonResultBackupArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTableDungeonResultBackupArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTableDungeonResultBackupArrayDim0(KaitaiStream p__io, ScriptVarValueTableDungeonResultBackupArray p__parent = null, ScriptVarValueTableDungeonResultBackupArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<byte>();
                for (var i = 0; i < 5; i++)
                {
                    _entries.Add(m_io.ReadU1());
                }
            }
            private List<byte> _entries;
            private ScriptVarValueTableDungeonResultBackupArray m_root;
            private ScriptVarValueTableDungeonResultBackupArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public ScriptVarValueTableDungeonResultBackupArray M_Root { get { return m_root; } }
            public ScriptVarValueTableDungeonResultBackupArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTableDungeonResultBackupArrayDim0 _entries;
        private ScriptVarValueTableDungeonResultBackupArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTableDungeonResultBackupArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTableDungeonResultBackupArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
