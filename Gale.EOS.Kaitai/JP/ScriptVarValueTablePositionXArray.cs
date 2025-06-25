// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array script_var_value_table_position_x defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTablePositionXArray : KaitaiStruct
    {
        public static ScriptVarValueTablePositionXArray FromFile(string fileName)
        {
            return new ScriptVarValueTablePositionXArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTablePositionXArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTablePositionXArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTablePositionXArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTablePositionXArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTablePositionXArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTablePositionXArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTablePositionXArrayDim0(KaitaiStream p__io, ScriptVarValueTablePositionXArray p__parent = null, ScriptVarValueTablePositionXArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<uint>();
                for (var i = 0; i < 3; i++)
                {
                    _entries.Add(m_io.ReadU4le());
                }
            }
            private List<uint> _entries;
            private ScriptVarValueTablePositionXArray m_root;
            private ScriptVarValueTablePositionXArray m_parent;
            public List<uint> Entries { get { return _entries; } }
            public ScriptVarValueTablePositionXArray M_Root { get { return m_root; } }
            public ScriptVarValueTablePositionXArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTablePositionXArrayDim0 _entries;
        private ScriptVarValueTablePositionXArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTablePositionXArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTablePositionXArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
