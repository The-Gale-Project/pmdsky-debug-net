// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array dungeon_unknown_tile_matrix defined within pmdsky.
    /// </summary>
    public partial class DungeonUnknownTileMatrixArray : KaitaiStruct
    {
        public static DungeonUnknownTileMatrixArray FromFile(string fileName)
        {
            return new DungeonUnknownTileMatrixArray(new KaitaiStream(fileName));
        }

        public DungeonUnknownTileMatrixArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonUnknownTileMatrixArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonUnknownTileMatrixArrayDim1(m_io, this, m_root);
        }
        public partial class DungeonUnknownTileMatrixArrayDim0 : KaitaiStruct
        {
            public static DungeonUnknownTileMatrixArrayDim0 FromFile(string fileName)
            {
                return new DungeonUnknownTileMatrixArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonUnknownTileMatrixArrayDim0(KaitaiStream p__io, DungeonUnknownTileMatrixArray.DungeonUnknownTileMatrixArrayDim1 p__parent = null, DungeonUnknownTileMatrixArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<ushort>();
                for (var i = 0; i < 34; i++)
                {
                    _entries.Add(m_io.ReadU2le());
                }
            }
            private List<ushort> _entries;
            private DungeonUnknownTileMatrixArray m_root;
            private DungeonUnknownTileMatrixArray.DungeonUnknownTileMatrixArrayDim1 m_parent;
            public List<ushort> Entries { get { return _entries; } }
            public DungeonUnknownTileMatrixArray M_Root { get { return m_root; } }
            public DungeonUnknownTileMatrixArray.DungeonUnknownTileMatrixArrayDim1 M_Parent { get { return m_parent; } }
        }
        public partial class DungeonUnknownTileMatrixArrayDim1 : KaitaiStruct
        {
            public static DungeonUnknownTileMatrixArrayDim1 FromFile(string fileName)
            {
                return new DungeonUnknownTileMatrixArrayDim1(new KaitaiStream(fileName));
            }

            public DungeonUnknownTileMatrixArrayDim1(KaitaiStream p__io, DungeonUnknownTileMatrixArray p__parent = null, DungeonUnknownTileMatrixArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<DungeonUnknownTileMatrixArrayDim0>();
                for (var i = 0; i < 9; i++)
                {
                    _entries.Add(new DungeonUnknownTileMatrixArrayDim0(m_io, this, m_root));
                }
            }
            private List<DungeonUnknownTileMatrixArrayDim0> _entries;
            private DungeonUnknownTileMatrixArray m_root;
            private DungeonUnknownTileMatrixArray m_parent;
            public List<DungeonUnknownTileMatrixArrayDim0> Entries { get { return _entries; } }
            public DungeonUnknownTileMatrixArray M_Root { get { return m_root; } }
            public DungeonUnknownTileMatrixArray M_Parent { get { return m_parent; } }
        }
        private DungeonUnknownTileMatrixArrayDim1 _entries;
        private DungeonUnknownTileMatrixArray m_root;
        private KaitaiStruct m_parent;
        public DungeonUnknownTileMatrixArrayDim1 Entries { get { return _entries; } }
        public DungeonUnknownTileMatrixArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
