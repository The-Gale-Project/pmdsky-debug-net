// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union guest_monster defined within pmdsky-debug.
    /// </summary>
    public partial class GuestMonster : KaitaiStruct
    {
        public static GuestMonster FromFile(string fileName)
        {
            return new GuestMonster(new KaitaiStream(fileName));
        }

        public GuestMonster(KaitaiStream p__io, KaitaiStruct p__parent = null, GuestMonster p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _name = new Pointer(m_io);
            _id = new MonsterId16(m_io);
            _joinedAt = new DungeonId8(m_io);
            _joinedAtFloor = m_io.ReadU1();
            _moves = new GuestMonsterMovesArray(m_io);
            _maxHp = m_io.ReadS2le();
            _level = m_io.ReadU1();
            _field0x13 = m_io.ReadU1();
            _iq = m_io.ReadS2le();
            _atk = m_io.ReadU1();
            _field0x17 = m_io.ReadU1();
            _spAtk = m_io.ReadU1();
            _field0x19 = m_io.ReadU1();
            _def = m_io.ReadU1();
            _field0x1b = m_io.ReadU1();
            _spDef = m_io.ReadU1();
            _field0x1d = m_io.ReadU1();
            _field0x1e = m_io.ReadU1();
            _field0x1f = m_io.ReadU1();
            _exp = m_io.ReadS4le();
        }
        private Pointer _name;
        private MonsterId16 _id;
        private DungeonId8 _joinedAt;
        private byte _joinedAtFloor;
        private GuestMonsterMovesArray _moves;
        private short _maxHp;
        private byte _level;
        private byte _field0x13;
        private short _iq;
        private byte _atk;
        private byte _field0x17;
        private byte _spAtk;
        private byte _field0x19;
        private byte _def;
        private byte _field0x1b;
        private byte _spDef;
        private byte _field0x1d;
        private byte _field0x1e;
        private byte _field0x1f;
        private int _exp;
        private GuestMonster m_root;
        private KaitaiStruct m_parent;
        public Pointer Name { get { return _name; } }
        public MonsterId16 Id { get { return _id; } }
        public DungeonId8 JoinedAt { get { return _joinedAt; } }
        public byte JoinedAtFloor { get { return _joinedAtFloor; } }
        public GuestMonsterMovesArray Moves { get { return _moves; } }
        public short MaxHp { get { return _maxHp; } }
        public byte Level { get { return _level; } }
        public byte Field0x13 { get { return _field0x13; } }
        public short Iq { get { return _iq; } }
        public byte Atk { get { return _atk; } }
        public byte Field0x17 { get { return _field0x17; } }
        public byte SpAtk { get { return _spAtk; } }
        public byte Field0x19 { get { return _field0x19; } }
        public byte Def { get { return _def; } }
        public byte Field0x1b { get { return _field0x1b; } }
        public byte SpDef { get { return _spDef; } }
        public byte Field0x1d { get { return _field0x1d; } }
        public byte Field0x1e { get { return _field0x1e; } }
        public byte Field0x1f { get { return _field0x1f; } }
        public int Exp { get { return _exp; } }
        public GuestMonster M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
