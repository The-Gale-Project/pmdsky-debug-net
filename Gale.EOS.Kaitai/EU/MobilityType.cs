// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Holds the data for the enum mobility_type.
    /// </summary>
    public partial class MobilityType : KaitaiStruct
    {
        public static MobilityType FromFile(string fileName)
        {
            return new MobilityType(new KaitaiStream(fileName));
        }


        public enum MobilityTypeEnum
        {
            MobilityNormal = 0,
            MobilitySecondary = 1,
            MobilityHovering = 2,
            MobilityIntangible = 3,
            MobilityLava = 4,
            MobilityWater = 5,
        }
        public MobilityType(KaitaiStream p__io, KaitaiStruct p__parent = null, MobilityType p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _mobilityTypeValue = ((MobilityTypeEnum) m_io.ReadBitsIntLe(32));
        }
        private MobilityTypeEnum _mobilityTypeValue;
        private MobilityType m_root;
        private KaitaiStruct m_parent;
        public MobilityTypeEnum MobilityTypeValue { get { return _mobilityTypeValue; } }
        public MobilityType M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
