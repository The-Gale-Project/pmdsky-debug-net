// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array script_var_value_table_station_item_static defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTableStationItemStaticArray : KaitaiStruct
    {
        public static ScriptVarValueTableStationItemStaticArray FromFile(string fileName)
        {
            return new ScriptVarValueTableStationItemStaticArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTableStationItemStaticArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTableStationItemStaticArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTableStationItemStaticArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTableStationItemStaticArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTableStationItemStaticArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTableStationItemStaticArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTableStationItemStaticArrayDim0(KaitaiStream p__io, ScriptVarValueTableStationItemStaticArray p__parent = null, ScriptVarValueTableStationItemStaticArray p__root = null) : base(p__io)
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
            private ScriptVarValueTableStationItemStaticArray m_root;
            private ScriptVarValueTableStationItemStaticArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public ScriptVarValueTableStationItemStaticArray M_Root { get { return m_root; } }
            public ScriptVarValueTableStationItemStaticArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTableStationItemStaticArrayDim0 _entries;
        private ScriptVarValueTableStationItemStaticArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTableStationItemStaticArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTableStationItemStaticArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
