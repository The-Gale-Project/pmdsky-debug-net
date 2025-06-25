// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Holds bitsized data for the parent enum floor_loop_status.
    /// </summary>
    public partial class FloorLoopStatus8 : KaitaiStruct
    {
        public static FloorLoopStatus8 FromFile(string fileName)
        {
            return new FloorLoopStatus8(new KaitaiStream(fileName));
        }


        public enum FloorLoopStatus8Enum
        {
            FloorLoopContinue = 0,
            FloorLoopLeaderFainted = 1,
            FloorLoopNextFloor = 2,
        }
        public FloorLoopStatus8(KaitaiStream p__io, KaitaiStruct p__parent = null, FloorLoopStatus8 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _floorLoopStatus8Value = ((FloorLoopStatus8Enum) m_io.ReadBitsIntLe(8));
        }
        private FloorLoopStatus8Enum _floorLoopStatus8Value;
        private FloorLoopStatus8 m_root;
        private KaitaiStruct m_parent;
        public FloorLoopStatus8Enum FloorLoopStatus8Value { get { return _floorLoopStatus8Value; } }
        public FloorLoopStatus8 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
