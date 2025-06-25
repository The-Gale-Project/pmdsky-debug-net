// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Controls the personality test, including the available partners and playable Pokémon. The actual personality test questions are stored in the MESSAGE folder.
    /// </summary>
    public partial class Overlay13 : KaitaiStruct
    {
        public static Overlay13 FromFile(string fileName)
        {
            return new Overlay13(new KaitaiStream(fileName));
        }

        public Overlay13(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay13 p__root = null) : base(p__io)
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
        private Overlay13Functions _functions;
        public Overlay13Functions Functions
        {
            get
            {
                if (f_functions)
                    return _functions;
                _functions = new Overlay13Functions(m_io);
                f_functions = true;
                return _functions;
            }
        }
        private bool f_data;
        private Overlay13Data _data;
        public Overlay13Data Data
        {
            get
            {
                if (f_data)
                    return _data;
                _data = new Overlay13Data(m_io);
                f_data = true;
                return _data;
            }
        }
        private Overlay13 m_root;
        private KaitaiStruct m_parent;
        public Overlay13 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
