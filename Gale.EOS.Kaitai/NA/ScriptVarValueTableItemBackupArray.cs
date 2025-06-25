// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array script_var_value_table_item_backup defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTableItemBackupArray : KaitaiStruct
    {
        public static ScriptVarValueTableItemBackupArray FromFile(string fileName)
        {
            return new ScriptVarValueTableItemBackupArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTableItemBackupArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTableItemBackupArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTableItemBackupArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTableItemBackupArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTableItemBackupArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTableItemBackupArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTableItemBackupArrayDim0(KaitaiStream p__io, ScriptVarValueTableItemBackupArray p__parent = null, ScriptVarValueTableItemBackupArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<short>();
                for (var i = 0; i < 2; i++)
                {
                    _entries.Add(m_io.ReadS2le());
                }
            }
            private List<short> _entries;
            private ScriptVarValueTableItemBackupArray m_root;
            private ScriptVarValueTableItemBackupArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public ScriptVarValueTableItemBackupArray M_Root { get { return m_root; } }
            public ScriptVarValueTableItemBackupArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTableItemBackupArrayDim0 _entries;
        private ScriptVarValueTableItemBackupArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTableItemBackupArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTableItemBackupArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
