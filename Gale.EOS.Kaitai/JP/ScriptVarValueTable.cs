// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents a struct or union script_var_value_table defined within pmdsky-debug.
    /// </summary>
    public partial class ScriptVarValueTable : KaitaiStruct
    {
        public static ScriptVarValueTable FromFile(string fileName)
        {
            return new ScriptVarValueTable(new KaitaiStream(fileName));
        }

        public ScriptVarValueTable(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTable p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _version = m_io.ReadS4le();
            _condition = m_io.ReadS4le();
            _positionX = new ScriptVarValueTablePositionXArray(m_io);
            _positionY = new ScriptVarValueTablePositionYArray(m_io);
            _positionHeight = new ScriptVarValueTablePositionHeightArray(m_io);
            _recycleCount = m_io.ReadU4le();
            _groundEnter = m_io.ReadS2le();
            _groundGetout = m_io.ReadS2le();
            _groundMap = m_io.ReadS2le();
            _groundPlace = m_io.ReadS2le();
            _groundEnterBackup = new ScriptVarValueTableGroundEnterBackupArray(m_io);
            _groundGetoutBackup = new ScriptVarValueTableGroundGetoutBackupArray(m_io);
            _groundMapBackup = new ScriptVarValueTableGroundMapBackupArray(m_io);
            _groundPlaceBackup = new ScriptVarValueTableGroundPlaceBackupArray(m_io);
            _dungeonSelect = m_io.ReadS2le();
            _dungeonEnter = m_io.ReadS2le();
            _dungeonEnterMode = m_io.ReadS2le();
            _dungeonEnterIndex = m_io.ReadS2le();
            _dungeonEnterBackup = new ScriptVarValueTableDungeonEnterBackupArray(m_io);
            _dungeonEnterModeBackup = new ScriptVarValueTableDungeonEnterModeBackupArray(m_io);
            _dungeonEnterIndexBackup = new ScriptVarValueTableDungeonEnterIndexBackupArray(m_io);
            _heroFirstKind = m_io.ReadS2le();
            _partnerFirstKind = m_io.ReadS2le();
            _randomRequestNpc03Kind = m_io.ReadS2le();
            _eventLocal = m_io.ReadS2le();
            _dungeonEventLocal = m_io.ReadS2le();
            _itemBackup = new ScriptVarValueTableItemBackupArray(m_io);
            _itemBackupKurekure = new ScriptVarValueTableItemBackupKurekureArray(m_io);
            _itemBackupTake = new ScriptVarValueTableItemBackupTakeArray(m_io);
            _itemBackupGet = new ScriptVarValueTableItemBackupGetArray(m_io);
            _requestThanksResultKind = m_io.ReadS2le();
            _requestThanksResultVariation = m_io.ReadS2le();
            _dungeonEnterFrequency = m_io.ReadU2le();
            _dungeonEnterFrequencyBackup = new ScriptVarValueTableDungeonEnterFrequencyBackupArray(m_io);
            _scenarioBalanceFlag = m_io.ReadS1();
            _scenarioBalanceDebug = m_io.ReadS1();
            _heroTalkKind = m_io.ReadS1();
            _partnerTalkKind = m_io.ReadS1();
            _configColorKind = m_io.ReadS1();
            _romVariation = m_io.ReadS1();
            _specialEpisodeType = new SpecialEpisodeType(m_io);
            _positionDirection = new ScriptVarValueTablePositionDirectionArray(m_io);
            _scenarioSelect = new ScriptVarValueTableScenarioSelectArray(m_io);
            _scenarioMain = new ScriptVarValueTableScenarioMainArray(m_io);
            _scenarioSide = new ScriptVarValueTableScenarioSideArray(m_io);
            _scenarioSub1 = new ScriptVarValueTableScenarioSub1Array(m_io);
            _scenarioSub2 = new ScriptVarValueTableScenarioSub2Array(m_io);
            _scenarioSub3 = new ScriptVarValueTableScenarioSub3Array(m_io);
            _scenarioSub4 = new ScriptVarValueTableScenarioSub4Array(m_io);
            _scenarioSub5 = new ScriptVarValueTableScenarioSub5Array(m_io);
            _scenarioSub6 = new ScriptVarValueTableScenarioSub6Array(m_io);
            _scenarioSub7 = new ScriptVarValueTableScenarioSub7Array(m_io);
            _scenarioSub8 = new ScriptVarValueTableScenarioSub8Array(m_io);
            _crystalColor01 = m_io.ReadU1();
            _crystalColor02 = m_io.ReadU1();
            _crystalColor03 = m_io.ReadU1();
            _compulsorySavePoint = m_io.ReadU1();
            _compulsorySavePointSide = m_io.ReadU1();
            _scenarioSelectBackup = new ScriptVarValueTableScenarioSelectBackupArray(m_io);
            _groundEnterLink = m_io.ReadU1();
            _groundEnterLinkBackup = new ScriptVarValueTableGroundEnterLinkBackupArray(m_io);
            _dungeonResult = m_io.ReadU1();
            _groundStartMode = m_io.ReadU1();
            _dungeonResultBackup = new ScriptVarValueTableDungeonResultBackupArray(m_io);
            _groundStartModeBackup = new ScriptVarValueTableGroundStartModeBackupArray(m_io);
            _requestClearCount = m_io.ReadU1();
            _playerKind = m_io.ReadU1();
            _attendant1Kind = m_io.ReadU1();
            _attendant2Kind = m_io.ReadU1();
            _playerKindBackup = new ScriptVarValueTablePlayerKindBackupArray(m_io);
            _attendant1KindBackup = new ScriptVarValueTableAttendant1KindBackupArray(m_io);
            _attendant2KindBackup = new ScriptVarValueTableAttendant2KindBackupArray(m_io);
            _worldMapLevel = m_io.ReadU1();
            _lotteryResult = m_io.ReadU1();
            _sub30SpotLevel = m_io.ReadU1();
            _teamRankEventLevel = m_io.ReadU1();
            _playOldGame = m_io.ReadU1();
            _heroFirstName = new ScriptVarValueTableHeroFirstNameArray(m_io);
            _partnerFirstName = new ScriptVarValueTablePartnerFirstNameArray(m_io);
            _side02Talk = m_io.ReadBitsIntLe(3);
            _side06Room = m_io.ReadBitsIntLe(3);
            _side08Boss2nd = m_io.ReadBitsIntLe(1) != 0;
            _side01Boss2nd = m_io.ReadBitsIntLe(1) != 0;
            m_io.AlignToByte();
            _scenarioMainBitFlag = new ScriptVarValueTableScenarioMainBitFlagArray(m_io);
            _scenarioTalkBitFlag = new ScriptVarValueTableScenarioTalkBitFlagArray(m_io);
            _scenarioMainBitFlagBackup = new ScriptVarValueTableScenarioMainBitFlagBackupArray(m_io);
            _specialEpisodeOpen = new ScriptVarValueTableSpecialEpisodeOpenArray(m_io);
            _specialEpisodeOpenOld = new ScriptVarValueTableSpecialEpisodeOpenOldArray(m_io);
            _specialEpisodeConquest = new ScriptVarValueTableSpecialEpisodeConquestArray(m_io);
            _performanceProgressList = new ScriptVarValueTablePerformanceProgressListArray(m_io);
            _dungeonOpenList = new ScriptVarValueTableDungeonOpenListArray(m_io);
            _dungeonEnterList = new ScriptVarValueTableDungeonEnterListArray(m_io);
            _dungeonArriveList = new ScriptVarValueTableDungeonArriveListArray(m_io);
            _dungeonConquestList = new ScriptVarValueTableDungeonConquestListArray(m_io);
            _dungeonPresentList = new ScriptVarValueTableDungeonPresentListArray(m_io);
            _dungeonRequestList = new ScriptVarValueTableDungeonRequestListArray(m_io);
            _worldMapMarkListNormal = new ScriptVarValueTableWorldMapMarkListNormalArray(m_io);
            _worldMapMarkListSpecial = new ScriptVarValueTableWorldMapMarkListSpecialArray(m_io);
            _stationItemStatic = new ScriptVarValueTableStationItemStaticArray(m_io);
            _stationItemTemp = new ScriptVarValueTableStationItemTempArray(m_io);
            _deliverItemStatic = new ScriptVarValueTableDeliverItemStaticArray(m_io);
            _deliverItemTemp = new ScriptVarValueTableDeliverItemTempArray(m_io);
            _bitFuwaranteLocal = m_io.ReadBitsIntLe(5);
            _sub30TreasureDiscover = m_io.ReadBitsIntLe(1) != 0;
            _sub30SpotDiscover = m_io.ReadBitsIntLe(1) != 0;
            _sub30Projectp = m_io.ReadBitsIntLe(1) != 0;
            m_io.AlignToByte();
            _unused = new ScriptVarValueTableUnusedArray(m_io);
        }
        private int _version;
        private int _condition;
        private ScriptVarValueTablePositionXArray _positionX;
        private ScriptVarValueTablePositionYArray _positionY;
        private ScriptVarValueTablePositionHeightArray _positionHeight;
        private uint _recycleCount;
        private short _groundEnter;
        private short _groundGetout;
        private short _groundMap;
        private short _groundPlace;
        private ScriptVarValueTableGroundEnterBackupArray _groundEnterBackup;
        private ScriptVarValueTableGroundGetoutBackupArray _groundGetoutBackup;
        private ScriptVarValueTableGroundMapBackupArray _groundMapBackup;
        private ScriptVarValueTableGroundPlaceBackupArray _groundPlaceBackup;
        private short _dungeonSelect;
        private short _dungeonEnter;
        private short _dungeonEnterMode;
        private short _dungeonEnterIndex;
        private ScriptVarValueTableDungeonEnterBackupArray _dungeonEnterBackup;
        private ScriptVarValueTableDungeonEnterModeBackupArray _dungeonEnterModeBackup;
        private ScriptVarValueTableDungeonEnterIndexBackupArray _dungeonEnterIndexBackup;
        private short _heroFirstKind;
        private short _partnerFirstKind;
        private short _randomRequestNpc03Kind;
        private short _eventLocal;
        private short _dungeonEventLocal;
        private ScriptVarValueTableItemBackupArray _itemBackup;
        private ScriptVarValueTableItemBackupKurekureArray _itemBackupKurekure;
        private ScriptVarValueTableItemBackupTakeArray _itemBackupTake;
        private ScriptVarValueTableItemBackupGetArray _itemBackupGet;
        private short _requestThanksResultKind;
        private short _requestThanksResultVariation;
        private ushort _dungeonEnterFrequency;
        private ScriptVarValueTableDungeonEnterFrequencyBackupArray _dungeonEnterFrequencyBackup;
        private sbyte _scenarioBalanceFlag;
        private sbyte _scenarioBalanceDebug;
        private sbyte _heroTalkKind;
        private sbyte _partnerTalkKind;
        private sbyte _configColorKind;
        private sbyte _romVariation;
        private SpecialEpisodeType _specialEpisodeType;
        private ScriptVarValueTablePositionDirectionArray _positionDirection;
        private ScriptVarValueTableScenarioSelectArray _scenarioSelect;
        private ScriptVarValueTableScenarioMainArray _scenarioMain;
        private ScriptVarValueTableScenarioSideArray _scenarioSide;
        private ScriptVarValueTableScenarioSub1Array _scenarioSub1;
        private ScriptVarValueTableScenarioSub2Array _scenarioSub2;
        private ScriptVarValueTableScenarioSub3Array _scenarioSub3;
        private ScriptVarValueTableScenarioSub4Array _scenarioSub4;
        private ScriptVarValueTableScenarioSub5Array _scenarioSub5;
        private ScriptVarValueTableScenarioSub6Array _scenarioSub6;
        private ScriptVarValueTableScenarioSub7Array _scenarioSub7;
        private ScriptVarValueTableScenarioSub8Array _scenarioSub8;
        private byte _crystalColor01;
        private byte _crystalColor02;
        private byte _crystalColor03;
        private byte _compulsorySavePoint;
        private byte _compulsorySavePointSide;
        private ScriptVarValueTableScenarioSelectBackupArray _scenarioSelectBackup;
        private byte _groundEnterLink;
        private ScriptVarValueTableGroundEnterLinkBackupArray _groundEnterLinkBackup;
        private byte _dungeonResult;
        private byte _groundStartMode;
        private ScriptVarValueTableDungeonResultBackupArray _dungeonResultBackup;
        private ScriptVarValueTableGroundStartModeBackupArray _groundStartModeBackup;
        private byte _requestClearCount;
        private byte _playerKind;
        private byte _attendant1Kind;
        private byte _attendant2Kind;
        private ScriptVarValueTablePlayerKindBackupArray _playerKindBackup;
        private ScriptVarValueTableAttendant1KindBackupArray _attendant1KindBackup;
        private ScriptVarValueTableAttendant2KindBackupArray _attendant2KindBackup;
        private byte _worldMapLevel;
        private byte _lotteryResult;
        private byte _sub30SpotLevel;
        private byte _teamRankEventLevel;
        private byte _playOldGame;
        private ScriptVarValueTableHeroFirstNameArray _heroFirstName;
        private ScriptVarValueTablePartnerFirstNameArray _partnerFirstName;
        private ulong _side02Talk;
        private ulong _side06Room;
        private bool _side08Boss2nd;
        private bool _side01Boss2nd;
        private ScriptVarValueTableScenarioMainBitFlagArray _scenarioMainBitFlag;
        private ScriptVarValueTableScenarioTalkBitFlagArray _scenarioTalkBitFlag;
        private ScriptVarValueTableScenarioMainBitFlagBackupArray _scenarioMainBitFlagBackup;
        private ScriptVarValueTableSpecialEpisodeOpenArray _specialEpisodeOpen;
        private ScriptVarValueTableSpecialEpisodeOpenOldArray _specialEpisodeOpenOld;
        private ScriptVarValueTableSpecialEpisodeConquestArray _specialEpisodeConquest;
        private ScriptVarValueTablePerformanceProgressListArray _performanceProgressList;
        private ScriptVarValueTableDungeonOpenListArray _dungeonOpenList;
        private ScriptVarValueTableDungeonEnterListArray _dungeonEnterList;
        private ScriptVarValueTableDungeonArriveListArray _dungeonArriveList;
        private ScriptVarValueTableDungeonConquestListArray _dungeonConquestList;
        private ScriptVarValueTableDungeonPresentListArray _dungeonPresentList;
        private ScriptVarValueTableDungeonRequestListArray _dungeonRequestList;
        private ScriptVarValueTableWorldMapMarkListNormalArray _worldMapMarkListNormal;
        private ScriptVarValueTableWorldMapMarkListSpecialArray _worldMapMarkListSpecial;
        private ScriptVarValueTableStationItemStaticArray _stationItemStatic;
        private ScriptVarValueTableStationItemTempArray _stationItemTemp;
        private ScriptVarValueTableDeliverItemStaticArray _deliverItemStatic;
        private ScriptVarValueTableDeliverItemTempArray _deliverItemTemp;
        private ulong _bitFuwaranteLocal;
        private bool _sub30TreasureDiscover;
        private bool _sub30SpotDiscover;
        private bool _sub30Projectp;
        private ScriptVarValueTableUnusedArray _unused;
        private ScriptVarValueTable m_root;
        private KaitaiStruct m_parent;
        public int Version { get { return _version; } }
        public int Condition { get { return _condition; } }
        public ScriptVarValueTablePositionXArray PositionX { get { return _positionX; } }
        public ScriptVarValueTablePositionYArray PositionY { get { return _positionY; } }
        public ScriptVarValueTablePositionHeightArray PositionHeight { get { return _positionHeight; } }
        public uint RecycleCount { get { return _recycleCount; } }
        public short GroundEnter { get { return _groundEnter; } }
        public short GroundGetout { get { return _groundGetout; } }
        public short GroundMap { get { return _groundMap; } }
        public short GroundPlace { get { return _groundPlace; } }
        public ScriptVarValueTableGroundEnterBackupArray GroundEnterBackup { get { return _groundEnterBackup; } }
        public ScriptVarValueTableGroundGetoutBackupArray GroundGetoutBackup { get { return _groundGetoutBackup; } }
        public ScriptVarValueTableGroundMapBackupArray GroundMapBackup { get { return _groundMapBackup; } }
        public ScriptVarValueTableGroundPlaceBackupArray GroundPlaceBackup { get { return _groundPlaceBackup; } }
        public short DungeonSelect { get { return _dungeonSelect; } }
        public short DungeonEnter { get { return _dungeonEnter; } }
        public short DungeonEnterMode { get { return _dungeonEnterMode; } }
        public short DungeonEnterIndex { get { return _dungeonEnterIndex; } }
        public ScriptVarValueTableDungeonEnterBackupArray DungeonEnterBackup { get { return _dungeonEnterBackup; } }
        public ScriptVarValueTableDungeonEnterModeBackupArray DungeonEnterModeBackup { get { return _dungeonEnterModeBackup; } }
        public ScriptVarValueTableDungeonEnterIndexBackupArray DungeonEnterIndexBackup { get { return _dungeonEnterIndexBackup; } }
        public short HeroFirstKind { get { return _heroFirstKind; } }
        public short PartnerFirstKind { get { return _partnerFirstKind; } }
        public short RandomRequestNpc03Kind { get { return _randomRequestNpc03Kind; } }
        public short EventLocal { get { return _eventLocal; } }
        public short DungeonEventLocal { get { return _dungeonEventLocal; } }
        public ScriptVarValueTableItemBackupArray ItemBackup { get { return _itemBackup; } }
        public ScriptVarValueTableItemBackupKurekureArray ItemBackupKurekure { get { return _itemBackupKurekure; } }
        public ScriptVarValueTableItemBackupTakeArray ItemBackupTake { get { return _itemBackupTake; } }
        public ScriptVarValueTableItemBackupGetArray ItemBackupGet { get { return _itemBackupGet; } }
        public short RequestThanksResultKind { get { return _requestThanksResultKind; } }
        public short RequestThanksResultVariation { get { return _requestThanksResultVariation; } }
        public ushort DungeonEnterFrequency { get { return _dungeonEnterFrequency; } }
        public ScriptVarValueTableDungeonEnterFrequencyBackupArray DungeonEnterFrequencyBackup { get { return _dungeonEnterFrequencyBackup; } }
        public sbyte ScenarioBalanceFlag { get { return _scenarioBalanceFlag; } }
        public sbyte ScenarioBalanceDebug { get { return _scenarioBalanceDebug; } }
        public sbyte HeroTalkKind { get { return _heroTalkKind; } }
        public sbyte PartnerTalkKind { get { return _partnerTalkKind; } }
        public sbyte ConfigColorKind { get { return _configColorKind; } }
        public sbyte RomVariation { get { return _romVariation; } }
        public SpecialEpisodeType SpecialEpisodeType { get { return _specialEpisodeType; } }
        public ScriptVarValueTablePositionDirectionArray PositionDirection { get { return _positionDirection; } }
        public ScriptVarValueTableScenarioSelectArray ScenarioSelect { get { return _scenarioSelect; } }
        public ScriptVarValueTableScenarioMainArray ScenarioMain { get { return _scenarioMain; } }
        public ScriptVarValueTableScenarioSideArray ScenarioSide { get { return _scenarioSide; } }
        public ScriptVarValueTableScenarioSub1Array ScenarioSub1 { get { return _scenarioSub1; } }
        public ScriptVarValueTableScenarioSub2Array ScenarioSub2 { get { return _scenarioSub2; } }
        public ScriptVarValueTableScenarioSub3Array ScenarioSub3 { get { return _scenarioSub3; } }
        public ScriptVarValueTableScenarioSub4Array ScenarioSub4 { get { return _scenarioSub4; } }
        public ScriptVarValueTableScenarioSub5Array ScenarioSub5 { get { return _scenarioSub5; } }
        public ScriptVarValueTableScenarioSub6Array ScenarioSub6 { get { return _scenarioSub6; } }
        public ScriptVarValueTableScenarioSub7Array ScenarioSub7 { get { return _scenarioSub7; } }
        public ScriptVarValueTableScenarioSub8Array ScenarioSub8 { get { return _scenarioSub8; } }
        public byte CrystalColor01 { get { return _crystalColor01; } }
        public byte CrystalColor02 { get { return _crystalColor02; } }
        public byte CrystalColor03 { get { return _crystalColor03; } }
        public byte CompulsorySavePoint { get { return _compulsorySavePoint; } }
        public byte CompulsorySavePointSide { get { return _compulsorySavePointSide; } }
        public ScriptVarValueTableScenarioSelectBackupArray ScenarioSelectBackup { get { return _scenarioSelectBackup; } }
        public byte GroundEnterLink { get { return _groundEnterLink; } }
        public ScriptVarValueTableGroundEnterLinkBackupArray GroundEnterLinkBackup { get { return _groundEnterLinkBackup; } }
        public byte DungeonResult { get { return _dungeonResult; } }
        public byte GroundStartMode { get { return _groundStartMode; } }
        public ScriptVarValueTableDungeonResultBackupArray DungeonResultBackup { get { return _dungeonResultBackup; } }
        public ScriptVarValueTableGroundStartModeBackupArray GroundStartModeBackup { get { return _groundStartModeBackup; } }
        public byte RequestClearCount { get { return _requestClearCount; } }
        public byte PlayerKind { get { return _playerKind; } }
        public byte Attendant1Kind { get { return _attendant1Kind; } }
        public byte Attendant2Kind { get { return _attendant2Kind; } }
        public ScriptVarValueTablePlayerKindBackupArray PlayerKindBackup { get { return _playerKindBackup; } }
        public ScriptVarValueTableAttendant1KindBackupArray Attendant1KindBackup { get { return _attendant1KindBackup; } }
        public ScriptVarValueTableAttendant2KindBackupArray Attendant2KindBackup { get { return _attendant2KindBackup; } }
        public byte WorldMapLevel { get { return _worldMapLevel; } }
        public byte LotteryResult { get { return _lotteryResult; } }
        public byte Sub30SpotLevel { get { return _sub30SpotLevel; } }
        public byte TeamRankEventLevel { get { return _teamRankEventLevel; } }
        public byte PlayOldGame { get { return _playOldGame; } }
        public ScriptVarValueTableHeroFirstNameArray HeroFirstName { get { return _heroFirstName; } }
        public ScriptVarValueTablePartnerFirstNameArray PartnerFirstName { get { return _partnerFirstName; } }
        public ulong Side02Talk { get { return _side02Talk; } }
        public ulong Side06Room { get { return _side06Room; } }
        public bool Side08Boss2nd { get { return _side08Boss2nd; } }
        public bool Side01Boss2nd { get { return _side01Boss2nd; } }
        public ScriptVarValueTableScenarioMainBitFlagArray ScenarioMainBitFlag { get { return _scenarioMainBitFlag; } }
        public ScriptVarValueTableScenarioTalkBitFlagArray ScenarioTalkBitFlag { get { return _scenarioTalkBitFlag; } }
        public ScriptVarValueTableScenarioMainBitFlagBackupArray ScenarioMainBitFlagBackup { get { return _scenarioMainBitFlagBackup; } }
        public ScriptVarValueTableSpecialEpisodeOpenArray SpecialEpisodeOpen { get { return _specialEpisodeOpen; } }
        public ScriptVarValueTableSpecialEpisodeOpenOldArray SpecialEpisodeOpenOld { get { return _specialEpisodeOpenOld; } }
        public ScriptVarValueTableSpecialEpisodeConquestArray SpecialEpisodeConquest { get { return _specialEpisodeConquest; } }
        public ScriptVarValueTablePerformanceProgressListArray PerformanceProgressList { get { return _performanceProgressList; } }
        public ScriptVarValueTableDungeonOpenListArray DungeonOpenList { get { return _dungeonOpenList; } }
        public ScriptVarValueTableDungeonEnterListArray DungeonEnterList { get { return _dungeonEnterList; } }
        public ScriptVarValueTableDungeonArriveListArray DungeonArriveList { get { return _dungeonArriveList; } }
        public ScriptVarValueTableDungeonConquestListArray DungeonConquestList { get { return _dungeonConquestList; } }
        public ScriptVarValueTableDungeonPresentListArray DungeonPresentList { get { return _dungeonPresentList; } }
        public ScriptVarValueTableDungeonRequestListArray DungeonRequestList { get { return _dungeonRequestList; } }
        public ScriptVarValueTableWorldMapMarkListNormalArray WorldMapMarkListNormal { get { return _worldMapMarkListNormal; } }
        public ScriptVarValueTableWorldMapMarkListSpecialArray WorldMapMarkListSpecial { get { return _worldMapMarkListSpecial; } }
        public ScriptVarValueTableStationItemStaticArray StationItemStatic { get { return _stationItemStatic; } }
        public ScriptVarValueTableStationItemTempArray StationItemTemp { get { return _stationItemTemp; } }
        public ScriptVarValueTableDeliverItemStaticArray DeliverItemStatic { get { return _deliverItemStatic; } }
        public ScriptVarValueTableDeliverItemTempArray DeliverItemTemp { get { return _deliverItemTemp; } }
        public ulong BitFuwaranteLocal { get { return _bitFuwaranteLocal; } }
        public bool Sub30TreasureDiscover { get { return _sub30TreasureDiscover; } }
        public bool Sub30SpotDiscover { get { return _sub30SpotDiscover; } }
        public bool Sub30Projectp { get { return _sub30Projectp; } }
        public ScriptVarValueTableUnusedArray Unused { get { return _unused; } }
        public ScriptVarValueTable M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
