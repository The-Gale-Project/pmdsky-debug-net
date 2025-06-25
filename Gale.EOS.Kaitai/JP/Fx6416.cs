// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents a struct or union fx64_16 defined within pmdsky-debug.
    /// </summary>
    public partial class Fx6416 : KaitaiStruct
    {
        public static Fx6416 FromFile(string fileName)
        {
            return new Fx6416(new KaitaiStream(fileName));
        }

        public Fx6416(KaitaiStream p__io, KaitaiStruct p__parent = null, Fx6416 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _upper = m_io.ReadS4le();
            _lower = m_io.ReadU4le();
        }
        private int _upper;
        private uint _lower;
        private Fx6416 m_root;
        private KaitaiStruct m_parent;
        public int Upper { get { return _upper; } }
        public uint Lower { get { return _lower; } }
        public Fx6416 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
