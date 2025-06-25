// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Holds bitsized data for the parent enum screen.
    /// </summary>
    public partial class Screen8 : KaitaiStruct
    {
        public static Screen8 FromFile(string fileName)
        {
            return new Screen8(new KaitaiStream(fileName));
        }


        public enum Screen8Enum
        {
            ScreenMain = 0,
            ScreenSub = 1,
        }
        public Screen8(KaitaiStream p__io, KaitaiStruct p__parent = null, Screen8 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _screen8Value = ((Screen8Enum) m_io.ReadBitsIntLe(8));
        }
        private Screen8Enum _screen8Value;
        private Screen8 m_root;
        private KaitaiStruct m_parent;
        public Screen8Enum Screen8Value { get { return _screen8Value; } }
        public Screen8 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
