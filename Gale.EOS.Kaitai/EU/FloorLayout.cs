// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Holds the data for the enum floor_layout.
    /// </summary>
    public partial class FloorLayout : KaitaiStruct
    {
        public static FloorLayout FromFile(string fileName)
        {
            return new FloorLayout(new KaitaiStream(fileName));
        }


        public enum FloorLayoutEnum
        {
            LayoutLarge = 0,
            LayoutSmall = 1,
            LayoutOneRoomMonsterHouse = 2,
            LayoutOuterRing = 3,
            LayoutCrossroads = 4,
            LayoutTwoRoomsWithMonsterHouse = 5,
            LayoutLine = 6,
            LayoutCross = 7,
            LayoutLarge0x8 = 8,
            LayoutBeetle = 9,
            LayoutOuterRooms = 10,
            LayoutMedium = 11,
            LayoutUnused0xc = 12,
            LayoutUnused0xd = 13,
            LayoutUnused0xe = 14,
            LayoutUnused0xf = 15,
        }
        public FloorLayout(KaitaiStream p__io, KaitaiStruct p__parent = null, FloorLayout p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _floorLayoutValue = ((FloorLayoutEnum) m_io.ReadBitsIntLe(32));
        }
        private FloorLayoutEnum _floorLayoutValue;
        private FloorLayout m_root;
        private KaitaiStruct m_parent;
        public FloorLayoutEnum FloorLayoutValue { get { return _floorLayoutValue; } }
        public FloorLayout M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
