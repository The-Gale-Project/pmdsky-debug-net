// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union map_marker defined within pmdsky-debug.
    /// </summary>
    public partial class MapMarker : KaitaiStruct
    {
        public static MapMarker FromFile(string fileName)
        {
            return new MapMarker(new KaitaiStream(fileName));
        }

        public MapMarker(KaitaiStream p__io, KaitaiStruct p__parent = null, MapMarker p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _mapId = m_io.ReadU2le();
            _referenceId = m_io.ReadS2le();
            _pos = new Position(m_io);
        }
        private ushort _mapId;
        private short _referenceId;
        private Position _pos;
        private MapMarker m_root;
        private KaitaiStruct m_parent;
        public ushort MapId { get { return _mapId; } }
        public short ReferenceId { get { return _referenceId; } }
        public Position Pos { get { return _pos; } }
        public MapMarker M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
