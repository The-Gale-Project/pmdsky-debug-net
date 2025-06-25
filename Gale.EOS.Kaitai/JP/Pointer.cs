// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents a memory address stored within the binary.
    /// </summary>
    public partial class Pointer : KaitaiStruct
    {
        public static Pointer FromFile(string fileName)
        {
            return new Pointer(new KaitaiStream(fileName));
        }

        public Pointer(KaitaiStream p__io, KaitaiStruct p__parent = null, Pointer p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _memAddress = m_io.ReadU4le();
        }
        private uint _memAddress;
        private Pointer m_root;
        private KaitaiStruct m_parent;
        public uint MemAddress { get { return _memAddress; } }
        public Pointer M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
