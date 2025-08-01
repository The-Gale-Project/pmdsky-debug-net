// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Controls Luminous Spring.
    /// </summary>
    public partial class Overlay16 : KaitaiStruct
    {
        public static Overlay16 FromFile(string fileName)
        {
            return new Overlay16(new KaitaiStream(fileName));
        }

        public Overlay16(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay16 p__root = null) : base(p__io)
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
        private Overlay16Data _data;
        public Overlay16Data Data
        {
            get
            {
                if (f_data)
                    return _data;
                _data = new Overlay16Data(m_io);
                f_data = true;
                return _data;
            }
        }
        private Overlay16 m_root;
        private KaitaiStruct m_parent;
        public Overlay16 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
