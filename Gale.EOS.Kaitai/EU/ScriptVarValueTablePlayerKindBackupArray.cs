// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array script_var_value_table_player_kind_backup defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTablePlayerKindBackupArray : KaitaiStruct
    {
        public static ScriptVarValueTablePlayerKindBackupArray FromFile(string fileName)
        {
            return new ScriptVarValueTablePlayerKindBackupArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTablePlayerKindBackupArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTablePlayerKindBackupArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTablePlayerKindBackupArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTablePlayerKindBackupArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTablePlayerKindBackupArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTablePlayerKindBackupArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTablePlayerKindBackupArrayDim0(KaitaiStream p__io, ScriptVarValueTablePlayerKindBackupArray p__parent = null, ScriptVarValueTablePlayerKindBackupArray p__root = null) : base(p__io)
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
            private ScriptVarValueTablePlayerKindBackupArray m_root;
            private ScriptVarValueTablePlayerKindBackupArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public ScriptVarValueTablePlayerKindBackupArray M_Root { get { return m_root; } }
            public ScriptVarValueTablePlayerKindBackupArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTablePlayerKindBackupArrayDim0 _entries;
        private ScriptVarValueTablePlayerKindBackupArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTablePlayerKindBackupArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTablePlayerKindBackupArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
