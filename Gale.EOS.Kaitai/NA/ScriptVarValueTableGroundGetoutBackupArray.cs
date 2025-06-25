// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array script_var_value_table_ground_getout_backup defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTableGroundGetoutBackupArray : KaitaiStruct
    {
        public static ScriptVarValueTableGroundGetoutBackupArray FromFile(string fileName)
        {
            return new ScriptVarValueTableGroundGetoutBackupArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTableGroundGetoutBackupArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTableGroundGetoutBackupArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTableGroundGetoutBackupArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTableGroundGetoutBackupArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTableGroundGetoutBackupArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTableGroundGetoutBackupArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTableGroundGetoutBackupArrayDim0(KaitaiStream p__io, ScriptVarValueTableGroundGetoutBackupArray p__parent = null, ScriptVarValueTableGroundGetoutBackupArray p__root = null) : base(p__io)
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
            private ScriptVarValueTableGroundGetoutBackupArray m_root;
            private ScriptVarValueTableGroundGetoutBackupArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public ScriptVarValueTableGroundGetoutBackupArray M_Root { get { return m_root; } }
            public ScriptVarValueTableGroundGetoutBackupArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTableGroundGetoutBackupArrayDim0 _entries;
        private ScriptVarValueTableGroundGetoutBackupArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTableGroundGetoutBackupArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTableGroundGetoutBackupArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
