// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Holds the data for the enum move_category.
    /// </summary>
    public partial class MoveCategory : KaitaiStruct
    {
        public static MoveCategory FromFile(string fileName)
        {
            return new MoveCategory(new KaitaiStream(fileName));
        }


        public enum MoveCategoryEnum
        {
            CategoryPhysical = 0,
            CategorySpecial = 1,
            CategoryStatus = 2,
            CategoryNone = 3,
        }
        public MoveCategory(KaitaiStream p__io, KaitaiStruct p__parent = null, MoveCategory p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _moveCategoryValue = ((MoveCategoryEnum) m_io.ReadBitsIntLe(32));
        }
        private MoveCategoryEnum _moveCategoryValue;
        private MoveCategory m_root;
        private KaitaiStruct m_parent;
        public MoveCategoryEnum MoveCategoryValue { get { return _moveCategoryValue; } }
        public MoveCategory M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
