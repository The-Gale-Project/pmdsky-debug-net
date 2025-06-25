// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Controls the Recycle Shop.
    /// </summary>
    public partial class Overlay20 : KaitaiStruct
    {
        public static Overlay20 FromFile(string fileName)
        {
            return new Overlay20(new KaitaiStream(fileName));
        }

        public Overlay20(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay20 p__root = null) : base(p__io)
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
        private Overlay20Data _data;
        public Overlay20Data Data
        {
            get
            {
                if (f_data)
                    return _data;
                _data = new Overlay20Data(m_io);
                f_data = true;
                return _data;
            }
        }
        private Overlay20 m_root;
        private KaitaiStruct m_parent;
        public Overlay20 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
