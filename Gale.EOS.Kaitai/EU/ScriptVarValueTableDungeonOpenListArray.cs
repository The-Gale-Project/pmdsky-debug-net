// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array script_var_value_table_dungeon_open_list defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTableDungeonOpenListArray : KaitaiStruct
    {
        public static ScriptVarValueTableDungeonOpenListArray FromFile(string fileName)
        {
            return new ScriptVarValueTableDungeonOpenListArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTableDungeonOpenListArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTableDungeonOpenListArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTableDungeonOpenListArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTableDungeonOpenListArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTableDungeonOpenListArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTableDungeonOpenListArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTableDungeonOpenListArrayDim0(KaitaiStream p__io, ScriptVarValueTableDungeonOpenListArray p__parent = null, ScriptVarValueTableDungeonOpenListArray p__root = null) : base(p__io)
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
            private ScriptVarValueTableDungeonOpenListArray m_root;
            private ScriptVarValueTableDungeonOpenListArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public ScriptVarValueTableDungeonOpenListArray M_Root { get { return m_root; } }
            public ScriptVarValueTableDungeonOpenListArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTableDungeonOpenListArrayDim0 _entries;
        private ScriptVarValueTableDungeonOpenListArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTableDungeonOpenListArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTableDungeonOpenListArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
