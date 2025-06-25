// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents a struct or union natural_gift_item_info defined within pmdsky-debug.
    /// </summary>
    public partial class NaturalGiftItemInfo : KaitaiStruct
    {
        public static NaturalGiftItemInfo FromFile(string fileName)
        {
            return new NaturalGiftItemInfo(new KaitaiStream(fileName));
        }

        public NaturalGiftItemInfo(KaitaiStream p__io, KaitaiStruct p__parent = null, NaturalGiftItemInfo p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _itemId = new ItemId16(m_io);
            _typeId = new TypeId8(m_io);
            _padding = m_io.ReadU1();
            _basePowerBoost = m_io.ReadS2le();
        }
        private ItemId16 _itemId;
        private TypeId8 _typeId;
        private byte _padding;
        private short _basePowerBoost;
        private NaturalGiftItemInfo m_root;
        private KaitaiStruct m_parent;
        public ItemId16 ItemId { get { return _itemId; } }
        public TypeId8 TypeId { get { return _typeId; } }
        public byte Padding { get { return _padding; } }
        public short BasePowerBoost { get { return _basePowerBoost; } }
        public NaturalGiftItemInfo M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
