// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array script_var_value_table_position_height defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTablePositionHeightArray : KaitaiStruct
    {
        public static ScriptVarValueTablePositionHeightArray FromFile(string fileName)
        {
            return new ScriptVarValueTablePositionHeightArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTablePositionHeightArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTablePositionHeightArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTablePositionHeightArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTablePositionHeightArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTablePositionHeightArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTablePositionHeightArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTablePositionHeightArrayDim0(KaitaiStream p__io, ScriptVarValueTablePositionHeightArray p__parent = null, ScriptVarValueTablePositionHeightArray p__root = null) : base(p__io)
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
            private ScriptVarValueTablePositionHeightArray m_root;
            private ScriptVarValueTablePositionHeightArray m_parent;
            public List<uint> Entries { get { return _entries; } }
            public ScriptVarValueTablePositionHeightArray M_Root { get { return m_root; } }
            public ScriptVarValueTablePositionHeightArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTablePositionHeightArrayDim0 _entries;
        private ScriptVarValueTablePositionHeightArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTablePositionHeightArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTablePositionHeightArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
