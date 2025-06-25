// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array script_var_value_table_position_y defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTablePositionYArray : KaitaiStruct
    {
        public static ScriptVarValueTablePositionYArray FromFile(string fileName)
        {
            return new ScriptVarValueTablePositionYArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTablePositionYArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTablePositionYArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTablePositionYArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTablePositionYArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTablePositionYArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTablePositionYArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTablePositionYArrayDim0(KaitaiStream p__io, ScriptVarValueTablePositionYArray p__parent = null, ScriptVarValueTablePositionYArray p__root = null) : base(p__io)
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
            private ScriptVarValueTablePositionYArray m_root;
            private ScriptVarValueTablePositionYArray m_parent;
            public List<uint> Entries { get { return _entries; } }
            public ScriptVarValueTablePositionYArray M_Root { get { return m_root; } }
            public ScriptVarValueTablePositionYArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTablePositionYArrayDim0 _entries;
        private ScriptVarValueTablePositionYArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTablePositionYArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTablePositionYArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
