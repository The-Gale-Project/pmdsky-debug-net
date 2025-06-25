// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Controls Kangaskhan Storage (both in Treasure Town and via Kangaskhan Rocks).
    /// </summary>
    public partial class Overlay23 : KaitaiStruct
    {
        public static Overlay23 FromFile(string fileName)
        {
            return new Overlay23(new KaitaiStream(fileName));
        }

        public Overlay23(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay23 p__root = null) : base(p__io)
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
        private Overlay23Data _data;
        public Overlay23Data Data
        {
            get
            {
                if (f_data)
                    return _data;
                _data = new Overlay23Data(m_io);
                f_data = true;
                return _data;
            }
        }
        private Overlay23 m_root;
        private KaitaiStruct m_parent;
        public Overlay23 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
