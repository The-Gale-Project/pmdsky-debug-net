// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Runs the sentry duty minigame.
    /// </summary>
    public partial class Overlay14 : KaitaiStruct
    {
        public static Overlay14 FromFile(string fileName)
        {
            return new Overlay14(new KaitaiStream(fileName));
        }

        public Overlay14(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay14 p__root = null) : base(p__io)
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
        private Overlay14Functions _functions;
        public Overlay14Functions Functions
        {
            get
            {
                if (f_functions)
                    return _functions;
                _functions = new Overlay14Functions(m_io);
                f_functions = true;
                return _functions;
            }
        }
        private bool f_data;
        private Overlay14Data _data;
        public Overlay14Data Data
        {
            get
            {
                if (f_data)
                    return _data;
                _data = new Overlay14Data(m_io);
                f_data = true;
                return _data;
            }
        }
        private Overlay14 m_root;
        private KaitaiStruct m_parent;
        public Overlay14 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
