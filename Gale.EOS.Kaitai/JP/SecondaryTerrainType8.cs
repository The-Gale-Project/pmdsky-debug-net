// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Holds bitsized data for the parent enum secondary_terrain_type.
    /// </summary>
    public partial class SecondaryTerrainType8 : KaitaiStruct
    {
        public static SecondaryTerrainType8 FromFile(string fileName)
        {
            return new SecondaryTerrainType8(new KaitaiStream(fileName));
        }


        public enum SecondaryTerrainType8Enum
        {
            SecondaryTerrainWater = 0,
            SecondaryTerrainLava = 1,
            SecondaryTerrainChasm = 2,
        }
        public SecondaryTerrainType8(KaitaiStream p__io, KaitaiStruct p__parent = null, SecondaryTerrainType8 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _secondaryTerrainType8Value = ((SecondaryTerrainType8Enum) m_io.ReadBitsIntLe(8));
        }
        private SecondaryTerrainType8Enum _secondaryTerrainType8Value;
        private SecondaryTerrainType8 m_root;
        private KaitaiStruct m_parent;
        public SecondaryTerrainType8Enum SecondaryTerrainType8Value { get { return _secondaryTerrainType8Value; } }
        public SecondaryTerrainType8 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
