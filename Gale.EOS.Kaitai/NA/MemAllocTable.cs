// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union mem_alloc_table defined within pmdsky-debug.
    /// </summary>
    public partial class MemAllocTable : KaitaiStruct
    {
        public static MemAllocTable FromFile(string fileName)
        {
            return new MemAllocTable(new KaitaiStream(fileName));
        }

        public MemAllocTable(KaitaiStream p__io, KaitaiStruct p__parent = null, MemAllocTable p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _nArenas = m_io.ReadU4le();
            _defaultArena = new MemArena(m_io);
            _arenas = new MemAllocTableArenasArray(m_io);
        }
        private uint _nArenas;
        private MemArena _defaultArena;
        private MemAllocTableArenasArray _arenas;
        private MemAllocTable m_root;
        private KaitaiStruct m_parent;
        public uint NArenas { get { return _nArenas; } }
        public MemArena DefaultArena { get { return _defaultArena; } }
        public MemAllocTableArenasArray Arenas { get { return _arenas; } }
        public MemAllocTable M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
