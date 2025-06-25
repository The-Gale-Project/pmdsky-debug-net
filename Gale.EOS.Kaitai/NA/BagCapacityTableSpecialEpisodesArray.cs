// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array BAG_CAPACITY_TABLE_SPECIAL_EPISODES defined within pmdsky.
    /// </summary>
    public partial class BagCapacityTableSpecialEpisodesArray : KaitaiStruct
    {
        public static BagCapacityTableSpecialEpisodesArray FromFile(string fileName)
        {
            return new BagCapacityTableSpecialEpisodesArray(new KaitaiStream(fileName));
        }

        public BagCapacityTableSpecialEpisodesArray(KaitaiStream p__io, KaitaiStruct p__parent = null, BagCapacityTableSpecialEpisodesArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new BagCapacityTableSpecialEpisodesArrayDim0(m_io, this, m_root);
        }
        public partial class BagCapacityTableSpecialEpisodesArrayDim0 : KaitaiStruct
        {
            public static BagCapacityTableSpecialEpisodesArrayDim0 FromFile(string fileName)
            {
                return new BagCapacityTableSpecialEpisodesArrayDim0(new KaitaiStream(fileName));
            }

            public BagCapacityTableSpecialEpisodesArrayDim0(KaitaiStream p__io, BagCapacityTableSpecialEpisodesArray p__parent = null, BagCapacityTableSpecialEpisodesArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<uint>();
                for (var i = 0; i < 5; i++)
                {
                    _entries.Add(m_io.ReadU4le());
                }
            }
            private List<uint> _entries;
            private BagCapacityTableSpecialEpisodesArray m_root;
            private BagCapacityTableSpecialEpisodesArray m_parent;
            public List<uint> Entries { get { return _entries; } }
            public BagCapacityTableSpecialEpisodesArray M_Root { get { return m_root; } }
            public BagCapacityTableSpecialEpisodesArray M_Parent { get { return m_parent; } }
        }
        private BagCapacityTableSpecialEpisodesArrayDim0 _entries;
        private BagCapacityTableSpecialEpisodesArray m_root;
        private KaitaiStruct m_parent;
        public BagCapacityTableSpecialEpisodesArrayDim0 Entries { get { return _entries; } }
        public BagCapacityTableSpecialEpisodesArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
