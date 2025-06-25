// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Holds bitsized data for the parent enum move_category.
    /// </summary>
    public partial class MoveCategory8 : KaitaiStruct
    {
        public static MoveCategory8 FromFile(string fileName)
        {
            return new MoveCategory8(new KaitaiStream(fileName));
        }


        public enum MoveCategory8Enum
        {
            CategoryPhysical = 0,
            CategorySpecial = 1,
            CategoryStatus = 2,
            CategoryNone = 3,
        }
        public MoveCategory8(KaitaiStream p__io, KaitaiStruct p__parent = null, MoveCategory8 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _moveCategory8Value = ((MoveCategory8Enum) m_io.ReadBitsIntLe(8));
        }
        private MoveCategory8Enum _moveCategory8Value;
        private MoveCategory8 m_root;
        private KaitaiStruct m_parent;
        public MoveCategory8Enum MoveCategory8Value { get { return _moveCategory8Value; } }
        public MoveCategory8 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
