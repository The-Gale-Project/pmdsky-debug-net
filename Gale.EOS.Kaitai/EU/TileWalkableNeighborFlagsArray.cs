// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array tile_walkable_neighbor_flags defined within pmdsky.
    /// </summary>
    public partial class TileWalkableNeighborFlagsArray : KaitaiStruct
    {
        public static TileWalkableNeighborFlagsArray FromFile(string fileName)
        {
            return new TileWalkableNeighborFlagsArray(new KaitaiStream(fileName));
        }

        public TileWalkableNeighborFlagsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, TileWalkableNeighborFlagsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new TileWalkableNeighborFlagsArrayDim0(m_io, this, m_root);
        }
        public partial class TileWalkableNeighborFlagsArrayDim0 : KaitaiStruct
        {
            public static TileWalkableNeighborFlagsArrayDim0 FromFile(string fileName)
            {
                return new TileWalkableNeighborFlagsArrayDim0(new KaitaiStream(fileName));
            }

            public TileWalkableNeighborFlagsArrayDim0(KaitaiStream p__io, TileWalkableNeighborFlagsArray p__parent = null, TileWalkableNeighborFlagsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<byte>();
                for (var i = 0; i < 4; i++)
                {
                    _entries.Add(m_io.ReadU1());
                }
            }
            private List<byte> _entries;
            private TileWalkableNeighborFlagsArray m_root;
            private TileWalkableNeighborFlagsArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public TileWalkableNeighborFlagsArray M_Root { get { return m_root; } }
            public TileWalkableNeighborFlagsArray M_Parent { get { return m_parent; } }
        }
        private TileWalkableNeighborFlagsArrayDim0 _entries;
        private TileWalkableNeighborFlagsArray m_root;
        private KaitaiStruct m_parent;
        public TileWalkableNeighborFlagsArrayDim0 Entries { get { return _entries; } }
        public TileWalkableNeighborFlagsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
