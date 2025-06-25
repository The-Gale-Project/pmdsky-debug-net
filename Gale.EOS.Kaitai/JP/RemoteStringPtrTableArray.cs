// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array REMOTE_STRING_PTR_TABLE defined within pmdsky.
    /// </summary>
    public partial class RemoteStringPtrTableArray : KaitaiStruct
    {
        public static RemoteStringPtrTableArray FromFile(string fileName)
        {
            return new RemoteStringPtrTableArray(new KaitaiStream(fileName));
        }

        public RemoteStringPtrTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, RemoteStringPtrTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new RemoteStringPtrTableArrayDim0(m_io, this, m_root);
        }
        public partial class RemoteStringPtrTableArrayDim0 : KaitaiStruct
        {
            public static RemoteStringPtrTableArrayDim0 FromFile(string fileName)
            {
                return new RemoteStringPtrTableArrayDim0(new KaitaiStream(fileName));
            }

            public RemoteStringPtrTableArrayDim0(KaitaiStream p__io, RemoteStringPtrTableArray p__parent = null, RemoteStringPtrTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<Pointer>();
                for (var i = 0; i < 7; i++)
                {
                    _entries.Add(new Pointer(m_io));
                }
            }
            private List<Pointer> _entries;
            private RemoteStringPtrTableArray m_root;
            private RemoteStringPtrTableArray m_parent;
            public List<Pointer> Entries { get { return _entries; } }
            public RemoteStringPtrTableArray M_Root { get { return m_root; } }
            public RemoteStringPtrTableArray M_Parent { get { return m_parent; } }
        }
        private RemoteStringPtrTableArrayDim0 _entries;
        private RemoteStringPtrTableArray m_root;
        private KaitaiStruct m_parent;
        public RemoteStringPtrTableArrayDim0 Entries { get { return _entries; } }
        public RemoteStringPtrTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
