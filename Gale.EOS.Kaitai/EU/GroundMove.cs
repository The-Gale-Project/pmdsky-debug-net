// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union ground_move defined within pmdsky-debug.
    /// </summary>
    public partial class GroundMove : KaitaiStruct
    {
        public static GroundMove FromFile(string fileName)
        {
            return new GroundMove(new KaitaiStream(fileName));
        }

        public GroundMove(KaitaiStream p__io, KaitaiStruct p__parent = null, GroundMove p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _fExists = m_io.ReadBitsIntLe(1) != 0;
            _fSubsequentInLinkChain = m_io.ReadBitsIntLe(1) != 0;
            _fEnabledForAi = m_io.ReadBitsIntLe(1) != 0;
            _fSet = m_io.ReadBitsIntLe(1) != 0;
            _fLastUsed = m_io.ReadBitsIntLe(1) != 0;
            _fDisabled = m_io.ReadBitsIntLe(1) != 0;
            _flagsUnk6 = m_io.ReadBitsIntLe(2);
            m_io.AlignToByte();
            _field0x1 = m_io.ReadU1();
            _id = new MoveId16(m_io);
            _ginseng = m_io.ReadU1();
            _field0x5 = m_io.ReadU1();
        }
        private bool _fExists;
        private bool _fSubsequentInLinkChain;
        private bool _fEnabledForAi;
        private bool _fSet;
        private bool _fLastUsed;
        private bool _fDisabled;
        private ulong _flagsUnk6;
        private byte _field0x1;
        private MoveId16 _id;
        private byte _ginseng;
        private byte _field0x5;
        private GroundMove m_root;
        private KaitaiStruct m_parent;
        public bool FExists { get { return _fExists; } }
        public bool FSubsequentInLinkChain { get { return _fSubsequentInLinkChain; } }
        public bool FEnabledForAi { get { return _fEnabledForAi; } }
        public bool FSet { get { return _fSet; } }
        public bool FLastUsed { get { return _fLastUsed; } }
        public bool FDisabled { get { return _fDisabled; } }
        public ulong FlagsUnk6 { get { return _flagsUnk6; } }
        public byte Field0x1 { get { return _field0x1; } }
        public MoveId16 Id { get { return _id; } }
        public byte Ginseng { get { return _ginseng; } }
        public byte Field0x5 { get { return _field0x5; } }
        public GroundMove M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
