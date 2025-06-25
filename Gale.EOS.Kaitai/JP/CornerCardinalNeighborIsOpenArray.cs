// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array CORNER_CARDINAL_NEIGHBOR_IS_OPEN defined within pmdsky.
    /// </summary>
    public partial class CornerCardinalNeighborIsOpenArray : KaitaiStruct
    {
        public static CornerCardinalNeighborIsOpenArray FromFile(string fileName)
        {
            return new CornerCardinalNeighborIsOpenArray(new KaitaiStream(fileName));
        }

        public CornerCardinalNeighborIsOpenArray(KaitaiStream p__io, KaitaiStruct p__parent = null, CornerCardinalNeighborIsOpenArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new CornerCardinalNeighborIsOpenArrayDim1(m_io, this, m_root);
        }
        public partial class CornerCardinalNeighborIsOpenArrayDim0 : KaitaiStruct
        {
            public static CornerCardinalNeighborIsOpenArrayDim0 FromFile(string fileName)
            {
                return new CornerCardinalNeighborIsOpenArrayDim0(new KaitaiStream(fileName));
            }

            public CornerCardinalNeighborIsOpenArrayDim0(KaitaiStream p__io, CornerCardinalNeighborIsOpenArray.CornerCardinalNeighborIsOpenArrayDim1 p__parent = null, CornerCardinalNeighborIsOpenArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<byte>();
                for (var i = 0; i < 8; i++)
                {
                    _entries.Add(m_io.ReadU1());
                }
            }
            private List<byte> _entries;
            private CornerCardinalNeighborIsOpenArray m_root;
            private CornerCardinalNeighborIsOpenArray.CornerCardinalNeighborIsOpenArrayDim1 m_parent;
            public List<byte> Entries { get { return _entries; } }
            public CornerCardinalNeighborIsOpenArray M_Root { get { return m_root; } }
            public CornerCardinalNeighborIsOpenArray.CornerCardinalNeighborIsOpenArrayDim1 M_Parent { get { return m_parent; } }
        }
        public partial class CornerCardinalNeighborIsOpenArrayDim1 : KaitaiStruct
        {
            public static CornerCardinalNeighborIsOpenArrayDim1 FromFile(string fileName)
            {
                return new CornerCardinalNeighborIsOpenArrayDim1(new KaitaiStream(fileName));
            }

            public CornerCardinalNeighborIsOpenArrayDim1(KaitaiStream p__io, CornerCardinalNeighborIsOpenArray p__parent = null, CornerCardinalNeighborIsOpenArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<CornerCardinalNeighborIsOpenArrayDim0>();
                for (var i = 0; i < 4; i++)
                {
                    _entries.Add(new CornerCardinalNeighborIsOpenArrayDim0(m_io, this, m_root));
                }
            }
            private List<CornerCardinalNeighborIsOpenArrayDim0> _entries;
            private CornerCardinalNeighborIsOpenArray m_root;
            private CornerCardinalNeighborIsOpenArray m_parent;
            public List<CornerCardinalNeighborIsOpenArrayDim0> Entries { get { return _entries; } }
            public CornerCardinalNeighborIsOpenArray M_Root { get { return m_root; } }
            public CornerCardinalNeighborIsOpenArray M_Parent { get { return m_parent; } }
        }
        private CornerCardinalNeighborIsOpenArrayDim1 _entries;
        private CornerCardinalNeighborIsOpenArray m_root;
        private KaitaiStruct m_parent;
        public CornerCardinalNeighborIsOpenArrayDim1 Entries { get { return _entries; } }
        public CornerCardinalNeighborIsOpenArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
