// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Holds bitsized data for the parent enum dungeon_group_id.
    /// </summary>
    public partial class DungeonGroupId8 : KaitaiStruct
    {
        public static DungeonGroupId8 FromFile(string fileName)
        {
            return new DungeonGroupId8(new KaitaiStream(fileName));
        }


        public enum DungeonGroupId8Enum
        {
            DgroupTestDungeon = 0,
            DgroupBeachCave = 1,
            DgroupDrenchedBluff = 2,
            DgroupMtBristle = 3,
            DgroupWaterfallCave = 4,
            DgroupAppleWoods = 5,
            DgroupCraggyCoast = 6,
            DgroupSidePath = 7,
            DgroupMtHorn = 8,
            DgroupRockPath = 9,
            DgroupFoggyForest = 10,
            DgroupForestPath = 11,
            DgroupSteamCave = 12,
            DgroupAmpPlains = 13,
            DgroupNorthernDesert = 14,
            DgroupQuicksandCave = 15,
            DgroupCrystalCave = 16,
            DgroupCrystalCrossing = 17,
            DgroupChasmCave = 18,
            DgroupDarkHill = 19,
            DgroupSealedRuin = 20,
            DgroupDuskForest = 21,
            DgroupDeepDuskForest = 22,
            DgroupTreeshroudForest = 23,
            DgroupBrineCave = 24,
            DgroupHiddenLand = 25,
            DgroupTemporalTower = 26,
            DgroupMystifyingForest = 27,
            DgroupMidnightForest = 28,
            DgroupLakeAfar = 29,
            DgroupMtMistral = 30,
            DgroupShimmerHill = 31,
            DgroupBottomlessSea = 32,
            DgroupSurroundedSea = 33,
            DgroupMiracleSea = 34,
            DgroupConcealedRuins = 35,
            DgroupLostWilderness = 36,
            DgroupMysteryJungle = 37,
            DgroupHappyOutlook = 38,
            DgroupSerenityRiver = 39,
            DgroupLandslideCave = 40,
            DgroupBlizzardIsland = 41,
            DgroupShimmerDesert = 42,
            DgroupCreviceCave = 43,
            DgroupMtAvalanche = 44,
            DgroupGiantVolcano = 45,
            DgroupWorldAbyss = 46,
            DgroupLushPrairie = 47,
            DgroupTinyMeadow = 48,
            DgroupLabyrinthCave = 49,
            DgroupOranForest = 50,
            DgroupSkyStairway = 51,
            DgroupAegisCave = 52,
            DgroupMarowakDojo = 53,
            DgroupDarkCrater = 54,
            DgroupMarineResort = 55,
            DgroupMtTravail = 56,
            DgroupTheNightmare = 57,
            DgroupSpacialRift = 58,
            DgroupZeroIsleNorth = 59,
            DgroupZeroIsleWest = 60,
            DgroupZeroIsleEast = 61,
            DgroupZeroIsleSouth = 62,
            DgroupRescue = 63,
            DgroupZeroIsleCenter = 64,
            DgroupDestinyTower = 65,
            DgroupDummy0x42 = 66,
            DgroupDummy0x43 = 67,
            DgroupOblivionForest = 68,
            DgroupTreacherousWaters = 69,
            DgroupSoutheasternIslands = 70,
            DgroupInfernoCave = 71,
            DgroupSkyPeak = 72,
            DgroupStarCaveSe1 = 73,
            DgroupMurkyForest = 74,
            DgroupEasternCave = 75,
            DgroupFortuneRavine = 76,
            DgroupBarrenValley = 77,
            DgroupDarkWasteland = 78,
            DgroupTemporalTowerSe5 = 79,
            DgroupDuskForestSe5 = 80,
            DgroupSpacialCliffs = 81,
            DgroupDarkIceMountain = 82,
            DgroupIcicleForest = 83,
            DgroupVastIceMountain = 84,
            DgroupSouthernJungle = 85,
            DgroupBoulderQuarry = 86,
            DgroupRightCavePath = 87,
            DgroupLeftCavePath = 88,
            DgroupLimestoneCavern = 89,
            DgroupSpringCave = 90,
            DgroupStarCave = 91,
            DgroupLittlePlains = 92,
            DgroupMtClear = 93,
            DgroupChallengeRiver = 94,
            DgroupTrialForest = 95,
            DgroupGuidingSea = 96,
            DgroupHiddenShopkeeperVillage = 97,
            DgroupDummy0x62 = 98,
            DgroupDummy0x63 = 99,
        }
        public DungeonGroupId8(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonGroupId8 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _dungeonGroupId8Value = ((DungeonGroupId8Enum) m_io.ReadBitsIntLe(8));
        }
        private DungeonGroupId8Enum _dungeonGroupId8Value;
        private DungeonGroupId8 m_root;
        private KaitaiStruct m_parent;
        public DungeonGroupId8Enum DungeonGroupId8Value { get { return _dungeonGroupId8Value; } }
        public DungeonGroupId8 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
