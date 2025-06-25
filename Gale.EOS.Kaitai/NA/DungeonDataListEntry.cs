// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union dungeon_data_list_entry defined within pmdsky-debug.
    /// </summary>
    public partial class DungeonDataListEntry : KaitaiStruct
    {
        public static DungeonDataListEntry FromFile(string fileName)
        {
            return new DungeonDataListEntry(new KaitaiStream(fileName));
        }

        public DungeonDataListEntry(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonDataListEntry p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _nFloors = m_io.ReadU1();
            _dungeonDataIndexMappaS = m_io.ReadU1();
            _nPrecedingFloorsGroup = m_io.ReadU1();
            _nTotalFloorsGroup = m_io.ReadU1();
        }
        private byte _nFloors;
        private byte _dungeonDataIndexMappaS;
        private byte _nPrecedingFloorsGroup;
        private byte _nTotalFloorsGroup;
        private DungeonDataListEntry m_root;
        private KaitaiStruct m_parent;
        public byte NFloors { get { return _nFloors; } }
        public byte DungeonDataIndexMappaS { get { return _dungeonDataIndexMappaS; } }
        public byte NPrecedingFloorsGroup { get { return _nPrecedingFloorsGroup; } }
        public byte NTotalFloorsGroup { get { return _nTotalFloorsGroup; } }
        public DungeonDataListEntry M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
