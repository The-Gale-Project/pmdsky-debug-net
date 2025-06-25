// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Holds bitsized data for the parent enum direction_id.
    /// </summary>
    public partial class DirectionId8 : KaitaiStruct
    {
        public static DirectionId8 FromFile(string fileName)
        {
            return new DirectionId8(new KaitaiStream(fileName));
        }


        public enum DirectionId8Enum
        {
            DirNone = -1,
            DirDown = 0,
            DirDownRight = 1,
            DirRight = 2,
            DirUpRight = 3,
            DirUp = 4,
            DirUpLeft = 5,
            DirLeft = 6,
            DirDownLeft = 7,
            DirCurrent = 8,
        }
        public DirectionId8(KaitaiStream p__io, KaitaiStruct p__parent = null, DirectionId8 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _directionId8Value = ((DirectionId8Enum) m_io.ReadBitsIntLe(8));
        }
        private DirectionId8Enum _directionId8Value;
        private DirectionId8 m_root;
        private KaitaiStruct m_parent;
        public DirectionId8Enum DirectionId8Value { get { return _directionId8Value; } }
        public DirectionId8 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
