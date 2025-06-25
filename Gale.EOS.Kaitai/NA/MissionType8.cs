// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Holds bitsized data for the parent enum mission_type.
    /// </summary>
    public partial class MissionType8 : KaitaiStruct
    {
        public static MissionType8 FromFile(string fileName)
        {
            return new MissionType8(new KaitaiStream(fileName));
        }


        public enum MissionType8Enum
        {
            MissionRescueClient = 0,
            MissionRescueTarget = 1,
            MissionEscortToTarget = 2,
            MissionExploreWithClient = 3,
            MissionProspectWithClient = 4,
            MissionGuideClient = 5,
            MissionFindItem = 6,
            MissionDeliverItem = 7,
            MissionSearchForTarget = 8,
            MissionTakeItemFromOutlaw = 9,
            MissionArrestOutlaw = 10,
            MissionChallengeRequest = 11,
            MissionTreasureMemo = 12,
            MissionTypeUnk0xd = 13,
            MissionTypeConsumable = 14,
        }
        public MissionType8(KaitaiStream p__io, KaitaiStruct p__parent = null, MissionType8 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _missionType8Value = ((MissionType8Enum) m_io.ReadBitsIntLe(8));
        }
        private MissionType8Enum _missionType8Value;
        private MissionType8 m_root;
        private KaitaiStruct m_parent;
        public MissionType8Enum MissionType8Value { get { return _missionType8Value; } }
        public MissionType8 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
