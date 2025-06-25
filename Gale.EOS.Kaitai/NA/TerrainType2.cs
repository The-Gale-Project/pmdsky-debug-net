// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Holds bitsized data for the parent enum terrain_type.
    /// </summary>
    public partial class TerrainType2 : KaitaiStruct
    {
        public static TerrainType2 FromFile(string fileName)
        {
            return new TerrainType2(new KaitaiStream(fileName));
        }


        public enum TerrainType2Enum
        {
            TerrainWall = 0,
            TerrainNormal = 1,
            TerrainSecondary = 2,
            TerrainChasm = 3,
        }
        public TerrainType2(KaitaiStream p__io, KaitaiStruct p__parent = null, TerrainType2 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _terrainType2Value = ((TerrainType2Enum) m_io.ReadBitsIntLe(2));
        }
        private TerrainType2Enum _terrainType2Value;
        private TerrainType2 m_root;
        private KaitaiStruct m_parent;
        public TerrainType2Enum TerrainType2Value { get { return _terrainType2Value; } }
        public TerrainType2 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
