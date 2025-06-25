// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Holds bitsized data for the parent enum nature_power_variant.
    /// </summary>
    public partial class NaturePowerVariant16 : KaitaiStruct
    {
        public static NaturePowerVariant16 FromFile(string fileName)
        {
            return new NaturePowerVariant16(new KaitaiStream(fileName));
        }


        public enum NaturePowerVariant16Enum
        {
            NaturePowerSurf = 0,
            NaturePowerStunSpore = 1,
            NaturePowerShadowBall = 2,
            NaturePowerSwift = 3,
            NaturePowerEarthquake = 4,
            NaturePowerRazorLeaf = 5,
            NaturePowerBubblebeam = 6,
            NaturePowerRockSlide = 7,
            NaturePowerEarthquake2 = 8,
            NaturePowerTriAttack = 9,
            NaturePowerHydroPump = 10,
            NaturePowerBlizzard = 11,
            NaturePowerIceBeam = 12,
            NaturePowerSeedBomb = 13,
            NaturePowerMudBomb = 14,
        }
        public NaturePowerVariant16(KaitaiStream p__io, KaitaiStruct p__parent = null, NaturePowerVariant16 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _naturePowerVariant16Value = ((NaturePowerVariant16Enum) m_io.ReadBitsIntLe(16));
        }
        private NaturePowerVariant16Enum _naturePowerVariant16Value;
        private NaturePowerVariant16 m_root;
        private KaitaiStruct m_parent;
        public NaturePowerVariant16Enum NaturePowerVariant16Value { get { return _naturePowerVariant16Value; } }
        public NaturePowerVariant16 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
