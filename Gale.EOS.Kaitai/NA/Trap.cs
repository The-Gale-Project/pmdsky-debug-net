// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union trap defined within pmdsky-debug.
    /// </summary>
    public partial class Trap : KaitaiStruct
    {
        public static Trap FromFile(string fileName)
        {
            return new Trap(new KaitaiStream(fileName));
        }

        public Trap(KaitaiStream p__io, KaitaiStruct p__parent = null, Trap p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _id = new TrapId8(m_io);
            _team = m_io.ReadU1();
            _fUnbreakable = m_io.ReadBitsIntLe(1) != 0;
            _flagsUnk1 = m_io.ReadBitsIntLe(7);
            m_io.AlignToByte();
            _field0x3 = m_io.ReadU1();
        }
        private TrapId8 _id;
        private byte _team;
        private bool _fUnbreakable;
        private ulong _flagsUnk1;
        private byte _field0x3;
        private Trap m_root;
        private KaitaiStruct m_parent;
        public TrapId8 Id { get { return _id; } }
        public byte Team { get { return _team; } }
        public bool FUnbreakable { get { return _fUnbreakable; } }
        public ulong FlagsUnk1 { get { return _flagsUnk1; } }
        public byte Field0x3 { get { return _field0x3; } }
        public Trap M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
