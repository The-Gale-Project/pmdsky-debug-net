// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array minimap_display_data_tile_matrix_1 defined within pmdsky.
    /// </summary>
    public partial class MinimapDisplayDataTileMatrix1Array : KaitaiStruct
    {
        public static MinimapDisplayDataTileMatrix1Array FromFile(string fileName)
        {
            return new MinimapDisplayDataTileMatrix1Array(new KaitaiStream(fileName));
        }

        public MinimapDisplayDataTileMatrix1Array(KaitaiStream p__io, KaitaiStruct p__parent = null, MinimapDisplayDataTileMatrix1Array p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MinimapDisplayDataTileMatrix1ArrayDim1(m_io, this, m_root);
        }
        public partial class MinimapDisplayDataTileMatrix1ArrayDim0 : KaitaiStruct
        {
            public static MinimapDisplayDataTileMatrix1ArrayDim0 FromFile(string fileName)
            {
                return new MinimapDisplayDataTileMatrix1ArrayDim0(new KaitaiStream(fileName));
            }

            public MinimapDisplayDataTileMatrix1ArrayDim0(KaitaiStream p__io, MinimapDisplayDataTileMatrix1Array.MinimapDisplayDataTileMatrix1ArrayDim1 p__parent = null, MinimapDisplayDataTileMatrix1Array p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<MinimapDisplayTile>();
                for (var i = 0; i < 28; i++)
                {
                    _entries.Add(new MinimapDisplayTile(m_io));
                }
            }
            private List<MinimapDisplayTile> _entries;
            private MinimapDisplayDataTileMatrix1Array m_root;
            private MinimapDisplayDataTileMatrix1Array.MinimapDisplayDataTileMatrix1ArrayDim1 m_parent;
            public List<MinimapDisplayTile> Entries { get { return _entries; } }
            public MinimapDisplayDataTileMatrix1Array M_Root { get { return m_root; } }
            public MinimapDisplayDataTileMatrix1Array.MinimapDisplayDataTileMatrix1ArrayDim1 M_Parent { get { return m_parent; } }
        }
        public partial class MinimapDisplayDataTileMatrix1ArrayDim1 : KaitaiStruct
        {
            public static MinimapDisplayDataTileMatrix1ArrayDim1 FromFile(string fileName)
            {
                return new MinimapDisplayDataTileMatrix1ArrayDim1(new KaitaiStream(fileName));
            }

            public MinimapDisplayDataTileMatrix1ArrayDim1(KaitaiStream p__io, MinimapDisplayDataTileMatrix1Array p__parent = null, MinimapDisplayDataTileMatrix1Array p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<MinimapDisplayDataTileMatrix1ArrayDim0>();
                for (var i = 0; i < 16; i++)
                {
                    _entries.Add(new MinimapDisplayDataTileMatrix1ArrayDim0(m_io, this, m_root));
                }
            }
            private List<MinimapDisplayDataTileMatrix1ArrayDim0> _entries;
            private MinimapDisplayDataTileMatrix1Array m_root;
            private MinimapDisplayDataTileMatrix1Array m_parent;
            public List<MinimapDisplayDataTileMatrix1ArrayDim0> Entries { get { return _entries; } }
            public MinimapDisplayDataTileMatrix1Array M_Root { get { return m_root; } }
            public MinimapDisplayDataTileMatrix1Array M_Parent { get { return m_parent; } }
        }
        private MinimapDisplayDataTileMatrix1ArrayDim1 _entries;
        private MinimapDisplayDataTileMatrix1Array m_root;
        private KaitaiStruct m_parent;
        public MinimapDisplayDataTileMatrix1ArrayDim1 Entries { get { return _entries; } }
        public MinimapDisplayDataTileMatrix1Array M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
