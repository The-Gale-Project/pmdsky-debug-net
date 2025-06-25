// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Holds bitsized data for the parent enum floor_size.
    /// </summary>
    public partial class FloorSize8 : KaitaiStruct
    {
        public static FloorSize8 FromFile(string fileName)
        {
            return new FloorSize8(new KaitaiStream(fileName));
        }


        public enum FloorSize8Enum
        {
            FloorSizeLarge = 0,
            FloorSizeSmall = 1,
            FloorSizeMedium = 2,
        }
        public FloorSize8(KaitaiStream p__io, KaitaiStruct p__parent = null, FloorSize8 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _floorSize8Value = ((FloorSize8Enum) m_io.ReadBitsIntLe(8));
        }
        private FloorSize8Enum _floorSize8Value;
        private FloorSize8 m_root;
        private KaitaiStruct m_parent;
        public FloorSize8Enum FloorSize8Value { get { return _floorSize8Value; } }
        public FloorSize8 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
