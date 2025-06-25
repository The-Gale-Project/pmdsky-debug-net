// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union render_3d_element_64 defined within pmdsky-debug.
    /// </summary>
    public partial class Render3dElement64 : KaitaiStruct
    {
        public static Render3dElement64 FromFile(string fileName)
        {
            return new Render3dElement64(new KaitaiStream(fileName));
        }

        public Render3dElement64(KaitaiStream p__io, KaitaiStruct p__parent = null, Render3dElement64 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _vec = new Render3dElement64VecArray(m_io);
            _scale = new Uvec216(m_io);
            _textureParams = new Render3dTextureParams(m_io);
            _textureTopLeft = new Vec216(m_io);
            _textureSize = new Vec216(m_io);
            _field0x1e = m_io.ReadU1();
            _field0x1f = m_io.ReadU1();
            _textureVramOffset = m_io.ReadS4le();
            _paletteBaseAddr = m_io.ReadS4le();
            _rotation = m_io.ReadU2le();
            _zIndex = m_io.ReadU2le();
            _color = new Render3dElement64ColorArray(m_io);
            _type = new RenderType648(m_io);
            _flags0x3d0 = m_io.ReadBitsIntLe(1) != 0;
            _multicolored = m_io.ReadBitsIntLe(1) != 0;
            _flags0x3d2 = m_io.ReadBitsIntLe(6);
            m_io.AlignToByte();
            _polygonId = m_io.ReadU1();
            _field0x3f = m_io.ReadU1();
        }
        private Render3dElement64VecArray _vec;
        private Uvec216 _scale;
        private Render3dTextureParams _textureParams;
        private Vec216 _textureTopLeft;
        private Vec216 _textureSize;
        private byte _field0x1e;
        private byte _field0x1f;
        private int _textureVramOffset;
        private int _paletteBaseAddr;
        private ushort _rotation;
        private ushort _zIndex;
        private Render3dElement64ColorArray _color;
        private RenderType648 _type;
        private bool _flags0x3d0;
        private bool _multicolored;
        private ulong _flags0x3d2;
        private byte _polygonId;
        private byte _field0x3f;
        private Render3dElement64 m_root;
        private KaitaiStruct m_parent;
        public Render3dElement64VecArray Vec { get { return _vec; } }
        public Uvec216 Scale { get { return _scale; } }
        public Render3dTextureParams TextureParams { get { return _textureParams; } }
        public Vec216 TextureTopLeft { get { return _textureTopLeft; } }
        public Vec216 TextureSize { get { return _textureSize; } }
        public byte Field0x1e { get { return _field0x1e; } }
        public byte Field0x1f { get { return _field0x1f; } }
        public int TextureVramOffset { get { return _textureVramOffset; } }
        public int PaletteBaseAddr { get { return _paletteBaseAddr; } }
        public ushort Rotation { get { return _rotation; } }
        public ushort ZIndex { get { return _zIndex; } }
        public Render3dElement64ColorArray Color { get { return _color; } }
        public RenderType648 Type { get { return _type; } }
        public bool Flags0x3d0 { get { return _flags0x3d0; } }
        public bool Multicolored { get { return _multicolored; } }
        public ulong Flags0x3d2 { get { return _flags0x3d2; } }
        public byte PolygonId { get { return _polygonId; } }
        public byte Field0x3f { get { return _field0x3f; } }
        public Render3dElement64 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
