// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Holds bitsized data for the parent enum box_type.
    /// </summary>
    public partial class BoxType8 : KaitaiStruct
    {
        public static BoxType8 FromFile(string fileName)
        {
            return new BoxType8(new KaitaiStream(fileName));
        }


        public enum BoxType8Enum
        {
            BoxTypeInvisible = 251,
            BoxTypeNormal = 254,
        }
        public BoxType8(KaitaiStream p__io, KaitaiStruct p__parent = null, BoxType8 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _boxType8Value = ((BoxType8Enum) m_io.ReadBitsIntLe(8));
        }
        private BoxType8Enum _boxType8Value;
        private BoxType8 m_root;
        private KaitaiStruct m_parent;
        public BoxType8Enum BoxType8Value { get { return _boxType8Value; } }
        public BoxType8 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
