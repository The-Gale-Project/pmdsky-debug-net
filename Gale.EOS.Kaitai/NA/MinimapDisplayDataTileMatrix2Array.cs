// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array minimap_display_data_tile_matrix_2 defined within pmdsky.
    /// </summary>
    public partial class MinimapDisplayDataTileMatrix2Array : KaitaiStruct
    {
        public static MinimapDisplayDataTileMatrix2Array FromFile(string fileName)
        {
            return new MinimapDisplayDataTileMatrix2Array(new KaitaiStream(fileName));
        }

        public MinimapDisplayDataTileMatrix2Array(KaitaiStream p__io, KaitaiStruct p__parent = null, MinimapDisplayDataTileMatrix2Array p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MinimapDisplayDataTileMatrix2ArrayDim1(m_io, this, m_root);
        }
        public partial class MinimapDisplayDataTileMatrix2ArrayDim0 : KaitaiStruct
        {
            public static MinimapDisplayDataTileMatrix2ArrayDim0 FromFile(string fileName)
            {
                return new MinimapDisplayDataTileMatrix2ArrayDim0(new KaitaiStream(fileName));
            }

            public MinimapDisplayDataTileMatrix2ArrayDim0(KaitaiStream p__io, MinimapDisplayDataTileMatrix2Array.MinimapDisplayDataTileMatrix2ArrayDim1 p__parent = null, MinimapDisplayDataTileMatrix2Array p__root = null) : base(p__io)
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
            private MinimapDisplayDataTileMatrix2Array m_root;
            private MinimapDisplayDataTileMatrix2Array.MinimapDisplayDataTileMatrix2ArrayDim1 m_parent;
            public List<MinimapDisplayTile> Entries { get { return _entries; } }
            public MinimapDisplayDataTileMatrix2Array M_Root { get { return m_root; } }
            public MinimapDisplayDataTileMatrix2Array.MinimapDisplayDataTileMatrix2ArrayDim1 M_Parent { get { return m_parent; } }
        }
        public partial class MinimapDisplayDataTileMatrix2ArrayDim1 : KaitaiStruct
        {
            public static MinimapDisplayDataTileMatrix2ArrayDim1 FromFile(string fileName)
            {
                return new MinimapDisplayDataTileMatrix2ArrayDim1(new KaitaiStream(fileName));
            }

            public MinimapDisplayDataTileMatrix2ArrayDim1(KaitaiStream p__io, MinimapDisplayDataTileMatrix2Array p__parent = null, MinimapDisplayDataTileMatrix2Array p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<MinimapDisplayDataTileMatrix2ArrayDim0>();
                for (var i = 0; i < 16; i++)
                {
                    _entries.Add(new MinimapDisplayDataTileMatrix2ArrayDim0(m_io, this, m_root));
                }
            }
            private List<MinimapDisplayDataTileMatrix2ArrayDim0> _entries;
            private MinimapDisplayDataTileMatrix2Array m_root;
            private MinimapDisplayDataTileMatrix2Array m_parent;
            public List<MinimapDisplayDataTileMatrix2ArrayDim0> Entries { get { return _entries; } }
            public MinimapDisplayDataTileMatrix2Array M_Root { get { return m_root; } }
            public MinimapDisplayDataTileMatrix2Array M_Parent { get { return m_parent; } }
        }
        private MinimapDisplayDataTileMatrix2ArrayDim1 _entries;
        private MinimapDisplayDataTileMatrix2Array m_root;
        private KaitaiStruct m_parent;
        public MinimapDisplayDataTileMatrix2ArrayDim1 Entries { get { return _entries; } }
        public MinimapDisplayDataTileMatrix2Array M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
