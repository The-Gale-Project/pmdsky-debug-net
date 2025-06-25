// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union enemy_spawn_stats defined within pmdsky-debug.
    /// </summary>
    public partial class EnemySpawnStats : KaitaiStruct
    {
        public static EnemySpawnStats FromFile(string fileName)
        {
            return new EnemySpawnStats(new KaitaiStream(fileName));
        }

        public EnemySpawnStats(KaitaiStream p__io, KaitaiStruct p__parent = null, EnemySpawnStats p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _id = new MonsterId16(m_io);
            _level = m_io.ReadU2le();
            _moves = new EnemySpawnStatsMovesArray(m_io);
            _maxHp = m_io.ReadU2le();
            _atk = m_io.ReadU1();
            _def = m_io.ReadU1();
            _spAtk = m_io.ReadU1();
            _spDef = m_io.ReadU1();
        }
        private MonsterId16 _id;
        private ushort _level;
        private EnemySpawnStatsMovesArray _moves;
        private ushort _maxHp;
        private byte _atk;
        private byte _def;
        private byte _spAtk;
        private byte _spDef;
        private EnemySpawnStats m_root;
        private KaitaiStruct m_parent;
        public MonsterId16 Id { get { return _id; } }
        public ushort Level { get { return _level; } }
        public EnemySpawnStatsMovesArray Moves { get { return _moves; } }
        public ushort MaxHp { get { return _maxHp; } }
        public byte Atk { get { return _atk; } }
        public byte Def { get { return _def; } }
        public byte SpAtk { get { return _spAtk; } }
        public byte SpDef { get { return _spDef; } }
        public EnemySpawnStats M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
