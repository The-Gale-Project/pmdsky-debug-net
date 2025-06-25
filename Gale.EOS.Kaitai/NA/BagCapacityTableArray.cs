// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array BAG_CAPACITY_TABLE defined within pmdsky.
    /// </summary>
    public partial class BagCapacityTableArray : KaitaiStruct
    {
        public static BagCapacityTableArray FromFile(string fileName)
        {
            return new BagCapacityTableArray(new KaitaiStream(fileName));
        }

        public BagCapacityTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, BagCapacityTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new BagCapacityTableArrayDim0(m_io, this, m_root);
        }
        public partial class BagCapacityTableArrayDim0 : KaitaiStruct
        {
            public static BagCapacityTableArrayDim0 FromFile(string fileName)
            {
                return new BagCapacityTableArrayDim0(new KaitaiStream(fileName));
            }

            public BagCapacityTableArrayDim0(KaitaiStream p__io, BagCapacityTableArray p__parent = null, BagCapacityTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<uint>();
                for (var i = 0; i < 8; i++)
                {
                    _entries.Add(m_io.ReadU4le());
                }
            }
            private List<uint> _entries;
            private BagCapacityTableArray m_root;
            private BagCapacityTableArray m_parent;
            public List<uint> Entries { get { return _entries; } }
            public BagCapacityTableArray M_Root { get { return m_root; } }
            public BagCapacityTableArray M_Parent { get { return m_parent; } }
        }
        private BagCapacityTableArrayDim0 _entries;
        private BagCapacityTableArray m_root;
        private KaitaiStruct m_parent;
        public BagCapacityTableArrayDim0 Entries { get { return _entries; } }
        public BagCapacityTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
