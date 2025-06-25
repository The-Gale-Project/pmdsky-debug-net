// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array script_var_value_table_partner_first_name defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTablePartnerFirstNameArray : KaitaiStruct
    {
        public static ScriptVarValueTablePartnerFirstNameArray FromFile(string fileName)
        {
            return new ScriptVarValueTablePartnerFirstNameArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTablePartnerFirstNameArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTablePartnerFirstNameArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTablePartnerFirstNameArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTablePartnerFirstNameArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTablePartnerFirstNameArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTablePartnerFirstNameArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTablePartnerFirstNameArrayDim0(KaitaiStream p__io, ScriptVarValueTablePartnerFirstNameArray p__parent = null, ScriptVarValueTablePartnerFirstNameArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<sbyte>();
                for (var i = 0; i < 10; i++)
                {
                    _entries.Add(m_io.ReadS1());
                }
            }
            private List<sbyte> _entries;
            private ScriptVarValueTablePartnerFirstNameArray m_root;
            private ScriptVarValueTablePartnerFirstNameArray m_parent;
            public List<sbyte> Entries { get { return _entries; } }
            public ScriptVarValueTablePartnerFirstNameArray M_Root { get { return m_root; } }
            public ScriptVarValueTablePartnerFirstNameArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTablePartnerFirstNameArrayDim0 _entries;
        private ScriptVarValueTablePartnerFirstNameArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTablePartnerFirstNameArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTablePartnerFirstNameArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
