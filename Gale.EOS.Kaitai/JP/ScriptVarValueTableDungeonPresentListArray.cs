// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array script_var_value_table_dungeon_present_list defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTableDungeonPresentListArray : KaitaiStruct
    {
        public static ScriptVarValueTableDungeonPresentListArray FromFile(string fileName)
        {
            return new ScriptVarValueTableDungeonPresentListArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTableDungeonPresentListArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTableDungeonPresentListArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTableDungeonPresentListArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTableDungeonPresentListArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTableDungeonPresentListArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTableDungeonPresentListArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTableDungeonPresentListArrayDim0(KaitaiStream p__io, ScriptVarValueTableDungeonPresentListArray p__parent = null, ScriptVarValueTableDungeonPresentListArray p__root = null) : base(p__io)
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
            private ScriptVarValueTableDungeonPresentListArray m_root;
            private ScriptVarValueTableDungeonPresentListArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public ScriptVarValueTableDungeonPresentListArray M_Root { get { return m_root; } }
            public ScriptVarValueTableDungeonPresentListArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTableDungeonPresentListArrayDim0 _entries;
        private ScriptVarValueTableDungeonPresentListArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTableDungeonPresentListArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTableDungeonPresentListArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
