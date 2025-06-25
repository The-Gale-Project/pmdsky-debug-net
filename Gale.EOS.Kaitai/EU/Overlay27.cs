// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Controls the special episode item discard menu.
    /// </summary>
    public partial class Overlay27 : KaitaiStruct
    {
        public static Overlay27 FromFile(string fileName)
        {
            return new Overlay27(new KaitaiStream(fileName));
        }

        public Overlay27(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay27 p__root = null) : base(p__io)
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
        private Overlay27Data _data;
        public Overlay27Data Data
        {
            get
            {
                if (f_data)
                    return _data;
                _data = new Overlay27Data(m_io);
                f_data = true;
                return _data;
            }
        }
        private Overlay27 m_root;
        private KaitaiStruct m_parent;
        public Overlay27 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
