// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Related to launching the game.
    /// 
    /// There are mention in the strings of logos like the ESRB logo. This only seems to be loaded during the ESRB rating splash screen, so this is likely the sole purpose of this overlay.
    /// </summary>
    public partial class Overlay34 : KaitaiStruct
    {
        public static Overlay34 FromFile(string fileName)
        {
            return new Overlay34(new KaitaiStream(fileName));
        }

        public Overlay34(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay34 p__root = null) : base(p__io)
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
        private Overlay34Functions _functions;
        public Overlay34Functions Functions
        {
            get
            {
                if (f_functions)
                    return _functions;
                _functions = new Overlay34Functions(m_io);
                f_functions = true;
                return _functions;
            }
        }
        private bool f_data;
        private Overlay34Data _data;
        public Overlay34Data Data
        {
            get
            {
                if (f_data)
                    return _data;
                _data = new Overlay34Data(m_io);
                f_data = true;
                return _data;
            }
        }
        private Overlay34 m_root;
        private KaitaiStruct m_parent;
        public Overlay34 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
