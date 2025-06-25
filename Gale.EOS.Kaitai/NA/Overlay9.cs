// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Controls the Sky Jukebox.
    /// </summary>
    public partial class Overlay9 : KaitaiStruct
    {
        public static Overlay9 FromFile(string fileName)
        {
            return new Overlay9(new KaitaiStream(fileName));
        }

        public Overlay9(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay9 p__root = null) : base(p__io)
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
        private Overlay9Functions _functions;
        public Overlay9Functions Functions
        {
            get
            {
                if (f_functions)
                    return _functions;
                _functions = new Overlay9Functions(m_io);
                f_functions = true;
                return _functions;
            }
        }
        private bool f_data;
        private Overlay9Data _data;
        public Overlay9Data Data
        {
            get
            {
                if (f_data)
                    return _data;
                _data = new Overlay9Data(m_io);
                f_data = true;
                return _data;
            }
        }
        private Overlay9 m_root;
        private KaitaiStruct m_parent;
        public Overlay9 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
