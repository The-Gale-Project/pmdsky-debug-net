// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union render_3d_texture_params defined within pmdsky-debug.
    /// </summary>
    public partial class Render3dTextureParams : KaitaiStruct
    {
        public static Render3dTextureParams FromFile(string fileName)
        {
            return new Render3dTextureParams(new KaitaiStream(fileName));
        }

        public Render3dTextureParams(KaitaiStream p__io, KaitaiStruct p__parent = null, Render3dTextureParams p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _textureSSize = m_io.ReadBitsIntLe(3);
            _textureTSize = m_io.ReadBitsIntLe(3);
            _teximageParamFlags6 = m_io.ReadBitsIntLe(2);
            _textureFormat = m_io.ReadBitsIntLe(3);
            _repeatS = m_io.ReadBitsIntLe(1) != 0;
            _repeatT = m_io.ReadBitsIntLe(1) != 0;
            _teximageParamFlagsD = m_io.ReadBitsIntLe(3);
        }
        private ulong _textureSSize;
        private ulong _textureTSize;
        private ulong _teximageParamFlags6;
        private ulong _textureFormat;
        private bool _repeatS;
        private bool _repeatT;
        private ulong _teximageParamFlagsD;
        private Render3dTextureParams m_root;
        private KaitaiStruct m_parent;
        public ulong TextureSSize { get { return _textureSSize; } }
        public ulong TextureTSize { get { return _textureTSize; } }
        public ulong TeximageParamFlags6 { get { return _teximageParamFlags6; } }
        public ulong TextureFormat { get { return _textureFormat; } }
        public bool RepeatS { get { return _repeatS; } }
        public bool RepeatT { get { return _repeatT; } }
        public ulong TeximageParamFlagsD { get { return _teximageParamFlagsD; } }
        public Render3dTextureParams M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
