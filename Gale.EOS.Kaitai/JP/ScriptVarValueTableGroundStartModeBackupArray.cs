// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array script_var_value_table_ground_start_mode_backup defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTableGroundStartModeBackupArray : KaitaiStruct
    {
        public static ScriptVarValueTableGroundStartModeBackupArray FromFile(string fileName)
        {
            return new ScriptVarValueTableGroundStartModeBackupArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTableGroundStartModeBackupArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTableGroundStartModeBackupArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTableGroundStartModeBackupArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTableGroundStartModeBackupArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTableGroundStartModeBackupArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTableGroundStartModeBackupArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTableGroundStartModeBackupArrayDim0(KaitaiStream p__io, ScriptVarValueTableGroundStartModeBackupArray p__parent = null, ScriptVarValueTableGroundStartModeBackupArray p__root = null) : base(p__io)
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
            private ScriptVarValueTableGroundStartModeBackupArray m_root;
            private ScriptVarValueTableGroundStartModeBackupArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public ScriptVarValueTableGroundStartModeBackupArray M_Root { get { return m_root; } }
            public ScriptVarValueTableGroundStartModeBackupArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTableGroundStartModeBackupArrayDim0 _entries;
        private ScriptVarValueTableGroundStartModeBackupArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTableGroundStartModeBackupArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTableGroundStartModeBackupArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
