// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union fixed_room_monster_spawn_entry defined within pmdsky-debug.
    /// </summary>
    public partial class FixedRoomMonsterSpawnEntry : KaitaiStruct
    {
        public static FixedRoomMonsterSpawnEntry FromFile(string fileName)
        {
            return new FixedRoomMonsterSpawnEntry(new KaitaiStream(fileName));
        }

        public FixedRoomMonsterSpawnEntry(KaitaiStream p__io, KaitaiStruct p__parent = null, FixedRoomMonsterSpawnEntry p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _id = new MonsterId16(m_io);
            _statTableIdx = m_io.ReadU1();
            _behavior = new MonsterBehavior8(m_io);
        }
        private MonsterId16 _id;
        private byte _statTableIdx;
        private MonsterBehavior8 _behavior;
        private FixedRoomMonsterSpawnEntry m_root;
        private KaitaiStruct m_parent;
        public MonsterId16 Id { get { return _id; } }
        public byte StatTableIdx { get { return _statTableIdx; } }
        public MonsterBehavior8 Behavior { get { return _behavior; } }
        public FixedRoomMonsterSpawnEntry M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
