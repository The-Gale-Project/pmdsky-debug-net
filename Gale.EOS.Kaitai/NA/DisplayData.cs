// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union display_data defined within pmdsky-debug.
    /// </summary>
    public partial class DisplayData : KaitaiStruct
    {
        public static DisplayData FromFile(string fileName)
        {
            return new DisplayData(new KaitaiStream(fileName));
        }

        public DisplayData(KaitaiStream p__io, KaitaiStruct p__parent = null, DisplayData p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _cameraPos = new Position(m_io);
            _cameraPosMirror = new Position(m_io);
            _cameraPixelPos = new Position(m_io);
            _cameraPixelPosMirror = new Position(m_io);
            _cameraTarget = new Pointer(m_io);
            _screenShakeOffset = m_io.ReadU4le();
            _screenShakeIntensity = m_io.ReadU4le();
            _screenShakeIntensityReset = m_io.ReadU4le();
            _field0x20 = m_io.ReadU1();
            _visibilityRange = m_io.ReadU1();
            _blinded = m_io.ReadU1();
            _luminous = m_io.ReadU1();
            _naturalLighting = m_io.ReadU1();
            _mapSurveyor = m_io.ReadU1();
            _canSeeEnemies = m_io.ReadU1();
            _canSeeItems = m_io.ReadU1();
            _canSeeTraps = m_io.ReadU1();
            _hallucinating = m_io.ReadU1();
            _canSeeStairs = m_io.ReadU1();
            _field0x2b = m_io.ReadU1();
            _field0x2c = m_io.ReadU1();
            _darkness = m_io.ReadU1();
            _field0x2e = m_io.ReadU1();
            _leaderPointed = m_io.ReadU1();
            _field0x30 = m_io.ReadU1();
            _unkFadeToBlackTracker = m_io.ReadU1();
            _field0x32 = m_io.ReadU1();
            _field0x33 = m_io.ReadU1();
            _field0x34 = m_io.ReadU1();
            _teamMenuOrGrid = m_io.ReadU1();
            _leaderTargetDirection = new DirectionId8(m_io);
            _leaderTargetDirectionMirror = new DirectionId8(m_io);
            _field0x38 = m_io.ReadU2le();
            _field0x3a = m_io.ReadU2le();
            _floorTouchScreen = m_io.ReadS2le();
            _leaderLevelTouchScreen = m_io.ReadS2le();
            _leaderHpTouchScreen = m_io.ReadS2le();
            _leaderMaxHpTouchScreen = m_io.ReadS2le();
            _field0x44 = m_io.ReadU2le();
            _field0x46 = m_io.ReadU1();
            _field0x47 = m_io.ReadU1();
        }
        private Position _cameraPos;
        private Position _cameraPosMirror;
        private Position _cameraPixelPos;
        private Position _cameraPixelPosMirror;
        private Pointer _cameraTarget;
        private uint _screenShakeOffset;
        private uint _screenShakeIntensity;
        private uint _screenShakeIntensityReset;
        private byte _field0x20;
        private byte _visibilityRange;
        private byte _blinded;
        private byte _luminous;
        private byte _naturalLighting;
        private byte _mapSurveyor;
        private byte _canSeeEnemies;
        private byte _canSeeItems;
        private byte _canSeeTraps;
        private byte _hallucinating;
        private byte _canSeeStairs;
        private byte _field0x2b;
        private byte _field0x2c;
        private byte _darkness;
        private byte _field0x2e;
        private byte _leaderPointed;
        private byte _field0x30;
        private byte _unkFadeToBlackTracker;
        private byte _field0x32;
        private byte _field0x33;
        private byte _field0x34;
        private byte _teamMenuOrGrid;
        private DirectionId8 _leaderTargetDirection;
        private DirectionId8 _leaderTargetDirectionMirror;
        private ushort _field0x38;
        private ushort _field0x3a;
        private short _floorTouchScreen;
        private short _leaderLevelTouchScreen;
        private short _leaderHpTouchScreen;
        private short _leaderMaxHpTouchScreen;
        private ushort _field0x44;
        private byte _field0x46;
        private byte _field0x47;
        private DisplayData m_root;
        private KaitaiStruct m_parent;
        public Position CameraPos { get { return _cameraPos; } }
        public Position CameraPosMirror { get { return _cameraPosMirror; } }
        public Position CameraPixelPos { get { return _cameraPixelPos; } }
        public Position CameraPixelPosMirror { get { return _cameraPixelPosMirror; } }
        public Pointer CameraTarget { get { return _cameraTarget; } }
        public uint ScreenShakeOffset { get { return _screenShakeOffset; } }
        public uint ScreenShakeIntensity { get { return _screenShakeIntensity; } }
        public uint ScreenShakeIntensityReset { get { return _screenShakeIntensityReset; } }
        public byte Field0x20 { get { return _field0x20; } }
        public byte VisibilityRange { get { return _visibilityRange; } }
        public byte Blinded { get { return _blinded; } }
        public byte Luminous { get { return _luminous; } }
        public byte NaturalLighting { get { return _naturalLighting; } }
        public byte MapSurveyor { get { return _mapSurveyor; } }
        public byte CanSeeEnemies { get { return _canSeeEnemies; } }
        public byte CanSeeItems { get { return _canSeeItems; } }
        public byte CanSeeTraps { get { return _canSeeTraps; } }
        public byte Hallucinating { get { return _hallucinating; } }
        public byte CanSeeStairs { get { return _canSeeStairs; } }
        public byte Field0x2b { get { return _field0x2b; } }
        public byte Field0x2c { get { return _field0x2c; } }
        public byte Darkness { get { return _darkness; } }
        public byte Field0x2e { get { return _field0x2e; } }
        public byte LeaderPointed { get { return _leaderPointed; } }
        public byte Field0x30 { get { return _field0x30; } }
        public byte UnkFadeToBlackTracker { get { return _unkFadeToBlackTracker; } }
        public byte Field0x32 { get { return _field0x32; } }
        public byte Field0x33 { get { return _field0x33; } }
        public byte Field0x34 { get { return _field0x34; } }
        public byte TeamMenuOrGrid { get { return _teamMenuOrGrid; } }
        public DirectionId8 LeaderTargetDirection { get { return _leaderTargetDirection; } }
        public DirectionId8 LeaderTargetDirectionMirror { get { return _leaderTargetDirectionMirror; } }
        public ushort Field0x38 { get { return _field0x38; } }
        public ushort Field0x3a { get { return _field0x3a; } }
        public short FloorTouchScreen { get { return _floorTouchScreen; } }
        public short LeaderLevelTouchScreen { get { return _leaderLevelTouchScreen; } }
        public short LeaderHpTouchScreen { get { return _leaderHpTouchScreen; } }
        public short LeaderMaxHpTouchScreen { get { return _leaderMaxHpTouchScreen; } }
        public ushort Field0x44 { get { return _field0x44; } }
        public byte Field0x46 { get { return _field0x46; } }
        public byte Field0x47 { get { return _field0x47; } }
        public DisplayData M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
