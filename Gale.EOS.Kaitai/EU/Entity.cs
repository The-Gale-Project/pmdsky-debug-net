// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union entity defined within pmdsky-debug.
    /// </summary>
    public partial class Entity : KaitaiStruct
    {
        public static Entity FromFile(string fileName)
        {
            return new Entity(new KaitaiStream(fileName));
        }

        public Entity(KaitaiStream p__io, KaitaiStruct p__parent = null, Entity p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _type = new EntityType(m_io);
            _pos = new Position(m_io);
            _prevPos = new Position(m_io);
            _pixelPos = new PixelPosition(m_io);
            _pixelPosMirror = new PixelPosition(m_io);
            _elevation = m_io.ReadS4le();
            _isVisible = m_io.ReadU1();
            _field0x21 = m_io.ReadU1();
            _transparent = m_io.ReadU1();
            _endWalkAnimFrame = m_io.ReadU1();
            _field0x24 = m_io.ReadU1();
            _roomIdx = m_io.ReadU1();
            _spawnGenid = m_io.ReadU2le();
            _field0x28 = m_io.ReadU1();
            _field0x29 = m_io.ReadU1();
            _field0x2a = m_io.ReadU1();
            _field0x2b = m_io.ReadU1();
            _animCtrl = new AnimationControl(m_io);
            _spriteIndex = m_io.ReadU2le();
            _field0xaa = m_io.ReadU1();
            _field0xab = m_io.ReadU1();
            _field0xac = m_io.ReadU1();
            _field0xad = m_io.ReadU1();
            _animationGroupId = m_io.ReadU1();
            _animationGroupIdMirror = m_io.ReadU1();
            _animationId = m_io.ReadU1();
            _animationIdMirror0 = m_io.ReadU1();
            _field0xb2 = m_io.ReadU1();
            _field0xb3 = m_io.ReadU1();
            _info = new Pointer(m_io);
        }
        private EntityType _type;
        private Position _pos;
        private Position _prevPos;
        private PixelPosition _pixelPos;
        private PixelPosition _pixelPosMirror;
        private int _elevation;
        private byte _isVisible;
        private byte _field0x21;
        private byte _transparent;
        private byte _endWalkAnimFrame;
        private byte _field0x24;
        private byte _roomIdx;
        private ushort _spawnGenid;
        private byte _field0x28;
        private byte _field0x29;
        private byte _field0x2a;
        private byte _field0x2b;
        private AnimationControl _animCtrl;
        private ushort _spriteIndex;
        private byte _field0xaa;
        private byte _field0xab;
        private byte _field0xac;
        private byte _field0xad;
        private byte _animationGroupId;
        private byte _animationGroupIdMirror;
        private byte _animationId;
        private byte _animationIdMirror0;
        private byte _field0xb2;
        private byte _field0xb3;
        private Pointer _info;
        private Entity m_root;
        private KaitaiStruct m_parent;
        public EntityType Type { get { return _type; } }
        public Position Pos { get { return _pos; } }
        public Position PrevPos { get { return _prevPos; } }
        public PixelPosition PixelPos { get { return _pixelPos; } }
        public PixelPosition PixelPosMirror { get { return _pixelPosMirror; } }
        public int Elevation { get { return _elevation; } }
        public byte IsVisible { get { return _isVisible; } }
        public byte Field0x21 { get { return _field0x21; } }
        public byte Transparent { get { return _transparent; } }
        public byte EndWalkAnimFrame { get { return _endWalkAnimFrame; } }
        public byte Field0x24 { get { return _field0x24; } }
        public byte RoomIdx { get { return _roomIdx; } }
        public ushort SpawnGenid { get { return _spawnGenid; } }
        public byte Field0x28 { get { return _field0x28; } }
        public byte Field0x29 { get { return _field0x29; } }
        public byte Field0x2a { get { return _field0x2a; } }
        public byte Field0x2b { get { return _field0x2b; } }
        public AnimationControl AnimCtrl { get { return _animCtrl; } }
        public ushort SpriteIndex { get { return _spriteIndex; } }
        public byte Field0xaa { get { return _field0xaa; } }
        public byte Field0xab { get { return _field0xab; } }
        public byte Field0xac { get { return _field0xac; } }
        public byte Field0xad { get { return _field0xad; } }
        public byte AnimationGroupId { get { return _animationGroupId; } }
        public byte AnimationGroupIdMirror { get { return _animationGroupIdMirror; } }
        public byte AnimationId { get { return _animationId; } }
        public byte AnimationIdMirror0 { get { return _animationIdMirror0; } }
        public byte Field0xb2 { get { return _field0xb2; } }
        public byte Field0xb3 { get { return _field0xb3; } }
        public Pointer Info { get { return _info; } }
        public Entity M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
