// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union animation_control defined within pmdsky-debug.
    /// </summary>
    public partial class AnimationControl : KaitaiStruct
    {
        public static AnimationControl FromFile(string fileName)
        {
            return new AnimationControl(new KaitaiStream(fileName));
        }

        public AnimationControl(KaitaiStream p__io, KaitaiStruct p__parent = null, AnimationControl p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _someBitfield = m_io.ReadU2le();
            _field10x2 = m_io.ReadU2le();
            _field20x4 = m_io.ReadU2le();
            _animFrameDuration = m_io.ReadU2le();
            _field40x8 = m_io.ReadU2le();
            _field50xa = m_io.ReadU2le();
            _field60xc = m_io.ReadU2le();
            _field70xe = m_io.ReadU1();
            _field80xf = m_io.ReadU1();
            _field90x10 = new AnimationControlField90x10Array(m_io);
            _position = new Vec216(m_io);
            _animFrameOffset = new Vec216(m_io);
            _animFrameShadowOffset = new Vec216(m_io);
            _animFrameFlag = m_io.ReadU4le();
            _animFrameFlagSum = m_io.ReadU4le();
            _animationsOrGroupLen = m_io.ReadU2le();
            _field190x32 = m_io.ReadU2le();
            _field200x34 = m_io.ReadU1();
            _field210x35 = m_io.ReadU1();
            _field220x36 = m_io.ReadU2le();
            _field230x38 = m_io.ReadU2le();
            _frameId = m_io.ReadU2le();
            _field250x3c = m_io.ReadU2le();
            _field260x3e = m_io.ReadU1();
            _field270x3f = m_io.ReadU1();
            _palettePosHigh = m_io.ReadU1();
            _palettePosLow = m_io.ReadU1();
            _field300x42 = m_io.ReadU1();
            _field310x43 = m_io.ReadU1();
            _field320x44 = m_io.ReadU1();
            _field330x45 = m_io.ReadU1();
            _field340x46 = m_io.ReadU1();
            _field350x47 = m_io.ReadU1();
            _firstAnimationFrame = new Pointer(m_io);
            _nextAnimationFrame = new Pointer(m_io);
            _wanOffsets = new Pointer(m_io);
            _wanFrames = new Pointer(m_io);
            _wanFragmentsByteStore = new Pointer(m_io);
            _wanPalettes = new Pointer(m_io);
            _wanIs256Color = m_io.ReadU2le();
            _loopStart = m_io.ReadU2le();
            _field440x64 = m_io.ReadU1();
            _field450x65 = m_io.ReadU1();
            _field460x66 = m_io.ReadU1();
            _field470x67 = m_io.ReadU1();
            _spriteOverride = new Pointer(m_io);
            _field490x6c = m_io.ReadU4le();
            _loadedSpriteId = m_io.ReadU2le();
            _field510x72 = new MonsterId16(m_io);
            _field520x74 = m_io.ReadU1();
            _field530x75 = m_io.ReadU1();
            _animationGroupId = m_io.ReadU2le();
            _animationId = m_io.ReadU2le();
            _paletteBank = m_io.ReadU1();
            _field570x7b = m_io.ReadU1();
        }
        private ushort _someBitfield;
        private ushort _field10x2;
        private ushort _field20x4;
        private ushort _animFrameDuration;
        private ushort _field40x8;
        private ushort _field50xa;
        private ushort _field60xc;
        private byte _field70xe;
        private byte _field80xf;
        private AnimationControlField90x10Array _field90x10;
        private Vec216 _position;
        private Vec216 _animFrameOffset;
        private Vec216 _animFrameShadowOffset;
        private uint _animFrameFlag;
        private uint _animFrameFlagSum;
        private ushort _animationsOrGroupLen;
        private ushort _field190x32;
        private byte _field200x34;
        private byte _field210x35;
        private ushort _field220x36;
        private ushort _field230x38;
        private ushort _frameId;
        private ushort _field250x3c;
        private byte _field260x3e;
        private byte _field270x3f;
        private byte _palettePosHigh;
        private byte _palettePosLow;
        private byte _field300x42;
        private byte _field310x43;
        private byte _field320x44;
        private byte _field330x45;
        private byte _field340x46;
        private byte _field350x47;
        private Pointer _firstAnimationFrame;
        private Pointer _nextAnimationFrame;
        private Pointer _wanOffsets;
        private Pointer _wanFrames;
        private Pointer _wanFragmentsByteStore;
        private Pointer _wanPalettes;
        private ushort _wanIs256Color;
        private ushort _loopStart;
        private byte _field440x64;
        private byte _field450x65;
        private byte _field460x66;
        private byte _field470x67;
        private Pointer _spriteOverride;
        private uint _field490x6c;
        private ushort _loadedSpriteId;
        private MonsterId16 _field510x72;
        private byte _field520x74;
        private byte _field530x75;
        private ushort _animationGroupId;
        private ushort _animationId;
        private byte _paletteBank;
        private byte _field570x7b;
        private AnimationControl m_root;
        private KaitaiStruct m_parent;
        public ushort SomeBitfield { get { return _someBitfield; } }
        public ushort Field10x2 { get { return _field10x2; } }
        public ushort Field20x4 { get { return _field20x4; } }
        public ushort AnimFrameDuration { get { return _animFrameDuration; } }
        public ushort Field40x8 { get { return _field40x8; } }
        public ushort Field50xa { get { return _field50xa; } }
        public ushort Field60xc { get { return _field60xc; } }
        public byte Field70xe { get { return _field70xe; } }
        public byte Field80xf { get { return _field80xf; } }
        public AnimationControlField90x10Array Field90x10 { get { return _field90x10; } }
        public Vec216 Position { get { return _position; } }
        public Vec216 AnimFrameOffset { get { return _animFrameOffset; } }
        public Vec216 AnimFrameShadowOffset { get { return _animFrameShadowOffset; } }
        public uint AnimFrameFlag { get { return _animFrameFlag; } }
        public uint AnimFrameFlagSum { get { return _animFrameFlagSum; } }
        public ushort AnimationsOrGroupLen { get { return _animationsOrGroupLen; } }
        public ushort Field190x32 { get { return _field190x32; } }
        public byte Field200x34 { get { return _field200x34; } }
        public byte Field210x35 { get { return _field210x35; } }
        public ushort Field220x36 { get { return _field220x36; } }
        public ushort Field230x38 { get { return _field230x38; } }
        public ushort FrameId { get { return _frameId; } }
        public ushort Field250x3c { get { return _field250x3c; } }
        public byte Field260x3e { get { return _field260x3e; } }
        public byte Field270x3f { get { return _field270x3f; } }
        public byte PalettePosHigh { get { return _palettePosHigh; } }
        public byte PalettePosLow { get { return _palettePosLow; } }
        public byte Field300x42 { get { return _field300x42; } }
        public byte Field310x43 { get { return _field310x43; } }
        public byte Field320x44 { get { return _field320x44; } }
        public byte Field330x45 { get { return _field330x45; } }
        public byte Field340x46 { get { return _field340x46; } }
        public byte Field350x47 { get { return _field350x47; } }
        public Pointer FirstAnimationFrame { get { return _firstAnimationFrame; } }
        public Pointer NextAnimationFrame { get { return _nextAnimationFrame; } }
        public Pointer WanOffsets { get { return _wanOffsets; } }
        public Pointer WanFrames { get { return _wanFrames; } }
        public Pointer WanFragmentsByteStore { get { return _wanFragmentsByteStore; } }
        public Pointer WanPalettes { get { return _wanPalettes; } }
        public ushort WanIs256Color { get { return _wanIs256Color; } }
        public ushort LoopStart { get { return _loopStart; } }
        public byte Field440x64 { get { return _field440x64; } }
        public byte Field450x65 { get { return _field450x65; } }
        public byte Field460x66 { get { return _field460x66; } }
        public byte Field470x67 { get { return _field470x67; } }
        public Pointer SpriteOverride { get { return _spriteOverride; } }
        public uint Field490x6c { get { return _field490x6c; } }
        public ushort LoadedSpriteId { get { return _loadedSpriteId; } }
        public MonsterId16 Field510x72 { get { return _field510x72; } }
        public byte Field520x74 { get { return _field520x74; } }
        public byte Field530x75 { get { return _field530x75; } }
        public ushort AnimationGroupId { get { return _animationGroupId; } }
        public ushort AnimationId { get { return _animationId; } }
        public byte PaletteBank { get { return _paletteBank; } }
        public byte Field570x7b { get { return _field570x7b; } }
        public AnimationControl M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
