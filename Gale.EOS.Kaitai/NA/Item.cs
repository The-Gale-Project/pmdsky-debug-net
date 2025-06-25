// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union item defined within pmdsky-debug.
    /// </summary>
    public partial class Item : KaitaiStruct
    {
        public static Item FromFile(string fileName)
        {
            return new Item(new KaitaiStream(fileName));
        }

        public Item(KaitaiStream p__io, KaitaiStruct p__parent = null, Item p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _fExists = m_io.ReadBitsIntLe(1) != 0;
            _fInShop = m_io.ReadBitsIntLe(1) != 0;
            _fUnpaid = m_io.ReadBitsIntLe(1) != 0;
            _fSticky = m_io.ReadBitsIntLe(1) != 0;
            _fSet = m_io.ReadBitsIntLe(1) != 0;
            _flagUnk5 = m_io.ReadBitsIntLe(1) != 0;
            _fUnkMissionItem1 = m_io.ReadBitsIntLe(1) != 0;
            _fUnkMissionItem2 = m_io.ReadBitsIntLe(1) != 0;
            m_io.AlignToByte();
            _heldBy = m_io.ReadU1();
            _quantity = m_io.ReadU2le();
            _id = new ItemId16(m_io);
        }
        private bool _fExists;
        private bool _fInShop;
        private bool _fUnpaid;
        private bool _fSticky;
        private bool _fSet;
        private bool _flagUnk5;
        private bool _fUnkMissionItem1;
        private bool _fUnkMissionItem2;
        private byte _heldBy;
        private ushort _quantity;
        private ItemId16 _id;
        private Item m_root;
        private KaitaiStruct m_parent;
        public bool FExists { get { return _fExists; } }
        public bool FInShop { get { return _fInShop; } }
        public bool FUnpaid { get { return _fUnpaid; } }
        public bool FSticky { get { return _fSticky; } }
        public bool FSet { get { return _fSet; } }
        public bool FlagUnk5 { get { return _flagUnk5; } }
        public bool FUnkMissionItem1 { get { return _fUnkMissionItem1; } }
        public bool FUnkMissionItem2 { get { return _fUnkMissionItem2; } }
        public byte HeldBy { get { return _heldBy; } }
        public ushort Quantity { get { return _quantity; } }
        public ItemId16 Id { get { return _id; } }
        public Item M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
