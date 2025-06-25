// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union fixed_room_monster_spawn_stats_entry defined within pmdsky-debug.
    /// </summary>
    public partial class FixedRoomMonsterSpawnStatsEntry : KaitaiStruct
    {
        public static FixedRoomMonsterSpawnStatsEntry FromFile(string fileName)
        {
            return new FixedRoomMonsterSpawnStatsEntry(new KaitaiStream(fileName));
        }

        public FixedRoomMonsterSpawnStatsEntry(KaitaiStream p__io, KaitaiStruct p__parent = null, FixedRoomMonsterSpawnStatsEntry p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _level = m_io.ReadU2le();
            _hp = m_io.ReadU2le();
            _expYield = m_io.ReadS2le();
            _atk = m_io.ReadU1();
            _spAtk = m_io.ReadU1();
            _def = m_io.ReadU1();
            _spDef = m_io.ReadU1();
            _field0xa = m_io.ReadU1();
            _field0xb = m_io.ReadU1();
        }
        private ushort _level;
        private ushort _hp;
        private short _expYield;
        private byte _atk;
        private byte _spAtk;
        private byte _def;
        private byte _spDef;
        private byte _field0xa;
        private byte _field0xb;
        private FixedRoomMonsterSpawnStatsEntry m_root;
        private KaitaiStruct m_parent;
        public ushort Level { get { return _level; } }
        public ushort Hp { get { return _hp; } }
        public short ExpYield { get { return _expYield; } }
        public byte Atk { get { return _atk; } }
        public byte SpAtk { get { return _spAtk; } }
        public byte Def { get { return _def; } }
        public byte SpDef { get { return _spDef; } }
        public byte Field0xa { get { return _field0xa; } }
        public byte Field0xb { get { return _field0xb; } }
        public FixedRoomMonsterSpawnStatsEntry M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
