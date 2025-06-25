// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Holds bitsized data for the parent enum move_range.
    /// </summary>
    public partial class MoveRange4 : KaitaiStruct
    {
        public static MoveRange4 FromFile(string fileName)
        {
            return new MoveRange4(new KaitaiStream(fileName));
        }


        public enum MoveRange4Enum
        {
            RangeFront = 0,
            RangeFrontAndSides = 1,
            RangeNearby = 2,
            RangeRoom = 3,
            RangeFront2 = 4,
            RangeFront10 = 5,
            RangeFloor = 6,
            RangeUser = 7,
            RangeFrontWithCornerCutting = 8,
            RangeFront2WithCornerCutting = 9,
            RangeSpecial = 15,
        }
        public MoveRange4(KaitaiStream p__io, KaitaiStruct p__parent = null, MoveRange4 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _moveRange4Value = ((MoveRange4Enum) m_io.ReadBitsIntLe(4));
        }
        private MoveRange4Enum _moveRange4Value;
        private MoveRange4 m_root;
        private KaitaiStruct m_parent;
        public MoveRange4Enum MoveRange4Value { get { return _moveRange4Value; } }
        public MoveRange4 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
