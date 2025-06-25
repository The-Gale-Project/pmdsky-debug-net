// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Controls Spinda's Juice Bar.
    /// </summary>
    public partial class Overlay19 : KaitaiStruct
    {
        public static Overlay19 FromFile(string fileName)
        {
            return new Overlay19(new KaitaiStream(fileName));
        }

        public Overlay19(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay19 p__root = null) : base(p__io)
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
        private Overlay19Functions _functions;
        public Overlay19Functions Functions
        {
            get
            {
                if (f_functions)
                    return _functions;
                _functions = new Overlay19Functions(m_io);
                f_functions = true;
                return _functions;
            }
        }
        private bool f_data;
        private Overlay19Data _data;
        public Overlay19Data Data
        {
            get
            {
                if (f_data)
                    return _data;
                _data = new Overlay19Data(m_io);
                f_data = true;
                return _data;
            }
        }
        private Overlay19 m_root;
        private KaitaiStruct m_parent;
        public Overlay19 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
