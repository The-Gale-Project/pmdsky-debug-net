// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union monster_spawn_entry defined within pmdsky-debug.
    /// </summary>
    public partial class MonsterSpawnEntry : KaitaiStruct
    {
        public static MonsterSpawnEntry FromFile(string fileName)
        {
            return new MonsterSpawnEntry(new KaitaiStream(fileName));
        }

        public MonsterSpawnEntry(KaitaiStream p__io, KaitaiStruct p__parent = null, MonsterSpawnEntry p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _levelMult512 = m_io.ReadU2le();
            _incrementalSpawnWeight = m_io.ReadU2le();
            _incrementalSpawnWeightMonsterHouse = m_io.ReadU2le();
            _id = new MonsterId16(m_io);
        }
        private ushort _levelMult512;
        private ushort _incrementalSpawnWeight;
        private ushort _incrementalSpawnWeightMonsterHouse;
        private MonsterId16 _id;
        private MonsterSpawnEntry m_root;
        private KaitaiStruct m_parent;
        public ushort LevelMult512 { get { return _levelMult512; } }
        public ushort IncrementalSpawnWeight { get { return _incrementalSpawnWeight; } }
        public ushort IncrementalSpawnWeightMonsterHouse { get { return _incrementalSpawnWeightMonsterHouse; } }
        public MonsterId16 Id { get { return _id; } }
        public MonsterSpawnEntry M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
