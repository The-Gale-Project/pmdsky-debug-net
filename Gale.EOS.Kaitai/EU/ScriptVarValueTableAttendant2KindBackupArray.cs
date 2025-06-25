// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array script_var_value_table_attendant2_kind_backup defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTableAttendant2KindBackupArray : KaitaiStruct
    {
        public static ScriptVarValueTableAttendant2KindBackupArray FromFile(string fileName)
        {
            return new ScriptVarValueTableAttendant2KindBackupArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTableAttendant2KindBackupArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTableAttendant2KindBackupArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTableAttendant2KindBackupArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTableAttendant2KindBackupArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTableAttendant2KindBackupArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTableAttendant2KindBackupArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTableAttendant2KindBackupArrayDim0(KaitaiStream p__io, ScriptVarValueTableAttendant2KindBackupArray p__parent = null, ScriptVarValueTableAttendant2KindBackupArray p__root = null) : base(p__io)
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
            private ScriptVarValueTableAttendant2KindBackupArray m_root;
            private ScriptVarValueTableAttendant2KindBackupArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public ScriptVarValueTableAttendant2KindBackupArray M_Root { get { return m_root; } }
            public ScriptVarValueTableAttendant2KindBackupArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTableAttendant2KindBackupArrayDim0 _entries;
        private ScriptVarValueTableAttendant2KindBackupArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTableAttendant2KindBackupArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTableAttendant2KindBackupArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
