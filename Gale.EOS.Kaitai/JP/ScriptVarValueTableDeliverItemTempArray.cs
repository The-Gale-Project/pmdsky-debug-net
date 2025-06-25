// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array script_var_value_table_deliver_item_temp defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTableDeliverItemTempArray : KaitaiStruct
    {
        public static ScriptVarValueTableDeliverItemTempArray FromFile(string fileName)
        {
            return new ScriptVarValueTableDeliverItemTempArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTableDeliverItemTempArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTableDeliverItemTempArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTableDeliverItemTempArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTableDeliverItemTempArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTableDeliverItemTempArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTableDeliverItemTempArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTableDeliverItemTempArrayDim0(KaitaiStream p__io, ScriptVarValueTableDeliverItemTempArray p__parent = null, ScriptVarValueTableDeliverItemTempArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<byte>();
                for (var i = 0; i < 2; i++)
                {
                    _entries.Add(m_io.ReadU1());
                }
            }
            private List<byte> _entries;
            private ScriptVarValueTableDeliverItemTempArray m_root;
            private ScriptVarValueTableDeliverItemTempArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public ScriptVarValueTableDeliverItemTempArray M_Root { get { return m_root; } }
            public ScriptVarValueTableDeliverItemTempArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTableDeliverItemTempArrayDim0 _entries;
        private ScriptVarValueTableDeliverItemTempArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTableDeliverItemTempArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTableDeliverItemTempArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
