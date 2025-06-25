// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union rankup_table_entry defined within pmdsky-debug.
    /// </summary>
    public partial class RankupTableEntry : KaitaiStruct
    {
        public static RankupTableEntry FromFile(string fileName)
        {
            return new RankupTableEntry(new KaitaiStream(fileName));
        }

        public RankupTableEntry(KaitaiStream p__io, KaitaiStruct p__parent = null, RankupTableEntry p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _field0x0 = m_io.ReadU1();
            _field0x1 = m_io.ReadU1();
            _field0x2 = m_io.ReadU1();
            _field0x3 = m_io.ReadU1();
            _field0x4 = m_io.ReadS4le();
            _field0x8 = m_io.ReadS4le();
            _field0xc = m_io.ReadS2le();
            _field0xe = m_io.ReadU1();
            _field0xf = m_io.ReadU1();
        }
        private byte _field0x0;
        private byte _field0x1;
        private byte _field0x2;
        private byte _field0x3;
        private int _field0x4;
        private int _field0x8;
        private short _field0xc;
        private byte _field0xe;
        private byte _field0xf;
        private RankupTableEntry m_root;
        private KaitaiStruct m_parent;
        public byte Field0x0 { get { return _field0x0; } }
        public byte Field0x1 { get { return _field0x1; } }
        public byte Field0x2 { get { return _field0x2; } }
        public byte Field0x3 { get { return _field0x3; } }
        public int Field0x4 { get { return _field0x4; } }
        public int Field0x8 { get { return _field0x8; } }
        public short Field0xc { get { return _field0xc; } }
        public byte Field0xe { get { return _field0xe; } }
        public byte Field0xf { get { return _field0xf; } }
        public RankupTableEntry M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
