// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union rgba defined within pmdsky-debug.
    /// </summary>
    public partial class Rgba : KaitaiStruct
    {
        public static Rgba FromFile(string fileName)
        {
            return new Rgba(new KaitaiStream(fileName));
        }

        public Rgba(KaitaiStream p__io, KaitaiStruct p__parent = null, Rgba p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _r = m_io.ReadU1();
            _g = m_io.ReadU1();
            _b = m_io.ReadU1();
            _a = m_io.ReadU1();
        }
        private byte _r;
        private byte _g;
        private byte _b;
        private byte _a;
        private Rgba m_root;
        private KaitaiStruct m_parent;
        public byte R { get { return _r; } }
        public byte G { get { return _g; } }
        public byte B { get { return _b; } }
        public byte A { get { return _a; } }
        public Rgba M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
