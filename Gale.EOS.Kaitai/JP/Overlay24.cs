// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Controls the Chansey Day Care.
    /// </summary>
    public partial class Overlay24 : KaitaiStruct
    {
        public static Overlay24 FromFile(string fileName)
        {
            return new Overlay24(new KaitaiStream(fileName));
        }

        public Overlay24(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay24 p__root = null) : base(p__io)
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
        private Overlay24Data _data;
        public Overlay24Data Data
        {
            get
            {
                if (f_data)
                    return _data;
                _data = new Overlay24Data(m_io);
                f_data = true;
                return _data;
            }
        }
        private Overlay24 m_root;
        private KaitaiStruct m_parent;
        public Overlay24 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
