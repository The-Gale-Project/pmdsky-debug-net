// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array script_var_value_table_station_item_temp defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTableStationItemTempArray : KaitaiStruct
    {
        public static ScriptVarValueTableStationItemTempArray FromFile(string fileName)
        {
            return new ScriptVarValueTableStationItemTempArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTableStationItemTempArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTableStationItemTempArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTableStationItemTempArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTableStationItemTempArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTableStationItemTempArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTableStationItemTempArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTableStationItemTempArrayDim0(KaitaiStream p__io, ScriptVarValueTableStationItemTempArray p__parent = null, ScriptVarValueTableStationItemTempArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<byte>();
                for (var i = 0; i < 4; i++)
                {
                    _entries.Add(m_io.ReadU1());
                }
            }
            private List<byte> _entries;
            private ScriptVarValueTableStationItemTempArray m_root;
            private ScriptVarValueTableStationItemTempArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public ScriptVarValueTableStationItemTempArray M_Root { get { return m_root; } }
            public ScriptVarValueTableStationItemTempArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTableStationItemTempArrayDim0 _entries;
        private ScriptVarValueTableStationItemTempArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTableStationItemTempArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTableStationItemTempArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
