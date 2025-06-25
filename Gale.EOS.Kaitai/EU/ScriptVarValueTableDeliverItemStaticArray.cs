// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array script_var_value_table_deliver_item_static defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTableDeliverItemStaticArray : KaitaiStruct
    {
        public static ScriptVarValueTableDeliverItemStaticArray FromFile(string fileName)
        {
            return new ScriptVarValueTableDeliverItemStaticArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTableDeliverItemStaticArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTableDeliverItemStaticArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTableDeliverItemStaticArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTableDeliverItemStaticArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTableDeliverItemStaticArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTableDeliverItemStaticArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTableDeliverItemStaticArrayDim0(KaitaiStream p__io, ScriptVarValueTableDeliverItemStaticArray p__parent = null, ScriptVarValueTableDeliverItemStaticArray p__root = null) : base(p__io)
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
            private ScriptVarValueTableDeliverItemStaticArray m_root;
            private ScriptVarValueTableDeliverItemStaticArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public ScriptVarValueTableDeliverItemStaticArray M_Root { get { return m_root; } }
            public ScriptVarValueTableDeliverItemStaticArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTableDeliverItemStaticArrayDim0 _entries;
        private ScriptVarValueTableDeliverItemStaticArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTableDeliverItemStaticArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTableDeliverItemStaticArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
