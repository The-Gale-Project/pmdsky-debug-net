// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Holds bitsized data for the parent enum floor_layout.
    /// </summary>
    public partial class FloorLayout8 : KaitaiStruct
    {
        public static FloorLayout8 FromFile(string fileName)
        {
            return new FloorLayout8(new KaitaiStream(fileName));
        }


        public enum FloorLayout8Enum
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
        public FloorLayout8(KaitaiStream p__io, KaitaiStruct p__parent = null, FloorLayout8 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _floorLayout8Value = ((FloorLayout8Enum) m_io.ReadBitsIntLe(8));
        }
        private FloorLayout8Enum _floorLayout8Value;
        private FloorLayout8 m_root;
        private KaitaiStruct m_parent;
        public FloorLayout8Enum FloorLayout8Value { get { return _floorLayout8Value; } }
        public FloorLayout8 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
