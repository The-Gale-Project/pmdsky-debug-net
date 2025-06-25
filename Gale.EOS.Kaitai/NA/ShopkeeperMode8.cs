// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Holds bitsized data for the parent enum shopkeeper_mode.
    /// </summary>
    public partial class ShopkeeperMode8 : KaitaiStruct
    {
        public static ShopkeeperMode8 FromFile(string fileName)
        {
            return new ShopkeeperMode8(new KaitaiStream(fileName));
        }


        public enum ShopkeeperMode8Enum
        {
            ShopkeeperModeNormal = 0,
            ShopkeeperModeShopkeeper = 1,
            ShopkeeperModeAttackEnemies = 2,
            ShopkeeperModeAttackTeam = 3,
        }
        public ShopkeeperMode8(KaitaiStream p__io, KaitaiStruct p__parent = null, ShopkeeperMode8 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _shopkeeperMode8Value = ((ShopkeeperMode8Enum) m_io.ReadBitsIntLe(8));
        }
        private ShopkeeperMode8Enum _shopkeeperMode8Value;
        private ShopkeeperMode8 m_root;
        private KaitaiStruct m_parent;
        public ShopkeeperMode8Enum ShopkeeperMode8Value { get { return _shopkeeperMode8Value; } }
        public ShopkeeperMode8 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
