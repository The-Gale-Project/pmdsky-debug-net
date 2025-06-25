// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union mem_arena_getters defined within pmdsky-debug.
    /// </summary>
    public partial class MemArenaGetters : KaitaiStruct
    {
        public static MemArenaGetters FromFile(string fileName)
        {
            return new MemArenaGetters(new KaitaiStream(fileName));
        }

        public MemArenaGetters(KaitaiStream p__io, KaitaiStruct p__parent = null, MemArenaGetters p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _getAllocArena = new Pointer(m_io);
            _getFreeArena = new Pointer(m_io);
        }
        private Pointer _getAllocArena;
        private Pointer _getFreeArena;
        private MemArenaGetters m_root;
        private KaitaiStruct m_parent;
        public Pointer GetAllocArena { get { return _getAllocArena; } }
        public Pointer GetFreeArena { get { return _getFreeArena; } }
        public MemArenaGetters M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
