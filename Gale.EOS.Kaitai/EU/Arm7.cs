// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// The ARM7 binary.
    /// 
    /// This is the secondary binary that gets loaded when the game is launched.
    /// 
    /// Speaking generally, this is the program run by the Nintendo DS's secondary ARM7TDMI CPU, which handles the audio I/O, the touch screen, Wi-Fi functions, cryptography, and more.
    /// 
    /// Memory map: (binary is initially loaded at 0x2380000)
    /// 0x2380000-0x23801E8 =&gt; Contains _start_arm7 and two more methods, all related to memory mapping.
    /// 0x23801E8-0x238F7F0 =&gt; Mapped to 0x37F8000, contains NitroSpMain and functions crucial to execution.
    /// 0x238F7F0-0x23A7068 =&gt; Mapped to 0x27E0000, contains everything else that won't fit in the fast WRAM.
    /// 
    /// Note that while the length for the main EU/NA/JP block is defined as 0x27080 above, after memory mappings, the block located at that address is only a 0x1E8 long ENTRY block, containing 3 functions solely used for the initial memory mapping. The memory following this block is reused and its purpose is undocumented at the moment.
    /// </summary>
    public partial class Arm7 : KaitaiStruct
    {
        public static Arm7 FromFile(string fileName)
        {
            return new Arm7(new KaitaiStream(fileName));
        }

        public Arm7(KaitaiStream p__io, KaitaiStruct p__parent = null, Arm7 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_functions = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_functions;
        private Arm7Functions _functions;
        public Arm7Functions Functions
        {
            get
            {
                if (f_functions)
                    return _functions;
                _functions = new Arm7Functions(m_io);
                f_functions = true;
                return _functions;
            }
        }
        private Arm7 m_root;
        private KaitaiStruct m_parent;
        public Arm7 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
