// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array script_var_value_table_ground_enter_link_backup defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTableGroundEnterLinkBackupArray : KaitaiStruct
    {
        public static ScriptVarValueTableGroundEnterLinkBackupArray FromFile(string fileName)
        {
            return new ScriptVarValueTableGroundEnterLinkBackupArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTableGroundEnterLinkBackupArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTableGroundEnterLinkBackupArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTableGroundEnterLinkBackupArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTableGroundEnterLinkBackupArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTableGroundEnterLinkBackupArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTableGroundEnterLinkBackupArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTableGroundEnterLinkBackupArrayDim0(KaitaiStream p__io, ScriptVarValueTableGroundEnterLinkBackupArray p__parent = null, ScriptVarValueTableGroundEnterLinkBackupArray p__root = null) : base(p__io)
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
            private ScriptVarValueTableGroundEnterLinkBackupArray m_root;
            private ScriptVarValueTableGroundEnterLinkBackupArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public ScriptVarValueTableGroundEnterLinkBackupArray M_Root { get { return m_root; } }
            public ScriptVarValueTableGroundEnterLinkBackupArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTableGroundEnterLinkBackupArrayDim0 _entries;
        private ScriptVarValueTableGroundEnterLinkBackupArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTableGroundEnterLinkBackupArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTableGroundEnterLinkBackupArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
