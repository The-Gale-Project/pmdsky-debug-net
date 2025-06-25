// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// The instruction TCM (tightly-coupled memory) and the corresponding region in the ARM9 binary.
    /// 
    /// The ITCM is a special area of low-latency memory meant for performance-critical routines. It's similar to an instruction cache, but more predictable. See the ARMv5 Architecture Reference Manual, Chapter B7 (https://developer.arm.com/documentation/ddi0100/i).
    /// 
    /// The Nintendo DS ITCM region is located at 0x0-0x7FFF in memory, but the 32 KiB segment is mirrored throughout the 16 MiB block from 0x0-0x1FFFFFF. The Explorers of Sky code seems to reference only the mirror at 0x1FF8000, the closest one to main memory.
    /// 
    /// In Explorers of Sky, a fixed region of the ARM9 binary appears to be loaded in the ITCM at all times, and seems to contain functions related to the dungeon AI, among other things. The ITCM has a max capacity of 0x8000, although not all of it is used.
    /// </summary>
    public partial class Itcm : KaitaiStruct
    {
        public static Itcm FromFile(string fileName)
        {
            return new Itcm(new KaitaiStream(fileName));
        }

        public Itcm(KaitaiStream p__io, KaitaiStruct p__parent = null, Itcm p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_functions = false;
            f_data = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_functions;
        private ItcmFunctions _functions;
        public ItcmFunctions Functions
        {
            get
            {
                if (f_functions)
                    return _functions;
                _functions = new ItcmFunctions(m_io);
                f_functions = true;
                return _functions;
            }
        }
        private bool f_data;
        private ItcmData _data;
        public ItcmData Data
        {
            get
            {
                if (f_data)
                    return _data;
                _data = new ItcmData(m_io);
                f_data = true;
                return _data;
            }
        }
        private Itcm m_root;
        private KaitaiStruct m_parent;
        public Itcm M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
