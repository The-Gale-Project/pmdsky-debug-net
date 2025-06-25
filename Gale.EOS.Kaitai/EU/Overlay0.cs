// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Likely contains supporting data and code related to the top menu.
    /// 
    /// This is loaded together with overlay 1 while in the top menu. Since it's in overlay group 2 (together with overlay 10, which is another &quot;data&quot; overlay), this overlay probably plays a similar role. It mentions several files from the BACK folder that are known backgrounds for the top menu.
    /// </summary>
    public partial class Overlay0 : KaitaiStruct
    {
        public static Overlay0 FromFile(string fileName)
        {
            return new Overlay0(new KaitaiStream(fileName));
        }

        public Overlay0(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay0 p__root = null) : base(p__io)
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
        private Overlay0Functions _functions;
        public Overlay0Functions Functions
        {
            get
            {
                if (f_functions)
                    return _functions;
                _functions = new Overlay0Functions(m_io);
                f_functions = true;
                return _functions;
            }
        }
        private Overlay0 m_root;
        private KaitaiStruct m_parent;
        public Overlay0 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
