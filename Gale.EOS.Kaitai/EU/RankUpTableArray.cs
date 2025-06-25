// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array RANK_UP_TABLE defined within pmdsky.
    /// </summary>
    public partial class RankUpTableArray : KaitaiStruct
    {
        public static RankUpTableArray FromFile(string fileName)
        {
            return new RankUpTableArray(new KaitaiStream(fileName));
        }

        public RankUpTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, RankUpTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new RankUpTableArrayDim0(m_io, this, m_root);
        }
        public partial class RankUpTableArrayDim0 : KaitaiStruct
        {
            public static RankUpTableArrayDim0 FromFile(string fileName)
            {
                return new RankUpTableArrayDim0(new KaitaiStream(fileName));
            }

            public RankUpTableArrayDim0(KaitaiStream p__io, RankUpTableArray p__parent = null, RankUpTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<RankupTableEntry>();
                for (var i = 0; i < 13; i++)
                {
                    _entries.Add(new RankupTableEntry(m_io));
                }
            }
            private List<RankupTableEntry> _entries;
            private RankUpTableArray m_root;
            private RankUpTableArray m_parent;
            public List<RankupTableEntry> Entries { get { return _entries; } }
            public RankUpTableArray M_Root { get { return m_root; } }
            public RankUpTableArray M_Parent { get { return m_parent; } }
        }
        private RankUpTableArrayDim0 _entries;
        private RankUpTableArray m_root;
        private KaitaiStruct m_parent;
        public RankUpTableArrayDim0 Entries { get { return _entries; } }
        public RankUpTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
