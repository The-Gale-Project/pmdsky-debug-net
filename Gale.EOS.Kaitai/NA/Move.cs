// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union move defined within pmdsky-debug.
    /// </summary>
    public partial class Move : KaitaiStruct
    {
        public static Move FromFile(string fileName)
        {
            return new Move(new KaitaiStream(fileName));
        }

        public Move(KaitaiStream p__io, KaitaiStruct p__parent = null, Move p__root = null) : base(p__io)
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
            _flags0Unk6 = m_io.ReadBitsIntLe(2);
            m_io.AlignToByte();
            _field0x1 = m_io.ReadU1();
            _fSealed = m_io.ReadBitsIntLe(1) != 0;
            _flags2Unk1 = m_io.ReadBitsIntLe(2);
            _fConsumePp = m_io.ReadBitsIntLe(1) != 0;
            _fConsume2Pp = m_io.ReadBitsIntLe(1) != 0;
            _flags2Unk5 = m_io.ReadBitsIntLe(1) != 0;
            _fConsume4Pp = m_io.ReadBitsIntLe(1) != 0;
            _flags2Unk7 = m_io.ReadBitsIntLe(1) != 0;
            _fMultitalentPpBoost = m_io.ReadBitsIntLe(1) != 0;
            _fExclusiveItemPpBoost = m_io.ReadBitsIntLe(1) != 0;
            _fUnknownPpBoost = m_io.ReadBitsIntLe(1) != 0;
            _flags3Unk11 = m_io.ReadBitsIntLe(5);
            m_io.AlignToByte();
            _id = new MoveId16(m_io);
            _pp = m_io.ReadU1();
            _ginseng = m_io.ReadU1();
        }
        private bool _fExists;
        private bool _fSubsequentInLinkChain;
        private bool _fEnabledForAi;
        private bool _fSet;
        private bool _fLastUsed;
        private bool _fDisabled;
        private ulong _flags0Unk6;
        private byte _field0x1;
        private bool _fSealed;
        private ulong _flags2Unk1;
        private bool _fConsumePp;
        private bool _fConsume2Pp;
        private bool _flags2Unk5;
        private bool _fConsume4Pp;
        private bool _flags2Unk7;
        private bool _fMultitalentPpBoost;
        private bool _fExclusiveItemPpBoost;
        private bool _fUnknownPpBoost;
        private ulong _flags3Unk11;
        private MoveId16 _id;
        private byte _pp;
        private byte _ginseng;
        private Move m_root;
        private KaitaiStruct m_parent;
        public bool FExists { get { return _fExists; } }
        public bool FSubsequentInLinkChain { get { return _fSubsequentInLinkChain; } }
        public bool FEnabledForAi { get { return _fEnabledForAi; } }
        public bool FSet { get { return _fSet; } }
        public bool FLastUsed { get { return _fLastUsed; } }
        public bool FDisabled { get { return _fDisabled; } }
        public ulong Flags0Unk6 { get { return _flags0Unk6; } }
        public byte Field0x1 { get { return _field0x1; } }
        public bool FSealed { get { return _fSealed; } }
        public ulong Flags2Unk1 { get { return _flags2Unk1; } }
        public bool FConsumePp { get { return _fConsumePp; } }
        public bool FConsume2Pp { get { return _fConsume2Pp; } }
        public bool Flags2Unk5 { get { return _flags2Unk5; } }
        public bool FConsume4Pp { get { return _fConsume4Pp; } }
        public bool Flags2Unk7 { get { return _flags2Unk7; } }
        public bool FMultitalentPpBoost { get { return _fMultitalentPpBoost; } }
        public bool FExclusiveItemPpBoost { get { return _fExclusiveItemPpBoost; } }
        public bool FUnknownPpBoost { get { return _fUnknownPpBoost; } }
        public ulong Flags3Unk11 { get { return _flags3Unk11; } }
        public MoveId16 Id { get { return _id; } }
        public byte Pp { get { return _pp; } }
        public byte Ginseng { get { return _ginseng; } }
        public Move M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
