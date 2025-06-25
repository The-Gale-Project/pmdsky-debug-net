// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union mem_block defined within pmdsky-debug.
    /// </summary>
    public partial class MemBlock : KaitaiStruct
    {
        public static MemBlock FromFile(string fileName)
        {
            return new MemBlock(new KaitaiStream(fileName));
        }

        public MemBlock(KaitaiStream p__io, KaitaiStruct p__parent = null, MemBlock p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _fInUse = m_io.ReadBitsIntLe(1) != 0;
            _fObject = m_io.ReadBitsIntLe(1) != 0;
            _fArena = m_io.ReadBitsIntLe(1) != 0;
            _contentFlagsUnused = m_io.ReadBitsIntLe(29);
            _fAllocInUse = m_io.ReadBitsIntLe(1) != 0;
            _fAllocObject = m_io.ReadBitsIntLe(1) != 0;
            _fAllocArena = m_io.ReadBitsIntLe(1) != 0;
            _fAllocSubarena = m_io.ReadBitsIntLe(1) != 0;
            _allocatorFlagsUnused = m_io.ReadBitsIntLe(28);
            _userFlags = m_io.ReadBitsIntLe(8);
            _fUserAllocInUse = m_io.ReadBitsIntLe(1) != 0;
            _fUserAllocObject = m_io.ReadBitsIntLe(1) != 0;
            _fUserAllocArena = m_io.ReadBitsIntLe(1) != 0;
            _fUserAllocSubarena = m_io.ReadBitsIntLe(1) != 0;
            _userFlagsUnused = m_io.ReadBitsIntLe(20);
            m_io.AlignToByte();
            _data = new Pointer(m_io);
            _available = m_io.ReadU4le();
            _used = m_io.ReadU4le();
        }
        private bool _fInUse;
        private bool _fObject;
        private bool _fArena;
        private ulong _contentFlagsUnused;
        private bool _fAllocInUse;
        private bool _fAllocObject;
        private bool _fAllocArena;
        private bool _fAllocSubarena;
        private ulong _allocatorFlagsUnused;
        private ulong _userFlags;
        private bool _fUserAllocInUse;
        private bool _fUserAllocObject;
        private bool _fUserAllocArena;
        private bool _fUserAllocSubarena;
        private ulong _userFlagsUnused;
        private Pointer _data;
        private uint _available;
        private uint _used;
        private MemBlock m_root;
        private KaitaiStruct m_parent;
        public bool FInUse { get { return _fInUse; } }
        public bool FObject { get { return _fObject; } }
        public bool FArena { get { return _fArena; } }
        public ulong ContentFlagsUnused { get { return _contentFlagsUnused; } }
        public bool FAllocInUse { get { return _fAllocInUse; } }
        public bool FAllocObject { get { return _fAllocObject; } }
        public bool FAllocArena { get { return _fAllocArena; } }
        public bool FAllocSubarena { get { return _fAllocSubarena; } }
        public ulong AllocatorFlagsUnused { get { return _allocatorFlagsUnused; } }
        public ulong UserFlags { get { return _userFlags; } }
        public bool FUserAllocInUse { get { return _fUserAllocInUse; } }
        public bool FUserAllocObject { get { return _fUserAllocObject; } }
        public bool FUserAllocArena { get { return _fUserAllocArena; } }
        public bool FUserAllocSubarena { get { return _fUserAllocSubarena; } }
        public ulong UserFlagsUnused { get { return _userFlagsUnused; } }
        public Pointer Data { get { return _data; } }
        public uint Available { get { return _available; } }
        public uint Used { get { return _used; } }
        public MemBlock M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
