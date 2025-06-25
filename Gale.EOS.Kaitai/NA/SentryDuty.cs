// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union sentry_duty defined within pmdsky-debug.
    /// </summary>
    public partial class SentryDuty : KaitaiStruct
    {
        public static SentryDuty FromFile(string fileName)
        {
            return new SentryDuty(new KaitaiStream(fileName));
        }

        public SentryDuty(KaitaiStream p__io, KaitaiStruct p__parent = null, SentryDuty p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _field0x0 = m_io.ReadU1();
            _field0x1 = m_io.ReadU1();
            _field0x2 = m_io.ReadU1();
            _field0x3 = m_io.ReadU1();
            _field0x4 = m_io.ReadU1();
            _field0x5 = m_io.ReadU1();
            _field0x6 = m_io.ReadU1();
            _field0x7 = m_io.ReadU1();
            _field0x8 = m_io.ReadU1();
            _field0x9 = m_io.ReadU1();
            _field0xa = m_io.ReadU1();
            _field0xb = m_io.ReadU1();
            _field0xc = m_io.ReadS4le();
            _field0x10 = m_io.ReadS4le();
            _field0x14 = m_io.ReadS4le();
            _field0x18 = m_io.ReadS4le();
            _field0x1c = m_io.ReadU1();
            _field0x1d = m_io.ReadU1();
            _field0x1e = m_io.ReadU1();
            _field0x1f = m_io.ReadU1();
            _field0x20 = m_io.ReadU1();
            _field0x21 = m_io.ReadU1();
            _field0x22 = m_io.ReadU1();
            _field0x23 = m_io.ReadU1();
            _field0x24 = m_io.ReadU1();
            _field0x25 = m_io.ReadU1();
            _field0x26 = m_io.ReadU1();
            _field0x27 = m_io.ReadU1();
            _field0x28 = m_io.ReadU1();
            _field0x29 = m_io.ReadU1();
            _field0x2a = m_io.ReadU1();
            _field0x2b = m_io.ReadU1();
            _field0x2c = m_io.ReadU1();
            _field0x2d = m_io.ReadU1();
            _field0x2e = m_io.ReadU1();
            _field0x2f = m_io.ReadU1();
            _field0x30 = m_io.ReadU1();
            _field0x31 = m_io.ReadU1();
            _field0x32 = m_io.ReadU1();
            _field0x33 = m_io.ReadU1();
            _field0x34 = m_io.ReadU1();
            _field0x35 = m_io.ReadU1();
            _field0x36 = m_io.ReadU1();
            _field0x37 = m_io.ReadU1();
            _field0x38 = m_io.ReadU1();
            _field0x39 = m_io.ReadU1();
            _field0x3a = m_io.ReadU1();
            _field0x3b = m_io.ReadU1();
            _field0x3c = m_io.ReadU1();
            _field0x3d = m_io.ReadU1();
            _field0x3e = m_io.ReadU1();
            _field0x3f = m_io.ReadU1();
            _field0x40 = m_io.ReadU1();
            _field0x41 = m_io.ReadU1();
            _field0x42 = m_io.ReadU1();
            _field0x43 = m_io.ReadU1();
            _field0x44 = m_io.ReadU1();
            _field0x45 = m_io.ReadU1();
            _field0x46 = m_io.ReadU1();
            _field0x47 = m_io.ReadU1();
            _field0x48 = m_io.ReadU1();
            _field0x49 = m_io.ReadU1();
            _field0x4a = m_io.ReadU1();
            _field0x4b = m_io.ReadU1();
            _field0x4c = m_io.ReadU1();
            _field0x4d = m_io.ReadU1();
            _field0x4e = m_io.ReadU1();
            _field0x4f = m_io.ReadU1();
            _field0x50 = m_io.ReadU1();
            _field0x51 = m_io.ReadU1();
            _field0x52 = m_io.ReadU1();
            _field0x53 = m_io.ReadU1();
            _field0x54 = m_io.ReadU1();
            _field0x55 = m_io.ReadU1();
            _field0x56 = m_io.ReadU1();
            _field0x57 = m_io.ReadU1();
            _field0x58 = m_io.ReadU1();
            _field0x59 = m_io.ReadU1();
            _field0x5a = m_io.ReadU1();
            _field0x5b = m_io.ReadU1();
            _field0x5c = m_io.ReadU1();
            _field0x5d = m_io.ReadU1();
            _field0x5e = m_io.ReadU1();
            _field0x5f = m_io.ReadU1();
            _field0x60 = m_io.ReadU1();
            _field0x61 = m_io.ReadU1();
            _field0x62 = m_io.ReadU1();
            _field0x63 = m_io.ReadU1();
            _field0x64 = m_io.ReadU1();
            _field0x65 = m_io.ReadU1();
            _field0x66 = m_io.ReadU1();
            _field0x67 = m_io.ReadU1();
            _field0x68 = m_io.ReadU1();
            _field0x69 = m_io.ReadU1();
            _field0x6a = m_io.ReadU1();
            _field0x6b = m_io.ReadU1();
            _field0x6c = m_io.ReadU1();
            _field0x6d = m_io.ReadU1();
            _field0x6e = m_io.ReadU1();
            _field0x6f = m_io.ReadU1();
            _field0x70 = m_io.ReadU1();
            _field0x71 = m_io.ReadU1();
            _field0x72 = m_io.ReadU1();
            _field0x73 = m_io.ReadU1();
            _field0x74 = m_io.ReadU1();
            _field0x75 = m_io.ReadU1();
            _field0x76 = m_io.ReadU1();
            _field0x77 = m_io.ReadU1();
            _field0x78 = m_io.ReadU1();
            _field0x79 = m_io.ReadU1();
            _field0x7a = m_io.ReadU1();
            _field0x7b = m_io.ReadU1();
            _field0x7c = m_io.ReadU1();
            _field0x7d = m_io.ReadU1();
            _field0x7e = m_io.ReadU1();
            _field0x7f = m_io.ReadU1();
            _field0x80 = m_io.ReadU1();
            _field0x81 = m_io.ReadU1();
            _field0x82 = m_io.ReadU1();
            _field0x83 = m_io.ReadU1();
            _field0x84 = m_io.ReadU1();
            _field0x85 = m_io.ReadU1();
            _field0x86 = m_io.ReadU1();
            _field0x87 = m_io.ReadU1();
            _field0x88 = m_io.ReadU1();
            _field0x89 = m_io.ReadU1();
            _field0x8a = m_io.ReadU1();
            _field0x8b = m_io.ReadU1();
            _field0x8c = m_io.ReadU1();
            _field0x8d = m_io.ReadU1();
            _field0x8e = m_io.ReadU1();
            _field0x8f = m_io.ReadU1();
            _field0x90 = m_io.ReadU1();
            _field0x91 = m_io.ReadU1();
            _field0x92 = m_io.ReadU1();
            _field0x93 = m_io.ReadU1();
            _field0x94 = m_io.ReadU1();
            _field0x95 = m_io.ReadU1();
            _field0x96 = m_io.ReadU1();
            _field0x97 = m_io.ReadU1();
            _field0x98 = m_io.ReadU1();
            _field0x99 = m_io.ReadU1();
            _field0x9a = m_io.ReadU1();
            _field0x9b = m_io.ReadU1();
            _field0x9c = m_io.ReadU1();
            _field0x9d = m_io.ReadU1();
            _field0x9e = m_io.ReadU1();
            _field0x9f = m_io.ReadU1();
            _field0xa0 = m_io.ReadU1();
            _field0xa1 = m_io.ReadU1();
            _field0xa2 = m_io.ReadU1();
            _field0xa3 = m_io.ReadU1();
            _dialogueArgs = new PreprocessorArgs(m_io);
            _field0xf4 = m_io.ReadU1();
            _field0xf5 = m_io.ReadU1();
            _field0xf6 = m_io.ReadU1();
            _field0xf7 = m_io.ReadU1();
            _field0xf8 = m_io.ReadU1();
            _field0xf9 = m_io.ReadU1();
            _field0xfa = m_io.ReadU1();
            _field0xfb = m_io.ReadU1();
            _field0xfc = m_io.ReadU1();
            _field0xfd = m_io.ReadU1();
            _field0xfe = m_io.ReadU1();
            _field0xff = m_io.ReadU1();
            _field0x100 = m_io.ReadU1();
            _field0x101 = m_io.ReadU1();
            _field0x102 = m_io.ReadU1();
            _field0x103 = m_io.ReadU1();
            _completionState = new SentryCompletionState(m_io);
            _gameState = m_io.ReadS4le();
            _controlState = new SentryControlState(m_io);
            _nextGameState = m_io.ReadS4le();
            _prevDialogueStrId = m_io.ReadS4le();
            _field0x118 = m_io.ReadS4le();
            _field0x11c = m_io.ReadS4le();
            _field0x120 = new Animation(m_io);
            _field0x1e4 = new Animation(m_io);
            _field0x2a8 = new Animation(m_io);
            _field0x36c = new SentryDutyField0x36cArray(m_io);
            _field0xfac = new SentryDutyField0xfacArray(m_io);
            _field0x1bec = new SentryDutyField0x1becArray(m_io);
            _field0x282c = new SentryDutyField0x282cArray(m_io);
            _field0x29b4 = new Animation(m_io);
            _field0x2a78 = new SentryDutyField0x2a78Array(m_io);
            _field0x2d88 = new SentryDutyField0x2d88Array(m_io);
            _field0x3098 = new SentryDutyField0x3098Array(m_io);
            _field0x33a8 = new Animation(m_io);
            _field0x346c = new Animation(m_io);
            _field0x3530 = m_io.ReadU1();
            _field0x3531 = m_io.ReadU1();
            _field0x3532 = m_io.ReadU1();
            _field0x3533 = m_io.ReadU1();
            _field0x3534 = m_io.ReadS4le();
            _field0x3538 = m_io.ReadS4le();
            _field0x353c = m_io.ReadS4le();
            _field0x3540 = m_io.ReadS4le();
            _field0x3544 = new SentryDutyField0x3544Array(m_io);
            _field0x3554 = new SentryDutyField0x3554Array(m_io);
            _roundDisplay = m_io.ReadS4le();
            _field0x3568 = m_io.ReadS4le();
            _field0x356c = m_io.ReadS4le();
            _field0x3570 = new SentryDutyField0x3570Array(m_io);
            _field0x3670 = new SentryDutyField0x3670Array(m_io);
            _field0x3770 = new SentryDutyField0x3770Array(m_io);
            _field0x3870 = m_io.ReadU1();
            _field0x3871 = m_io.ReadU1();
            _field0x3872 = m_io.ReadU1();
            _field0x3873 = m_io.ReadU1();
            _field0x3874 = m_io.ReadS4le();
            _field0x3878 = m_io.ReadS4le();
            _rightAnswerSlot = m_io.ReadS4le();
            _rightAnswerDataIdx = m_io.ReadS4le();
            _round = m_io.ReadS4le();
            _field0x3888 = m_io.ReadS4le();
            _points = m_io.ReadS4le();
            _field0x3890 = m_io.ReadS4le();
            _field0x3894 = m_io.ReadS4le();
            _field0x3898 = m_io.ReadS4le();
            _field0x389c = m_io.ReadU1();
            _field0x389d = m_io.ReadU1();
            _field0x389e = m_io.ReadU1();
            _field0x389f = m_io.ReadU1();
            _field0x38a0 = m_io.ReadU1();
            _field0x38a1 = m_io.ReadU1();
            _choices = new SentryDutyChoicesArray(m_io);
            _field0x38aa = m_io.ReadU1();
            _field0x38ab = m_io.ReadU1();
            _field0x38ac = m_io.ReadS4le();
            _field0x38b0 = m_io.ReadS4le();
            _field0x38b4 = m_io.ReadS4le();
            _prevRightAnswerDataIdxs = new SentryDutyPrevRightAnswerDataIdxsArray(m_io);
            _heroStrId = m_io.ReadS2le();
            _partnerStrId = m_io.ReadS2le();
        }
        private byte _field0x0;
        private byte _field0x1;
        private byte _field0x2;
        private byte _field0x3;
        private byte _field0x4;
        private byte _field0x5;
        private byte _field0x6;
        private byte _field0x7;
        private byte _field0x8;
        private byte _field0x9;
        private byte _field0xa;
        private byte _field0xb;
        private int _field0xc;
        private int _field0x10;
        private int _field0x14;
        private int _field0x18;
        private byte _field0x1c;
        private byte _field0x1d;
        private byte _field0x1e;
        private byte _field0x1f;
        private byte _field0x20;
        private byte _field0x21;
        private byte _field0x22;
        private byte _field0x23;
        private byte _field0x24;
        private byte _field0x25;
        private byte _field0x26;
        private byte _field0x27;
        private byte _field0x28;
        private byte _field0x29;
        private byte _field0x2a;
        private byte _field0x2b;
        private byte _field0x2c;
        private byte _field0x2d;
        private byte _field0x2e;
        private byte _field0x2f;
        private byte _field0x30;
        private byte _field0x31;
        private byte _field0x32;
        private byte _field0x33;
        private byte _field0x34;
        private byte _field0x35;
        private byte _field0x36;
        private byte _field0x37;
        private byte _field0x38;
        private byte _field0x39;
        private byte _field0x3a;
        private byte _field0x3b;
        private byte _field0x3c;
        private byte _field0x3d;
        private byte _field0x3e;
        private byte _field0x3f;
        private byte _field0x40;
        private byte _field0x41;
        private byte _field0x42;
        private byte _field0x43;
        private byte _field0x44;
        private byte _field0x45;
        private byte _field0x46;
        private byte _field0x47;
        private byte _field0x48;
        private byte _field0x49;
        private byte _field0x4a;
        private byte _field0x4b;
        private byte _field0x4c;
        private byte _field0x4d;
        private byte _field0x4e;
        private byte _field0x4f;
        private byte _field0x50;
        private byte _field0x51;
        private byte _field0x52;
        private byte _field0x53;
        private byte _field0x54;
        private byte _field0x55;
        private byte _field0x56;
        private byte _field0x57;
        private byte _field0x58;
        private byte _field0x59;
        private byte _field0x5a;
        private byte _field0x5b;
        private byte _field0x5c;
        private byte _field0x5d;
        private byte _field0x5e;
        private byte _field0x5f;
        private byte _field0x60;
        private byte _field0x61;
        private byte _field0x62;
        private byte _field0x63;
        private byte _field0x64;
        private byte _field0x65;
        private byte _field0x66;
        private byte _field0x67;
        private byte _field0x68;
        private byte _field0x69;
        private byte _field0x6a;
        private byte _field0x6b;
        private byte _field0x6c;
        private byte _field0x6d;
        private byte _field0x6e;
        private byte _field0x6f;
        private byte _field0x70;
        private byte _field0x71;
        private byte _field0x72;
        private byte _field0x73;
        private byte _field0x74;
        private byte _field0x75;
        private byte _field0x76;
        private byte _field0x77;
        private byte _field0x78;
        private byte _field0x79;
        private byte _field0x7a;
        private byte _field0x7b;
        private byte _field0x7c;
        private byte _field0x7d;
        private byte _field0x7e;
        private byte _field0x7f;
        private byte _field0x80;
        private byte _field0x81;
        private byte _field0x82;
        private byte _field0x83;
        private byte _field0x84;
        private byte _field0x85;
        private byte _field0x86;
        private byte _field0x87;
        private byte _field0x88;
        private byte _field0x89;
        private byte _field0x8a;
        private byte _field0x8b;
        private byte _field0x8c;
        private byte _field0x8d;
        private byte _field0x8e;
        private byte _field0x8f;
        private byte _field0x90;
        private byte _field0x91;
        private byte _field0x92;
        private byte _field0x93;
        private byte _field0x94;
        private byte _field0x95;
        private byte _field0x96;
        private byte _field0x97;
        private byte _field0x98;
        private byte _field0x99;
        private byte _field0x9a;
        private byte _field0x9b;
        private byte _field0x9c;
        private byte _field0x9d;
        private byte _field0x9e;
        private byte _field0x9f;
        private byte _field0xa0;
        private byte _field0xa1;
        private byte _field0xa2;
        private byte _field0xa3;
        private PreprocessorArgs _dialogueArgs;
        private byte _field0xf4;
        private byte _field0xf5;
        private byte _field0xf6;
        private byte _field0xf7;
        private byte _field0xf8;
        private byte _field0xf9;
        private byte _field0xfa;
        private byte _field0xfb;
        private byte _field0xfc;
        private byte _field0xfd;
        private byte _field0xfe;
        private byte _field0xff;
        private byte _field0x100;
        private byte _field0x101;
        private byte _field0x102;
        private byte _field0x103;
        private SentryCompletionState _completionState;
        private int _gameState;
        private SentryControlState _controlState;
        private int _nextGameState;
        private int _prevDialogueStrId;
        private int _field0x118;
        private int _field0x11c;
        private Animation _field0x120;
        private Animation _field0x1e4;
        private Animation _field0x2a8;
        private SentryDutyField0x36cArray _field0x36c;
        private SentryDutyField0xfacArray _field0xfac;
        private SentryDutyField0x1becArray _field0x1bec;
        private SentryDutyField0x282cArray _field0x282c;
        private Animation _field0x29b4;
        private SentryDutyField0x2a78Array _field0x2a78;
        private SentryDutyField0x2d88Array _field0x2d88;
        private SentryDutyField0x3098Array _field0x3098;
        private Animation _field0x33a8;
        private Animation _field0x346c;
        private byte _field0x3530;
        private byte _field0x3531;
        private byte _field0x3532;
        private byte _field0x3533;
        private int _field0x3534;
        private int _field0x3538;
        private int _field0x353c;
        private int _field0x3540;
        private SentryDutyField0x3544Array _field0x3544;
        private SentryDutyField0x3554Array _field0x3554;
        private int _roundDisplay;
        private int _field0x3568;
        private int _field0x356c;
        private SentryDutyField0x3570Array _field0x3570;
        private SentryDutyField0x3670Array _field0x3670;
        private SentryDutyField0x3770Array _field0x3770;
        private byte _field0x3870;
        private byte _field0x3871;
        private byte _field0x3872;
        private byte _field0x3873;
        private int _field0x3874;
        private int _field0x3878;
        private int _rightAnswerSlot;
        private int _rightAnswerDataIdx;
        private int _round;
        private int _field0x3888;
        private int _points;
        private int _field0x3890;
        private int _field0x3894;
        private int _field0x3898;
        private byte _field0x389c;
        private byte _field0x389d;
        private byte _field0x389e;
        private byte _field0x389f;
        private byte _field0x38a0;
        private byte _field0x38a1;
        private SentryDutyChoicesArray _choices;
        private byte _field0x38aa;
        private byte _field0x38ab;
        private int _field0x38ac;
        private int _field0x38b0;
        private int _field0x38b4;
        private SentryDutyPrevRightAnswerDataIdxsArray _prevRightAnswerDataIdxs;
        private short _heroStrId;
        private short _partnerStrId;
        private SentryDuty m_root;
        private KaitaiStruct m_parent;
        public byte Field0x0 { get { return _field0x0; } }
        public byte Field0x1 { get { return _field0x1; } }
        public byte Field0x2 { get { return _field0x2; } }
        public byte Field0x3 { get { return _field0x3; } }
        public byte Field0x4 { get { return _field0x4; } }
        public byte Field0x5 { get { return _field0x5; } }
        public byte Field0x6 { get { return _field0x6; } }
        public byte Field0x7 { get { return _field0x7; } }
        public byte Field0x8 { get { return _field0x8; } }
        public byte Field0x9 { get { return _field0x9; } }
        public byte Field0xa { get { return _field0xa; } }
        public byte Field0xb { get { return _field0xb; } }
        public int Field0xc { get { return _field0xc; } }
        public int Field0x10 { get { return _field0x10; } }
        public int Field0x14 { get { return _field0x14; } }
        public int Field0x18 { get { return _field0x18; } }
        public byte Field0x1c { get { return _field0x1c; } }
        public byte Field0x1d { get { return _field0x1d; } }
        public byte Field0x1e { get { return _field0x1e; } }
        public byte Field0x1f { get { return _field0x1f; } }
        public byte Field0x20 { get { return _field0x20; } }
        public byte Field0x21 { get { return _field0x21; } }
        public byte Field0x22 { get { return _field0x22; } }
        public byte Field0x23 { get { return _field0x23; } }
        public byte Field0x24 { get { return _field0x24; } }
        public byte Field0x25 { get { return _field0x25; } }
        public byte Field0x26 { get { return _field0x26; } }
        public byte Field0x27 { get { return _field0x27; } }
        public byte Field0x28 { get { return _field0x28; } }
        public byte Field0x29 { get { return _field0x29; } }
        public byte Field0x2a { get { return _field0x2a; } }
        public byte Field0x2b { get { return _field0x2b; } }
        public byte Field0x2c { get { return _field0x2c; } }
        public byte Field0x2d { get { return _field0x2d; } }
        public byte Field0x2e { get { return _field0x2e; } }
        public byte Field0x2f { get { return _field0x2f; } }
        public byte Field0x30 { get { return _field0x30; } }
        public byte Field0x31 { get { return _field0x31; } }
        public byte Field0x32 { get { return _field0x32; } }
        public byte Field0x33 { get { return _field0x33; } }
        public byte Field0x34 { get { return _field0x34; } }
        public byte Field0x35 { get { return _field0x35; } }
        public byte Field0x36 { get { return _field0x36; } }
        public byte Field0x37 { get { return _field0x37; } }
        public byte Field0x38 { get { return _field0x38; } }
        public byte Field0x39 { get { return _field0x39; } }
        public byte Field0x3a { get { return _field0x3a; } }
        public byte Field0x3b { get { return _field0x3b; } }
        public byte Field0x3c { get { return _field0x3c; } }
        public byte Field0x3d { get { return _field0x3d; } }
        public byte Field0x3e { get { return _field0x3e; } }
        public byte Field0x3f { get { return _field0x3f; } }
        public byte Field0x40 { get { return _field0x40; } }
        public byte Field0x41 { get { return _field0x41; } }
        public byte Field0x42 { get { return _field0x42; } }
        public byte Field0x43 { get { return _field0x43; } }
        public byte Field0x44 { get { return _field0x44; } }
        public byte Field0x45 { get { return _field0x45; } }
        public byte Field0x46 { get { return _field0x46; } }
        public byte Field0x47 { get { return _field0x47; } }
        public byte Field0x48 { get { return _field0x48; } }
        public byte Field0x49 { get { return _field0x49; } }
        public byte Field0x4a { get { return _field0x4a; } }
        public byte Field0x4b { get { return _field0x4b; } }
        public byte Field0x4c { get { return _field0x4c; } }
        public byte Field0x4d { get { return _field0x4d; } }
        public byte Field0x4e { get { return _field0x4e; } }
        public byte Field0x4f { get { return _field0x4f; } }
        public byte Field0x50 { get { return _field0x50; } }
        public byte Field0x51 { get { return _field0x51; } }
        public byte Field0x52 { get { return _field0x52; } }
        public byte Field0x53 { get { return _field0x53; } }
        public byte Field0x54 { get { return _field0x54; } }
        public byte Field0x55 { get { return _field0x55; } }
        public byte Field0x56 { get { return _field0x56; } }
        public byte Field0x57 { get { return _field0x57; } }
        public byte Field0x58 { get { return _field0x58; } }
        public byte Field0x59 { get { return _field0x59; } }
        public byte Field0x5a { get { return _field0x5a; } }
        public byte Field0x5b { get { return _field0x5b; } }
        public byte Field0x5c { get { return _field0x5c; } }
        public byte Field0x5d { get { return _field0x5d; } }
        public byte Field0x5e { get { return _field0x5e; } }
        public byte Field0x5f { get { return _field0x5f; } }
        public byte Field0x60 { get { return _field0x60; } }
        public byte Field0x61 { get { return _field0x61; } }
        public byte Field0x62 { get { return _field0x62; } }
        public byte Field0x63 { get { return _field0x63; } }
        public byte Field0x64 { get { return _field0x64; } }
        public byte Field0x65 { get { return _field0x65; } }
        public byte Field0x66 { get { return _field0x66; } }
        public byte Field0x67 { get { return _field0x67; } }
        public byte Field0x68 { get { return _field0x68; } }
        public byte Field0x69 { get { return _field0x69; } }
        public byte Field0x6a { get { return _field0x6a; } }
        public byte Field0x6b { get { return _field0x6b; } }
        public byte Field0x6c { get { return _field0x6c; } }
        public byte Field0x6d { get { return _field0x6d; } }
        public byte Field0x6e { get { return _field0x6e; } }
        public byte Field0x6f { get { return _field0x6f; } }
        public byte Field0x70 { get { return _field0x70; } }
        public byte Field0x71 { get { return _field0x71; } }
        public byte Field0x72 { get { return _field0x72; } }
        public byte Field0x73 { get { return _field0x73; } }
        public byte Field0x74 { get { return _field0x74; } }
        public byte Field0x75 { get { return _field0x75; } }
        public byte Field0x76 { get { return _field0x76; } }
        public byte Field0x77 { get { return _field0x77; } }
        public byte Field0x78 { get { return _field0x78; } }
        public byte Field0x79 { get { return _field0x79; } }
        public byte Field0x7a { get { return _field0x7a; } }
        public byte Field0x7b { get { return _field0x7b; } }
        public byte Field0x7c { get { return _field0x7c; } }
        public byte Field0x7d { get { return _field0x7d; } }
        public byte Field0x7e { get { return _field0x7e; } }
        public byte Field0x7f { get { return _field0x7f; } }
        public byte Field0x80 { get { return _field0x80; } }
        public byte Field0x81 { get { return _field0x81; } }
        public byte Field0x82 { get { return _field0x82; } }
        public byte Field0x83 { get { return _field0x83; } }
        public byte Field0x84 { get { return _field0x84; } }
        public byte Field0x85 { get { return _field0x85; } }
        public byte Field0x86 { get { return _field0x86; } }
        public byte Field0x87 { get { return _field0x87; } }
        public byte Field0x88 { get { return _field0x88; } }
        public byte Field0x89 { get { return _field0x89; } }
        public byte Field0x8a { get { return _field0x8a; } }
        public byte Field0x8b { get { return _field0x8b; } }
        public byte Field0x8c { get { return _field0x8c; } }
        public byte Field0x8d { get { return _field0x8d; } }
        public byte Field0x8e { get { return _field0x8e; } }
        public byte Field0x8f { get { return _field0x8f; } }
        public byte Field0x90 { get { return _field0x90; } }
        public byte Field0x91 { get { return _field0x91; } }
        public byte Field0x92 { get { return _field0x92; } }
        public byte Field0x93 { get { return _field0x93; } }
        public byte Field0x94 { get { return _field0x94; } }
        public byte Field0x95 { get { return _field0x95; } }
        public byte Field0x96 { get { return _field0x96; } }
        public byte Field0x97 { get { return _field0x97; } }
        public byte Field0x98 { get { return _field0x98; } }
        public byte Field0x99 { get { return _field0x99; } }
        public byte Field0x9a { get { return _field0x9a; } }
        public byte Field0x9b { get { return _field0x9b; } }
        public byte Field0x9c { get { return _field0x9c; } }
        public byte Field0x9d { get { return _field0x9d; } }
        public byte Field0x9e { get { return _field0x9e; } }
        public byte Field0x9f { get { return _field0x9f; } }
        public byte Field0xa0 { get { return _field0xa0; } }
        public byte Field0xa1 { get { return _field0xa1; } }
        public byte Field0xa2 { get { return _field0xa2; } }
        public byte Field0xa3 { get { return _field0xa3; } }
        public PreprocessorArgs DialogueArgs { get { return _dialogueArgs; } }
        public byte Field0xf4 { get { return _field0xf4; } }
        public byte Field0xf5 { get { return _field0xf5; } }
        public byte Field0xf6 { get { return _field0xf6; } }
        public byte Field0xf7 { get { return _field0xf7; } }
        public byte Field0xf8 { get { return _field0xf8; } }
        public byte Field0xf9 { get { return _field0xf9; } }
        public byte Field0xfa { get { return _field0xfa; } }
        public byte Field0xfb { get { return _field0xfb; } }
        public byte Field0xfc { get { return _field0xfc; } }
        public byte Field0xfd { get { return _field0xfd; } }
        public byte Field0xfe { get { return _field0xfe; } }
        public byte Field0xff { get { return _field0xff; } }
        public byte Field0x100 { get { return _field0x100; } }
        public byte Field0x101 { get { return _field0x101; } }
        public byte Field0x102 { get { return _field0x102; } }
        public byte Field0x103 { get { return _field0x103; } }
        public SentryCompletionState CompletionState { get { return _completionState; } }
        public int GameState { get { return _gameState; } }
        public SentryControlState ControlState { get { return _controlState; } }
        public int NextGameState { get { return _nextGameState; } }
        public int PrevDialogueStrId { get { return _prevDialogueStrId; } }
        public int Field0x118 { get { return _field0x118; } }
        public int Field0x11c { get { return _field0x11c; } }
        public Animation Field0x120 { get { return _field0x120; } }
        public Animation Field0x1e4 { get { return _field0x1e4; } }
        public Animation Field0x2a8 { get { return _field0x2a8; } }
        public SentryDutyField0x36cArray Field0x36c { get { return _field0x36c; } }
        public SentryDutyField0xfacArray Field0xfac { get { return _field0xfac; } }
        public SentryDutyField0x1becArray Field0x1bec { get { return _field0x1bec; } }
        public SentryDutyField0x282cArray Field0x282c { get { return _field0x282c; } }
        public Animation Field0x29b4 { get { return _field0x29b4; } }
        public SentryDutyField0x2a78Array Field0x2a78 { get { return _field0x2a78; } }
        public SentryDutyField0x2d88Array Field0x2d88 { get { return _field0x2d88; } }
        public SentryDutyField0x3098Array Field0x3098 { get { return _field0x3098; } }
        public Animation Field0x33a8 { get { return _field0x33a8; } }
        public Animation Field0x346c { get { return _field0x346c; } }
        public byte Field0x3530 { get { return _field0x3530; } }
        public byte Field0x3531 { get { return _field0x3531; } }
        public byte Field0x3532 { get { return _field0x3532; } }
        public byte Field0x3533 { get { return _field0x3533; } }
        public int Field0x3534 { get { return _field0x3534; } }
        public int Field0x3538 { get { return _field0x3538; } }
        public int Field0x353c { get { return _field0x353c; } }
        public int Field0x3540 { get { return _field0x3540; } }
        public SentryDutyField0x3544Array Field0x3544 { get { return _field0x3544; } }
        public SentryDutyField0x3554Array Field0x3554 { get { return _field0x3554; } }
        public int RoundDisplay { get { return _roundDisplay; } }
        public int Field0x3568 { get { return _field0x3568; } }
        public int Field0x356c { get { return _field0x356c; } }
        public SentryDutyField0x3570Array Field0x3570 { get { return _field0x3570; } }
        public SentryDutyField0x3670Array Field0x3670 { get { return _field0x3670; } }
        public SentryDutyField0x3770Array Field0x3770 { get { return _field0x3770; } }
        public byte Field0x3870 { get { return _field0x3870; } }
        public byte Field0x3871 { get { return _field0x3871; } }
        public byte Field0x3872 { get { return _field0x3872; } }
        public byte Field0x3873 { get { return _field0x3873; } }
        public int Field0x3874 { get { return _field0x3874; } }
        public int Field0x3878 { get { return _field0x3878; } }
        public int RightAnswerSlot { get { return _rightAnswerSlot; } }
        public int RightAnswerDataIdx { get { return _rightAnswerDataIdx; } }
        public int Round { get { return _round; } }
        public int Field0x3888 { get { return _field0x3888; } }
        public int Points { get { return _points; } }
        public int Field0x3890 { get { return _field0x3890; } }
        public int Field0x3894 { get { return _field0x3894; } }
        public int Field0x3898 { get { return _field0x3898; } }
        public byte Field0x389c { get { return _field0x389c; } }
        public byte Field0x389d { get { return _field0x389d; } }
        public byte Field0x389e { get { return _field0x389e; } }
        public byte Field0x389f { get { return _field0x389f; } }
        public byte Field0x38a0 { get { return _field0x38a0; } }
        public byte Field0x38a1 { get { return _field0x38a1; } }
        public SentryDutyChoicesArray Choices { get { return _choices; } }
        public byte Field0x38aa { get { return _field0x38aa; } }
        public byte Field0x38ab { get { return _field0x38ab; } }
        public int Field0x38ac { get { return _field0x38ac; } }
        public int Field0x38b0 { get { return _field0x38b0; } }
        public int Field0x38b4 { get { return _field0x38b4; } }
        public SentryDutyPrevRightAnswerDataIdxsArray PrevRightAnswerDataIdxs { get { return _prevRightAnswerDataIdxs; } }
        public short HeroStrId { get { return _heroStrId; } }
        public short PartnerStrId { get { return _partnerStrId; } }
        public SentryDuty M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
