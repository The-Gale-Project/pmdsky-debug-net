// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array script_var_value_table_ground_enter_backup defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTableGroundEnterBackupArray : KaitaiStruct
    {
        public static ScriptVarValueTableGroundEnterBackupArray FromFile(string fileName)
        {
            return new ScriptVarValueTableGroundEnterBackupArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTableGroundEnterBackupArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTableGroundEnterBackupArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTableGroundEnterBackupArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTableGroundEnterBackupArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTableGroundEnterBackupArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTableGroundEnterBackupArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTableGroundEnterBackupArrayDim0(KaitaiStream p__io, ScriptVarValueTableGroundEnterBackupArray p__parent = null, ScriptVarValueTableGroundEnterBackupArray p__root = null) : base(p__io)
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
            private ScriptVarValueTableGroundEnterBackupArray m_root;
            private ScriptVarValueTableGroundEnterBackupArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public ScriptVarValueTableGroundEnterBackupArray M_Root { get { return m_root; } }
            public ScriptVarValueTableGroundEnterBackupArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTableGroundEnterBackupArrayDim0 _entries;
        private ScriptVarValueTableGroundEnterBackupArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTableGroundEnterBackupArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTableGroundEnterBackupArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
