// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Holds bitsized data for the parent enum render_type_64.
    /// </summary>
    public partial class RenderType648 : KaitaiStruct
    {
        public static RenderType648 FromFile(string fileName)
        {
            return new RenderType648(new KaitaiStream(fileName));
        }


        public enum RenderType648Enum
        {
            Render64Texture = 0,
            Render64Nothing = 1,
            Render64Rectangle = 2,
            Render64RectangleMulticolor = 3,
            Render64Quadrilateral = 4,
            Render64Tiling = 5,
            Render64WindowFrame = 6,
            Render64Texture0x7 = 7,
        }
        public RenderType648(KaitaiStream p__io, KaitaiStruct p__parent = null, RenderType648 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _renderType648Value = ((RenderType648Enum) m_io.ReadBitsIntLe(8));
        }
        private RenderType648Enum _renderType648Value;
        private RenderType648 m_root;
        private KaitaiStruct m_parent;
        public RenderType648Enum RenderType648Value { get { return _renderType648Value; } }
        public RenderType648 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
