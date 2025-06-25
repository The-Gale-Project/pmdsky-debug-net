// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents a struct or union dungeon_unlock_entry defined within pmdsky-debug.
    /// </summary>
    public partial class DungeonUnlockEntry : KaitaiStruct
    {
        public static DungeonUnlockEntry FromFile(string fileName)
        {
            return new DungeonUnlockEntry(new KaitaiStream(fileName));
        }

        public DungeonUnlockEntry(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonUnlockEntry p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _dungeonId = new DungeonId8(m_io);
            _scenarioBalanceMin = m_io.ReadU1();
        }
        private DungeonId8 _dungeonId;
        private byte _scenarioBalanceMin;
        private DungeonUnlockEntry m_root;
        private KaitaiStruct m_parent;
        public DungeonId8 DungeonId { get { return _dungeonId; } }
        public byte ScenarioBalanceMin { get { return _scenarioBalanceMin; } }
        public DungeonUnlockEntry M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
