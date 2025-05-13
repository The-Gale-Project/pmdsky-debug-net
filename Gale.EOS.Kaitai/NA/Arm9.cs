// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// The main ARM9 binary.
    /// 
    /// This is the main binary that gets loaded when the game is launched, and contains the core code that runs the game, low level facilities such as memory allocation, compression, other external dependencies (such as linked libraries), and the functions and tables necessary to load overlays and dispatch execution to them.
    /// 
    /// Speaking generally, this is the program run by the Nintendo DS's main ARM946E-S CPU, which handles all gameplay mechanisms and graphics rendering.
    /// </summary>
    public partial class Arm9 : KaitaiStruct
    {
        public static Arm9 FromFile(string fileName)
        {
            return new Arm9(new KaitaiStream(fileName));
        }

        public Arm9(KaitaiStream p__io, KaitaiStruct p__parent = null, Arm9 p__root = null) : base(p__io)
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
        private Arm9Functions _functions;
        public Arm9Functions Functions
        {
            get
            {
                if (f_functions)
                    return _functions;
                _functions = new Arm9Functions(m_io);
                f_functions = true;
                return _functions;
            }
        }
        private Arm9 m_root;
        private KaitaiStruct m_parent;
        public Arm9 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
