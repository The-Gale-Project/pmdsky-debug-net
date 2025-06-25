// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Controls the Electivire Link Shop.
    /// </summary>
    public partial class Overlay18 : KaitaiStruct
    {
        public static Overlay18 FromFile(string fileName)
        {
            return new Overlay18(new KaitaiStream(fileName));
        }

        public Overlay18(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay18 p__root = null) : base(p__io)
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
        private Overlay18Data _data;
        public Overlay18Data Data
        {
            get
            {
                if (f_data)
                    return _data;
                _data = new Overlay18Data(m_io);
                f_data = true;
                return _data;
            }
        }
        private Overlay18 m_root;
        private KaitaiStruct m_parent;
        public Overlay18 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
