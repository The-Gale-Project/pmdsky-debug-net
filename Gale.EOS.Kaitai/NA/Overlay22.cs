// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Controls the Kecleon Shop in Treasure Town.
    /// </summary>
    public partial class Overlay22 : KaitaiStruct
    {
        public static Overlay22 FromFile(string fileName)
        {
            return new Overlay22(new KaitaiStream(fileName));
        }

        public Overlay22(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay22 p__root = null) : base(p__io)
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
        private Overlay22Data _data;
        public Overlay22Data Data
        {
            get
            {
                if (f_data)
                    return _data;
                _data = new Overlay22Data(m_io);
                f_data = true;
                return _data;
            }
        }
        private Overlay22 m_root;
        private KaitaiStruct m_parent;
        public Overlay22 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
