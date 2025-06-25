// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array script_var_value_table_attendant1_kind_backup defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTableAttendant1KindBackupArray : KaitaiStruct
    {
        public static ScriptVarValueTableAttendant1KindBackupArray FromFile(string fileName)
        {
            return new ScriptVarValueTableAttendant1KindBackupArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTableAttendant1KindBackupArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTableAttendant1KindBackupArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTableAttendant1KindBackupArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTableAttendant1KindBackupArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTableAttendant1KindBackupArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTableAttendant1KindBackupArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTableAttendant1KindBackupArrayDim0(KaitaiStream p__io, ScriptVarValueTableAttendant1KindBackupArray p__parent = null, ScriptVarValueTableAttendant1KindBackupArray p__root = null) : base(p__io)
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
            private ScriptVarValueTableAttendant1KindBackupArray m_root;
            private ScriptVarValueTableAttendant1KindBackupArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public ScriptVarValueTableAttendant1KindBackupArray M_Root { get { return m_root; } }
            public ScriptVarValueTableAttendant1KindBackupArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTableAttendant1KindBackupArrayDim0 _entries;
        private ScriptVarValueTableAttendant1KindBackupArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTableAttendant1KindBackupArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTableAttendant1KindBackupArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
