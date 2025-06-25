// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array script_var_value_table_position_direction defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTablePositionDirectionArray : KaitaiStruct
    {
        public static ScriptVarValueTablePositionDirectionArray FromFile(string fileName)
        {
            return new ScriptVarValueTablePositionDirectionArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTablePositionDirectionArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTablePositionDirectionArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTablePositionDirectionArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTablePositionDirectionArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTablePositionDirectionArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTablePositionDirectionArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTablePositionDirectionArrayDim0(KaitaiStream p__io, ScriptVarValueTablePositionDirectionArray p__parent = null, ScriptVarValueTablePositionDirectionArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<sbyte>();
                for (var i = 0; i < 3; i++)
                {
                    _entries.Add(m_io.ReadS1());
                }
            }
            private List<sbyte> _entries;
            private ScriptVarValueTablePositionDirectionArray m_root;
            private ScriptVarValueTablePositionDirectionArray m_parent;
            public List<sbyte> Entries { get { return _entries; } }
            public ScriptVarValueTablePositionDirectionArray M_Root { get { return m_root; } }
            public ScriptVarValueTablePositionDirectionArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTablePositionDirectionArrayDim0 _entries;
        private ScriptVarValueTablePositionDirectionArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTablePositionDirectionArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTablePositionDirectionArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
