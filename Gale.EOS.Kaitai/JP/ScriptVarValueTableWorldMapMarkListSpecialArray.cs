// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array script_var_value_table_world_map_mark_list_special defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTableWorldMapMarkListSpecialArray : KaitaiStruct
    {
        public static ScriptVarValueTableWorldMapMarkListSpecialArray FromFile(string fileName)
        {
            return new ScriptVarValueTableWorldMapMarkListSpecialArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTableWorldMapMarkListSpecialArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTableWorldMapMarkListSpecialArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTableWorldMapMarkListSpecialArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTableWorldMapMarkListSpecialArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTableWorldMapMarkListSpecialArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTableWorldMapMarkListSpecialArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTableWorldMapMarkListSpecialArrayDim0(KaitaiStream p__io, ScriptVarValueTableWorldMapMarkListSpecialArray p__parent = null, ScriptVarValueTableWorldMapMarkListSpecialArray p__root = null) : base(p__io)
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
            private ScriptVarValueTableWorldMapMarkListSpecialArray m_root;
            private ScriptVarValueTableWorldMapMarkListSpecialArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public ScriptVarValueTableWorldMapMarkListSpecialArray M_Root { get { return m_root; } }
            public ScriptVarValueTableWorldMapMarkListSpecialArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTableWorldMapMarkListSpecialArrayDim0 _entries;
        private ScriptVarValueTableWorldMapMarkListSpecialArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTableWorldMapMarkListSpecialArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTableWorldMapMarkListSpecialArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
