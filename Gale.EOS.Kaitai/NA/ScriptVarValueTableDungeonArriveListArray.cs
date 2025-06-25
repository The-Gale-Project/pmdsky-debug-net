// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array script_var_value_table_dungeon_arrive_list defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTableDungeonArriveListArray : KaitaiStruct
    {
        public static ScriptVarValueTableDungeonArriveListArray FromFile(string fileName)
        {
            return new ScriptVarValueTableDungeonArriveListArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTableDungeonArriveListArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTableDungeonArriveListArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTableDungeonArriveListArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTableDungeonArriveListArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTableDungeonArriveListArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTableDungeonArriveListArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTableDungeonArriveListArrayDim0(KaitaiStream p__io, ScriptVarValueTableDungeonArriveListArray p__parent = null, ScriptVarValueTableDungeonArriveListArray p__root = null) : base(p__io)
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
            private ScriptVarValueTableDungeonArriveListArray m_root;
            private ScriptVarValueTableDungeonArriveListArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public ScriptVarValueTableDungeonArriveListArray M_Root { get { return m_root; } }
            public ScriptVarValueTableDungeonArriveListArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTableDungeonArriveListArrayDim0 _entries;
        private ScriptVarValueTableDungeonArriveListArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTableDungeonArriveListArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTableDungeonArriveListArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
