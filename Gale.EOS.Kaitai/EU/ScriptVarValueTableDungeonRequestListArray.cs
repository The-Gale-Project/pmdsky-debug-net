// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array script_var_value_table_dungeon_request_list defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTableDungeonRequestListArray : KaitaiStruct
    {
        public static ScriptVarValueTableDungeonRequestListArray FromFile(string fileName)
        {
            return new ScriptVarValueTableDungeonRequestListArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTableDungeonRequestListArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTableDungeonRequestListArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTableDungeonRequestListArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTableDungeonRequestListArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTableDungeonRequestListArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTableDungeonRequestListArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTableDungeonRequestListArrayDim0(KaitaiStream p__io, ScriptVarValueTableDungeonRequestListArray p__parent = null, ScriptVarValueTableDungeonRequestListArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<byte>();
                for (var i = 0; i < 32; i++)
                {
                    _entries.Add(m_io.ReadU1());
                }
            }
            private List<byte> _entries;
            private ScriptVarValueTableDungeonRequestListArray m_root;
            private ScriptVarValueTableDungeonRequestListArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public ScriptVarValueTableDungeonRequestListArray M_Root { get { return m_root; } }
            public ScriptVarValueTableDungeonRequestListArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTableDungeonRequestListArrayDim0 _entries;
        private ScriptVarValueTableDungeonRequestListArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTableDungeonRequestListArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTableDungeonRequestListArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
