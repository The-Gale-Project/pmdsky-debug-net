// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array script_var_value_table_ground_map_backup defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTableGroundMapBackupArray : KaitaiStruct
    {
        public static ScriptVarValueTableGroundMapBackupArray FromFile(string fileName)
        {
            return new ScriptVarValueTableGroundMapBackupArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTableGroundMapBackupArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTableGroundMapBackupArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTableGroundMapBackupArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTableGroundMapBackupArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTableGroundMapBackupArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTableGroundMapBackupArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTableGroundMapBackupArrayDim0(KaitaiStream p__io, ScriptVarValueTableGroundMapBackupArray p__parent = null, ScriptVarValueTableGroundMapBackupArray p__root = null) : base(p__io)
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
            private ScriptVarValueTableGroundMapBackupArray m_root;
            private ScriptVarValueTableGroundMapBackupArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public ScriptVarValueTableGroundMapBackupArray M_Root { get { return m_root; } }
            public ScriptVarValueTableGroundMapBackupArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTableGroundMapBackupArrayDim0 _entries;
        private ScriptVarValueTableGroundMapBackupArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTableGroundMapBackupArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTableGroundMapBackupArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
