// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union status_icon_flags defined within pmdsky-debug.
    /// </summary>
    public partial class StatusIconFlags : KaitaiStruct
    {
        public static StatusIconFlags FromFile(string fileName)
        {
            return new StatusIconFlags(new KaitaiStream(fileName));
        }

        public StatusIconFlags(KaitaiStream p__io, KaitaiStruct p__parent = null, StatusIconFlags p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _fSleepless = m_io.ReadBitsIntLe(1) != 0;
            _fBurn = m_io.ReadBitsIntLe(1) != 0;
            _fPoison = m_io.ReadBitsIntLe(1) != 0;
            _fToxic = m_io.ReadBitsIntLe(1) != 0;
            _fConfused = m_io.ReadBitsIntLe(1) != 0;
            _fCowering = m_io.ReadBitsIntLe(1) != 0;
            _fTaunt = m_io.ReadBitsIntLe(1) != 0;
            _fEncore = m_io.ReadBitsIntLe(1) != 0;
            _fReflect = m_io.ReadBitsIntLe(1) != 0;
            _fSafeguard = m_io.ReadBitsIntLe(1) != 0;
            _fLightScreen = m_io.ReadBitsIntLe(1) != 0;
            _fProtect = m_io.ReadBitsIntLe(1) != 0;
            _fEndure = m_io.ReadBitsIntLe(1) != 0;
            _fLowHp = m_io.ReadBitsIntLe(1) != 0;
            _fCurse = m_io.ReadBitsIntLe(1) != 0;
            _fEmbargo = m_io.ReadBitsIntLe(1) != 0;
            _fSureShot = m_io.ReadBitsIntLe(1) != 0;
            _fWhiffer = m_io.ReadBitsIntLe(1) != 0;
            _fSetDamage = m_io.ReadBitsIntLe(1) != 0;
            _fFocusEnergy = m_io.ReadBitsIntLe(1) != 0;
            _fBlinded = m_io.ReadBitsIntLe(1) != 0;
            _fCrossEyed = m_io.ReadBitsIntLe(1) != 0;
            _fEyedrops = m_io.ReadBitsIntLe(1) != 0;
            _fMuzzled = m_io.ReadBitsIntLe(1) != 0;
            _fGrudge = m_io.ReadBitsIntLe(1) != 0;
            _fExposed = m_io.ReadBitsIntLe(1) != 0;
            _fSleep = m_io.ReadBitsIntLe(1) != 0;
            _fLoweredStat = m_io.ReadBitsIntLe(1) != 0;
            _fHealBlock = m_io.ReadBitsIntLe(1) != 0;
            _fMiracleEye = m_io.ReadBitsIntLe(1) != 0;
            _fRedExclamationMark = m_io.ReadBitsIntLe(1) != 0;
            _fMagnetRise = m_io.ReadBitsIntLe(1) != 0;
            _fFreeze = m_io.ReadBitsIntLe(1) != 0;
            _flagsUnk2 = m_io.ReadBitsIntLe(7);
            m_io.AlignToByte();
            _field0x5 = m_io.ReadU1();
            _field0x6 = m_io.ReadU1();
            _field0x7 = m_io.ReadU1();
        }
        private bool _fSleepless;
        private bool _fBurn;
        private bool _fPoison;
        private bool _fToxic;
        private bool _fConfused;
        private bool _fCowering;
        private bool _fTaunt;
        private bool _fEncore;
        private bool _fReflect;
        private bool _fSafeguard;
        private bool _fLightScreen;
        private bool _fProtect;
        private bool _fEndure;
        private bool _fLowHp;
        private bool _fCurse;
        private bool _fEmbargo;
        private bool _fSureShot;
        private bool _fWhiffer;
        private bool _fSetDamage;
        private bool _fFocusEnergy;
        private bool _fBlinded;
        private bool _fCrossEyed;
        private bool _fEyedrops;
        private bool _fMuzzled;
        private bool _fGrudge;
        private bool _fExposed;
        private bool _fSleep;
        private bool _fLoweredStat;
        private bool _fHealBlock;
        private bool _fMiracleEye;
        private bool _fRedExclamationMark;
        private bool _fMagnetRise;
        private bool _fFreeze;
        private ulong _flagsUnk2;
        private byte _field0x5;
        private byte _field0x6;
        private byte _field0x7;
        private StatusIconFlags m_root;
        private KaitaiStruct m_parent;
        public bool FSleepless { get { return _fSleepless; } }
        public bool FBurn { get { return _fBurn; } }
        public bool FPoison { get { return _fPoison; } }
        public bool FToxic { get { return _fToxic; } }
        public bool FConfused { get { return _fConfused; } }
        public bool FCowering { get { return _fCowering; } }
        public bool FTaunt { get { return _fTaunt; } }
        public bool FEncore { get { return _fEncore; } }
        public bool FReflect { get { return _fReflect; } }
        public bool FSafeguard { get { return _fSafeguard; } }
        public bool FLightScreen { get { return _fLightScreen; } }
        public bool FProtect { get { return _fProtect; } }
        public bool FEndure { get { return _fEndure; } }
        public bool FLowHp { get { return _fLowHp; } }
        public bool FCurse { get { return _fCurse; } }
        public bool FEmbargo { get { return _fEmbargo; } }
        public bool FSureShot { get { return _fSureShot; } }
        public bool FWhiffer { get { return _fWhiffer; } }
        public bool FSetDamage { get { return _fSetDamage; } }
        public bool FFocusEnergy { get { return _fFocusEnergy; } }
        public bool FBlinded { get { return _fBlinded; } }
        public bool FCrossEyed { get { return _fCrossEyed; } }
        public bool FEyedrops { get { return _fEyedrops; } }
        public bool FMuzzled { get { return _fMuzzled; } }
        public bool FGrudge { get { return _fGrudge; } }
        public bool FExposed { get { return _fExposed; } }
        public bool FSleep { get { return _fSleep; } }
        public bool FLoweredStat { get { return _fLoweredStat; } }
        public bool FHealBlock { get { return _fHealBlock; } }
        public bool FMiracleEye { get { return _fMiracleEye; } }
        public bool FRedExclamationMark { get { return _fRedExclamationMark; } }
        public bool FMagnetRise { get { return _fMagnetRise; } }
        public bool FFreeze { get { return _fFreeze; } }
        public ulong FlagsUnk2 { get { return _flagsUnk2; } }
        public byte Field0x5 { get { return _field0x5; } }
        public byte Field0x6 { get { return _field0x6; } }
        public byte Field0x7 { get { return _field0x7; } }
        public StatusIconFlags M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
