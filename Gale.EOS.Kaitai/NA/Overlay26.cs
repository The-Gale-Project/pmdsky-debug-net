// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Related to mission completion. It's loaded when the dungeon completion summary is shown upon exiting a dungeon, and during the cutscenes where you collect mission rewards from clients.
    /// </summary>
    public partial class Overlay26 : KaitaiStruct
    {
        public static Overlay26 FromFile(string fileName)
        {
            return new Overlay26(new KaitaiStream(fileName));
        }

        public Overlay26(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay26 p__root = null) : base(p__io)
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
        private Overlay26Data _data;
        public Overlay26Data Data
        {
            get
            {
                if (f_data)
                    return _data;
                _data = new Overlay26Data(m_io);
                f_data = true;
                return _data;
            }
        }
        private Overlay26 m_root;
        private KaitaiStruct m_parent;
        public Overlay26 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
