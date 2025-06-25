// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array script_var_value_table_hero_first_name defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTableHeroFirstNameArray : KaitaiStruct
    {
        public static ScriptVarValueTableHeroFirstNameArray FromFile(string fileName)
        {
            return new ScriptVarValueTableHeroFirstNameArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTableHeroFirstNameArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTableHeroFirstNameArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTableHeroFirstNameArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTableHeroFirstNameArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTableHeroFirstNameArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTableHeroFirstNameArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTableHeroFirstNameArrayDim0(KaitaiStream p__io, ScriptVarValueTableHeroFirstNameArray p__parent = null, ScriptVarValueTableHeroFirstNameArray p__root = null) : base(p__io)
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
            private ScriptVarValueTableHeroFirstNameArray m_root;
            private ScriptVarValueTableHeroFirstNameArray m_parent;
            public List<sbyte> Entries { get { return _entries; } }
            public ScriptVarValueTableHeroFirstNameArray M_Root { get { return m_root; } }
            public ScriptVarValueTableHeroFirstNameArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTableHeroFirstNameArrayDim0 _entries;
        private ScriptVarValueTableHeroFirstNameArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTableHeroFirstNameArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTableHeroFirstNameArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
