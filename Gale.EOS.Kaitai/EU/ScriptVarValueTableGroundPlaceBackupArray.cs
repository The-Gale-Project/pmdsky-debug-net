// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array script_var_value_table_ground_place_backup defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTableGroundPlaceBackupArray : KaitaiStruct
    {
        public static ScriptVarValueTableGroundPlaceBackupArray FromFile(string fileName)
        {
            return new ScriptVarValueTableGroundPlaceBackupArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTableGroundPlaceBackupArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTableGroundPlaceBackupArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTableGroundPlaceBackupArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTableGroundPlaceBackupArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTableGroundPlaceBackupArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTableGroundPlaceBackupArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTableGroundPlaceBackupArrayDim0(KaitaiStream p__io, ScriptVarValueTableGroundPlaceBackupArray p__parent = null, ScriptVarValueTableGroundPlaceBackupArray p__root = null) : base(p__io)
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
            private ScriptVarValueTableGroundPlaceBackupArray m_root;
            private ScriptVarValueTableGroundPlaceBackupArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public ScriptVarValueTableGroundPlaceBackupArray M_Root { get { return m_root; } }
            public ScriptVarValueTableGroundPlaceBackupArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTableGroundPlaceBackupArrayDim0 _entries;
        private ScriptVarValueTableGroundPlaceBackupArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTableGroundPlaceBackupArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTableGroundPlaceBackupArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
