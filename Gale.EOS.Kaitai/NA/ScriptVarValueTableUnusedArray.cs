// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array script_var_value_table_unused defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTableUnusedArray : KaitaiStruct
    {
        public static ScriptVarValueTableUnusedArray FromFile(string fileName)
        {
            return new ScriptVarValueTableUnusedArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTableUnusedArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTableUnusedArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTableUnusedArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTableUnusedArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTableUnusedArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTableUnusedArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTableUnusedArrayDim0(KaitaiStream p__io, ScriptVarValueTableUnusedArray p__parent = null, ScriptVarValueTableUnusedArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<byte>();
                for (var i = 0; i < 332; i++)
                {
                    _entries.Add(m_io.ReadU1());
                }
            }
            private List<byte> _entries;
            private ScriptVarValueTableUnusedArray m_root;
            private ScriptVarValueTableUnusedArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public ScriptVarValueTableUnusedArray M_Root { get { return m_root; } }
            public ScriptVarValueTableUnusedArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTableUnusedArrayDim0 _entries;
        private ScriptVarValueTableUnusedArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTableUnusedArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTableUnusedArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
