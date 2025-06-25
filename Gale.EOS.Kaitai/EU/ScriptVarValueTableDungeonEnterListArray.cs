// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array script_var_value_table_dungeon_enter_list defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTableDungeonEnterListArray : KaitaiStruct
    {
        public static ScriptVarValueTableDungeonEnterListArray FromFile(string fileName)
        {
            return new ScriptVarValueTableDungeonEnterListArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTableDungeonEnterListArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTableDungeonEnterListArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTableDungeonEnterListArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTableDungeonEnterListArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTableDungeonEnterListArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTableDungeonEnterListArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTableDungeonEnterListArrayDim0(KaitaiStream p__io, ScriptVarValueTableDungeonEnterListArray p__parent = null, ScriptVarValueTableDungeonEnterListArray p__root = null) : base(p__io)
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
            private ScriptVarValueTableDungeonEnterListArray m_root;
            private ScriptVarValueTableDungeonEnterListArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public ScriptVarValueTableDungeonEnterListArray M_Root { get { return m_root; } }
            public ScriptVarValueTableDungeonEnterListArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTableDungeonEnterListArrayDim0 _entries;
        private ScriptVarValueTableDungeonEnterListArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTableDungeonEnterListArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTableDungeonEnterListArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
