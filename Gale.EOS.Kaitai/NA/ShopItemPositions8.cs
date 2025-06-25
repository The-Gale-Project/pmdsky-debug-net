// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Holds bitsized data for the parent enum shop_item_positions.
    /// </summary>
    public partial class ShopItemPositions8 : KaitaiStruct
    {
        public static ShopItemPositions8 FromFile(string fileName)
        {
            return new ShopItemPositions8(new KaitaiStream(fileName));
        }


        public enum ShopItemPositions8Enum
        {
            ShopPosition0 = 0,
            ShopPosition1 = 1,
            ShopPosition2 = 2,
            ShopPosition3 = 3,
            ShopPosition4 = 4,
            ShopPosition5 = 5,
            ShopPosition6 = 6,
            ShopPosition7 = 7,
            ShopPosition8 = 8,
            ShopPosition9 = 9,
            ShopPositionA = 10,
            ShopPositionB = 11,
            ShopPositionC = 12,
            ShopPositionD = 13,
            ShopPositionE = 14,
            ShopPositionF = 15,
        }
        public ShopItemPositions8(KaitaiStream p__io, KaitaiStruct p__parent = null, ShopItemPositions8 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _shopItemPositions8Value = ((ShopItemPositions8Enum) m_io.ReadBitsIntLe(8));
        }
        private ShopItemPositions8Enum _shopItemPositions8Value;
        private ShopItemPositions8 m_root;
        private KaitaiStruct m_parent;
        public ShopItemPositions8Enum ShopItemPositions8Value { get { return _shopItemPositions8Value; } }
        public ShopItemPositions8 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
