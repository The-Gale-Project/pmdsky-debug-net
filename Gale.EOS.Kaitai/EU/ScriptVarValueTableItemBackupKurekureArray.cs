// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array script_var_value_table_item_backup_kurekure defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTableItemBackupKurekureArray : KaitaiStruct
    {
        public static ScriptVarValueTableItemBackupKurekureArray FromFile(string fileName)
        {
            return new ScriptVarValueTableItemBackupKurekureArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTableItemBackupKurekureArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTableItemBackupKurekureArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTableItemBackupKurekureArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTableItemBackupKurekureArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTableItemBackupKurekureArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTableItemBackupKurekureArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTableItemBackupKurekureArrayDim0(KaitaiStream p__io, ScriptVarValueTableItemBackupKurekureArray p__parent = null, ScriptVarValueTableItemBackupKurekureArray p__root = null) : base(p__io)
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
            private ScriptVarValueTableItemBackupKurekureArray m_root;
            private ScriptVarValueTableItemBackupKurekureArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public ScriptVarValueTableItemBackupKurekureArray M_Root { get { return m_root; } }
            public ScriptVarValueTableItemBackupKurekureArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTableItemBackupKurekureArrayDim0 _entries;
        private ScriptVarValueTableItemBackupKurekureArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTableItemBackupKurekureArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTableItemBackupKurekureArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
