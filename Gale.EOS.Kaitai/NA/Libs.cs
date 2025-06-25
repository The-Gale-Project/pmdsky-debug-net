// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// System libraries linked to the main ARM9 binary.
    /// 
    /// This includes code from common NDS system libraries like the Nitro SDK (which contains NDS-specific functionality as well as utilities akin to libc and libgcc).
    /// 
    /// Where the library region starts and ends is a guess, but there appear to be fairly sharp boundaries. The function directly before it calls functions at lower memory addresses outside of the region, while all functions in the region only call other functions within the region. The bytes after the region seem to be the start of a global data region, used by both the libraries and the rest of ARM9.
    /// </summary>
    public partial class Libs : KaitaiStruct
    {
        public static Libs FromFile(string fileName)
        {
            return new Libs(new KaitaiStream(fileName));
        }

        public Libs(KaitaiStream p__io, KaitaiStruct p__parent = null, Libs p__root = null) : base(p__io)
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
        private LibsFunctions _functions;
        public LibsFunctions Functions
        {
            get
            {
                if (f_functions)
                    return _functions;
                _functions = new LibsFunctions(m_io);
                f_functions = true;
                return _functions;
            }
        }
        private Libs m_root;
        private KaitaiStruct m_parent;
        public Libs M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
