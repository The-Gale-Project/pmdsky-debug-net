// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Likely controls the top menu.
    /// 
    /// This is loaded together with overlay 0 while in the top menu. Since it's in overlay group 1 (together with other &quot;main&quot; overlays like overlay 11 and overlay 29), this is probably the controller.
    /// 
    /// Seems to contain code related to Wi-Fi rescue. It mentions several files from the GROUND and BACK folders.
    /// </summary>
    public partial class Overlay1 : KaitaiStruct
    {
        public static Overlay1 FromFile(string fileName)
        {
            return new Overlay1(new KaitaiStream(fileName));
        }

        public Overlay1(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay1 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_functions = false;
            f_data = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_functions;
        private Overlay1Functions _functions;
        public Overlay1Functions Functions
        {
            get
            {
                if (f_functions)
                    return _functions;
                _functions = new Overlay1Functions(m_io);
                f_functions = true;
                return _functions;
            }
        }
        private bool f_data;
        private Overlay1Data _data;
        public Overlay1Data Data
        {
            get
            {
                if (f_data)
                    return _data;
                _data = new Overlay1Data(m_io);
                f_data = true;
                return _data;
            }
        }
        private Overlay1 m_root;
        private KaitaiStruct m_parent;
        public Overlay1 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
