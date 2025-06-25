// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union mission_destination_info defined within pmdsky-debug.
    /// </summary>
    public partial class MissionDestinationInfo : KaitaiStruct
    {
        public static MissionDestinationInfo FromFile(string fileName)
        {
            return new MissionDestinationInfo(new KaitaiStream(fileName));
        }

        public MissionDestinationInfo(KaitaiStream p__io, KaitaiStruct p__parent = null, MissionDestinationInfo p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _isDestinationFloor = m_io.ReadU1();
            _type = new MissionType8(m_io);
            _subtype = m_io.ReadU1();
            _missionJobListIdx = m_io.ReadU1();
            _itemToRetrieve = new ItemId16(m_io);
            _itemToDeliver = new ItemId16(m_io);
            _specialTargetItem = new ItemId16(m_io);
            _client = new MonsterId16(m_io);
            _rescueTarget = new MonsterId16(m_io);
            _enemySpecies = new MissionDestinationInfoEnemySpeciesArray(m_io);
            _nEnemySpecies = m_io.ReadU1();
            _field0x15 = m_io.ReadU1();
            _fixedRoomId = new FixedRoomId8(m_io);
            _unkMissionItemTracker1 = m_io.ReadU1();
            _field0x18 = m_io.ReadU1();
            _field0x19 = m_io.ReadU1();
            _unkMissionItemTracker2 = m_io.ReadU1();
            _targetEnemyIsDefeated = m_io.ReadU1();
            _fleeingOutlawTracker = m_io.ReadU1();
            _field0x1d = m_io.ReadU1();
        }
        private byte _isDestinationFloor;
        private MissionType8 _type;
        private byte _subtype;
        private byte _missionJobListIdx;
        private ItemId16 _itemToRetrieve;
        private ItemId16 _itemToDeliver;
        private ItemId16 _specialTargetItem;
        private MonsterId16 _client;
        private MonsterId16 _rescueTarget;
        private MissionDestinationInfoEnemySpeciesArray _enemySpecies;
        private byte _nEnemySpecies;
        private byte _field0x15;
        private FixedRoomId8 _fixedRoomId;
        private byte _unkMissionItemTracker1;
        private byte _field0x18;
        private byte _field0x19;
        private byte _unkMissionItemTracker2;
        private byte _targetEnemyIsDefeated;
        private byte _fleeingOutlawTracker;
        private byte _field0x1d;
        private MissionDestinationInfo m_root;
        private KaitaiStruct m_parent;
        public byte IsDestinationFloor { get { return _isDestinationFloor; } }
        public MissionType8 Type { get { return _type; } }
        public byte Subtype { get { return _subtype; } }
        public byte MissionJobListIdx { get { return _missionJobListIdx; } }
        public ItemId16 ItemToRetrieve { get { return _itemToRetrieve; } }
        public ItemId16 ItemToDeliver { get { return _itemToDeliver; } }
        public ItemId16 SpecialTargetItem { get { return _specialTargetItem; } }
        public MonsterId16 Client { get { return _client; } }
        public MonsterId16 RescueTarget { get { return _rescueTarget; } }
        public MissionDestinationInfoEnemySpeciesArray EnemySpecies { get { return _enemySpecies; } }
        public byte NEnemySpecies { get { return _nEnemySpecies; } }
        public byte Field0x15 { get { return _field0x15; } }
        public FixedRoomId8 FixedRoomId { get { return _fixedRoomId; } }
        public byte UnkMissionItemTracker1 { get { return _unkMissionItemTracker1; } }
        public byte Field0x18 { get { return _field0x18; } }
        public byte Field0x19 { get { return _field0x19; } }
        public byte UnkMissionItemTracker2 { get { return _unkMissionItemTracker2; } }
        public byte TargetEnemyIsDefeated { get { return _targetEnemyIsDefeated; } }
        public byte FleeingOutlawTracker { get { return _fleeingOutlawTracker; } }
        public byte Field0x1d { get { return _field0x1d; } }
        public MissionDestinationInfo M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
