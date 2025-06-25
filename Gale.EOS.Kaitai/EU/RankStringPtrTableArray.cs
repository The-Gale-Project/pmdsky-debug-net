// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array RANK_STRING_PTR_TABLE defined within pmdsky.
    /// </summary>
    public partial class RankStringPtrTableArray : KaitaiStruct
    {
        public static RankStringPtrTableArray FromFile(string fileName)
        {
            return new RankStringPtrTableArray(new KaitaiStream(fileName));
        }

        public RankStringPtrTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, RankStringPtrTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new RankStringPtrTableArrayDim0(m_io, this, m_root);
        }
        public partial class RankStringPtrTableArrayDim0 : KaitaiStruct
        {
            public static RankStringPtrTableArrayDim0 FromFile(string fileName)
            {
                return new RankStringPtrTableArrayDim0(new KaitaiStream(fileName));
            }

            public RankStringPtrTableArrayDim0(KaitaiStream p__io, RankStringPtrTableArray p__parent = null, RankStringPtrTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<Pointer>();
                for (var i = 0; i < 16; i++)
                {
                    _entries.Add(new Pointer(m_io));
                }
            }
            private List<Pointer> _entries;
            private RankStringPtrTableArray m_root;
            private RankStringPtrTableArray m_parent;
            public List<Pointer> Entries { get { return _entries; } }
            public RankStringPtrTableArray M_Root { get { return m_root; } }
            public RankStringPtrTableArray M_Parent { get { return m_parent; } }
        }
        private RankStringPtrTableArrayDim0 _entries;
        private RankStringPtrTableArray m_root;
        private KaitaiStruct m_parent;
        public RankStringPtrTableArrayDim0 Entries { get { return _entries; } }
        public RankStringPtrTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
