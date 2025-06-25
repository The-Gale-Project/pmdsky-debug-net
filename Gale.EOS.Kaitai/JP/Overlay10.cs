// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Appears to be used both during ground mode and dungeon mode. With dungeon mode, whereas overlay 29 contains the main dungeon engine, this overlay seems to contain routines and data for dungeon mechanics.
    /// </summary>
    public partial class Overlay10 : KaitaiStruct
    {
        public static Overlay10 FromFile(string fileName)
        {
            return new Overlay10(new KaitaiStream(fileName));
        }

        public Overlay10(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay10 p__root = null) : base(p__io)
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
        private Overlay10Functions _functions;
        public Overlay10Functions Functions
        {
            get
            {
                if (f_functions)
                    return _functions;
                _functions = new Overlay10Functions(m_io);
                f_functions = true;
                return _functions;
            }
        }
        private bool f_data;
        private Overlay10Data _data;
        public Overlay10Data Data
        {
            get
            {
                if (f_data)
                    return _data;
                _data = new Overlay10Data(m_io);
                f_data = true;
                return _data;
            }
        }
        private Overlay10 m_root;
        private KaitaiStruct m_parent;
        public Overlay10 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
