// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union mem_arena defined within pmdsky-debug.
    /// </summary>
    public partial class MemArena : KaitaiStruct
    {
        public static MemArena FromFile(string fileName)
        {
            return new MemArena(new KaitaiStream(fileName));
        }

        public MemArena(KaitaiStream p__io, KaitaiStruct p__parent = null, MemArena p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _contentFlags = m_io.ReadU4le();
            _parent = new Pointer(m_io);
            _blocks = new Pointer(m_io);
            _nBlocks = m_io.ReadU4le();
            _maxBlocks = m_io.ReadU4le();
            _data = new Pointer(m_io);
            _len = m_io.ReadU4le();
        }
        private uint _contentFlags;
        private Pointer _parent;
        private Pointer _blocks;
        private uint _nBlocks;
        private uint _maxBlocks;
        private Pointer _data;
        private uint _len;
        private MemArena m_root;
        private KaitaiStruct m_parent;
        public uint ContentFlags { get { return _contentFlags; } }
        public Pointer Parent { get { return _parent; } }
        public Pointer Blocks { get { return _blocks; } }
        public uint NBlocks { get { return _nBlocks; } }
        public uint MaxBlocks { get { return _maxBlocks; } }
        public Pointer Data { get { return _data; } }
        public uint Len { get { return _len; } }
        public MemArena M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
