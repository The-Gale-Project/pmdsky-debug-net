// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Controls Xatu Appraisal.
    /// </summary>
    public partial class Overlay25 : KaitaiStruct
    {
        public static Overlay25 FromFile(string fileName)
        {
            return new Overlay25(new KaitaiStream(fileName));
        }

        public Overlay25(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay25 p__root = null) : base(p__io)
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
        private Overlay25Data _data;
        public Overlay25Data Data
        {
            get
            {
                if (f_data)
                    return _data;
                _data = new Overlay25Data(m_io);
                f_data = true;
                return _data;
            }
        }
        private Overlay25 m_root;
        private KaitaiStruct m_parent;
        public Overlay25 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
