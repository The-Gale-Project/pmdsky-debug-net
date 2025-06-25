// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array OVERLAY17_FUNCTION_POINTER_TABLE defined within pmdsky.
    /// </summary>
    public partial class Overlay17FunctionPointerTableArray : KaitaiStruct
    {
        public static Overlay17FunctionPointerTableArray FromFile(string fileName)
        {
            return new Overlay17FunctionPointerTableArray(new KaitaiStream(fileName));
        }

        public Overlay17FunctionPointerTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay17FunctionPointerTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new Overlay17FunctionPointerTableArrayDim0(m_io, this, m_root);
        }
        public partial class Overlay17FunctionPointerTableArrayDim0 : KaitaiStruct
        {
            public static Overlay17FunctionPointerTableArrayDim0 FromFile(string fileName)
            {
                return new Overlay17FunctionPointerTableArrayDim0(new KaitaiStream(fileName));
            }

            public Overlay17FunctionPointerTableArrayDim0(KaitaiStream p__io, Overlay17FunctionPointerTableArray p__parent = null, Overlay17FunctionPointerTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<Pointer>();
                for (var i = 0; i < 42; i++)
                {
                    _entries.Add(new Pointer(m_io));
                }
            }
            private List<Pointer> _entries;
            private Overlay17FunctionPointerTableArray m_root;
            private Overlay17FunctionPointerTableArray m_parent;
            public List<Pointer> Entries { get { return _entries; } }
            public Overlay17FunctionPointerTableArray M_Root { get { return m_root; } }
            public Overlay17FunctionPointerTableArray M_Parent { get { return m_parent; } }
        }
        private Overlay17FunctionPointerTableArrayDim0 _entries;
        private Overlay17FunctionPointerTableArray m_root;
        private KaitaiStruct m_parent;
        public Overlay17FunctionPointerTableArrayDim0 Entries { get { return _entries; } }
        public Overlay17FunctionPointerTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
