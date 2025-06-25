// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array MAP_MARKER_PLACEMENTS defined within pmdsky.
    /// </summary>
    public partial class MapMarkerPlacementsArray : KaitaiStruct
    {
        public static MapMarkerPlacementsArray FromFile(string fileName)
        {
            return new MapMarkerPlacementsArray(new KaitaiStream(fileName));
        }

        public MapMarkerPlacementsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MapMarkerPlacementsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MapMarkerPlacementsArrayDim0(m_io, this, m_root);
        }
        public partial class MapMarkerPlacementsArrayDim0 : KaitaiStruct
        {
            public static MapMarkerPlacementsArrayDim0 FromFile(string fileName)
            {
                return new MapMarkerPlacementsArrayDim0(new KaitaiStream(fileName));
            }

            public MapMarkerPlacementsArrayDim0(KaitaiStream p__io, MapMarkerPlacementsArray p__parent = null, MapMarkerPlacementsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<MapMarker>();
                for (var i = 0; i < 310; i++)
                {
                    _entries.Add(new MapMarker(m_io));
                }
            }
            private List<MapMarker> _entries;
            private MapMarkerPlacementsArray m_root;
            private MapMarkerPlacementsArray m_parent;
            public List<MapMarker> Entries { get { return _entries; } }
            public MapMarkerPlacementsArray M_Root { get { return m_root; } }
            public MapMarkerPlacementsArray M_Parent { get { return m_parent; } }
        }
        private MapMarkerPlacementsArrayDim0 _entries;
        private MapMarkerPlacementsArray m_root;
        private KaitaiStruct m_parent;
        public MapMarkerPlacementsArrayDim0 Entries { get { return _entries; } }
        public MapMarkerPlacementsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
