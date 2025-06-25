// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array TILESET_PROPERTIES defined within pmdsky.
    /// </summary>
    public partial class TilesetPropertiesArray : KaitaiStruct
    {
        public static TilesetPropertiesArray FromFile(string fileName)
        {
            return new TilesetPropertiesArray(new KaitaiStream(fileName));
        }

        public TilesetPropertiesArray(KaitaiStream p__io, KaitaiStruct p__parent = null, TilesetPropertiesArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new TilesetPropertiesArrayDim0(m_io, this, m_root);
        }
        public partial class TilesetPropertiesArrayDim0 : KaitaiStruct
        {
            public static TilesetPropertiesArrayDim0 FromFile(string fileName)
            {
                return new TilesetPropertiesArrayDim0(new KaitaiStream(fileName));
            }

            public TilesetPropertiesArrayDim0(KaitaiStream p__io, TilesetPropertiesArray p__parent = null, TilesetPropertiesArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<TilesetProperty>();
                for (var i = 0; i < 199; i++)
                {
                    _entries.Add(new TilesetProperty(m_io));
                }
            }
            private List<TilesetProperty> _entries;
            private TilesetPropertiesArray m_root;
            private TilesetPropertiesArray m_parent;
            public List<TilesetProperty> Entries { get { return _entries; } }
            public TilesetPropertiesArray M_Root { get { return m_root; } }
            public TilesetPropertiesArray M_Parent { get { return m_parent; } }
        }
        private TilesetPropertiesArrayDim0 _entries;
        private TilesetPropertiesArray m_root;
        private KaitaiStruct m_parent;
        public TilesetPropertiesArrayDim0 Entries { get { return _entries; } }
        public TilesetPropertiesArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
