// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array MAP_COLOR_TABLE defined within pmdsky.
    /// </summary>
    public partial class MapColorTableArray : KaitaiStruct
    {
        public static MapColorTableArray FromFile(string fileName)
        {
            return new MapColorTableArray(new KaitaiStream(fileName));
        }

        public MapColorTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MapColorTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MapColorTableArrayDim0(m_io, this, m_root);
        }
        public partial class MapColorTableArrayDim0 : KaitaiStruct
        {
            public static MapColorTableArrayDim0 FromFile(string fileName)
            {
                return new MapColorTableArrayDim0(new KaitaiStream(fileName));
            }

            public MapColorTableArrayDim0(KaitaiStream p__io, MapColorTableArray p__parent = null, MapColorTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<Rgba>();
                for (var i = 0; i < 9; i++)
                {
                    _entries.Add(new Rgba(m_io));
                }
            }
            private List<Rgba> _entries;
            private MapColorTableArray m_root;
            private MapColorTableArray m_parent;
            public List<Rgba> Entries { get { return _entries; } }
            public MapColorTableArray M_Root { get { return m_root; } }
            public MapColorTableArray M_Parent { get { return m_parent; } }
        }
        private MapColorTableArrayDim0 _entries;
        private MapColorTableArray m_root;
        private KaitaiStruct m_parent;
        public MapColorTableArrayDim0 Entries { get { return _entries; } }
        public MapColorTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
