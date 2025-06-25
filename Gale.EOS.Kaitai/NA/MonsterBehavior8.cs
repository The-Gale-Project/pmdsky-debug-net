// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Holds bitsized data for the parent enum monster_behavior.
    /// </summary>
    public partial class MonsterBehavior8 : KaitaiStruct
    {
        public static MonsterBehavior8 FromFile(string fileName)
        {
            return new MonsterBehavior8(new KaitaiStream(fileName));
        }


        public enum MonsterBehavior8Enum
        {
            BehaviorNormalEnemy0x0 = 0,
            BehaviorOutlaw = 1,
            BehaviorHiddenOutlaw = 2,
            BehaviorFleeingOutlaw = 3,
            BehaviorOutlawTeamLeader = 4,
            BehaviorOutlawTeamMinion = 5,
            BehaviorFixedEnemy = 6,
            BehaviorRescueTarget = 7,
            BehaviorWanderingEnemy0x8 = 8,
            BehaviorNormalEnemy0x9 = 9,
            BehaviorAlly = 10,
            BehaviorExplorerMaze1 = 11,
            BehaviorExplorerMaze2 = 12,
            BehaviorExplorerMaze3 = 13,
            BehaviorExplorerMaze4 = 14,
            BehaviorInvalid = 15,
            BehaviorSecretBazaarKirlia = 16,
            BehaviorSecretBazaarMimeJr = 17,
            BehaviorSecretBazaarSwalot = 18,
            BehaviorSecretBazaarLickilicky = 19,
            BehaviorSecretBazaarShedinja = 20,
            BehaviorWanderingEnemy0x15 = 21,
        }
        public MonsterBehavior8(KaitaiStream p__io, KaitaiStruct p__parent = null, MonsterBehavior8 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _monsterBehavior8Value = ((MonsterBehavior8Enum) m_io.ReadBitsIntLe(8));
        }
        private MonsterBehavior8Enum _monsterBehavior8Value;
        private MonsterBehavior8 m_root;
        private KaitaiStruct m_parent;
        public MonsterBehavior8Enum MonsterBehavior8Value { get { return _monsterBehavior8Value; } }
        public MonsterBehavior8 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
