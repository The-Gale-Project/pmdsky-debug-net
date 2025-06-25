// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// List of functions within OVERLAY0 with relative address locations as their values.
    /// </summary>
    public partial class Overlay0Functions : KaitaiStruct
    {
        public static Overlay0Functions FromFile(string fileName)
        {
            return new Overlay0Functions(new KaitaiStream(fileName));
        }

        public Overlay0Functions(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay0Functions p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_selectRandomBackground = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_selectRandomBackground;
        private int _selectRandomBackground;

        /// <summary>
        /// Selects a random background from the BACK/s09p04-10a.bgp files to be used as the background for the top menu.
        ///   
        /// No params.
        /// </summary>
        public int SelectRandomBackground
        {
            get
            {
                if (f_selectRandomBackground)
                    return _selectRandomBackground;
                _selectRandomBackground = (int) (7832);
                f_selectRandomBackground = true;
                return _selectRandomBackground;
            }
        }
        private Overlay0Functions m_root;
        private KaitaiStruct m_parent;
        public Overlay0Functions M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
