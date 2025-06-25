// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Holds the data for the enum direction_id.
    /// </summary>
    public partial class DirectionId : KaitaiStruct
    {
        public static DirectionId FromFile(string fileName)
        {
            return new DirectionId(new KaitaiStream(fileName));
        }


        public enum DirectionIdEnum
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
        public DirectionId(KaitaiStream p__io, KaitaiStruct p__parent = null, DirectionId p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _directionIdValue = ((DirectionIdEnum) m_io.ReadBitsIntLe(32));
        }
        private DirectionIdEnum _directionIdValue;
        private DirectionId m_root;
        private KaitaiStruct m_parent;
        public DirectionIdEnum DirectionIdValue { get { return _directionIdValue; } }
        public DirectionId M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
