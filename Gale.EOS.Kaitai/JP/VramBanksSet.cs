// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents a struct or union vram_banks_set defined within pmdsky-debug.
    /// </summary>
    public partial class VramBanksSet : KaitaiStruct
    {
        public static VramBanksSet FromFile(string fileName)
        {
            return new VramBanksSet(new KaitaiStream(fileName));
        }

        public VramBanksSet(KaitaiStream p__io, KaitaiStruct p__parent = null, VramBanksSet p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _vramA = m_io.ReadBitsIntLe(1) != 0;
            _vramB = m_io.ReadBitsIntLe(1) != 0;
            _vramC = m_io.ReadBitsIntLe(1) != 0;
            _vramD = m_io.ReadBitsIntLe(1) != 0;
            _vramE = m_io.ReadBitsIntLe(1) != 0;
            _vramF = m_io.ReadBitsIntLe(1) != 0;
            _vramG = m_io.ReadBitsIntLe(1) != 0;
            _vramH = m_io.ReadBitsIntLe(1) != 0;
            _vramI = m_io.ReadBitsIntLe(1) != 0;
            _unused = m_io.ReadBitsIntLe(7);
        }
        private bool _vramA;
        private bool _vramB;
        private bool _vramC;
        private bool _vramD;
        private bool _vramE;
        private bool _vramF;
        private bool _vramG;
        private bool _vramH;
        private bool _vramI;
        private ulong _unused;
        private VramBanksSet m_root;
        private KaitaiStruct m_parent;
        public bool VramA { get { return _vramA; } }
        public bool VramB { get { return _vramB; } }
        public bool VramC { get { return _vramC; } }
        public bool VramD { get { return _vramD; } }
        public bool VramE { get { return _vramE; } }
        public bool VramF { get { return _vramF; } }
        public bool VramG { get { return _vramG; } }
        public bool VramH { get { return _vramH; } }
        public bool VramI { get { return _vramI; } }
        public ulong Unused { get { return _unused; } }
        public VramBanksSet M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
