// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union level_up_entry defined within pmdsky-debug.
    /// </summary>
    public partial class LevelUpEntry : KaitaiStruct
    {
        public static LevelUpEntry FromFile(string fileName)
        {
            return new LevelUpEntry(new KaitaiStream(fileName));
        }

        public LevelUpEntry(KaitaiStream p__io, KaitaiStruct p__parent = null, LevelUpEntry p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _totalExp = m_io.ReadU4le();
            _hp = m_io.ReadU2le();
            _atk = m_io.ReadU1();
            _spAtk = m_io.ReadU1();
            _def = m_io.ReadU1();
            _spDef = m_io.ReadU1();
            _field0xa = m_io.ReadU1();
            _field0xb = m_io.ReadU1();
        }
        private uint _totalExp;
        private ushort _hp;
        private byte _atk;
        private byte _spAtk;
        private byte _def;
        private byte _spDef;
        private byte _field0xa;
        private byte _field0xb;
        private LevelUpEntry m_root;
        private KaitaiStruct m_parent;
        public uint TotalExp { get { return _totalExp; } }
        public ushort Hp { get { return _hp; } }
        public byte Atk { get { return _atk; } }
        public byte SpAtk { get { return _spAtk; } }
        public byte Def { get { return _def; } }
        public byte SpDef { get { return _spDef; } }
        public byte Field0xa { get { return _field0xa; } }
        public byte Field0xb { get { return _field0xb; } }
        public LevelUpEntry M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
