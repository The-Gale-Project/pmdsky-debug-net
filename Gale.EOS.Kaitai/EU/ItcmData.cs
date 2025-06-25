// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{
    public partial class ItcmData : KaitaiStruct
    {
        public static ItcmData FromFile(string fileName)
        {
            return new ItcmData(new KaitaiStream(fileName));
        }

        public ItcmData(KaitaiStream p__io, KaitaiStruct p__parent = null, ItcmData p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_memoryAllocationTable = false;
            f_defaultMemoryArena = false;
            f_defaultMemoryArenaBlocks = false;
            f_render3dFunctions = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_memoryAllocationTable;
        private MemAllocTable _memoryAllocationTable;

        /// <summary>
        /// [Runtime] Keeps track of all active heap allocations.
        /// 
        /// The memory allocator in the ARM9 binary uses region-based memory management (see https://en.wikipedia.org/wiki/Region-based_memory_management). The heap is broken up into smaller contiguous chunks called arenas (struct mem_arena), which are in turn broken up into chunks referred to as blocks (struct mem_block). Most of the time, an allocation results in a block being split off from a free part of an existing memory arena.
        /// 
        /// Note: This symbol isn't actually part of the ITCM, it gets created at runtime on the spot in RAM that used to contain the code that was moved to the ITCM.
        /// 
        /// type: struct mem_alloc_table
        /// </summary>
        public MemAllocTable MemoryAllocationTable
        {
            get
            {
                if (f_memoryAllocationTable)
                    return _memoryAllocationTable;
                long _pos = m_io.Pos;
                m_io.Seek(0);
                _memoryAllocationTable = new MemAllocTable(m_io);
                m_io.Seek(_pos);
                f_memoryAllocationTable = true;
                return _memoryAllocationTable;
            }
        }
        private bool f_defaultMemoryArena;
        private MemArena _defaultMemoryArena;

        /// <summary>
        /// [Runtime] The default memory allocation arena. This is part of MEMORY_ALLOCATION_TABLE, but is also referenced on its own by various functions.
        /// 
        /// Note: This symbol isn't actually part of the ITCM, it gets created at runtime on the spot in RAM that used to contain the code that was moved to the ITCM.
        /// 
        /// type: struct mem_arena
        /// </summary>
        public MemArena DefaultMemoryArena
        {
            get
            {
                if (f_defaultMemoryArena)
                    return _defaultMemoryArena;
                long _pos = m_io.Pos;
                m_io.Seek(4);
                _defaultMemoryArena = new MemArena(m_io);
                m_io.Seek(_pos);
                f_defaultMemoryArena = true;
                return _defaultMemoryArena;
            }
        }
        private bool f_defaultMemoryArenaBlocks;
        private DefaultMemoryArenaBlocksArray _defaultMemoryArenaBlocks;

        /// <summary>
        /// [Runtime] The block array for DEFAULT_MEMORY_ARENA.
        /// 
        /// Note: This symbol isn't actually part of the ITCM, it gets created at runtime on the spot in RAM that used to contain the code that was moved to the ITCM.
        /// 
        /// type: struct mem_block[256]
        /// </summary>
        public DefaultMemoryArenaBlocksArray DefaultMemoryArenaBlocks
        {
            get
            {
                if (f_defaultMemoryArenaBlocks)
                    return _defaultMemoryArenaBlocks;
                long _pos = m_io.Pos;
                m_io.Seek(64);
                _defaultMemoryArenaBlocks = new DefaultMemoryArenaBlocksArray(m_io);
                m_io.Seek(_pos);
                f_defaultMemoryArenaBlocks = true;
                return _defaultMemoryArenaBlocks;
            }
        }
        private bool f_render3dFunctions;
        private Render3dFunctionsArray _render3dFunctions;

        /// <summary>
        /// Pointers to the 4 functions available for rendering a render_3d_element (in ITCM)
        /// 
        /// type: render_3d_element_fn_t[4]
        /// </summary>
        public Render3dFunctionsArray Render3dFunctions
        {
            get
            {
                if (f_render3dFunctions)
                    return _render3dFunctions;
                long _pos = m_io.Pos;
                m_io.Seek(288);
                _render3dFunctions = new Render3dFunctionsArray(m_io);
                m_io.Seek(_pos);
                f_render3dFunctions = true;
                return _render3dFunctions;
            }
        }
        private ItcmData m_root;
        private KaitaiStruct m_parent;
        public ItcmData M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
