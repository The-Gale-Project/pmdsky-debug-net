// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents a struct or union bar_item defined within pmdsky-debug.
    /// </summary>
    public partial class BarItem : KaitaiStruct
    {
        public static BarItem FromFile(string fileName)
        {
            return new BarItem(new KaitaiStream(fileName));
        }

        public BarItem(KaitaiStream p__io, KaitaiStruct p__parent = null, BarItem p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _id = new ItemId16(m_io);
            _field0x2 = m_io.ReadS2le();
            _field0x4 = m_io.ReadS2le();
            _field0x6 = m_io.ReadS2le();
            _field0x8 = m_io.ReadS2le();
            _field0xa = m_io.ReadS2le();
            _field0xc = m_io.ReadS2le();
            _field0xe = new BarItemField0xeArray(m_io);
        }
        private ItemId16 _id;
        private short _field0x2;
        private short _field0x4;
        private short _field0x6;
        private short _field0x8;
        private short _field0xa;
        private short _field0xc;
        private BarItemField0xeArray _field0xe;
        private BarItem m_root;
        private KaitaiStruct m_parent;
        public ItemId16 Id { get { return _id; } }
        public short Field0x2 { get { return _field0x2; } }
        public short Field0x4 { get { return _field0x4; } }
        public short Field0x6 { get { return _field0x6; } }
        public short Field0x8 { get { return _field0x8; } }
        public short Field0xa { get { return _field0xa; } }
        public short Field0xc { get { return _field0xc; } }
        public BarItemField0xeArray Field0xe { get { return _field0xe; } }
        public BarItem M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
