// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array OVERLAY18_FUNCTION_POINTER_TABLE defined within pmdsky.
    /// </summary>
    public partial class Overlay18FunctionPointerTableArray : KaitaiStruct
    {
        public static Overlay18FunctionPointerTableArray FromFile(string fileName)
        {
            return new Overlay18FunctionPointerTableArray(new KaitaiStream(fileName));
        }

        public Overlay18FunctionPointerTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay18FunctionPointerTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new Overlay18FunctionPointerTableArrayDim0(m_io, this, m_root);
        }
        public partial class Overlay18FunctionPointerTableArrayDim0 : KaitaiStruct
        {
            public static Overlay18FunctionPointerTableArrayDim0 FromFile(string fileName)
            {
                return new Overlay18FunctionPointerTableArrayDim0(new KaitaiStream(fileName));
            }

            public Overlay18FunctionPointerTableArrayDim0(KaitaiStream p__io, Overlay18FunctionPointerTableArray p__parent = null, Overlay18FunctionPointerTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<Pointer>();
                for (var i = 0; i < 76; i++)
                {
                    _entries.Add(new Pointer(m_io));
                }
            }
            private List<Pointer> _entries;
            private Overlay18FunctionPointerTableArray m_root;
            private Overlay18FunctionPointerTableArray m_parent;
            public List<Pointer> Entries { get { return _entries; } }
            public Overlay18FunctionPointerTableArray M_Root { get { return m_root; } }
            public Overlay18FunctionPointerTableArray M_Parent { get { return m_parent; } }
        }
        private Overlay18FunctionPointerTableArrayDim0 _entries;
        private Overlay18FunctionPointerTableArray m_root;
        private KaitaiStruct m_parent;
        public Overlay18FunctionPointerTableArrayDim0 Entries { get { return _entries; } }
        public Overlay18FunctionPointerTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
