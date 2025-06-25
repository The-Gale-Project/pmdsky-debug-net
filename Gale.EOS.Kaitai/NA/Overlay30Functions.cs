// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// List of functions within OVERLAY30 with relative address locations as their values.
    /// </summary>
    public partial class Overlay30Functions : KaitaiStruct
    {
        public static Overlay30Functions FromFile(string fileName)
        {
            return new Overlay30Functions(new KaitaiStream(fileName));
        }

        public Overlay30Functions(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay30Functions p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_writeQuicksaveData = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_writeQuicksaveData;
        private int _writeQuicksaveData;

        /// <summary>
        /// Function responsible for writing dungeon data when quicksaving.
        /// 
        /// Among other things, it contains a loop that goes through all the monsters in the current dungeon, copying their data to the buffer. The data is not copied as-is though, the game uses a reduced version of the monster struct containing only the minimum required data to resume the game later.
        /// 
        /// r0: Pointer to buffer where data should be written
        /// r1: Buffer size. Seems to be 0x5800 (22 KB) when the function is called.
        /// </summary>
        public int WriteQuicksaveData
        {
            get
            {
                if (f_writeQuicksaveData)
                    return _writeQuicksaveData;
                _writeQuicksaveData = (int) (1096);
                f_writeQuicksaveData = true;
                return _writeQuicksaveData;
            }
        }
        private Overlay30Functions m_root;
        private KaitaiStruct m_parent;
        public Overlay30Functions M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
