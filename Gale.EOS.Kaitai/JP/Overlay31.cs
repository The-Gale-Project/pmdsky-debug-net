// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Controls the dungeon menu (during dungeon mode).
    /// </summary>
    public partial class Overlay31 : KaitaiStruct
    {
        public static Overlay31 FromFile(string fileName)
        {
            return new Overlay31(new KaitaiStream(fileName));
        }

        public Overlay31(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay31 p__root = null) : base(p__io)
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
        private Overlay31Functions _functions;
        public Overlay31Functions Functions
        {
            get
            {
                if (f_functions)
                    return _functions;
                _functions = new Overlay31Functions(m_io);
                f_functions = true;
                return _functions;
            }
        }
        private bool f_data;
        private Overlay31Data _data;
        public Overlay31Data Data
        {
            get
            {
                if (f_data)
                    return _data;
                _data = new Overlay31Data(m_io);
                f_data = true;
                return _data;
            }
        }
        private Overlay31 m_root;
        private KaitaiStruct m_parent;
        public Overlay31 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
