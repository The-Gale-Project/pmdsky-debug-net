// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array script_var_value_table_dungeon_conquest_list defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTableDungeonConquestListArray : KaitaiStruct
    {
        public static ScriptVarValueTableDungeonConquestListArray FromFile(string fileName)
        {
            return new ScriptVarValueTableDungeonConquestListArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTableDungeonConquestListArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTableDungeonConquestListArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTableDungeonConquestListArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTableDungeonConquestListArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTableDungeonConquestListArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTableDungeonConquestListArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTableDungeonConquestListArrayDim0(KaitaiStream p__io, ScriptVarValueTableDungeonConquestListArray p__parent = null, ScriptVarValueTableDungeonConquestListArray p__root = null) : base(p__io)
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
            private ScriptVarValueTableDungeonConquestListArray m_root;
            private ScriptVarValueTableDungeonConquestListArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public ScriptVarValueTableDungeonConquestListArray M_Root { get { return m_root; } }
            public ScriptVarValueTableDungeonConquestListArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTableDungeonConquestListArrayDim0 _entries;
        private ScriptVarValueTableDungeonConquestListArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTableDungeonConquestListArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTableDungeonConquestListArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
