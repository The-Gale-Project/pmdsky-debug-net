// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Controls the Croagunk Swap Shop.
    /// </summary>
    public partial class Overlay21 : KaitaiStruct
    {
        public static Overlay21 FromFile(string fileName)
        {
            return new Overlay21(new KaitaiStream(fileName));
        }

        public Overlay21(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay21 p__root = null) : base(p__io)
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
        private Overlay21Data _data;
        public Overlay21Data Data
        {
            get
            {
                if (f_data)
                    return _data;
                _data = new Overlay21Data(m_io);
                f_data = true;
                return _data;
            }
        }
        private Overlay21 m_root;
        private KaitaiStruct m_parent;
        public Overlay21 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
