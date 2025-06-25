// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array script_var_value_table_item_backup_take defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTableItemBackupTakeArray : KaitaiStruct
    {
        public static ScriptVarValueTableItemBackupTakeArray FromFile(string fileName)
        {
            return new ScriptVarValueTableItemBackupTakeArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTableItemBackupTakeArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTableItemBackupTakeArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTableItemBackupTakeArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTableItemBackupTakeArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTableItemBackupTakeArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTableItemBackupTakeArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTableItemBackupTakeArrayDim0(KaitaiStream p__io, ScriptVarValueTableItemBackupTakeArray p__parent = null, ScriptVarValueTableItemBackupTakeArray p__root = null) : base(p__io)
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
            private ScriptVarValueTableItemBackupTakeArray m_root;
            private ScriptVarValueTableItemBackupTakeArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public ScriptVarValueTableItemBackupTakeArray M_Root { get { return m_root; } }
            public ScriptVarValueTableItemBackupTakeArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTableItemBackupTakeArrayDim0 _entries;
        private ScriptVarValueTableItemBackupTakeArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTableItemBackupTakeArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTableItemBackupTakeArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
