// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents a struct or union item_animation defined within pmdsky-debug.
    /// </summary>
    public partial class ItemAnimation : KaitaiStruct
    {
        public static ItemAnimation FromFile(string fileName)
        {
            return new ItemAnimation(new KaitaiStream(fileName));
        }

        public ItemAnimation(KaitaiStream p__io, KaitaiStruct p__parent = null, ItemAnimation p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _field0x0 = m_io.ReadS2le();
            _field0x2 = m_io.ReadS2le();
        }
        private short _field0x0;
        private short _field0x2;
        private ItemAnimation m_root;
        private KaitaiStruct m_parent;
        public short Field0x0 { get { return _field0x0; } }
        public short Field0x2 { get { return _field0x2; } }
        public ItemAnimation M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
