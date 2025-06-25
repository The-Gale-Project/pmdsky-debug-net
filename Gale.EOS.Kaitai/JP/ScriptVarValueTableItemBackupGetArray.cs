// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array script_var_value_table_item_backup_get defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTableItemBackupGetArray : KaitaiStruct
    {
        public static ScriptVarValueTableItemBackupGetArray FromFile(string fileName)
        {
            return new ScriptVarValueTableItemBackupGetArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTableItemBackupGetArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTableItemBackupGetArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTableItemBackupGetArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTableItemBackupGetArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTableItemBackupGetArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTableItemBackupGetArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTableItemBackupGetArrayDim0(KaitaiStream p__io, ScriptVarValueTableItemBackupGetArray p__parent = null, ScriptVarValueTableItemBackupGetArray p__root = null) : base(p__io)
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
            private ScriptVarValueTableItemBackupGetArray m_root;
            private ScriptVarValueTableItemBackupGetArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public ScriptVarValueTableItemBackupGetArray M_Root { get { return m_root; } }
            public ScriptVarValueTableItemBackupGetArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTableItemBackupGetArrayDim0 _entries;
        private ScriptVarValueTableItemBackupGetArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTableItemBackupGetArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTableItemBackupGetArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
