// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// List of functions within OVERLAY34 with relative address locations as their values.
    /// </summary>
    public partial class Overlay34Functions : KaitaiStruct
    {
        public static Overlay34Functions FromFile(string fileName)
        {
            return new Overlay34Functions(new KaitaiStream(fileName));
        }

        public Overlay34Functions(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay34Functions p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_explorersOfSkyMain = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_explorersOfSkyMain;
        private sbyte _explorersOfSkyMain;

        /// <summary>
        /// The main function for Explorers of Sky.
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: probably a game mode ID?
        /// return: probably a return code?
        /// </summary>
        public sbyte ExplorersOfSkyMain
        {
            get
            {
                if (f_explorersOfSkyMain)
                    return _explorersOfSkyMain;
                _explorersOfSkyMain = (sbyte) (0);
                f_explorersOfSkyMain = true;
                return _explorersOfSkyMain;
            }
        }
        private Overlay34Functions m_root;
        private KaitaiStruct m_parent;
        public Overlay34Functions M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
