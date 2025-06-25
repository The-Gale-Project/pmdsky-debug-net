// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array script_var_value_table_world_map_mark_list_normal defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTableWorldMapMarkListNormalArray : KaitaiStruct
    {
        public static ScriptVarValueTableWorldMapMarkListNormalArray FromFile(string fileName)
        {
            return new ScriptVarValueTableWorldMapMarkListNormalArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTableWorldMapMarkListNormalArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTableWorldMapMarkListNormalArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTableWorldMapMarkListNormalArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTableWorldMapMarkListNormalArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTableWorldMapMarkListNormalArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTableWorldMapMarkListNormalArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTableWorldMapMarkListNormalArrayDim0(KaitaiStream p__io, ScriptVarValueTableWorldMapMarkListNormalArray p__parent = null, ScriptVarValueTableWorldMapMarkListNormalArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<byte>();
                for (var i = 0; i < 40; i++)
                {
                    _entries.Add(m_io.ReadU1());
                }
            }
            private List<byte> _entries;
            private ScriptVarValueTableWorldMapMarkListNormalArray m_root;
            private ScriptVarValueTableWorldMapMarkListNormalArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public ScriptVarValueTableWorldMapMarkListNormalArray M_Root { get { return m_root; } }
            public ScriptVarValueTableWorldMapMarkListNormalArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTableWorldMapMarkListNormalArrayDim0 _entries;
        private ScriptVarValueTableWorldMapMarkListNormalArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTableWorldMapMarkListNormalArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTableWorldMapMarkListNormalArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
