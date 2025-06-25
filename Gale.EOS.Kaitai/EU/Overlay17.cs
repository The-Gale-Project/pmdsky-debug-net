// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Controls the Chimecho Assembly.
    /// </summary>
    public partial class Overlay17 : KaitaiStruct
    {
        public static Overlay17 FromFile(string fileName)
        {
            return new Overlay17(new KaitaiStream(fileName));
        }

        public Overlay17(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay17 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_data = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_data;
        private Overlay17Data _data;
        public Overlay17Data Data
        {
            get
            {
                if (f_data)
                    return _data;
                _data = new Overlay17Data(m_io);
                f_data = true;
                return _data;
            }
        }
        private Overlay17 m_root;
        private KaitaiStruct m_parent;
        public Overlay17 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
