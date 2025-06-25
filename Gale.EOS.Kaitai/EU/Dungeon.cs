// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union dungeon defined within pmdsky-debug.
    /// </summary>
    public partial class Dungeon : KaitaiStruct
    {
        public static Dungeon FromFile(string fileName)
        {
            return new Dungeon(new KaitaiStream(fileName));
        }

        public Dungeon(KaitaiStream p__io, KaitaiStruct p__parent = null, Dungeon p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _field0x0 = m_io.ReadU1();
            _targetEnemyDefeatedMessage = m_io.ReadU1();
            _hiddenOutlawDefeatedMessage = m_io.ReadU1();
            _targetMonsterNotFoundFlag = m_io.ReadU1();
            _field0x4 = m_io.ReadU1();
            _steppedOnStairs = m_io.ReadU1();
            _endFloorFlag = m_io.ReadU1();
            _quicksaveFlag = m_io.ReadU1();
            _endFloorNoDeathCheckFlag = m_io.ReadU1();
            _field0x9 = m_io.ReadU1();
            _field0xa = m_io.ReadU1();
            _field0xb = m_io.ReadU1();
            _missionDeliverItemCheck = m_io.ReadU1();
            _field0xd = m_io.ReadU1();
            _activateArtificialWeatherFlag = m_io.ReadU1();
            _shouldEnemyEvolve = m_io.ReadU1();
            _swappingPlaces = m_io.ReadU1();
            _noActionInProgress = m_io.ReadU1();
            _iqDisabled = m_io.ReadU1();
            _regularAttackRevealTraps = m_io.ReadU1();
            _forcedLossReason = new ForcedLossReason(m_io);
            _successfulExitTracker = m_io.ReadU4le();
            _cameraFrameCounter = m_io.ReadS2le();
            _numberCompletedFloors = m_io.ReadU1();
            _speedBoostCounter = m_io.ReadU1();
            _numberPrecedingFloors = m_io.ReadU2le();
            _totalFloorsCompleted = m_io.ReadU2le();
            _field0x24 = m_io.ReadU1();
            _field0x25 = m_io.ReadU1();
            _field0x26 = m_io.ReadU1();
            _field0x27 = m_io.ReadU1();
            _field0x28 = m_io.ReadU1();
            _field0x29 = m_io.ReadU1();
            _field0x2a = m_io.ReadU1();
            _field0x2b = m_io.ReadU1();
            _field0x2c = m_io.ReadU1();
            _field0x2d = m_io.ReadU1();
            _field0x2e = m_io.ReadU1();
            _field0x2f = m_io.ReadU1();
            _field0x30 = m_io.ReadU1();
            _field0x31 = m_io.ReadU1();
            _field0x32 = m_io.ReadU1();
            _field0x33 = m_io.ReadU1();
            _field0x34 = m_io.ReadU1();
            _field0x35 = m_io.ReadU1();
            _field0x36 = m_io.ReadU1();
            _field0x37 = m_io.ReadU1();
            _field0x38 = m_io.ReadU1();
            _field0x39 = m_io.ReadU1();
            _field0x3a = m_io.ReadU1();
            _field0x3b = m_io.ReadU1();
            _field0x3c = m_io.ReadU1();
            _field0x3d = m_io.ReadU1();
            _field0x3e = m_io.ReadU1();
            _field0x3f = m_io.ReadU1();
            _field0x40 = m_io.ReadU1();
            _field0x41 = m_io.ReadU1();
            _field0x42 = m_io.ReadU1();
            _field0x43 = m_io.ReadU1();
            _field0x44 = m_io.ReadU1();
            _field0x45 = m_io.ReadU1();
            _field0x46 = m_io.ReadU1();
            _field0x47 = m_io.ReadU1();
            _field0x48 = m_io.ReadU1();
            _field0x49 = m_io.ReadU1();
            _field0x4a = m_io.ReadU1();
            _field0x4b = m_io.ReadU1();
            _field0x4c = m_io.ReadU1();
            _field0x4d = m_io.ReadU1();
            _field0x4e = m_io.ReadU1();
            _field0x4f = m_io.ReadU1();
            _field0x50 = m_io.ReadU1();
            _field0x51 = m_io.ReadU1();
            _field0x52 = m_io.ReadU1();
            _field0x53 = m_io.ReadU1();
            _field0x54 = m_io.ReadU1();
            _field0x55 = m_io.ReadU1();
            _field0x56 = m_io.ReadU1();
            _field0x57 = m_io.ReadU1();
            _field0x58 = m_io.ReadU1();
            _field0x59 = m_io.ReadU1();
            _field0x5a = m_io.ReadU1();
            _field0x5b = m_io.ReadU1();
            _field0x5c = m_io.ReadU1();
            _field0x5d = m_io.ReadU1();
            _field0x5e = m_io.ReadU1();
            _field0x5f = m_io.ReadU1();
            _field0x60 = m_io.ReadU1();
            _field0x61 = m_io.ReadU1();
            _field0x62 = m_io.ReadU1();
            _field0x63 = m_io.ReadU1();
            _field0x64 = m_io.ReadU1();
            _field0x65 = m_io.ReadU1();
            _field0x66 = m_io.ReadU1();
            _field0x67 = m_io.ReadU1();
            _field0x68 = m_io.ReadU1();
            _field0x69 = m_io.ReadU1();
            _field0x6a = m_io.ReadU1();
            _field0x6b = m_io.ReadU1();
            _field0x6c = m_io.ReadU1();
            _field0x6d = m_io.ReadU1();
            _field0x6e = m_io.ReadU1();
            _field0x6f = m_io.ReadU1();
            _field0x70 = m_io.ReadU1();
            _field0x71 = m_io.ReadU1();
            _field0x72 = m_io.ReadU1();
            _field0x73 = m_io.ReadU1();
            _field0x74 = m_io.ReadU1();
            _field0x75 = m_io.ReadU1();
            _field0x76 = m_io.ReadU1();
            _field0x77 = m_io.ReadU1();
            _field0x78 = m_io.ReadU1();
            _field0x79 = m_io.ReadU1();
            _field0x7a = m_io.ReadU1();
            _field0x7b = m_io.ReadU1();
            _field0x7c = m_io.ReadU1();
            _field0x7d = m_io.ReadU1();
            _field0x7e = m_io.ReadU1();
            _field0x7f = m_io.ReadU1();
            _field0x80 = m_io.ReadU1();
            _field0x81 = m_io.ReadU1();
            _field0x82 = m_io.ReadU1();
            _field0x83 = m_io.ReadU1();
            _field0x84 = m_io.ReadU1();
            _field0x85 = m_io.ReadU1();
            _field0x86 = m_io.ReadU1();
            _field0x87 = m_io.ReadU1();
            _field0x88 = m_io.ReadU1();
            _field0x89 = m_io.ReadU1();
            _field0x8a = m_io.ReadU1();
            _field0x8b = m_io.ReadU1();
            _field0x8c = m_io.ReadU1();
            _field0x8d = m_io.ReadU1();
            _field0x8e = m_io.ReadU1();
            _field0x8f = m_io.ReadU1();
            _field0x90 = m_io.ReadU1();
            _field0x91 = m_io.ReadU1();
            _field0x92 = m_io.ReadU1();
            _field0x93 = m_io.ReadU1();
            _field0x94 = m_io.ReadU1();
            _field0x95 = m_io.ReadU1();
            _field0x96 = m_io.ReadU1();
            _field0x97 = m_io.ReadU1();
            _field0x98 = m_io.ReadU1();
            _field0x99 = m_io.ReadU1();
            _field0x9a = m_io.ReadU1();
            _field0x9b = m_io.ReadU1();
            _field0x9c = m_io.ReadU1();
            _field0x9d = m_io.ReadU1();
            _field0x9e = m_io.ReadU1();
            _field0x9f = m_io.ReadU1();
            _field0xa0 = m_io.ReadU1();
            _field0xa1 = m_io.ReadU1();
            _field0xa2 = m_io.ReadU1();
            _field0xa3 = m_io.ReadU1();
            _field0xa4 = m_io.ReadU1();
            _field0xa5 = m_io.ReadU1();
            _field0xa6 = m_io.ReadU1();
            _field0xa7 = m_io.ReadU1();
            _field0xa8 = m_io.ReadU1();
            _field0xa9 = m_io.ReadU1();
            _field0xaa = m_io.ReadU1();
            _field0xab = m_io.ReadU1();
            _field0xac = m_io.ReadU1();
            _field0xad = m_io.ReadU1();
            _field0xae = m_io.ReadU1();
            _field0xaf = m_io.ReadU1();
            _field0xb0 = m_io.ReadU1();
            _field0xb1 = m_io.ReadU1();
            _field0xb2 = m_io.ReadU1();
            _field0xb3 = m_io.ReadU1();
            _field0xb4 = m_io.ReadU1();
            _field0xb5 = m_io.ReadU1();
            _field0xb6 = m_io.ReadU1();
            _field0xb7 = m_io.ReadU1();
            _field0xb8 = m_io.ReadU1();
            _field0xb9 = m_io.ReadU1();
            _field0xba = m_io.ReadU1();
            _field0xbb = m_io.ReadU1();
            _field0xbc = m_io.ReadU1();
            _field0xbd = m_io.ReadU1();
            _field0xbe = m_io.ReadU1();
            _field0xbf = m_io.ReadU1();
            _field0xc0 = m_io.ReadU1();
            _field0xc1 = m_io.ReadU1();
            _field0xc2 = m_io.ReadU1();
            _field0xc3 = m_io.ReadU1();
            _currentActiveEntity = new Pointer(m_io);
            _newLeader = new Pointer(m_io);
            _thrownItem = new Entity(m_io);
            _lastDamageCalc = new DamageCalcDiag(m_io);
            _touchscreenTargetPosition = new Position(m_io);
            _unknownLeaderPosition = new Position(m_io);
            _colorTable = new DungeonColorTableArray(m_io);
            _shopkeeperSpawns = new DungeonShopkeeperSpawnsArray(m_io);
            _shopkeeperSpawnCount = m_io.ReadS4le();
            _field0x614 = m_io.ReadS4le();
            _unk1Animation1Value = m_io.ReadU4le();
            _unk2Animation1Value = m_io.ReadU4le();
            _unk3Animation1Value = m_io.ReadU4le();
            _animation1Entity = new Pointer(m_io);
            _unk1Animation2Value = m_io.ReadU4le();
            _unk2Animation2Value = m_io.ReadU4le();
            _unk3Animation2Value = m_io.ReadU4le();
            _animation2Entity = new Pointer(m_io);
            _unk1Animation3Value = m_io.ReadU4le();
            _unk2Animation3Value = m_io.ReadU4le();
            _unk3Animation3Value = m_io.ReadU4le();
            _animation3Entity = new Pointer(m_io);
            _fallenAllyMonsterName = new DungeonFallenAllyMonsterNameArray(m_io);
            _field0x652 = m_io.ReadU1();
            _field0x653 = m_io.ReadU1();
            _field0x654 = m_io.ReadU1();
            _field0x655 = m_io.ReadU1();
            _field0x656 = m_io.ReadU1();
            _field0x657 = m_io.ReadU1();
            _field0x658 = m_io.ReadU1();
            _field0x659 = m_io.ReadU1();
            _field0x65a = m_io.ReadU1();
            _field0x65b = m_io.ReadU1();
            _field0x65c = m_io.ReadU1();
            _field0x65d = m_io.ReadU1();
            _field0x65e = m_io.ReadU1();
            _field0x65f = m_io.ReadU1();
            _field0x660 = m_io.ReadU1();
            _field0x661 = m_io.ReadU1();
            _field0x662 = m_io.ReadU1();
            _field0x663 = m_io.ReadU1();
            _field0x664 = m_io.ReadU1();
            _field0x665 = m_io.ReadU1();
            _field0x666 = m_io.ReadU1();
            _field0x667 = m_io.ReadU1();
            _field0x668 = m_io.ReadU1();
            _field0x669 = m_io.ReadU1();
            _field0x66a = m_io.ReadU1();
            _field0x66b = m_io.ReadU1();
            _field0x66c = m_io.ReadU1();
            _field0x66d = m_io.ReadU1();
            _field0x66e = m_io.ReadU1();
            _field0x66f = m_io.ReadU1();
            _field0x670 = m_io.ReadU1();
            _field0x671 = m_io.ReadU1();
            _field0x672 = m_io.ReadU1();
            _field0x673 = m_io.ReadU1();
            _field0x674 = m_io.ReadU1();
            _field0x675 = m_io.ReadU1();
            _field0x676 = m_io.ReadU1();
            _field0x677 = m_io.ReadU1();
            _field0x678 = m_io.ReadU1();
            _field0x679 = m_io.ReadU1();
            _field0x67a = m_io.ReadU1();
            _field0x67b = m_io.ReadU1();
            _field0x67c = m_io.ReadU1();
            _field0x67d = m_io.ReadU1();
            _field0x67e = m_io.ReadU1();
            _field0x67f = m_io.ReadU1();
            _field0x680 = m_io.ReadU1();
            _field0x681 = m_io.ReadU1();
            _field0x682 = m_io.ReadU1();
            _field0x683 = m_io.ReadU1();
            _field0x684 = m_io.ReadU1();
            _field0x685 = m_io.ReadU1();
            _field0x686 = m_io.ReadU1();
            _field0x687 = m_io.ReadU1();
            _field0x688 = m_io.ReadU1();
            _field0x689 = m_io.ReadU1();
            _field0x68a = m_io.ReadU1();
            _field0x68b = m_io.ReadU1();
            _field0x68c = m_io.ReadU1();
            _field0x68d = m_io.ReadU1();
            _field0x68e = m_io.ReadU1();
            _field0x68f = m_io.ReadU1();
            _field0x690 = m_io.ReadU1();
            _field0x691 = m_io.ReadU1();
            _field0x692 = m_io.ReadU1();
            _field0x693 = m_io.ReadU1();
            _field0x694 = m_io.ReadU1();
            _field0x695 = m_io.ReadU1();
            _field0x696 = m_io.ReadU1();
            _field0x697 = m_io.ReadU1();
            _field0x698 = m_io.ReadU1();
            _field0x699 = m_io.ReadU1();
            _field0x69a = m_io.ReadU1();
            _field0x69b = m_io.ReadU1();
            _field0x69c = m_io.ReadU1();
            _field0x69d = m_io.ReadU1();
            _field0x69e = m_io.ReadU1();
            _field0x69f = m_io.ReadU1();
            _field0x6a0 = m_io.ReadU1();
            _field0x6a1 = m_io.ReadU1();
            _field0x6a2 = m_io.ReadU1();
            _field0x6a3 = m_io.ReadU1();
            _field0x6a4 = m_io.ReadU1();
            _field0x6a5 = m_io.ReadU1();
            _field0x6a6 = m_io.ReadU1();
            _field0x6a7 = m_io.ReadU1();
            _field0x6a8 = m_io.ReadU1();
            _field0x6a9 = m_io.ReadU1();
            _field0x6aa = m_io.ReadU1();
            _field0x6ab = m_io.ReadU1();
            _field0x6ac = m_io.ReadU1();
            _field0x6ad = m_io.ReadU1();
            _field0x6ae = m_io.ReadU1();
            _field0x6af = m_io.ReadU1();
            _field0x6b0 = m_io.ReadU1();
            _field0x6b1 = m_io.ReadU1();
            _field0x6b2 = m_io.ReadU1();
            _field0x6b3 = m_io.ReadU1();
            _field0x6b4 = m_io.ReadU1();
            _field0x6b5 = m_io.ReadU1();
            _field0x6b6 = m_io.ReadU1();
            _field0x6b7 = m_io.ReadU1();
            _field0x6b8 = m_io.ReadU1();
            _field0x6b9 = m_io.ReadU1();
            _field0x6ba = m_io.ReadU1();
            _field0x6bb = m_io.ReadU1();
            _field0x6bc = m_io.ReadU1();
            _field0x6bd = m_io.ReadU1();
            _field0x6be = m_io.ReadU1();
            _field0x6bf = m_io.ReadU1();
            _field0x6c0 = m_io.ReadU1();
            _field0x6c1 = m_io.ReadU1();
            _field0x6c2 = m_io.ReadU1();
            _field0x6c3 = m_io.ReadU1();
            _field0x6c4 = m_io.ReadU1();
            _field0x6c5 = m_io.ReadU1();
            _field0x6c6 = m_io.ReadU1();
            _field0x6c7 = m_io.ReadU1();
            _field0x6c8 = m_io.ReadU1();
            _field0x6c9 = m_io.ReadU1();
            _field0x6ca = m_io.ReadU1();
            _field0x6cb = m_io.ReadU1();
            _field0x6cc = m_io.ReadU1();
            _field0x6cd = m_io.ReadU1();
            _field0x6ce = m_io.ReadU1();
            _field0x6cf = m_io.ReadU1();
            _field0x6d0 = m_io.ReadU1();
            _field0x6d1 = m_io.ReadU1();
            _field0x6d2 = m_io.ReadU1();
            _field0x6d3 = m_io.ReadU1();
            _field0x6d4 = m_io.ReadU1();
            _field0x6d5 = m_io.ReadU1();
            _field0x6d6 = m_io.ReadU1();
            _field0x6d7 = m_io.ReadU1();
            _field0x6d8 = m_io.ReadU1();
            _field0x6d9 = m_io.ReadU1();
            _field0x6da = m_io.ReadU1();
            _field0x6db = m_io.ReadU1();
            _field0x6dc = m_io.ReadU1();
            _field0x6dd = m_io.ReadU1();
            _field0x6de = m_io.ReadU1();
            _field0x6df = m_io.ReadU1();
            _field0x6e0 = m_io.ReadU1();
            _field0x6e1 = m_io.ReadU1();
            _field0x6e2 = m_io.ReadU1();
            _field0x6e3 = m_io.ReadU1();
            _field0x6e4 = m_io.ReadU1();
            _field0x6e5 = m_io.ReadU1();
            _field0x6e6 = m_io.ReadU1();
            _field0x6e7 = m_io.ReadU1();
            _field0x6e8 = m_io.ReadU1();
            _field0x6e9 = m_io.ReadU1();
            _field0x6ea = m_io.ReadU1();
            _field0x6eb = m_io.ReadU1();
            _field0x6ec = m_io.ReadU1();
            _field0x6ed = m_io.ReadU1();
            _field0x6ee = m_io.ReadU1();
            _field0x6ef = m_io.ReadU1();
            _field0x6f0 = m_io.ReadU1();
            _field0x6f1 = m_io.ReadU1();
            _field0x6f2 = m_io.ReadU1();
            _field0x6f3 = m_io.ReadU1();
            _field0x6f4 = m_io.ReadU1();
            _field0x6f5 = m_io.ReadU1();
            _field0x6f6 = m_io.ReadU1();
            _field0x6f7 = m_io.ReadU1();
            _field0x6f8 = m_io.ReadU1();
            _field0x6f9 = m_io.ReadU1();
            _field0x6fa = m_io.ReadU1();
            _field0x6fb = m_io.ReadU1();
            _field0x6fc = m_io.ReadU1();
            _field0x6fd = m_io.ReadU1();
            _field0x6fe = m_io.ReadU1();
            _field0x6ff = m_io.ReadU1();
            _field0x700 = m_io.ReadU1();
            _field0x701 = m_io.ReadU1();
            _field0x702 = m_io.ReadU1();
            _field0x703 = m_io.ReadU1();
            _field0x704 = m_io.ReadU1();
            _field0x705 = m_io.ReadU1();
            _field0x706 = m_io.ReadU1();
            _field0x707 = m_io.ReadU1();
            _field0x708 = m_io.ReadU1();
            _field0x709 = m_io.ReadU1();
            _field0x70a = m_io.ReadU1();
            _field0x70b = m_io.ReadU1();
            _field0x70c = m_io.ReadU1();
            _field0x70d = m_io.ReadU1();
            _field0x70e = m_io.ReadU1();
            _field0x70f = m_io.ReadU1();
            _field0x710 = m_io.ReadU1();
            _field0x711 = m_io.ReadU1();
            _field0x712 = m_io.ReadU1();
            _field0x713 = m_io.ReadU1();
            _field0x714 = m_io.ReadU1();
            _field0x715 = m_io.ReadU1();
            _field0x716 = m_io.ReadU1();
            _field0x717 = m_io.ReadU1();
            _field0x718 = m_io.ReadU1();
            _field0x719 = m_io.ReadU1();
            _field0x71a = m_io.ReadU1();
            _field0x71b = m_io.ReadU1();
            _field0x71c = m_io.ReadU1();
            _field0x71d = m_io.ReadU1();
            _field0x71e = m_io.ReadU1();
            _field0x71f = m_io.ReadU1();
            _field0x720 = m_io.ReadU1();
            _field0x721 = m_io.ReadU1();
            _field0x722 = m_io.ReadU1();
            _field0x723 = m_io.ReadU1();
            _field0x724 = m_io.ReadU1();
            _field0x725 = m_io.ReadU1();
            _field0x726 = m_io.ReadU1();
            _field0x727 = m_io.ReadU1();
            _field0x728 = m_io.ReadU1();
            _field0x729 = m_io.ReadU1();
            _field0x72a = m_io.ReadU1();
            _field0x72b = m_io.ReadU1();
            _field0x72c = m_io.ReadU1();
            _field0x72d = m_io.ReadU1();
            _field0x72e = m_io.ReadU1();
            _field0x72f = m_io.ReadU1();
            _field0x730 = m_io.ReadU1();
            _field0x731 = m_io.ReadU1();
            _field0x732 = m_io.ReadU1();
            _field0x733 = m_io.ReadU1();
            _field0x734 = m_io.ReadU1();
            _field0x735 = m_io.ReadU1();
            _field0x736 = m_io.ReadU1();
            _field0x737 = m_io.ReadU1();
            _field0x738 = m_io.ReadU1();
            _field0x739 = m_io.ReadU1();
            _field0x73a = m_io.ReadU1();
            _field0x73b = m_io.ReadU1();
            _field0x73c = m_io.ReadU1();
            _field0x73d = m_io.ReadU1();
            _field0x73e = m_io.ReadU1();
            _field0x73f = m_io.ReadU1();
            _field0x740 = m_io.ReadU1();
            _field0x741 = m_io.ReadU1();
            _field0x742 = m_io.ReadU1();
            _field0x743 = m_io.ReadU1();
            _field0x744 = m_io.ReadU1();
            _field0x745 = m_io.ReadU1();
            _field0x746 = m_io.ReadU1();
            _field0x747 = m_io.ReadU1();
            _id = new DungeonId8(m_io);
            _floor = m_io.ReadU1();
            _groupAndGroupFloorId = new DungeonGroupAndGroupFloor(m_io);
            _field0x74c = m_io.ReadU2le();
            _field0x74e = m_io.ReadU1();
            _field0x74f = m_io.ReadU1();
            _field0x750 = m_io.ReadU1();
            _rescueFloor = m_io.ReadU1();
            _field0x752 = m_io.ReadU1();
            _field0x753 = m_io.ReadU1();
            _prngPreseed23Bit = m_io.ReadU4le();
            _floorLoopStatus = new FloorLoopStatus8(m_io);
            _recruitingEnabled = m_io.ReadU1();
            _field0x75a = m_io.ReadU1();
            _bagEnabled = m_io.ReadU1();
            _nonstoryFlag = m_io.ReadU1();
            _sendHomeDisabled = m_io.ReadU1();
            _hiddenLandFlag = m_io.ReadU1();
            _skipFaintAnimationFlag = m_io.ReadU1();
            _missionDestination = new MissionDestinationInfo(m_io);
            _bazaarMimeJrHeal = m_io.ReadU1();
            _field0x77f = m_io.ReadU1();
            _fractionalTurn = m_io.ReadU2le();
            _enemySpawnCounter = m_io.ReadU2le();
            _windTurns = m_io.ReadS2le();
            _enemyDensity = m_io.ReadU2le();
            _nextSpawnGenid = m_io.ReadU2le();
            _field0x78a = m_io.ReadU1();
            _leaderRunning = m_io.ReadU1();
            _preventMisinputs = m_io.ReadU1();
            _identifyOrbFlag = m_io.ReadU1();
            _passTurn = m_io.ReadU1();
            _droughtOrbFlag = m_io.ReadU1();
            _thiefAlert = m_io.ReadU1();
            _thiefAlertEvent = m_io.ReadU1();
            _unkMusicFlag = m_io.ReadU1();
            _monsterHouseTriggered = m_io.ReadU1();
            _monsterHouseTriggeredEvent = m_io.ReadU1();
            _field0x795 = m_io.ReadU1();
            _field0x796 = m_io.ReadU2le();
            _dungeonObjective = new DungeonObjective8(m_io);
            _leaderHungerMessageTracker = m_io.ReadU1();
            _turnLimitWarningTracker = m_io.ReadU1();
            _rescueAttemptsLeft = m_io.ReadS1();
            _prngSeed = m_io.ReadU4le();
            _rescuePrngPreseed23Bit = m_io.ReadU4le();
            _fixedRoomAction109Position = new Position(m_io);
            _someMonsterSpriteToLoad = new MonsterId16(m_io);
            _someMonsterLevel = m_io.ReadU1();
            _field0x7ab = m_io.ReadU1();
            _prngPreseed = m_io.ReadU4le();
            _field0x7b0 = m_io.ReadU1();
            _field0x7b1 = m_io.ReadU1();
            _field0x7b2 = m_io.ReadU1();
            _field0x7b3 = m_io.ReadU1();
            _field0x7b4 = m_io.ReadU1();
            _field0x7b5 = m_io.ReadU1();
            _field0x7b6 = m_io.ReadU1();
            _field0x7b7 = m_io.ReadU1();
            _field0x7b8 = m_io.ReadU1();
            _field0x7b9 = m_io.ReadU1();
            _field0x7ba = m_io.ReadU1();
            _field0x7bb = m_io.ReadU1();
            _pokeBuyKecleonShop = m_io.ReadU4le();
            _pokeSoldKecleonShop = m_io.ReadU4le();
            _unkPokeKecleonShopTracker = m_io.ReadU4le();
            _leaderStandingInKecleonShop = m_io.ReadU1();
            _standingInKecleonShop = m_io.ReadU1();
            _field0x7ca = m_io.ReadU1();
            _field0x7cb = m_io.ReadU1();
            _dungeonGameVersionId = new GameId(m_io);
            _field0x7d0 = m_io.ReadU1();
            _field0x7d1 = m_io.ReadU1();
            _field0x7d2 = m_io.ReadU1();
            _field0x7d3 = m_io.ReadU1();
            _field0x7d4 = m_io.ReadU1();
            _field0x7d5 = m_io.ReadU1();
            _field0x7d6 = m_io.ReadU1();
            _field0x7d7 = m_io.ReadU1();
            _field0x7d8 = m_io.ReadU1();
            _field0x7d9 = m_io.ReadU1();
            _field0x7da = m_io.ReadU1();
            _field0x7db = m_io.ReadU1();
            _field0x7dc = m_io.ReadU1();
            _field0x7dd = m_io.ReadU1();
            _field0x7de = m_io.ReadU1();
            _field0x7df = m_io.ReadU1();
            _field0x7e0 = m_io.ReadU1();
            _field0x7e1 = m_io.ReadU1();
            _field0x7e2 = m_io.ReadU1();
            _field0x7e3 = m_io.ReadU1();
            _field0x7e4 = m_io.ReadU1();
            _field0x7e5 = m_io.ReadU1();
            _field0x7e6 = m_io.ReadU1();
            _field0x7e7 = m_io.ReadU1();
            _field0x7e8 = m_io.ReadU1();
            _field0x7e9 = m_io.ReadU1();
            _field0x7ea = m_io.ReadU1();
            _field0x7eb = m_io.ReadU1();
            _field0x7ec = m_io.ReadU1();
            _field0x7ed = m_io.ReadU1();
            _field0x7ee = m_io.ReadU1();
            _field0x7ef = m_io.ReadU1();
            _numEntriesForField0x7d0 = m_io.ReadU2le();
            _someMonsterSprite = new MonsterId16(m_io);
            _monsters = new DungeonMonstersArray(m_io);
            _enemySpawnStats = new DungeonEnemySpawnStatsArray(m_io);
            _spawnEntries = new DungeonSpawnEntriesArray(m_io);
            _field0x39f4 = m_io.ReadU1();
            _field0x39f5 = m_io.ReadU1();
            _field0x39f6 = m_io.ReadU1();
            _field0x39f7 = m_io.ReadU1();
            _field0x39f8 = m_io.ReadU1();
            _field0x39f9 = m_io.ReadU1();
            _field0x39fa = m_io.ReadU1();
            _field0x39fb = m_io.ReadU1();
            _field0x39fc = m_io.ReadU1();
            _field0x39fd = m_io.ReadU1();
            _field0x39fe = m_io.ReadU1();
            _field0x39ff = m_io.ReadU1();
            _field0x3a00 = m_io.ReadU1();
            _field0x3a01 = m_io.ReadU1();
            _field0x3a02 = m_io.ReadU1();
            _field0x3a03 = m_io.ReadU1();
            _field0x3a04 = m_io.ReadU1();
            _field0x3a05 = m_io.ReadU1();
            _field0x3a06 = m_io.ReadU1();
            _field0x3a07 = m_io.ReadU1();
            _field0x3a08 = m_io.ReadU1();
            _field0x3a09 = m_io.ReadU1();
            _field0x3a0a = m_io.ReadU1();
            _field0x3a0b = m_io.ReadU1();
            _field0x3a0c = m_io.ReadU1();
            _field0x3a0d = m_io.ReadU1();
            _field0x3a0e = m_io.ReadU1();
            _field0x3a0f = m_io.ReadU1();
            _field0x3a10 = m_io.ReadU1();
            _field0x3a11 = m_io.ReadU1();
            _field0x3a12 = m_io.ReadU1();
            _field0x3a13 = m_io.ReadU1();
            _field0x3a14 = m_io.ReadU1();
            _field0x3a15 = m_io.ReadU1();
            _field0x3a16 = m_io.ReadU1();
            _field0x3a17 = m_io.ReadU1();
            _field0x3a18 = m_io.ReadU1();
            _field0x3a19 = m_io.ReadU1();
            _field0x3a1a = m_io.ReadU1();
            _field0x3a1b = m_io.ReadU1();
            _field0x3a1c = m_io.ReadU1();
            _field0x3a1d = m_io.ReadU1();
            _field0x3a1e = m_io.ReadU1();
            _field0x3a1f = m_io.ReadU1();
            _field0x3a20 = m_io.ReadU1();
            _field0x3a21 = m_io.ReadU1();
            _field0x3a22 = m_io.ReadU1();
            _field0x3a23 = m_io.ReadU1();
            _field0x3a24 = m_io.ReadU1();
            _field0x3a25 = m_io.ReadU1();
            _field0x3a26 = m_io.ReadU1();
            _field0x3a27 = m_io.ReadU1();
            _field0x3a28 = m_io.ReadU1();
            _field0x3a29 = m_io.ReadU1();
            _field0x3a2a = m_io.ReadU1();
            _field0x3a2b = m_io.ReadU1();
            _field0x3a2c = m_io.ReadU1();
            _field0x3a2d = m_io.ReadU1();
            _field0x3a2e = m_io.ReadU1();
            _field0x3a2f = m_io.ReadU1();
            _field0x3a30 = m_io.ReadU1();
            _field0x3a31 = m_io.ReadU1();
            _field0x3a32 = m_io.ReadU1();
            _field0x3a33 = m_io.ReadU1();
            _field0x3a34 = m_io.ReadU1();
            _field0x3a35 = m_io.ReadU1();
            _field0x3a36 = m_io.ReadU1();
            _field0x3a37 = m_io.ReadU1();
            _field0x3a38 = m_io.ReadU1();
            _field0x3a39 = m_io.ReadU1();
            _field0x3a3a = m_io.ReadU1();
            _field0x3a3b = m_io.ReadU1();
            _field0x3a3c = m_io.ReadU1();
            _field0x3a3d = m_io.ReadU1();
            _field0x3a3e = m_io.ReadU1();
            _field0x3a3f = m_io.ReadU1();
            _field0x3a40 = m_io.ReadU1();
            _field0x3a41 = m_io.ReadU1();
            _field0x3a42 = m_io.ReadU1();
            _field0x3a43 = m_io.ReadU1();
            _field0x3a44 = m_io.ReadU1();
            _field0x3a45 = m_io.ReadU1();
            _field0x3a46 = m_io.ReadU1();
            _field0x3a47 = m_io.ReadU1();
            _field0x3a48 = m_io.ReadU1();
            _field0x3a49 = m_io.ReadU1();
            _field0x3a4a = m_io.ReadU1();
            _field0x3a4b = m_io.ReadU1();
            _field0x3a4c = m_io.ReadU1();
            _field0x3a4d = m_io.ReadU1();
            _field0x3a4e = m_io.ReadU1();
            _field0x3a4f = m_io.ReadU1();
            _field0x3a50 = m_io.ReadU1();
            _field0x3a51 = m_io.ReadU1();
            _field0x3a52 = m_io.ReadU1();
            _field0x3a53 = m_io.ReadU1();
            _field0x3a54 = m_io.ReadU1();
            _field0x3a55 = m_io.ReadU1();
            _field0x3a56 = m_io.ReadU1();
            _field0x3a57 = m_io.ReadU1();
            _field0x3a58 = m_io.ReadU1();
            _field0x3a59 = m_io.ReadU1();
            _field0x3a5a = m_io.ReadU1();
            _field0x3a5b = m_io.ReadU1();
            _field0x3a5c = m_io.ReadU1();
            _field0x3a5d = m_io.ReadU1();
            _field0x3a5e = m_io.ReadU1();
            _field0x3a5f = m_io.ReadU1();
            _field0x3a60 = m_io.ReadU1();
            _field0x3a61 = m_io.ReadU1();
            _field0x3a62 = m_io.ReadU1();
            _field0x3a63 = m_io.ReadU1();
            _field0x3a64 = m_io.ReadU1();
            _field0x3a65 = m_io.ReadU1();
            _field0x3a66 = m_io.ReadU1();
            _field0x3a67 = m_io.ReadU1();
            _field0x3a68 = m_io.ReadU1();
            _field0x3a69 = m_io.ReadU1();
            _field0x3a6a = m_io.ReadU1();
            _field0x3a6b = m_io.ReadU1();
            _field0x3a6c = m_io.ReadU1();
            _field0x3a6d = m_io.ReadU1();
            _field0x3a6e = m_io.ReadU1();
            _field0x3a6f = m_io.ReadU1();
            _field0x3a70 = m_io.ReadU1();
            _field0x3a71 = m_io.ReadU1();
            _field0x3a72 = m_io.ReadU1();
            _field0x3a73 = m_io.ReadU1();
            _field0x3a74 = m_io.ReadU1();
            _field0x3a75 = m_io.ReadU1();
            _field0x3a76 = m_io.ReadU1();
            _field0x3a77 = m_io.ReadU1();
            _field0x3a78 = m_io.ReadU1();
            _field0x3a79 = m_io.ReadU1();
            _field0x3a7a = m_io.ReadU1();
            _field0x3a7b = m_io.ReadU1();
            _field0x3a7c = m_io.ReadU1();
            _field0x3a7d = m_io.ReadU1();
            _field0x3a7e = m_io.ReadU1();
            _field0x3a7f = m_io.ReadU1();
            _field0x3a80 = m_io.ReadU1();
            _field0x3a81 = m_io.ReadU1();
            _field0x3a82 = m_io.ReadU1();
            _field0x3a83 = m_io.ReadU1();
            _field0x3a84 = m_io.ReadU1();
            _field0x3a85 = m_io.ReadU1();
            _field0x3a86 = m_io.ReadU1();
            _field0x3a87 = m_io.ReadU1();
            _field0x3a88 = m_io.ReadU1();
            _field0x3a89 = m_io.ReadU1();
            _field0x3a8a = m_io.ReadU1();
            _field0x3a8b = m_io.ReadU1();
            _field0x3a8c = m_io.ReadU1();
            _field0x3a8d = m_io.ReadU1();
            _field0x3a8e = m_io.ReadU1();
            _field0x3a8f = m_io.ReadU1();
            _field0x3a90 = m_io.ReadU1();
            _field0x3a91 = m_io.ReadU1();
            _field0x3a92 = m_io.ReadU1();
            _field0x3a93 = m_io.ReadU1();
            _field0x3a94 = m_io.ReadU1();
            _field0x3a95 = m_io.ReadU1();
            _field0x3a96 = m_io.ReadU1();
            _field0x3a97 = m_io.ReadU1();
            _field0x3a98 = m_io.ReadU1();
            _field0x3a99 = m_io.ReadU1();
            _field0x3a9a = m_io.ReadU1();
            _field0x3a9b = m_io.ReadU1();
            _field0x3a9c = m_io.ReadU1();
            _field0x3a9d = m_io.ReadU1();
            _field0x3a9e = m_io.ReadU1();
            _field0x3a9f = m_io.ReadU1();
            _field0x3aa0 = m_io.ReadU1();
            _field0x3aa1 = m_io.ReadU1();
            _field0x3aa2 = m_io.ReadU1();
            _field0x3aa3 = m_io.ReadU1();
            _field0x3aa4 = m_io.ReadU1();
            _field0x3aa5 = m_io.ReadU1();
            _field0x3aa6 = m_io.ReadU1();
            _field0x3aa7 = m_io.ReadU1();
            _field0x3aa8 = m_io.ReadU1();
            _field0x3aa9 = m_io.ReadU1();
            _field0x3aaa = m_io.ReadU1();
            _field0x3aab = m_io.ReadU1();
            _field0x3aac = m_io.ReadU1();
            _field0x3aad = m_io.ReadU1();
            _field0x3aae = m_io.ReadU1();
            _field0x3aaf = m_io.ReadU1();
            _field0x3ab0 = m_io.ReadU1();
            _field0x3ab1 = m_io.ReadU1();
            _field0x3ab2 = m_io.ReadU1();
            _field0x3ab3 = m_io.ReadU1();
            _field0x3ab4 = m_io.ReadU1();
            _field0x3ab5 = m_io.ReadU1();
            _field0x3ab6 = m_io.ReadU1();
            _field0x3ab7 = m_io.ReadU1();
            _field0x3ab8 = m_io.ReadU1();
            _field0x3ab9 = m_io.ReadU1();
            _field0x3aba = m_io.ReadU1();
            _field0x3abb = m_io.ReadU1();
            _field0x3abc = m_io.ReadU1();
            _field0x3abd = m_io.ReadU1();
            _field0x3abe = m_io.ReadU1();
            _field0x3abf = m_io.ReadU1();
            _field0x3ac0 = m_io.ReadU1();
            _field0x3ac1 = m_io.ReadU1();
            _field0x3ac2 = m_io.ReadU1();
            _field0x3ac3 = m_io.ReadU1();
            _field0x3ac4 = m_io.ReadU1();
            _field0x3ac5 = m_io.ReadU1();
            _field0x3ac6 = m_io.ReadU1();
            _field0x3ac7 = m_io.ReadU1();
            _field0x3ac8 = m_io.ReadU1();
            _field0x3ac9 = m_io.ReadU1();
            _field0x3aca = m_io.ReadU1();
            _field0x3acb = m_io.ReadU1();
            _field0x3acc = m_io.ReadU1();
            _field0x3acd = m_io.ReadU1();
            _field0x3ace = m_io.ReadU1();
            _field0x3acf = m_io.ReadU1();
            _field0x3ad0 = m_io.ReadU1();
            _field0x3ad1 = m_io.ReadU1();
            _field0x3ad2 = m_io.ReadU1();
            _field0x3ad3 = m_io.ReadU1();
            _field0x3ad4 = m_io.ReadU1();
            _field0x3ad5 = m_io.ReadU1();
            _field0x3ad6 = m_io.ReadU1();
            _field0x3ad7 = m_io.ReadU1();
            _field0x3ad8 = m_io.ReadU1();
            _field0x3ad9 = m_io.ReadU1();
            _field0x3ada = m_io.ReadU1();
            _field0x3adb = m_io.ReadU1();
            _field0x3adc = m_io.ReadU1();
            _field0x3add = m_io.ReadU1();
            _field0x3ade = m_io.ReadU1();
            _field0x3adf = m_io.ReadU1();
            _field0x3ae0 = m_io.ReadU1();
            _field0x3ae1 = m_io.ReadU1();
            _field0x3ae2 = m_io.ReadU1();
            _field0x3ae3 = m_io.ReadU1();
            _field0x3ae4 = m_io.ReadU1();
            _field0x3ae5 = m_io.ReadU1();
            _field0x3ae6 = m_io.ReadU1();
            _field0x3ae7 = m_io.ReadU1();
            _field0x3ae8 = m_io.ReadU1();
            _field0x3ae9 = m_io.ReadU1();
            _field0x3aea = m_io.ReadU1();
            _field0x3aeb = m_io.ReadU1();
            _field0x3aec = m_io.ReadU1();
            _field0x3aed = m_io.ReadU1();
            _field0x3aee = m_io.ReadU1();
            _field0x3aef = m_io.ReadU1();
            _field0x3af0 = m_io.ReadU1();
            _field0x3af1 = m_io.ReadU1();
            _field0x3af2 = m_io.ReadU1();
            _field0x3af3 = m_io.ReadU1();
            _field0x3af4 = m_io.ReadU1();
            _field0x3af5 = m_io.ReadU1();
            _field0x3af6 = m_io.ReadU1();
            _field0x3af7 = m_io.ReadU1();
            _field0x3af8 = m_io.ReadU1();
            _field0x3af9 = m_io.ReadU1();
            _field0x3afa = m_io.ReadU1();
            _field0x3afb = m_io.ReadU1();
            _field0x3afc = m_io.ReadU1();
            _field0x3afd = m_io.ReadU1();
            _field0x3afe = m_io.ReadU1();
            _field0x3aff = m_io.ReadU1();
            _field0x3b00 = m_io.ReadU1();
            _field0x3b01 = m_io.ReadU1();
            _field0x3b02 = m_io.ReadU1();
            _field0x3b03 = m_io.ReadU1();
            _field0x3b04 = m_io.ReadU1();
            _field0x3b05 = m_io.ReadU1();
            _field0x3b06 = m_io.ReadU1();
            _field0x3b07 = m_io.ReadU1();
            _field0x3b08 = m_io.ReadU1();
            _field0x3b09 = m_io.ReadU1();
            _field0x3b0a = m_io.ReadU1();
            _field0x3b0b = m_io.ReadU1();
            _field0x3b0c = m_io.ReadU1();
            _field0x3b0d = m_io.ReadU1();
            _field0x3b0e = m_io.ReadU1();
            _field0x3b0f = m_io.ReadU1();
            _field0x3b10 = m_io.ReadU1();
            _field0x3b11 = m_io.ReadU1();
            _field0x3b12 = m_io.ReadU1();
            _field0x3b13 = m_io.ReadU1();
            _field0x3b14 = m_io.ReadU1();
            _field0x3b15 = m_io.ReadU1();
            _field0x3b16 = m_io.ReadU1();
            _field0x3b17 = m_io.ReadU1();
            _field0x3b18 = m_io.ReadU1();
            _field0x3b19 = m_io.ReadU1();
            _field0x3b1a = m_io.ReadU1();
            _field0x3b1b = m_io.ReadU1();
            _field0x3b1c = m_io.ReadU1();
            _field0x3b1d = m_io.ReadU1();
            _field0x3b1e = m_io.ReadU1();
            _field0x3b1f = m_io.ReadU1();
            _field0x3b20 = m_io.ReadU1();
            _field0x3b21 = m_io.ReadU1();
            _field0x3b22 = m_io.ReadU1();
            _field0x3b23 = m_io.ReadU1();
            _field0x3b24 = m_io.ReadU1();
            _field0x3b25 = m_io.ReadU1();
            _field0x3b26 = m_io.ReadU1();
            _field0x3b27 = m_io.ReadU1();
            _field0x3b28 = m_io.ReadU1();
            _field0x3b29 = m_io.ReadU1();
            _field0x3b2a = m_io.ReadU1();
            _field0x3b2b = m_io.ReadU1();
            _field0x3b2c = m_io.ReadU1();
            _field0x3b2d = m_io.ReadU1();
            _field0x3b2e = m_io.ReadU1();
            _field0x3b2f = m_io.ReadU1();
            _field0x3b30 = m_io.ReadU1();
            _field0x3b31 = m_io.ReadU1();
            _field0x3b32 = m_io.ReadU1();
            _field0x3b33 = m_io.ReadU1();
            _field0x3b34 = m_io.ReadU1();
            _field0x3b35 = m_io.ReadU1();
            _field0x3b36 = m_io.ReadU1();
            _field0x3b37 = m_io.ReadU1();
            _field0x3b38 = m_io.ReadU1();
            _field0x3b39 = m_io.ReadU1();
            _field0x3b3a = m_io.ReadU1();
            _field0x3b3b = m_io.ReadU1();
            _field0x3b3c = m_io.ReadU1();
            _field0x3b3d = m_io.ReadU1();
            _field0x3b3e = m_io.ReadU1();
            _field0x3b3f = m_io.ReadU1();
            _field0x3b40 = m_io.ReadU1();
            _field0x3b41 = m_io.ReadU1();
            _field0x3b42 = m_io.ReadU1();
            _field0x3b43 = m_io.ReadU1();
            _field0x3b44 = m_io.ReadU1();
            _field0x3b45 = m_io.ReadU1();
            _field0x3b46 = m_io.ReadU1();
            _field0x3b47 = m_io.ReadU1();
            _field0x3b48 = m_io.ReadU1();
            _field0x3b49 = m_io.ReadU1();
            _field0x3b4a = m_io.ReadU1();
            _field0x3b4b = m_io.ReadU1();
            _field0x3b4c = m_io.ReadU1();
            _field0x3b4d = m_io.ReadU1();
            _field0x3b4e = m_io.ReadU1();
            _field0x3b4f = m_io.ReadU1();
            _field0x3b50 = m_io.ReadU1();
            _field0x3b51 = m_io.ReadU1();
            _field0x3b52 = m_io.ReadU1();
            _field0x3b53 = m_io.ReadU1();
            _field0x3b54 = m_io.ReadU1();
            _field0x3b55 = m_io.ReadU1();
            _field0x3b56 = m_io.ReadU1();
            _field0x3b57 = m_io.ReadU1();
            _field0x3b58 = m_io.ReadU1();
            _field0x3b59 = m_io.ReadU1();
            _field0x3b5a = m_io.ReadU1();
            _field0x3b5b = m_io.ReadU1();
            _field0x3b5c = m_io.ReadU1();
            _field0x3b5d = m_io.ReadU1();
            _field0x3b5e = m_io.ReadU1();
            _field0x3b5f = m_io.ReadU1();
            _field0x3b60 = m_io.ReadU1();
            _field0x3b61 = m_io.ReadU1();
            _field0x3b62 = m_io.ReadU1();
            _field0x3b63 = m_io.ReadU1();
            _field0x3b64 = m_io.ReadU1();
            _field0x3b65 = m_io.ReadU1();
            _field0x3b66 = m_io.ReadU1();
            _field0x3b67 = m_io.ReadU1();
            _field0x3b68 = m_io.ReadU1();
            _field0x3b69 = m_io.ReadU1();
            _field0x3b6a = m_io.ReadU1();
            _field0x3b6b = m_io.ReadU1();
            _field0x3b6c = m_io.ReadU1();
            _field0x3b6d = m_io.ReadU1();
            _field0x3b6e = m_io.ReadU1();
            _field0x3b6f = m_io.ReadU1();
            _field0x3b70 = m_io.ReadU1();
            _field0x3b71 = m_io.ReadU1();
            _field0x3b72 = m_io.ReadU1();
            _field0x3b73 = m_io.ReadU1();
            _unknownArray0x3b74 = new DungeonUnknownArray0x3b74Array(m_io);
            _monsterUniqueId = new DungeonMonsterUniqueIdArray(m_io);
            _uniqueIdIndex = m_io.ReadU4le();
            _monsterSpawnEntriesLength = m_io.ReadS4le();
            _field0x3e24 = m_io.ReadU1();
            _field0x3e25 = m_io.ReadU1();
            _field0x3e26 = m_io.ReadU1();
            _field0x3e27 = m_io.ReadU1();
            _unkSpawnEntryIdCheck = m_io.ReadU1();
            _field0x3e29 = m_io.ReadU1();
            _field0x3e2a = m_io.ReadU1();
            _field0x3e2b = m_io.ReadU1();
            _monsterUniqueIdCounter = m_io.ReadU4le();
            _monsterUniqueWrapCounter = m_io.ReadU4le();
            _plusIsActive = new DungeonPlusIsActiveArray(m_io);
            _minusIsActive = new DungeonMinusIsActiveArray(m_io);
            _decoyIsActive = m_io.ReadU1();
            _mewCannotSpawn = m_io.ReadU1();
            _deoxysFloorId = new MonsterId16(m_io);
            _shayminSkyFormLoaded = m_io.ReadU1();
            _field0x3e3d = m_io.ReadU1();
            _field0x3e3e = m_io.ReadU1();
            _field0x3e3f = m_io.ReadU1();
            _items = new DungeonItemsArray(m_io);
            _nItems = m_io.ReadU2le();
            _nFixedRoomItems = m_io.ReadS2le();
            _traps = new DungeonTrapsArray(m_io);
            _genInfo = new DungeonGenerationInfo(m_io);
            _field0xccfc = m_io.ReadU1();
            _field0xccfd = m_io.ReadU1();
            _field0xccfe = m_io.ReadU1();
            _field0xccff = m_io.ReadU1();
            _field0xcd00 = m_io.ReadU1();
            _field0xcd01 = m_io.ReadU1();
            _field0xcd02 = m_io.ReadU1();
            _field0xcd03 = m_io.ReadU1();
            _field0xcd04 = m_io.ReadU1();
            _field0xcd05 = m_io.ReadU1();
            _field0xcd06 = m_io.ReadU1();
            _field0xcd07 = m_io.ReadU1();
            _field0xcd08 = m_io.ReadU1();
            _field0xcd09 = m_io.ReadU1();
            _field0xcd0a = m_io.ReadU1();
            _field0xcd0b = m_io.ReadU1();
            _unkTeamDirectionArray = new DungeonUnkTeamDirectionArrayArray(m_io);
            _kecleonShopMinX = m_io.ReadS4le();
            _kecleonShopMinY = m_io.ReadS4le();
            _kecleonShopMaxX = m_io.ReadS4le();
            _kecleonShopMaxY = m_io.ReadS4le();
            _fixedRoomMinX = m_io.ReadS4le();
            _fixedRoomMinY = m_io.ReadS4le();
            _fixedRoomMaxX = m_io.ReadS4le();
            _fixedRoomMaxY = m_io.ReadS4le();
            _fixedRoomWidth = m_io.ReadU2le();
            _fixedRoomHeight = m_io.ReadU2le();
            _weather = new WeatherId8(m_io);
            _naturalWeather = new WeatherId8(m_io);
            _weatherTurns = new DungeonWeatherTurnsArray(m_io);
            _artificialPermaweatherTurns = new DungeonArtificialPermaweatherTurnsArray(m_io);
            _weatherDamageCounter = m_io.ReadU1();
            _mudSportTurns = m_io.ReadU1();
            _waterSportTurns = m_io.ReadU1();
            _nullifyWeather = m_io.ReadU1();
            _field0xcd5e = m_io.ReadU1();
            _field0xcd5f = m_io.ReadU1();
            _fixedRoomTiles = new DungeonFixedRoomTilesArray(m_io);
            _field0xd260 = m_io.ReadU1();
            _field0xd261 = m_io.ReadU1();
            _field0xd262 = m_io.ReadU1();
            _field0xd263 = m_io.ReadU1();
            _field0xd264 = m_io.ReadU1();
            _field0xd265 = m_io.ReadU1();
            _field0xd266 = m_io.ReadU1();
            _field0xd267 = m_io.ReadU1();
            _field0xd268 = m_io.ReadU1();
            _field0xd269 = m_io.ReadU1();
            _field0xd26a = m_io.ReadU1();
            _field0xd26b = m_io.ReadU1();
            _field0xd26c = m_io.ReadU1();
            _field0xd26d = m_io.ReadU1();
            _field0xd26e = m_io.ReadU1();
            _field0xd26f = m_io.ReadU1();
            _field0xd270 = m_io.ReadU1();
            _field0xd271 = m_io.ReadU1();
            _field0xd272 = m_io.ReadU1();
            _field0xd273 = m_io.ReadU1();
            _field0xd274 = m_io.ReadU1();
            _field0xd275 = m_io.ReadU1();
            _field0xd276 = m_io.ReadU1();
            _field0xd277 = m_io.ReadU1();
            _field0xd278 = m_io.ReadU1();
            _field0xd279 = m_io.ReadU1();
            _field0xd27a = m_io.ReadU1();
            _field0xd27b = m_io.ReadU1();
            _field0xd27c = m_io.ReadU1();
            _field0xd27d = m_io.ReadU1();
            _field0xd27e = m_io.ReadU1();
            _field0xd27f = m_io.ReadU1();
            _field0xd280 = m_io.ReadU1();
            _field0xd281 = m_io.ReadU1();
            _field0xd282 = m_io.ReadU1();
            _field0xd283 = m_io.ReadU1();
            _field0xd284 = m_io.ReadU1();
            _field0xd285 = m_io.ReadU1();
            _field0xd286 = m_io.ReadU1();
            _field0xd287 = m_io.ReadU1();
            _field0xd288 = m_io.ReadU1();
            _field0xd289 = m_io.ReadU1();
            _field0xd28a = m_io.ReadU1();
            _field0xd28b = m_io.ReadU1();
            _field0xd28c = m_io.ReadU1();
            _field0xd28d = m_io.ReadU1();
            _field0xd28e = m_io.ReadU1();
            _field0xd28f = m_io.ReadU1();
            _field0xd290 = m_io.ReadU1();
            _field0xd291 = m_io.ReadU1();
            _field0xd292 = m_io.ReadU1();
            _field0xd293 = m_io.ReadU1();
            _field0xd294 = m_io.ReadU1();
            _field0xd295 = m_io.ReadU1();
            _field0xd296 = m_io.ReadU1();
            _field0xd297 = m_io.ReadU1();
            _field0xd298 = m_io.ReadU1();
            _field0xd299 = m_io.ReadU1();
            _field0xd29a = m_io.ReadU1();
            _field0xd29b = m_io.ReadU1();
            _field0xd29c = m_io.ReadU1();
            _field0xd29d = m_io.ReadU1();
            _field0xd29e = m_io.ReadU1();
            _field0xd29f = m_io.ReadU1();
            _field0xd2a0 = m_io.ReadU1();
            _field0xd2a1 = m_io.ReadU1();
            _field0xd2a2 = m_io.ReadU1();
            _field0xd2a3 = m_io.ReadU1();
            _field0xd2a4 = m_io.ReadU1();
            _field0xd2a5 = m_io.ReadU1();
            _field0xd2a6 = m_io.ReadU1();
            _field0xd2a7 = m_io.ReadU1();
            _field0xd2a8 = m_io.ReadU1();
            _field0xd2a9 = m_io.ReadU1();
            _field0xd2aa = m_io.ReadU1();
            _field0xd2ab = m_io.ReadU1();
            _field0xd2ac = m_io.ReadU1();
            _field0xd2ad = m_io.ReadU1();
            _field0xd2ae = m_io.ReadU1();
            _field0xd2af = m_io.ReadU1();
            _field0xd2b0 = m_io.ReadU1();
            _field0xd2b1 = m_io.ReadU1();
            _field0xd2b2 = m_io.ReadU1();
            _field0xd2b3 = m_io.ReadU1();
            _field0xd2b4 = m_io.ReadU1();
            _field0xd2b5 = m_io.ReadU1();
            _field0xd2b6 = m_io.ReadU1();
            _field0xd2b7 = m_io.ReadU1();
            _field0xd2b8 = m_io.ReadU1();
            _field0xd2b9 = m_io.ReadU1();
            _field0xd2ba = m_io.ReadU1();
            _field0xd2bb = m_io.ReadU1();
            _field0xd2bc = m_io.ReadU1();
            _field0xd2bd = m_io.ReadU1();
            _field0xd2be = m_io.ReadU1();
            _field0xd2bf = m_io.ReadU1();
            _field0xd2c0 = m_io.ReadU1();
            _field0xd2c1 = m_io.ReadU1();
            _field0xd2c2 = m_io.ReadU1();
            _field0xd2c3 = m_io.ReadU1();
            _field0xd2c4 = m_io.ReadU1();
            _field0xd2c5 = m_io.ReadU1();
            _field0xd2c6 = m_io.ReadU1();
            _field0xd2c7 = m_io.ReadU1();
            _field0xd2c8 = m_io.ReadU1();
            _field0xd2c9 = m_io.ReadU1();
            _field0xd2ca = m_io.ReadU1();
            _field0xd2cb = m_io.ReadU1();
            _field0xd2cc = m_io.ReadU1();
            _field0xd2cd = m_io.ReadU1();
            _field0xd2ce = m_io.ReadU1();
            _field0xd2cf = m_io.ReadU1();
            _field0xd2d0 = m_io.ReadU1();
            _field0xd2d1 = m_io.ReadU1();
            _field0xd2d2 = m_io.ReadU1();
            _field0xd2d3 = m_io.ReadU1();
            _field0xd2d4 = m_io.ReadU1();
            _field0xd2d5 = m_io.ReadU1();
            _field0xd2d6 = m_io.ReadU1();
            _field0xd2d7 = m_io.ReadU1();
            _field0xd2d8 = m_io.ReadU1();
            _field0xd2d9 = m_io.ReadU1();
            _field0xd2da = m_io.ReadU1();
            _field0xd2db = m_io.ReadU1();
            _field0xd2dc = m_io.ReadU1();
            _field0xd2dd = m_io.ReadU1();
            _field0xd2de = m_io.ReadU1();
            _field0xd2df = m_io.ReadU1();
            _fixedRoomRoomIndex = m_io.ReadU1();
            _field0xd2e1 = m_io.ReadU1();
            _field0xd2e2 = m_io.ReadU1();
            _field0xd2e3 = m_io.ReadU1();
            _tilePtrs = new DungeonTilePtrsArray(m_io);
            _nRooms = m_io.ReadU1();
            _field0xeee5 = m_io.ReadU1();
            _field0xeee6 = m_io.ReadU1();
            _field0xeee7 = m_io.ReadU1();
            _roomData = new DungeonRoomDataArray(m_io);
            _naturalJunctionListCounts = new DungeonNaturalJunctionListCountsArray(m_io);
            _naturalJunctionList = new DungeonNaturalJunctionListArray(m_io);
            _unknownFileBuffer0x102a8 = new DungeonUnknownFileBuffer0x102a8Array(m_io);
            _unknownTileMatrix = new DungeonUnknownTileMatrixArray(m_io);
            _unknownMatrix0x1212c = new DungeonUnknownMatrix0x1212cArray(m_io);
            _unknownFileBuffer0x12162 = new DungeonUnknownFileBuffer0x12162Array(m_io);
            _unknownArray0x12a92 = new DungeonUnknownArray0x12a92Array(m_io);
            _unkFixedRoomPointer = new Pointer(m_io);
            _trapperOrbFlag = m_io.ReadU1();
            _field0x12aa9 = m_io.ReadU1();
            _trapperOrbTrapPos = new Position(m_io);
            _trapperOrbTrapId = new TrapId8(m_io);
            _trapperOrbTrapTeam = m_io.ReadU1();
            _field0x12ab0 = m_io.ReadU1();
            _field0x12ab1 = m_io.ReadU1();
            _field0x12ab2 = m_io.ReadU1();
            _field0x12ab3 = m_io.ReadU1();
            _field0x12ab4 = m_io.ReadU1();
            _field0x12ab5 = m_io.ReadU1();
            _field0x12ab6 = m_io.ReadU1();
            _field0x12ab7 = m_io.ReadU1();
            _field0x12ab8 = m_io.ReadU1();
            _field0x12ab9 = m_io.ReadU1();
            _field0x12aba = m_io.ReadU1();
            _field0x12abb = m_io.ReadU1();
            _field0x12abc = m_io.ReadU1();
            _field0x12abd = m_io.ReadU1();
            _field0x12abe = m_io.ReadU1();
            _field0x12abf = m_io.ReadU1();
            _field0x12ac0 = m_io.ReadU1();
            _field0x12ac1 = m_io.ReadU1();
            _field0x12ac2 = m_io.ReadU1();
            _field0x12ac3 = m_io.ReadU1();
            _field0x12ac4 = m_io.ReadU1();
            _field0x12ac5 = m_io.ReadU1();
            _field0x12ac6 = m_io.ReadU1();
            _field0x12ac7 = m_io.ReadU1();
            _field0x12ac8 = m_io.ReadU1();
            _field0x12ac9 = m_io.ReadU1();
            _field0x12aca = m_io.ReadU1();
            _field0x12acb = m_io.ReadU1();
            _field0x12acc = m_io.ReadU1();
            _field0x12acd = m_io.ReadU1();
            _field0x12ace = m_io.ReadU1();
            _field0x12acf = m_io.ReadU1();
            _field0x12ad0 = m_io.ReadU1();
            _field0x12ad1 = m_io.ReadU1();
            _field0x12ad2 = m_io.ReadU1();
            _field0x12ad3 = m_io.ReadU1();
            _field0x12ad4 = m_io.ReadU1();
            _field0x12ad5 = m_io.ReadU1();
            _field0x12ad6 = m_io.ReadU1();
            _field0x12ad7 = m_io.ReadU1();
            _field0x12ad8 = m_io.ReadU1();
            _field0x12ad9 = m_io.ReadU1();
            _field0x12ada = m_io.ReadU1();
            _field0x12adb = m_io.ReadU1();
            _field0x12adc = m_io.ReadU1();
            _field0x12add = m_io.ReadU1();
            _field0x12ade = m_io.ReadU1();
            _field0x12adf = m_io.ReadU1();
            _field0x12ae0 = m_io.ReadU1();
            _field0x12ae1 = m_io.ReadU1();
            _field0x12ae2 = m_io.ReadU1();
            _field0x12ae3 = m_io.ReadU1();
            _field0x12ae4 = m_io.ReadU1();
            _field0x12ae5 = m_io.ReadU1();
            _field0x12ae6 = m_io.ReadU1();
            _field0x12ae7 = m_io.ReadU1();
            _field0x12ae8 = m_io.ReadU1();
            _field0x12ae9 = m_io.ReadU1();
            _field0x12aea = m_io.ReadU1();
            _field0x12aeb = m_io.ReadU1();
            _field0x12aec = m_io.ReadU1();
            _field0x12aed = m_io.ReadU1();
            _field0x12aee = m_io.ReadU1();
            _field0x12aef = m_io.ReadU1();
            _field0x12af0 = m_io.ReadU1();
            _field0x12af1 = m_io.ReadU1();
            _field0x12af2 = m_io.ReadU1();
            _field0x12af3 = m_io.ReadU1();
            _field0x12af4 = m_io.ReadU1();
            _field0x12af5 = m_io.ReadU1();
            _field0x12af6 = m_io.ReadU1();
            _field0x12af7 = m_io.ReadU1();
            _acuteSnifferItemCount = m_io.ReadU2le();
            _nNormalItemSpawns = m_io.ReadU2le();
            _gravity = m_io.ReadU1();
            _field0x12afd = m_io.ReadU1();
            _victoryCounter = m_io.ReadS2le();
            _field0x12b00 = m_io.ReadU1();
            _field0x12b01 = m_io.ReadU1();
            _field0x12b02 = m_io.ReadU1();
            _field0x12b03 = m_io.ReadU1();
            _field0x12b04 = m_io.ReadU1();
            _field0x12b05 = m_io.ReadU1();
            _field0x12b06 = m_io.ReadU1();
            _field0x12b07 = m_io.ReadU1();
            _field0x12b08 = m_io.ReadU1();
            _field0x12b09 = m_io.ReadU1();
            _field0x12b0a = m_io.ReadU1();
            _field0x12b0b = m_io.ReadU1();
            _field0x12b0c = m_io.ReadU1();
            _field0x12b0d = m_io.ReadU1();
            _field0x12b0e = m_io.ReadU1();
            _field0x12b0f = m_io.ReadU1();
            _field0x12b10 = m_io.ReadU1();
            _field0x12b11 = m_io.ReadU1();
            _field0x12b12 = m_io.ReadU1();
            _field0x12b13 = m_io.ReadU1();
            _field0x12b14 = m_io.ReadU1();
            _field0x12b15 = m_io.ReadU1();
            _field0x12b16 = m_io.ReadU1();
            _field0x12b17 = m_io.ReadU1();
            _field0x12b18 = m_io.ReadU1();
            _field0x12b19 = m_io.ReadU1();
            _field0x12b1a = m_io.ReadU1();
            _field0x12b1b = m_io.ReadU1();
            _field0x12b1c = m_io.ReadU1();
            _field0x12b1d = m_io.ReadU1();
            _field0x12b1e = m_io.ReadU1();
            _field0x12b1f = m_io.ReadU1();
            _fixedRoomMonsterSpriteCounter = m_io.ReadU4le();
            _boostKecleonShopSpawnChance = m_io.ReadU1();
            _boostHiddenStairsSpawnChance = m_io.ReadU1();
            _field0x12b26 = m_io.ReadU1();
            _field0x12b27 = m_io.ReadU1();
            _entityTable = new EntityTable(m_io);
            _unkAllyMonster1 = new Pointer(m_io);
            _unkAllyMonsterUniqueId1 = m_io.ReadU4le();
            _unkAllyMonster2 = new Pointer(m_io);
            _unkAllyMonsterUniqueId2 = m_io.ReadU4le();
            _unkEnemyMonster1 = new Pointer(m_io);
            _unkEnemyMonsterUniqueId1 = m_io.ReadU4le();
            _unkEnemyMonster2 = new Pointer(m_io);
            _unkEnemyMonsterUniqueId2 = m_io.ReadU4le();
            _snatchMonster = new Pointer(m_io);
            _illuminateSpawnEntity = new Pointer(m_io);
            _snatchStatusUniqueId = m_io.ReadU4le();
            _illuminateSpawnGenid = m_io.ReadU2le();
            _field0x19912 = m_io.ReadU1();
            _field0x19913 = m_io.ReadU1();
            _spriteIndexes = new DungeonSpriteIndexesArray(m_io);
            _field0x1a21a = m_io.ReadU1();
            _field0x1a21b = m_io.ReadU1();
            _displayData = new DisplayData(m_io);
            _minimapDisplayData = new MinimapDisplayData(m_io);
            _groupAndGroupFloorIdCopy = new DungeonGroupAndGroupFloor(m_io);
            _floorProperties = new FloorProperties(m_io);
            _field0x286d2 = m_io.ReadU2le();
            _field0x286d4 = m_io.ReadU2le();
            _field0x286d6 = m_io.ReadU2le();
            _field0x286d8 = m_io.ReadU2le();
            _field0x286da = m_io.ReadU2le();
            _field0x286dc = m_io.ReadU2le();
            _field0x286de = m_io.ReadU2le();
            _field0x286e0 = m_io.ReadU2le();
            _field0x286e2 = m_io.ReadU2le();
            _field0x286e4 = m_io.ReadU2le();
            _field0x286e6 = m_io.ReadU2le();
            _field0x286e8 = m_io.ReadU2le();
            _field0x286ea = m_io.ReadU2le();
            _field0x286ec = m_io.ReadU2le();
            _field0x286ee = m_io.ReadU2le();
            _field0x286f0 = m_io.ReadU2le();
            _regularItemWeights = new DungeonRegularItemWeightsArray(m_io);
            _kecleonItemWeights = new DungeonKecleonItemWeightsArray(m_io);
            _monsterHouseItemWeights = new DungeonMonsterHouseItemWeightsArray(m_io);
            _buriedItemWeights = new DungeonBuriedItemWeightsArray(m_io);
            _grabBagItemWeights = new DungeonGrabBagItemWeightsArray(m_io);
            _secretRoomItemWeights = new DungeonSecretRoomItemWeightsArray(m_io);
            _trapWeights = new DungeonTrapWeightsArray(m_io);
            _spawnEntriesMaster = new DungeonSpawnEntriesMasterArray(m_io);
            _numberSpritesLoaded = m_io.ReadU2le();
            _highestEnemyLevel = m_io.ReadU2le();
            _guaranteedItemId = new ItemId16(m_io);
            _spawnTableEntriesChosen = new DungeonSpawnTableEntriesChosenArray(m_io);
            _field0x2ca0a = m_io.ReadU1();
            _field0x2ca0b = m_io.ReadU1();
            _faintedMonsterCauseEntityName = new DungeonFaintedMonsterCauseEntityNameArray(m_io);
            _faintedMonsterName = new DungeonFaintedMonsterNameArray(m_io);
            _fallenEscortMonsterName = new DungeonFallenEscortMonsterNameArray(m_io);
            _faintedMonsterDungeonEndReason = new DamageSource16(m_io);
            _faintedId = new DungeonId8(m_io);
            _faintedFloor = m_io.ReadU1();
            _faintedMonsterHeldItem = new Item(m_io);
            _faintedMonsterExp = m_io.ReadS4le();
            _faintedMonsterMaxHp = m_io.ReadS2le();
            _faintedMonsterOffensiveStats = new DungeonFaintedMonsterOffensiveStatsArray(m_io);
            _faintedMonsterDefensiveStats = new DungeonFaintedMonsterDefensiveStatsArray(m_io);
            _faintedMonsterLevel = m_io.ReadU1();
            _field0x2ca7b = m_io.ReadU1();
            _getoutMonsterSummary = new MonsterSummary(m_io);
            _nFloorsPlusOne = m_io.ReadU1();
            _field0x2caf5 = m_io.ReadU1();
            _field0x2caf6 = m_io.ReadU1();
            _field0x2caf7 = m_io.ReadU1();
            _field0x2caf8 = m_io.ReadU4le();
            _field0x2cafc = m_io.ReadU4le();
            _field0x2cb00 = m_io.ReadU2le();
            _field0x2cb02 = m_io.ReadU2le();
            _field0x2cb04 = m_io.ReadU2le();
            _dungeonMusicPlayingId = new MusicId16(m_io);
            _field0x2cb08 = m_io.ReadU1();
            _field0x2cb09 = m_io.ReadU1();
            _field0x2cb0a = m_io.ReadU1();
            _field0x2cb0b = m_io.ReadU1();
            _field0x2cb0c = m_io.ReadU1();
            _field0x2cb0d = m_io.ReadU1();
            _field0x2cb0e = m_io.ReadU1();
            _field0x2cb0f = m_io.ReadU1();
            _unkCameraTracker = m_io.ReadU1();
            _field0x2cb11 = m_io.ReadU1();
            _field0x2cb12 = m_io.ReadU1();
            _field0x2cb13 = m_io.ReadU1();
        }
        private byte _field0x0;
        private byte _targetEnemyDefeatedMessage;
        private byte _hiddenOutlawDefeatedMessage;
        private byte _targetMonsterNotFoundFlag;
        private byte _field0x4;
        private byte _steppedOnStairs;
        private byte _endFloorFlag;
        private byte _quicksaveFlag;
        private byte _endFloorNoDeathCheckFlag;
        private byte _field0x9;
        private byte _field0xa;
        private byte _field0xb;
        private byte _missionDeliverItemCheck;
        private byte _field0xd;
        private byte _activateArtificialWeatherFlag;
        private byte _shouldEnemyEvolve;
        private byte _swappingPlaces;
        private byte _noActionInProgress;
        private byte _iqDisabled;
        private byte _regularAttackRevealTraps;
        private ForcedLossReason _forcedLossReason;
        private uint _successfulExitTracker;
        private short _cameraFrameCounter;
        private byte _numberCompletedFloors;
        private byte _speedBoostCounter;
        private ushort _numberPrecedingFloors;
        private ushort _totalFloorsCompleted;
        private byte _field0x24;
        private byte _field0x25;
        private byte _field0x26;
        private byte _field0x27;
        private byte _field0x28;
        private byte _field0x29;
        private byte _field0x2a;
        private byte _field0x2b;
        private byte _field0x2c;
        private byte _field0x2d;
        private byte _field0x2e;
        private byte _field0x2f;
        private byte _field0x30;
        private byte _field0x31;
        private byte _field0x32;
        private byte _field0x33;
        private byte _field0x34;
        private byte _field0x35;
        private byte _field0x36;
        private byte _field0x37;
        private byte _field0x38;
        private byte _field0x39;
        private byte _field0x3a;
        private byte _field0x3b;
        private byte _field0x3c;
        private byte _field0x3d;
        private byte _field0x3e;
        private byte _field0x3f;
        private byte _field0x40;
        private byte _field0x41;
        private byte _field0x42;
        private byte _field0x43;
        private byte _field0x44;
        private byte _field0x45;
        private byte _field0x46;
        private byte _field0x47;
        private byte _field0x48;
        private byte _field0x49;
        private byte _field0x4a;
        private byte _field0x4b;
        private byte _field0x4c;
        private byte _field0x4d;
        private byte _field0x4e;
        private byte _field0x4f;
        private byte _field0x50;
        private byte _field0x51;
        private byte _field0x52;
        private byte _field0x53;
        private byte _field0x54;
        private byte _field0x55;
        private byte _field0x56;
        private byte _field0x57;
        private byte _field0x58;
        private byte _field0x59;
        private byte _field0x5a;
        private byte _field0x5b;
        private byte _field0x5c;
        private byte _field0x5d;
        private byte _field0x5e;
        private byte _field0x5f;
        private byte _field0x60;
        private byte _field0x61;
        private byte _field0x62;
        private byte _field0x63;
        private byte _field0x64;
        private byte _field0x65;
        private byte _field0x66;
        private byte _field0x67;
        private byte _field0x68;
        private byte _field0x69;
        private byte _field0x6a;
        private byte _field0x6b;
        private byte _field0x6c;
        private byte _field0x6d;
        private byte _field0x6e;
        private byte _field0x6f;
        private byte _field0x70;
        private byte _field0x71;
        private byte _field0x72;
        private byte _field0x73;
        private byte _field0x74;
        private byte _field0x75;
        private byte _field0x76;
        private byte _field0x77;
        private byte _field0x78;
        private byte _field0x79;
        private byte _field0x7a;
        private byte _field0x7b;
        private byte _field0x7c;
        private byte _field0x7d;
        private byte _field0x7e;
        private byte _field0x7f;
        private byte _field0x80;
        private byte _field0x81;
        private byte _field0x82;
        private byte _field0x83;
        private byte _field0x84;
        private byte _field0x85;
        private byte _field0x86;
        private byte _field0x87;
        private byte _field0x88;
        private byte _field0x89;
        private byte _field0x8a;
        private byte _field0x8b;
        private byte _field0x8c;
        private byte _field0x8d;
        private byte _field0x8e;
        private byte _field0x8f;
        private byte _field0x90;
        private byte _field0x91;
        private byte _field0x92;
        private byte _field0x93;
        private byte _field0x94;
        private byte _field0x95;
        private byte _field0x96;
        private byte _field0x97;
        private byte _field0x98;
        private byte _field0x99;
        private byte _field0x9a;
        private byte _field0x9b;
        private byte _field0x9c;
        private byte _field0x9d;
        private byte _field0x9e;
        private byte _field0x9f;
        private byte _field0xa0;
        private byte _field0xa1;
        private byte _field0xa2;
        private byte _field0xa3;
        private byte _field0xa4;
        private byte _field0xa5;
        private byte _field0xa6;
        private byte _field0xa7;
        private byte _field0xa8;
        private byte _field0xa9;
        private byte _field0xaa;
        private byte _field0xab;
        private byte _field0xac;
        private byte _field0xad;
        private byte _field0xae;
        private byte _field0xaf;
        private byte _field0xb0;
        private byte _field0xb1;
        private byte _field0xb2;
        private byte _field0xb3;
        private byte _field0xb4;
        private byte _field0xb5;
        private byte _field0xb6;
        private byte _field0xb7;
        private byte _field0xb8;
        private byte _field0xb9;
        private byte _field0xba;
        private byte _field0xbb;
        private byte _field0xbc;
        private byte _field0xbd;
        private byte _field0xbe;
        private byte _field0xbf;
        private byte _field0xc0;
        private byte _field0xc1;
        private byte _field0xc2;
        private byte _field0xc3;
        private Pointer _currentActiveEntity;
        private Pointer _newLeader;
        private Entity _thrownItem;
        private DamageCalcDiag _lastDamageCalc;
        private Position _touchscreenTargetPosition;
        private Position _unknownLeaderPosition;
        private DungeonColorTableArray _colorTable;
        private DungeonShopkeeperSpawnsArray _shopkeeperSpawns;
        private int _shopkeeperSpawnCount;
        private int _field0x614;
        private uint _unk1Animation1Value;
        private uint _unk2Animation1Value;
        private uint _unk3Animation1Value;
        private Pointer _animation1Entity;
        private uint _unk1Animation2Value;
        private uint _unk2Animation2Value;
        private uint _unk3Animation2Value;
        private Pointer _animation2Entity;
        private uint _unk1Animation3Value;
        private uint _unk2Animation3Value;
        private uint _unk3Animation3Value;
        private Pointer _animation3Entity;
        private DungeonFallenAllyMonsterNameArray _fallenAllyMonsterName;
        private byte _field0x652;
        private byte _field0x653;
        private byte _field0x654;
        private byte _field0x655;
        private byte _field0x656;
        private byte _field0x657;
        private byte _field0x658;
        private byte _field0x659;
        private byte _field0x65a;
        private byte _field0x65b;
        private byte _field0x65c;
        private byte _field0x65d;
        private byte _field0x65e;
        private byte _field0x65f;
        private byte _field0x660;
        private byte _field0x661;
        private byte _field0x662;
        private byte _field0x663;
        private byte _field0x664;
        private byte _field0x665;
        private byte _field0x666;
        private byte _field0x667;
        private byte _field0x668;
        private byte _field0x669;
        private byte _field0x66a;
        private byte _field0x66b;
        private byte _field0x66c;
        private byte _field0x66d;
        private byte _field0x66e;
        private byte _field0x66f;
        private byte _field0x670;
        private byte _field0x671;
        private byte _field0x672;
        private byte _field0x673;
        private byte _field0x674;
        private byte _field0x675;
        private byte _field0x676;
        private byte _field0x677;
        private byte _field0x678;
        private byte _field0x679;
        private byte _field0x67a;
        private byte _field0x67b;
        private byte _field0x67c;
        private byte _field0x67d;
        private byte _field0x67e;
        private byte _field0x67f;
        private byte _field0x680;
        private byte _field0x681;
        private byte _field0x682;
        private byte _field0x683;
        private byte _field0x684;
        private byte _field0x685;
        private byte _field0x686;
        private byte _field0x687;
        private byte _field0x688;
        private byte _field0x689;
        private byte _field0x68a;
        private byte _field0x68b;
        private byte _field0x68c;
        private byte _field0x68d;
        private byte _field0x68e;
        private byte _field0x68f;
        private byte _field0x690;
        private byte _field0x691;
        private byte _field0x692;
        private byte _field0x693;
        private byte _field0x694;
        private byte _field0x695;
        private byte _field0x696;
        private byte _field0x697;
        private byte _field0x698;
        private byte _field0x699;
        private byte _field0x69a;
        private byte _field0x69b;
        private byte _field0x69c;
        private byte _field0x69d;
        private byte _field0x69e;
        private byte _field0x69f;
        private byte _field0x6a0;
        private byte _field0x6a1;
        private byte _field0x6a2;
        private byte _field0x6a3;
        private byte _field0x6a4;
        private byte _field0x6a5;
        private byte _field0x6a6;
        private byte _field0x6a7;
        private byte _field0x6a8;
        private byte _field0x6a9;
        private byte _field0x6aa;
        private byte _field0x6ab;
        private byte _field0x6ac;
        private byte _field0x6ad;
        private byte _field0x6ae;
        private byte _field0x6af;
        private byte _field0x6b0;
        private byte _field0x6b1;
        private byte _field0x6b2;
        private byte _field0x6b3;
        private byte _field0x6b4;
        private byte _field0x6b5;
        private byte _field0x6b6;
        private byte _field0x6b7;
        private byte _field0x6b8;
        private byte _field0x6b9;
        private byte _field0x6ba;
        private byte _field0x6bb;
        private byte _field0x6bc;
        private byte _field0x6bd;
        private byte _field0x6be;
        private byte _field0x6bf;
        private byte _field0x6c0;
        private byte _field0x6c1;
        private byte _field0x6c2;
        private byte _field0x6c3;
        private byte _field0x6c4;
        private byte _field0x6c5;
        private byte _field0x6c6;
        private byte _field0x6c7;
        private byte _field0x6c8;
        private byte _field0x6c9;
        private byte _field0x6ca;
        private byte _field0x6cb;
        private byte _field0x6cc;
        private byte _field0x6cd;
        private byte _field0x6ce;
        private byte _field0x6cf;
        private byte _field0x6d0;
        private byte _field0x6d1;
        private byte _field0x6d2;
        private byte _field0x6d3;
        private byte _field0x6d4;
        private byte _field0x6d5;
        private byte _field0x6d6;
        private byte _field0x6d7;
        private byte _field0x6d8;
        private byte _field0x6d9;
        private byte _field0x6da;
        private byte _field0x6db;
        private byte _field0x6dc;
        private byte _field0x6dd;
        private byte _field0x6de;
        private byte _field0x6df;
        private byte _field0x6e0;
        private byte _field0x6e1;
        private byte _field0x6e2;
        private byte _field0x6e3;
        private byte _field0x6e4;
        private byte _field0x6e5;
        private byte _field0x6e6;
        private byte _field0x6e7;
        private byte _field0x6e8;
        private byte _field0x6e9;
        private byte _field0x6ea;
        private byte _field0x6eb;
        private byte _field0x6ec;
        private byte _field0x6ed;
        private byte _field0x6ee;
        private byte _field0x6ef;
        private byte _field0x6f0;
        private byte _field0x6f1;
        private byte _field0x6f2;
        private byte _field0x6f3;
        private byte _field0x6f4;
        private byte _field0x6f5;
        private byte _field0x6f6;
        private byte _field0x6f7;
        private byte _field0x6f8;
        private byte _field0x6f9;
        private byte _field0x6fa;
        private byte _field0x6fb;
        private byte _field0x6fc;
        private byte _field0x6fd;
        private byte _field0x6fe;
        private byte _field0x6ff;
        private byte _field0x700;
        private byte _field0x701;
        private byte _field0x702;
        private byte _field0x703;
        private byte _field0x704;
        private byte _field0x705;
        private byte _field0x706;
        private byte _field0x707;
        private byte _field0x708;
        private byte _field0x709;
        private byte _field0x70a;
        private byte _field0x70b;
        private byte _field0x70c;
        private byte _field0x70d;
        private byte _field0x70e;
        private byte _field0x70f;
        private byte _field0x710;
        private byte _field0x711;
        private byte _field0x712;
        private byte _field0x713;
        private byte _field0x714;
        private byte _field0x715;
        private byte _field0x716;
        private byte _field0x717;
        private byte _field0x718;
        private byte _field0x719;
        private byte _field0x71a;
        private byte _field0x71b;
        private byte _field0x71c;
        private byte _field0x71d;
        private byte _field0x71e;
        private byte _field0x71f;
        private byte _field0x720;
        private byte _field0x721;
        private byte _field0x722;
        private byte _field0x723;
        private byte _field0x724;
        private byte _field0x725;
        private byte _field0x726;
        private byte _field0x727;
        private byte _field0x728;
        private byte _field0x729;
        private byte _field0x72a;
        private byte _field0x72b;
        private byte _field0x72c;
        private byte _field0x72d;
        private byte _field0x72e;
        private byte _field0x72f;
        private byte _field0x730;
        private byte _field0x731;
        private byte _field0x732;
        private byte _field0x733;
        private byte _field0x734;
        private byte _field0x735;
        private byte _field0x736;
        private byte _field0x737;
        private byte _field0x738;
        private byte _field0x739;
        private byte _field0x73a;
        private byte _field0x73b;
        private byte _field0x73c;
        private byte _field0x73d;
        private byte _field0x73e;
        private byte _field0x73f;
        private byte _field0x740;
        private byte _field0x741;
        private byte _field0x742;
        private byte _field0x743;
        private byte _field0x744;
        private byte _field0x745;
        private byte _field0x746;
        private byte _field0x747;
        private DungeonId8 _id;
        private byte _floor;
        private DungeonGroupAndGroupFloor _groupAndGroupFloorId;
        private ushort _field0x74c;
        private byte _field0x74e;
        private byte _field0x74f;
        private byte _field0x750;
        private byte _rescueFloor;
        private byte _field0x752;
        private byte _field0x753;
        private uint _prngPreseed23Bit;
        private FloorLoopStatus8 _floorLoopStatus;
        private byte _recruitingEnabled;
        private byte _field0x75a;
        private byte _bagEnabled;
        private byte _nonstoryFlag;
        private byte _sendHomeDisabled;
        private byte _hiddenLandFlag;
        private byte _skipFaintAnimationFlag;
        private MissionDestinationInfo _missionDestination;
        private byte _bazaarMimeJrHeal;
        private byte _field0x77f;
        private ushort _fractionalTurn;
        private ushort _enemySpawnCounter;
        private short _windTurns;
        private ushort _enemyDensity;
        private ushort _nextSpawnGenid;
        private byte _field0x78a;
        private byte _leaderRunning;
        private byte _preventMisinputs;
        private byte _identifyOrbFlag;
        private byte _passTurn;
        private byte _droughtOrbFlag;
        private byte _thiefAlert;
        private byte _thiefAlertEvent;
        private byte _unkMusicFlag;
        private byte _monsterHouseTriggered;
        private byte _monsterHouseTriggeredEvent;
        private byte _field0x795;
        private ushort _field0x796;
        private DungeonObjective8 _dungeonObjective;
        private byte _leaderHungerMessageTracker;
        private byte _turnLimitWarningTracker;
        private sbyte _rescueAttemptsLeft;
        private uint _prngSeed;
        private uint _rescuePrngPreseed23Bit;
        private Position _fixedRoomAction109Position;
        private MonsterId16 _someMonsterSpriteToLoad;
        private byte _someMonsterLevel;
        private byte _field0x7ab;
        private uint _prngPreseed;
        private byte _field0x7b0;
        private byte _field0x7b1;
        private byte _field0x7b2;
        private byte _field0x7b3;
        private byte _field0x7b4;
        private byte _field0x7b5;
        private byte _field0x7b6;
        private byte _field0x7b7;
        private byte _field0x7b8;
        private byte _field0x7b9;
        private byte _field0x7ba;
        private byte _field0x7bb;
        private uint _pokeBuyKecleonShop;
        private uint _pokeSoldKecleonShop;
        private uint _unkPokeKecleonShopTracker;
        private byte _leaderStandingInKecleonShop;
        private byte _standingInKecleonShop;
        private byte _field0x7ca;
        private byte _field0x7cb;
        private GameId _dungeonGameVersionId;
        private byte _field0x7d0;
        private byte _field0x7d1;
        private byte _field0x7d2;
        private byte _field0x7d3;
        private byte _field0x7d4;
        private byte _field0x7d5;
        private byte _field0x7d6;
        private byte _field0x7d7;
        private byte _field0x7d8;
        private byte _field0x7d9;
        private byte _field0x7da;
        private byte _field0x7db;
        private byte _field0x7dc;
        private byte _field0x7dd;
        private byte _field0x7de;
        private byte _field0x7df;
        private byte _field0x7e0;
        private byte _field0x7e1;
        private byte _field0x7e2;
        private byte _field0x7e3;
        private byte _field0x7e4;
        private byte _field0x7e5;
        private byte _field0x7e6;
        private byte _field0x7e7;
        private byte _field0x7e8;
        private byte _field0x7e9;
        private byte _field0x7ea;
        private byte _field0x7eb;
        private byte _field0x7ec;
        private byte _field0x7ed;
        private byte _field0x7ee;
        private byte _field0x7ef;
        private ushort _numEntriesForField0x7d0;
        private MonsterId16 _someMonsterSprite;
        private DungeonMonstersArray _monsters;
        private DungeonEnemySpawnStatsArray _enemySpawnStats;
        private DungeonSpawnEntriesArray _spawnEntries;
        private byte _field0x39f4;
        private byte _field0x39f5;
        private byte _field0x39f6;
        private byte _field0x39f7;
        private byte _field0x39f8;
        private byte _field0x39f9;
        private byte _field0x39fa;
        private byte _field0x39fb;
        private byte _field0x39fc;
        private byte _field0x39fd;
        private byte _field0x39fe;
        private byte _field0x39ff;
        private byte _field0x3a00;
        private byte _field0x3a01;
        private byte _field0x3a02;
        private byte _field0x3a03;
        private byte _field0x3a04;
        private byte _field0x3a05;
        private byte _field0x3a06;
        private byte _field0x3a07;
        private byte _field0x3a08;
        private byte _field0x3a09;
        private byte _field0x3a0a;
        private byte _field0x3a0b;
        private byte _field0x3a0c;
        private byte _field0x3a0d;
        private byte _field0x3a0e;
        private byte _field0x3a0f;
        private byte _field0x3a10;
        private byte _field0x3a11;
        private byte _field0x3a12;
        private byte _field0x3a13;
        private byte _field0x3a14;
        private byte _field0x3a15;
        private byte _field0x3a16;
        private byte _field0x3a17;
        private byte _field0x3a18;
        private byte _field0x3a19;
        private byte _field0x3a1a;
        private byte _field0x3a1b;
        private byte _field0x3a1c;
        private byte _field0x3a1d;
        private byte _field0x3a1e;
        private byte _field0x3a1f;
        private byte _field0x3a20;
        private byte _field0x3a21;
        private byte _field0x3a22;
        private byte _field0x3a23;
        private byte _field0x3a24;
        private byte _field0x3a25;
        private byte _field0x3a26;
        private byte _field0x3a27;
        private byte _field0x3a28;
        private byte _field0x3a29;
        private byte _field0x3a2a;
        private byte _field0x3a2b;
        private byte _field0x3a2c;
        private byte _field0x3a2d;
        private byte _field0x3a2e;
        private byte _field0x3a2f;
        private byte _field0x3a30;
        private byte _field0x3a31;
        private byte _field0x3a32;
        private byte _field0x3a33;
        private byte _field0x3a34;
        private byte _field0x3a35;
        private byte _field0x3a36;
        private byte _field0x3a37;
        private byte _field0x3a38;
        private byte _field0x3a39;
        private byte _field0x3a3a;
        private byte _field0x3a3b;
        private byte _field0x3a3c;
        private byte _field0x3a3d;
        private byte _field0x3a3e;
        private byte _field0x3a3f;
        private byte _field0x3a40;
        private byte _field0x3a41;
        private byte _field0x3a42;
        private byte _field0x3a43;
        private byte _field0x3a44;
        private byte _field0x3a45;
        private byte _field0x3a46;
        private byte _field0x3a47;
        private byte _field0x3a48;
        private byte _field0x3a49;
        private byte _field0x3a4a;
        private byte _field0x3a4b;
        private byte _field0x3a4c;
        private byte _field0x3a4d;
        private byte _field0x3a4e;
        private byte _field0x3a4f;
        private byte _field0x3a50;
        private byte _field0x3a51;
        private byte _field0x3a52;
        private byte _field0x3a53;
        private byte _field0x3a54;
        private byte _field0x3a55;
        private byte _field0x3a56;
        private byte _field0x3a57;
        private byte _field0x3a58;
        private byte _field0x3a59;
        private byte _field0x3a5a;
        private byte _field0x3a5b;
        private byte _field0x3a5c;
        private byte _field0x3a5d;
        private byte _field0x3a5e;
        private byte _field0x3a5f;
        private byte _field0x3a60;
        private byte _field0x3a61;
        private byte _field0x3a62;
        private byte _field0x3a63;
        private byte _field0x3a64;
        private byte _field0x3a65;
        private byte _field0x3a66;
        private byte _field0x3a67;
        private byte _field0x3a68;
        private byte _field0x3a69;
        private byte _field0x3a6a;
        private byte _field0x3a6b;
        private byte _field0x3a6c;
        private byte _field0x3a6d;
        private byte _field0x3a6e;
        private byte _field0x3a6f;
        private byte _field0x3a70;
        private byte _field0x3a71;
        private byte _field0x3a72;
        private byte _field0x3a73;
        private byte _field0x3a74;
        private byte _field0x3a75;
        private byte _field0x3a76;
        private byte _field0x3a77;
        private byte _field0x3a78;
        private byte _field0x3a79;
        private byte _field0x3a7a;
        private byte _field0x3a7b;
        private byte _field0x3a7c;
        private byte _field0x3a7d;
        private byte _field0x3a7e;
        private byte _field0x3a7f;
        private byte _field0x3a80;
        private byte _field0x3a81;
        private byte _field0x3a82;
        private byte _field0x3a83;
        private byte _field0x3a84;
        private byte _field0x3a85;
        private byte _field0x3a86;
        private byte _field0x3a87;
        private byte _field0x3a88;
        private byte _field0x3a89;
        private byte _field0x3a8a;
        private byte _field0x3a8b;
        private byte _field0x3a8c;
        private byte _field0x3a8d;
        private byte _field0x3a8e;
        private byte _field0x3a8f;
        private byte _field0x3a90;
        private byte _field0x3a91;
        private byte _field0x3a92;
        private byte _field0x3a93;
        private byte _field0x3a94;
        private byte _field0x3a95;
        private byte _field0x3a96;
        private byte _field0x3a97;
        private byte _field0x3a98;
        private byte _field0x3a99;
        private byte _field0x3a9a;
        private byte _field0x3a9b;
        private byte _field0x3a9c;
        private byte _field0x3a9d;
        private byte _field0x3a9e;
        private byte _field0x3a9f;
        private byte _field0x3aa0;
        private byte _field0x3aa1;
        private byte _field0x3aa2;
        private byte _field0x3aa3;
        private byte _field0x3aa4;
        private byte _field0x3aa5;
        private byte _field0x3aa6;
        private byte _field0x3aa7;
        private byte _field0x3aa8;
        private byte _field0x3aa9;
        private byte _field0x3aaa;
        private byte _field0x3aab;
        private byte _field0x3aac;
        private byte _field0x3aad;
        private byte _field0x3aae;
        private byte _field0x3aaf;
        private byte _field0x3ab0;
        private byte _field0x3ab1;
        private byte _field0x3ab2;
        private byte _field0x3ab3;
        private byte _field0x3ab4;
        private byte _field0x3ab5;
        private byte _field0x3ab6;
        private byte _field0x3ab7;
        private byte _field0x3ab8;
        private byte _field0x3ab9;
        private byte _field0x3aba;
        private byte _field0x3abb;
        private byte _field0x3abc;
        private byte _field0x3abd;
        private byte _field0x3abe;
        private byte _field0x3abf;
        private byte _field0x3ac0;
        private byte _field0x3ac1;
        private byte _field0x3ac2;
        private byte _field0x3ac3;
        private byte _field0x3ac4;
        private byte _field0x3ac5;
        private byte _field0x3ac6;
        private byte _field0x3ac7;
        private byte _field0x3ac8;
        private byte _field0x3ac9;
        private byte _field0x3aca;
        private byte _field0x3acb;
        private byte _field0x3acc;
        private byte _field0x3acd;
        private byte _field0x3ace;
        private byte _field0x3acf;
        private byte _field0x3ad0;
        private byte _field0x3ad1;
        private byte _field0x3ad2;
        private byte _field0x3ad3;
        private byte _field0x3ad4;
        private byte _field0x3ad5;
        private byte _field0x3ad6;
        private byte _field0x3ad7;
        private byte _field0x3ad8;
        private byte _field0x3ad9;
        private byte _field0x3ada;
        private byte _field0x3adb;
        private byte _field0x3adc;
        private byte _field0x3add;
        private byte _field0x3ade;
        private byte _field0x3adf;
        private byte _field0x3ae0;
        private byte _field0x3ae1;
        private byte _field0x3ae2;
        private byte _field0x3ae3;
        private byte _field0x3ae4;
        private byte _field0x3ae5;
        private byte _field0x3ae6;
        private byte _field0x3ae7;
        private byte _field0x3ae8;
        private byte _field0x3ae9;
        private byte _field0x3aea;
        private byte _field0x3aeb;
        private byte _field0x3aec;
        private byte _field0x3aed;
        private byte _field0x3aee;
        private byte _field0x3aef;
        private byte _field0x3af0;
        private byte _field0x3af1;
        private byte _field0x3af2;
        private byte _field0x3af3;
        private byte _field0x3af4;
        private byte _field0x3af5;
        private byte _field0x3af6;
        private byte _field0x3af7;
        private byte _field0x3af8;
        private byte _field0x3af9;
        private byte _field0x3afa;
        private byte _field0x3afb;
        private byte _field0x3afc;
        private byte _field0x3afd;
        private byte _field0x3afe;
        private byte _field0x3aff;
        private byte _field0x3b00;
        private byte _field0x3b01;
        private byte _field0x3b02;
        private byte _field0x3b03;
        private byte _field0x3b04;
        private byte _field0x3b05;
        private byte _field0x3b06;
        private byte _field0x3b07;
        private byte _field0x3b08;
        private byte _field0x3b09;
        private byte _field0x3b0a;
        private byte _field0x3b0b;
        private byte _field0x3b0c;
        private byte _field0x3b0d;
        private byte _field0x3b0e;
        private byte _field0x3b0f;
        private byte _field0x3b10;
        private byte _field0x3b11;
        private byte _field0x3b12;
        private byte _field0x3b13;
        private byte _field0x3b14;
        private byte _field0x3b15;
        private byte _field0x3b16;
        private byte _field0x3b17;
        private byte _field0x3b18;
        private byte _field0x3b19;
        private byte _field0x3b1a;
        private byte _field0x3b1b;
        private byte _field0x3b1c;
        private byte _field0x3b1d;
        private byte _field0x3b1e;
        private byte _field0x3b1f;
        private byte _field0x3b20;
        private byte _field0x3b21;
        private byte _field0x3b22;
        private byte _field0x3b23;
        private byte _field0x3b24;
        private byte _field0x3b25;
        private byte _field0x3b26;
        private byte _field0x3b27;
        private byte _field0x3b28;
        private byte _field0x3b29;
        private byte _field0x3b2a;
        private byte _field0x3b2b;
        private byte _field0x3b2c;
        private byte _field0x3b2d;
        private byte _field0x3b2e;
        private byte _field0x3b2f;
        private byte _field0x3b30;
        private byte _field0x3b31;
        private byte _field0x3b32;
        private byte _field0x3b33;
        private byte _field0x3b34;
        private byte _field0x3b35;
        private byte _field0x3b36;
        private byte _field0x3b37;
        private byte _field0x3b38;
        private byte _field0x3b39;
        private byte _field0x3b3a;
        private byte _field0x3b3b;
        private byte _field0x3b3c;
        private byte _field0x3b3d;
        private byte _field0x3b3e;
        private byte _field0x3b3f;
        private byte _field0x3b40;
        private byte _field0x3b41;
        private byte _field0x3b42;
        private byte _field0x3b43;
        private byte _field0x3b44;
        private byte _field0x3b45;
        private byte _field0x3b46;
        private byte _field0x3b47;
        private byte _field0x3b48;
        private byte _field0x3b49;
        private byte _field0x3b4a;
        private byte _field0x3b4b;
        private byte _field0x3b4c;
        private byte _field0x3b4d;
        private byte _field0x3b4e;
        private byte _field0x3b4f;
        private byte _field0x3b50;
        private byte _field0x3b51;
        private byte _field0x3b52;
        private byte _field0x3b53;
        private byte _field0x3b54;
        private byte _field0x3b55;
        private byte _field0x3b56;
        private byte _field0x3b57;
        private byte _field0x3b58;
        private byte _field0x3b59;
        private byte _field0x3b5a;
        private byte _field0x3b5b;
        private byte _field0x3b5c;
        private byte _field0x3b5d;
        private byte _field0x3b5e;
        private byte _field0x3b5f;
        private byte _field0x3b60;
        private byte _field0x3b61;
        private byte _field0x3b62;
        private byte _field0x3b63;
        private byte _field0x3b64;
        private byte _field0x3b65;
        private byte _field0x3b66;
        private byte _field0x3b67;
        private byte _field0x3b68;
        private byte _field0x3b69;
        private byte _field0x3b6a;
        private byte _field0x3b6b;
        private byte _field0x3b6c;
        private byte _field0x3b6d;
        private byte _field0x3b6e;
        private byte _field0x3b6f;
        private byte _field0x3b70;
        private byte _field0x3b71;
        private byte _field0x3b72;
        private byte _field0x3b73;
        private DungeonUnknownArray0x3b74Array _unknownArray0x3b74;
        private DungeonMonsterUniqueIdArray _monsterUniqueId;
        private uint _uniqueIdIndex;
        private int _monsterSpawnEntriesLength;
        private byte _field0x3e24;
        private byte _field0x3e25;
        private byte _field0x3e26;
        private byte _field0x3e27;
        private byte _unkSpawnEntryIdCheck;
        private byte _field0x3e29;
        private byte _field0x3e2a;
        private byte _field0x3e2b;
        private uint _monsterUniqueIdCounter;
        private uint _monsterUniqueWrapCounter;
        private DungeonPlusIsActiveArray _plusIsActive;
        private DungeonMinusIsActiveArray _minusIsActive;
        private byte _decoyIsActive;
        private byte _mewCannotSpawn;
        private MonsterId16 _deoxysFloorId;
        private byte _shayminSkyFormLoaded;
        private byte _field0x3e3d;
        private byte _field0x3e3e;
        private byte _field0x3e3f;
        private DungeonItemsArray _items;
        private ushort _nItems;
        private short _nFixedRoomItems;
        private DungeonTrapsArray _traps;
        private DungeonGenerationInfo _genInfo;
        private byte _field0xccfc;
        private byte _field0xccfd;
        private byte _field0xccfe;
        private byte _field0xccff;
        private byte _field0xcd00;
        private byte _field0xcd01;
        private byte _field0xcd02;
        private byte _field0xcd03;
        private byte _field0xcd04;
        private byte _field0xcd05;
        private byte _field0xcd06;
        private byte _field0xcd07;
        private byte _field0xcd08;
        private byte _field0xcd09;
        private byte _field0xcd0a;
        private byte _field0xcd0b;
        private DungeonUnkTeamDirectionArrayArray _unkTeamDirectionArray;
        private int _kecleonShopMinX;
        private int _kecleonShopMinY;
        private int _kecleonShopMaxX;
        private int _kecleonShopMaxY;
        private int _fixedRoomMinX;
        private int _fixedRoomMinY;
        private int _fixedRoomMaxX;
        private int _fixedRoomMaxY;
        private ushort _fixedRoomWidth;
        private ushort _fixedRoomHeight;
        private WeatherId8 _weather;
        private WeatherId8 _naturalWeather;
        private DungeonWeatherTurnsArray _weatherTurns;
        private DungeonArtificialPermaweatherTurnsArray _artificialPermaweatherTurns;
        private byte _weatherDamageCounter;
        private byte _mudSportTurns;
        private byte _waterSportTurns;
        private byte _nullifyWeather;
        private byte _field0xcd5e;
        private byte _field0xcd5f;
        private DungeonFixedRoomTilesArray _fixedRoomTiles;
        private byte _field0xd260;
        private byte _field0xd261;
        private byte _field0xd262;
        private byte _field0xd263;
        private byte _field0xd264;
        private byte _field0xd265;
        private byte _field0xd266;
        private byte _field0xd267;
        private byte _field0xd268;
        private byte _field0xd269;
        private byte _field0xd26a;
        private byte _field0xd26b;
        private byte _field0xd26c;
        private byte _field0xd26d;
        private byte _field0xd26e;
        private byte _field0xd26f;
        private byte _field0xd270;
        private byte _field0xd271;
        private byte _field0xd272;
        private byte _field0xd273;
        private byte _field0xd274;
        private byte _field0xd275;
        private byte _field0xd276;
        private byte _field0xd277;
        private byte _field0xd278;
        private byte _field0xd279;
        private byte _field0xd27a;
        private byte _field0xd27b;
        private byte _field0xd27c;
        private byte _field0xd27d;
        private byte _field0xd27e;
        private byte _field0xd27f;
        private byte _field0xd280;
        private byte _field0xd281;
        private byte _field0xd282;
        private byte _field0xd283;
        private byte _field0xd284;
        private byte _field0xd285;
        private byte _field0xd286;
        private byte _field0xd287;
        private byte _field0xd288;
        private byte _field0xd289;
        private byte _field0xd28a;
        private byte _field0xd28b;
        private byte _field0xd28c;
        private byte _field0xd28d;
        private byte _field0xd28e;
        private byte _field0xd28f;
        private byte _field0xd290;
        private byte _field0xd291;
        private byte _field0xd292;
        private byte _field0xd293;
        private byte _field0xd294;
        private byte _field0xd295;
        private byte _field0xd296;
        private byte _field0xd297;
        private byte _field0xd298;
        private byte _field0xd299;
        private byte _field0xd29a;
        private byte _field0xd29b;
        private byte _field0xd29c;
        private byte _field0xd29d;
        private byte _field0xd29e;
        private byte _field0xd29f;
        private byte _field0xd2a0;
        private byte _field0xd2a1;
        private byte _field0xd2a2;
        private byte _field0xd2a3;
        private byte _field0xd2a4;
        private byte _field0xd2a5;
        private byte _field0xd2a6;
        private byte _field0xd2a7;
        private byte _field0xd2a8;
        private byte _field0xd2a9;
        private byte _field0xd2aa;
        private byte _field0xd2ab;
        private byte _field0xd2ac;
        private byte _field0xd2ad;
        private byte _field0xd2ae;
        private byte _field0xd2af;
        private byte _field0xd2b0;
        private byte _field0xd2b1;
        private byte _field0xd2b2;
        private byte _field0xd2b3;
        private byte _field0xd2b4;
        private byte _field0xd2b5;
        private byte _field0xd2b6;
        private byte _field0xd2b7;
        private byte _field0xd2b8;
        private byte _field0xd2b9;
        private byte _field0xd2ba;
        private byte _field0xd2bb;
        private byte _field0xd2bc;
        private byte _field0xd2bd;
        private byte _field0xd2be;
        private byte _field0xd2bf;
        private byte _field0xd2c0;
        private byte _field0xd2c1;
        private byte _field0xd2c2;
        private byte _field0xd2c3;
        private byte _field0xd2c4;
        private byte _field0xd2c5;
        private byte _field0xd2c6;
        private byte _field0xd2c7;
        private byte _field0xd2c8;
        private byte _field0xd2c9;
        private byte _field0xd2ca;
        private byte _field0xd2cb;
        private byte _field0xd2cc;
        private byte _field0xd2cd;
        private byte _field0xd2ce;
        private byte _field0xd2cf;
        private byte _field0xd2d0;
        private byte _field0xd2d1;
        private byte _field0xd2d2;
        private byte _field0xd2d3;
        private byte _field0xd2d4;
        private byte _field0xd2d5;
        private byte _field0xd2d6;
        private byte _field0xd2d7;
        private byte _field0xd2d8;
        private byte _field0xd2d9;
        private byte _field0xd2da;
        private byte _field0xd2db;
        private byte _field0xd2dc;
        private byte _field0xd2dd;
        private byte _field0xd2de;
        private byte _field0xd2df;
        private byte _fixedRoomRoomIndex;
        private byte _field0xd2e1;
        private byte _field0xd2e2;
        private byte _field0xd2e3;
        private DungeonTilePtrsArray _tilePtrs;
        private byte _nRooms;
        private byte _field0xeee5;
        private byte _field0xeee6;
        private byte _field0xeee7;
        private DungeonRoomDataArray _roomData;
        private DungeonNaturalJunctionListCountsArray _naturalJunctionListCounts;
        private DungeonNaturalJunctionListArray _naturalJunctionList;
        private DungeonUnknownFileBuffer0x102a8Array _unknownFileBuffer0x102a8;
        private DungeonUnknownTileMatrixArray _unknownTileMatrix;
        private DungeonUnknownMatrix0x1212cArray _unknownMatrix0x1212c;
        private DungeonUnknownFileBuffer0x12162Array _unknownFileBuffer0x12162;
        private DungeonUnknownArray0x12a92Array _unknownArray0x12a92;
        private Pointer _unkFixedRoomPointer;
        private byte _trapperOrbFlag;
        private byte _field0x12aa9;
        private Position _trapperOrbTrapPos;
        private TrapId8 _trapperOrbTrapId;
        private byte _trapperOrbTrapTeam;
        private byte _field0x12ab0;
        private byte _field0x12ab1;
        private byte _field0x12ab2;
        private byte _field0x12ab3;
        private byte _field0x12ab4;
        private byte _field0x12ab5;
        private byte _field0x12ab6;
        private byte _field0x12ab7;
        private byte _field0x12ab8;
        private byte _field0x12ab9;
        private byte _field0x12aba;
        private byte _field0x12abb;
        private byte _field0x12abc;
        private byte _field0x12abd;
        private byte _field0x12abe;
        private byte _field0x12abf;
        private byte _field0x12ac0;
        private byte _field0x12ac1;
        private byte _field0x12ac2;
        private byte _field0x12ac3;
        private byte _field0x12ac4;
        private byte _field0x12ac5;
        private byte _field0x12ac6;
        private byte _field0x12ac7;
        private byte _field0x12ac8;
        private byte _field0x12ac9;
        private byte _field0x12aca;
        private byte _field0x12acb;
        private byte _field0x12acc;
        private byte _field0x12acd;
        private byte _field0x12ace;
        private byte _field0x12acf;
        private byte _field0x12ad0;
        private byte _field0x12ad1;
        private byte _field0x12ad2;
        private byte _field0x12ad3;
        private byte _field0x12ad4;
        private byte _field0x12ad5;
        private byte _field0x12ad6;
        private byte _field0x12ad7;
        private byte _field0x12ad8;
        private byte _field0x12ad9;
        private byte _field0x12ada;
        private byte _field0x12adb;
        private byte _field0x12adc;
        private byte _field0x12add;
        private byte _field0x12ade;
        private byte _field0x12adf;
        private byte _field0x12ae0;
        private byte _field0x12ae1;
        private byte _field0x12ae2;
        private byte _field0x12ae3;
        private byte _field0x12ae4;
        private byte _field0x12ae5;
        private byte _field0x12ae6;
        private byte _field0x12ae7;
        private byte _field0x12ae8;
        private byte _field0x12ae9;
        private byte _field0x12aea;
        private byte _field0x12aeb;
        private byte _field0x12aec;
        private byte _field0x12aed;
        private byte _field0x12aee;
        private byte _field0x12aef;
        private byte _field0x12af0;
        private byte _field0x12af1;
        private byte _field0x12af2;
        private byte _field0x12af3;
        private byte _field0x12af4;
        private byte _field0x12af5;
        private byte _field0x12af6;
        private byte _field0x12af7;
        private ushort _acuteSnifferItemCount;
        private ushort _nNormalItemSpawns;
        private byte _gravity;
        private byte _field0x12afd;
        private short _victoryCounter;
        private byte _field0x12b00;
        private byte _field0x12b01;
        private byte _field0x12b02;
        private byte _field0x12b03;
        private byte _field0x12b04;
        private byte _field0x12b05;
        private byte _field0x12b06;
        private byte _field0x12b07;
        private byte _field0x12b08;
        private byte _field0x12b09;
        private byte _field0x12b0a;
        private byte _field0x12b0b;
        private byte _field0x12b0c;
        private byte _field0x12b0d;
        private byte _field0x12b0e;
        private byte _field0x12b0f;
        private byte _field0x12b10;
        private byte _field0x12b11;
        private byte _field0x12b12;
        private byte _field0x12b13;
        private byte _field0x12b14;
        private byte _field0x12b15;
        private byte _field0x12b16;
        private byte _field0x12b17;
        private byte _field0x12b18;
        private byte _field0x12b19;
        private byte _field0x12b1a;
        private byte _field0x12b1b;
        private byte _field0x12b1c;
        private byte _field0x12b1d;
        private byte _field0x12b1e;
        private byte _field0x12b1f;
        private uint _fixedRoomMonsterSpriteCounter;
        private byte _boostKecleonShopSpawnChance;
        private byte _boostHiddenStairsSpawnChance;
        private byte _field0x12b26;
        private byte _field0x12b27;
        private EntityTable _entityTable;
        private Pointer _unkAllyMonster1;
        private uint _unkAllyMonsterUniqueId1;
        private Pointer _unkAllyMonster2;
        private uint _unkAllyMonsterUniqueId2;
        private Pointer _unkEnemyMonster1;
        private uint _unkEnemyMonsterUniqueId1;
        private Pointer _unkEnemyMonster2;
        private uint _unkEnemyMonsterUniqueId2;
        private Pointer _snatchMonster;
        private Pointer _illuminateSpawnEntity;
        private uint _snatchStatusUniqueId;
        private ushort _illuminateSpawnGenid;
        private byte _field0x19912;
        private byte _field0x19913;
        private DungeonSpriteIndexesArray _spriteIndexes;
        private byte _field0x1a21a;
        private byte _field0x1a21b;
        private DisplayData _displayData;
        private MinimapDisplayData _minimapDisplayData;
        private DungeonGroupAndGroupFloor _groupAndGroupFloorIdCopy;
        private FloorProperties _floorProperties;
        private ushort _field0x286d2;
        private ushort _field0x286d4;
        private ushort _field0x286d6;
        private ushort _field0x286d8;
        private ushort _field0x286da;
        private ushort _field0x286dc;
        private ushort _field0x286de;
        private ushort _field0x286e0;
        private ushort _field0x286e2;
        private ushort _field0x286e4;
        private ushort _field0x286e6;
        private ushort _field0x286e8;
        private ushort _field0x286ea;
        private ushort _field0x286ec;
        private ushort _field0x286ee;
        private ushort _field0x286f0;
        private DungeonRegularItemWeightsArray _regularItemWeights;
        private DungeonKecleonItemWeightsArray _kecleonItemWeights;
        private DungeonMonsterHouseItemWeightsArray _monsterHouseItemWeights;
        private DungeonBuriedItemWeightsArray _buriedItemWeights;
        private DungeonGrabBagItemWeightsArray _grabBagItemWeights;
        private DungeonSecretRoomItemWeightsArray _secretRoomItemWeights;
        private DungeonTrapWeightsArray _trapWeights;
        private DungeonSpawnEntriesMasterArray _spawnEntriesMaster;
        private ushort _numberSpritesLoaded;
        private ushort _highestEnemyLevel;
        private ItemId16 _guaranteedItemId;
        private DungeonSpawnTableEntriesChosenArray _spawnTableEntriesChosen;
        private byte _field0x2ca0a;
        private byte _field0x2ca0b;
        private DungeonFaintedMonsterCauseEntityNameArray _faintedMonsterCauseEntityName;
        private DungeonFaintedMonsterNameArray _faintedMonsterName;
        private DungeonFallenEscortMonsterNameArray _fallenEscortMonsterName;
        private DamageSource16 _faintedMonsterDungeonEndReason;
        private DungeonId8 _faintedId;
        private byte _faintedFloor;
        private Item _faintedMonsterHeldItem;
        private int _faintedMonsterExp;
        private short _faintedMonsterMaxHp;
        private DungeonFaintedMonsterOffensiveStatsArray _faintedMonsterOffensiveStats;
        private DungeonFaintedMonsterDefensiveStatsArray _faintedMonsterDefensiveStats;
        private byte _faintedMonsterLevel;
        private byte _field0x2ca7b;
        private MonsterSummary _getoutMonsterSummary;
        private byte _nFloorsPlusOne;
        private byte _field0x2caf5;
        private byte _field0x2caf6;
        private byte _field0x2caf7;
        private uint _field0x2caf8;
        private uint _field0x2cafc;
        private ushort _field0x2cb00;
        private ushort _field0x2cb02;
        private ushort _field0x2cb04;
        private MusicId16 _dungeonMusicPlayingId;
        private byte _field0x2cb08;
        private byte _field0x2cb09;
        private byte _field0x2cb0a;
        private byte _field0x2cb0b;
        private byte _field0x2cb0c;
        private byte _field0x2cb0d;
        private byte _field0x2cb0e;
        private byte _field0x2cb0f;
        private byte _unkCameraTracker;
        private byte _field0x2cb11;
        private byte _field0x2cb12;
        private byte _field0x2cb13;
        private Dungeon m_root;
        private KaitaiStruct m_parent;
        public byte Field0x0 { get { return _field0x0; } }
        public byte TargetEnemyDefeatedMessage { get { return _targetEnemyDefeatedMessage; } }
        public byte HiddenOutlawDefeatedMessage { get { return _hiddenOutlawDefeatedMessage; } }
        public byte TargetMonsterNotFoundFlag { get { return _targetMonsterNotFoundFlag; } }
        public byte Field0x4 { get { return _field0x4; } }
        public byte SteppedOnStairs { get { return _steppedOnStairs; } }
        public byte EndFloorFlag { get { return _endFloorFlag; } }
        public byte QuicksaveFlag { get { return _quicksaveFlag; } }
        public byte EndFloorNoDeathCheckFlag { get { return _endFloorNoDeathCheckFlag; } }
        public byte Field0x9 { get { return _field0x9; } }
        public byte Field0xa { get { return _field0xa; } }
        public byte Field0xb { get { return _field0xb; } }
        public byte MissionDeliverItemCheck { get { return _missionDeliverItemCheck; } }
        public byte Field0xd { get { return _field0xd; } }
        public byte ActivateArtificialWeatherFlag { get { return _activateArtificialWeatherFlag; } }
        public byte ShouldEnemyEvolve { get { return _shouldEnemyEvolve; } }
        public byte SwappingPlaces { get { return _swappingPlaces; } }
        public byte NoActionInProgress { get { return _noActionInProgress; } }
        public byte IqDisabled { get { return _iqDisabled; } }
        public byte RegularAttackRevealTraps { get { return _regularAttackRevealTraps; } }
        public ForcedLossReason ForcedLossReason { get { return _forcedLossReason; } }
        public uint SuccessfulExitTracker { get { return _successfulExitTracker; } }
        public short CameraFrameCounter { get { return _cameraFrameCounter; } }
        public byte NumberCompletedFloors { get { return _numberCompletedFloors; } }
        public byte SpeedBoostCounter { get { return _speedBoostCounter; } }
        public ushort NumberPrecedingFloors { get { return _numberPrecedingFloors; } }
        public ushort TotalFloorsCompleted { get { return _totalFloorsCompleted; } }
        public byte Field0x24 { get { return _field0x24; } }
        public byte Field0x25 { get { return _field0x25; } }
        public byte Field0x26 { get { return _field0x26; } }
        public byte Field0x27 { get { return _field0x27; } }
        public byte Field0x28 { get { return _field0x28; } }
        public byte Field0x29 { get { return _field0x29; } }
        public byte Field0x2a { get { return _field0x2a; } }
        public byte Field0x2b { get { return _field0x2b; } }
        public byte Field0x2c { get { return _field0x2c; } }
        public byte Field0x2d { get { return _field0x2d; } }
        public byte Field0x2e { get { return _field0x2e; } }
        public byte Field0x2f { get { return _field0x2f; } }
        public byte Field0x30 { get { return _field0x30; } }
        public byte Field0x31 { get { return _field0x31; } }
        public byte Field0x32 { get { return _field0x32; } }
        public byte Field0x33 { get { return _field0x33; } }
        public byte Field0x34 { get { return _field0x34; } }
        public byte Field0x35 { get { return _field0x35; } }
        public byte Field0x36 { get { return _field0x36; } }
        public byte Field0x37 { get { return _field0x37; } }
        public byte Field0x38 { get { return _field0x38; } }
        public byte Field0x39 { get { return _field0x39; } }
        public byte Field0x3a { get { return _field0x3a; } }
        public byte Field0x3b { get { return _field0x3b; } }
        public byte Field0x3c { get { return _field0x3c; } }
        public byte Field0x3d { get { return _field0x3d; } }
        public byte Field0x3e { get { return _field0x3e; } }
        public byte Field0x3f { get { return _field0x3f; } }
        public byte Field0x40 { get { return _field0x40; } }
        public byte Field0x41 { get { return _field0x41; } }
        public byte Field0x42 { get { return _field0x42; } }
        public byte Field0x43 { get { return _field0x43; } }
        public byte Field0x44 { get { return _field0x44; } }
        public byte Field0x45 { get { return _field0x45; } }
        public byte Field0x46 { get { return _field0x46; } }
        public byte Field0x47 { get { return _field0x47; } }
        public byte Field0x48 { get { return _field0x48; } }
        public byte Field0x49 { get { return _field0x49; } }
        public byte Field0x4a { get { return _field0x4a; } }
        public byte Field0x4b { get { return _field0x4b; } }
        public byte Field0x4c { get { return _field0x4c; } }
        public byte Field0x4d { get { return _field0x4d; } }
        public byte Field0x4e { get { return _field0x4e; } }
        public byte Field0x4f { get { return _field0x4f; } }
        public byte Field0x50 { get { return _field0x50; } }
        public byte Field0x51 { get { return _field0x51; } }
        public byte Field0x52 { get { return _field0x52; } }
        public byte Field0x53 { get { return _field0x53; } }
        public byte Field0x54 { get { return _field0x54; } }
        public byte Field0x55 { get { return _field0x55; } }
        public byte Field0x56 { get { return _field0x56; } }
        public byte Field0x57 { get { return _field0x57; } }
        public byte Field0x58 { get { return _field0x58; } }
        public byte Field0x59 { get { return _field0x59; } }
        public byte Field0x5a { get { return _field0x5a; } }
        public byte Field0x5b { get { return _field0x5b; } }
        public byte Field0x5c { get { return _field0x5c; } }
        public byte Field0x5d { get { return _field0x5d; } }
        public byte Field0x5e { get { return _field0x5e; } }
        public byte Field0x5f { get { return _field0x5f; } }
        public byte Field0x60 { get { return _field0x60; } }
        public byte Field0x61 { get { return _field0x61; } }
        public byte Field0x62 { get { return _field0x62; } }
        public byte Field0x63 { get { return _field0x63; } }
        public byte Field0x64 { get { return _field0x64; } }
        public byte Field0x65 { get { return _field0x65; } }
        public byte Field0x66 { get { return _field0x66; } }
        public byte Field0x67 { get { return _field0x67; } }
        public byte Field0x68 { get { return _field0x68; } }
        public byte Field0x69 { get { return _field0x69; } }
        public byte Field0x6a { get { return _field0x6a; } }
        public byte Field0x6b { get { return _field0x6b; } }
        public byte Field0x6c { get { return _field0x6c; } }
        public byte Field0x6d { get { return _field0x6d; } }
        public byte Field0x6e { get { return _field0x6e; } }
        public byte Field0x6f { get { return _field0x6f; } }
        public byte Field0x70 { get { return _field0x70; } }
        public byte Field0x71 { get { return _field0x71; } }
        public byte Field0x72 { get { return _field0x72; } }
        public byte Field0x73 { get { return _field0x73; } }
        public byte Field0x74 { get { return _field0x74; } }
        public byte Field0x75 { get { return _field0x75; } }
        public byte Field0x76 { get { return _field0x76; } }
        public byte Field0x77 { get { return _field0x77; } }
        public byte Field0x78 { get { return _field0x78; } }
        public byte Field0x79 { get { return _field0x79; } }
        public byte Field0x7a { get { return _field0x7a; } }
        public byte Field0x7b { get { return _field0x7b; } }
        public byte Field0x7c { get { return _field0x7c; } }
        public byte Field0x7d { get { return _field0x7d; } }
        public byte Field0x7e { get { return _field0x7e; } }
        public byte Field0x7f { get { return _field0x7f; } }
        public byte Field0x80 { get { return _field0x80; } }
        public byte Field0x81 { get { return _field0x81; } }
        public byte Field0x82 { get { return _field0x82; } }
        public byte Field0x83 { get { return _field0x83; } }
        public byte Field0x84 { get { return _field0x84; } }
        public byte Field0x85 { get { return _field0x85; } }
        public byte Field0x86 { get { return _field0x86; } }
        public byte Field0x87 { get { return _field0x87; } }
        public byte Field0x88 { get { return _field0x88; } }
        public byte Field0x89 { get { return _field0x89; } }
        public byte Field0x8a { get { return _field0x8a; } }
        public byte Field0x8b { get { return _field0x8b; } }
        public byte Field0x8c { get { return _field0x8c; } }
        public byte Field0x8d { get { return _field0x8d; } }
        public byte Field0x8e { get { return _field0x8e; } }
        public byte Field0x8f { get { return _field0x8f; } }
        public byte Field0x90 { get { return _field0x90; } }
        public byte Field0x91 { get { return _field0x91; } }
        public byte Field0x92 { get { return _field0x92; } }
        public byte Field0x93 { get { return _field0x93; } }
        public byte Field0x94 { get { return _field0x94; } }
        public byte Field0x95 { get { return _field0x95; } }
        public byte Field0x96 { get { return _field0x96; } }
        public byte Field0x97 { get { return _field0x97; } }
        public byte Field0x98 { get { return _field0x98; } }
        public byte Field0x99 { get { return _field0x99; } }
        public byte Field0x9a { get { return _field0x9a; } }
        public byte Field0x9b { get { return _field0x9b; } }
        public byte Field0x9c { get { return _field0x9c; } }
        public byte Field0x9d { get { return _field0x9d; } }
        public byte Field0x9e { get { return _field0x9e; } }
        public byte Field0x9f { get { return _field0x9f; } }
        public byte Field0xa0 { get { return _field0xa0; } }
        public byte Field0xa1 { get { return _field0xa1; } }
        public byte Field0xa2 { get { return _field0xa2; } }
        public byte Field0xa3 { get { return _field0xa3; } }
        public byte Field0xa4 { get { return _field0xa4; } }
        public byte Field0xa5 { get { return _field0xa5; } }
        public byte Field0xa6 { get { return _field0xa6; } }
        public byte Field0xa7 { get { return _field0xa7; } }
        public byte Field0xa8 { get { return _field0xa8; } }
        public byte Field0xa9 { get { return _field0xa9; } }
        public byte Field0xaa { get { return _field0xaa; } }
        public byte Field0xab { get { return _field0xab; } }
        public byte Field0xac { get { return _field0xac; } }
        public byte Field0xad { get { return _field0xad; } }
        public byte Field0xae { get { return _field0xae; } }
        public byte Field0xaf { get { return _field0xaf; } }
        public byte Field0xb0 { get { return _field0xb0; } }
        public byte Field0xb1 { get { return _field0xb1; } }
        public byte Field0xb2 { get { return _field0xb2; } }
        public byte Field0xb3 { get { return _field0xb3; } }
        public byte Field0xb4 { get { return _field0xb4; } }
        public byte Field0xb5 { get { return _field0xb5; } }
        public byte Field0xb6 { get { return _field0xb6; } }
        public byte Field0xb7 { get { return _field0xb7; } }
        public byte Field0xb8 { get { return _field0xb8; } }
        public byte Field0xb9 { get { return _field0xb9; } }
        public byte Field0xba { get { return _field0xba; } }
        public byte Field0xbb { get { return _field0xbb; } }
        public byte Field0xbc { get { return _field0xbc; } }
        public byte Field0xbd { get { return _field0xbd; } }
        public byte Field0xbe { get { return _field0xbe; } }
        public byte Field0xbf { get { return _field0xbf; } }
        public byte Field0xc0 { get { return _field0xc0; } }
        public byte Field0xc1 { get { return _field0xc1; } }
        public byte Field0xc2 { get { return _field0xc2; } }
        public byte Field0xc3 { get { return _field0xc3; } }
        public Pointer CurrentActiveEntity { get { return _currentActiveEntity; } }
        public Pointer NewLeader { get { return _newLeader; } }
        public Entity ThrownItem { get { return _thrownItem; } }
        public DamageCalcDiag LastDamageCalc { get { return _lastDamageCalc; } }
        public Position TouchscreenTargetPosition { get { return _touchscreenTargetPosition; } }
        public Position UnknownLeaderPosition { get { return _unknownLeaderPosition; } }
        public DungeonColorTableArray ColorTable { get { return _colorTable; } }
        public DungeonShopkeeperSpawnsArray ShopkeeperSpawns { get { return _shopkeeperSpawns; } }
        public int ShopkeeperSpawnCount { get { return _shopkeeperSpawnCount; } }
        public int Field0x614 { get { return _field0x614; } }
        public uint Unk1Animation1Value { get { return _unk1Animation1Value; } }
        public uint Unk2Animation1Value { get { return _unk2Animation1Value; } }
        public uint Unk3Animation1Value { get { return _unk3Animation1Value; } }
        public Pointer Animation1Entity { get { return _animation1Entity; } }
        public uint Unk1Animation2Value { get { return _unk1Animation2Value; } }
        public uint Unk2Animation2Value { get { return _unk2Animation2Value; } }
        public uint Unk3Animation2Value { get { return _unk3Animation2Value; } }
        public Pointer Animation2Entity { get { return _animation2Entity; } }
        public uint Unk1Animation3Value { get { return _unk1Animation3Value; } }
        public uint Unk2Animation3Value { get { return _unk2Animation3Value; } }
        public uint Unk3Animation3Value { get { return _unk3Animation3Value; } }
        public Pointer Animation3Entity { get { return _animation3Entity; } }
        public DungeonFallenAllyMonsterNameArray FallenAllyMonsterName { get { return _fallenAllyMonsterName; } }
        public byte Field0x652 { get { return _field0x652; } }
        public byte Field0x653 { get { return _field0x653; } }
        public byte Field0x654 { get { return _field0x654; } }
        public byte Field0x655 { get { return _field0x655; } }
        public byte Field0x656 { get { return _field0x656; } }
        public byte Field0x657 { get { return _field0x657; } }
        public byte Field0x658 { get { return _field0x658; } }
        public byte Field0x659 { get { return _field0x659; } }
        public byte Field0x65a { get { return _field0x65a; } }
        public byte Field0x65b { get { return _field0x65b; } }
        public byte Field0x65c { get { return _field0x65c; } }
        public byte Field0x65d { get { return _field0x65d; } }
        public byte Field0x65e { get { return _field0x65e; } }
        public byte Field0x65f { get { return _field0x65f; } }
        public byte Field0x660 { get { return _field0x660; } }
        public byte Field0x661 { get { return _field0x661; } }
        public byte Field0x662 { get { return _field0x662; } }
        public byte Field0x663 { get { return _field0x663; } }
        public byte Field0x664 { get { return _field0x664; } }
        public byte Field0x665 { get { return _field0x665; } }
        public byte Field0x666 { get { return _field0x666; } }
        public byte Field0x667 { get { return _field0x667; } }
        public byte Field0x668 { get { return _field0x668; } }
        public byte Field0x669 { get { return _field0x669; } }
        public byte Field0x66a { get { return _field0x66a; } }
        public byte Field0x66b { get { return _field0x66b; } }
        public byte Field0x66c { get { return _field0x66c; } }
        public byte Field0x66d { get { return _field0x66d; } }
        public byte Field0x66e { get { return _field0x66e; } }
        public byte Field0x66f { get { return _field0x66f; } }
        public byte Field0x670 { get { return _field0x670; } }
        public byte Field0x671 { get { return _field0x671; } }
        public byte Field0x672 { get { return _field0x672; } }
        public byte Field0x673 { get { return _field0x673; } }
        public byte Field0x674 { get { return _field0x674; } }
        public byte Field0x675 { get { return _field0x675; } }
        public byte Field0x676 { get { return _field0x676; } }
        public byte Field0x677 { get { return _field0x677; } }
        public byte Field0x678 { get { return _field0x678; } }
        public byte Field0x679 { get { return _field0x679; } }
        public byte Field0x67a { get { return _field0x67a; } }
        public byte Field0x67b { get { return _field0x67b; } }
        public byte Field0x67c { get { return _field0x67c; } }
        public byte Field0x67d { get { return _field0x67d; } }
        public byte Field0x67e { get { return _field0x67e; } }
        public byte Field0x67f { get { return _field0x67f; } }
        public byte Field0x680 { get { return _field0x680; } }
        public byte Field0x681 { get { return _field0x681; } }
        public byte Field0x682 { get { return _field0x682; } }
        public byte Field0x683 { get { return _field0x683; } }
        public byte Field0x684 { get { return _field0x684; } }
        public byte Field0x685 { get { return _field0x685; } }
        public byte Field0x686 { get { return _field0x686; } }
        public byte Field0x687 { get { return _field0x687; } }
        public byte Field0x688 { get { return _field0x688; } }
        public byte Field0x689 { get { return _field0x689; } }
        public byte Field0x68a { get { return _field0x68a; } }
        public byte Field0x68b { get { return _field0x68b; } }
        public byte Field0x68c { get { return _field0x68c; } }
        public byte Field0x68d { get { return _field0x68d; } }
        public byte Field0x68e { get { return _field0x68e; } }
        public byte Field0x68f { get { return _field0x68f; } }
        public byte Field0x690 { get { return _field0x690; } }
        public byte Field0x691 { get { return _field0x691; } }
        public byte Field0x692 { get { return _field0x692; } }
        public byte Field0x693 { get { return _field0x693; } }
        public byte Field0x694 { get { return _field0x694; } }
        public byte Field0x695 { get { return _field0x695; } }
        public byte Field0x696 { get { return _field0x696; } }
        public byte Field0x697 { get { return _field0x697; } }
        public byte Field0x698 { get { return _field0x698; } }
        public byte Field0x699 { get { return _field0x699; } }
        public byte Field0x69a { get { return _field0x69a; } }
        public byte Field0x69b { get { return _field0x69b; } }
        public byte Field0x69c { get { return _field0x69c; } }
        public byte Field0x69d { get { return _field0x69d; } }
        public byte Field0x69e { get { return _field0x69e; } }
        public byte Field0x69f { get { return _field0x69f; } }
        public byte Field0x6a0 { get { return _field0x6a0; } }
        public byte Field0x6a1 { get { return _field0x6a1; } }
        public byte Field0x6a2 { get { return _field0x6a2; } }
        public byte Field0x6a3 { get { return _field0x6a3; } }
        public byte Field0x6a4 { get { return _field0x6a4; } }
        public byte Field0x6a5 { get { return _field0x6a5; } }
        public byte Field0x6a6 { get { return _field0x6a6; } }
        public byte Field0x6a7 { get { return _field0x6a7; } }
        public byte Field0x6a8 { get { return _field0x6a8; } }
        public byte Field0x6a9 { get { return _field0x6a9; } }
        public byte Field0x6aa { get { return _field0x6aa; } }
        public byte Field0x6ab { get { return _field0x6ab; } }
        public byte Field0x6ac { get { return _field0x6ac; } }
        public byte Field0x6ad { get { return _field0x6ad; } }
        public byte Field0x6ae { get { return _field0x6ae; } }
        public byte Field0x6af { get { return _field0x6af; } }
        public byte Field0x6b0 { get { return _field0x6b0; } }
        public byte Field0x6b1 { get { return _field0x6b1; } }
        public byte Field0x6b2 { get { return _field0x6b2; } }
        public byte Field0x6b3 { get { return _field0x6b3; } }
        public byte Field0x6b4 { get { return _field0x6b4; } }
        public byte Field0x6b5 { get { return _field0x6b5; } }
        public byte Field0x6b6 { get { return _field0x6b6; } }
        public byte Field0x6b7 { get { return _field0x6b7; } }
        public byte Field0x6b8 { get { return _field0x6b8; } }
        public byte Field0x6b9 { get { return _field0x6b9; } }
        public byte Field0x6ba { get { return _field0x6ba; } }
        public byte Field0x6bb { get { return _field0x6bb; } }
        public byte Field0x6bc { get { return _field0x6bc; } }
        public byte Field0x6bd { get { return _field0x6bd; } }
        public byte Field0x6be { get { return _field0x6be; } }
        public byte Field0x6bf { get { return _field0x6bf; } }
        public byte Field0x6c0 { get { return _field0x6c0; } }
        public byte Field0x6c1 { get { return _field0x6c1; } }
        public byte Field0x6c2 { get { return _field0x6c2; } }
        public byte Field0x6c3 { get { return _field0x6c3; } }
        public byte Field0x6c4 { get { return _field0x6c4; } }
        public byte Field0x6c5 { get { return _field0x6c5; } }
        public byte Field0x6c6 { get { return _field0x6c6; } }
        public byte Field0x6c7 { get { return _field0x6c7; } }
        public byte Field0x6c8 { get { return _field0x6c8; } }
        public byte Field0x6c9 { get { return _field0x6c9; } }
        public byte Field0x6ca { get { return _field0x6ca; } }
        public byte Field0x6cb { get { return _field0x6cb; } }
        public byte Field0x6cc { get { return _field0x6cc; } }
        public byte Field0x6cd { get { return _field0x6cd; } }
        public byte Field0x6ce { get { return _field0x6ce; } }
        public byte Field0x6cf { get { return _field0x6cf; } }
        public byte Field0x6d0 { get { return _field0x6d0; } }
        public byte Field0x6d1 { get { return _field0x6d1; } }
        public byte Field0x6d2 { get { return _field0x6d2; } }
        public byte Field0x6d3 { get { return _field0x6d3; } }
        public byte Field0x6d4 { get { return _field0x6d4; } }
        public byte Field0x6d5 { get { return _field0x6d5; } }
        public byte Field0x6d6 { get { return _field0x6d6; } }
        public byte Field0x6d7 { get { return _field0x6d7; } }
        public byte Field0x6d8 { get { return _field0x6d8; } }
        public byte Field0x6d9 { get { return _field0x6d9; } }
        public byte Field0x6da { get { return _field0x6da; } }
        public byte Field0x6db { get { return _field0x6db; } }
        public byte Field0x6dc { get { return _field0x6dc; } }
        public byte Field0x6dd { get { return _field0x6dd; } }
        public byte Field0x6de { get { return _field0x6de; } }
        public byte Field0x6df { get { return _field0x6df; } }
        public byte Field0x6e0 { get { return _field0x6e0; } }
        public byte Field0x6e1 { get { return _field0x6e1; } }
        public byte Field0x6e2 { get { return _field0x6e2; } }
        public byte Field0x6e3 { get { return _field0x6e3; } }
        public byte Field0x6e4 { get { return _field0x6e4; } }
        public byte Field0x6e5 { get { return _field0x6e5; } }
        public byte Field0x6e6 { get { return _field0x6e6; } }
        public byte Field0x6e7 { get { return _field0x6e7; } }
        public byte Field0x6e8 { get { return _field0x6e8; } }
        public byte Field0x6e9 { get { return _field0x6e9; } }
        public byte Field0x6ea { get { return _field0x6ea; } }
        public byte Field0x6eb { get { return _field0x6eb; } }
        public byte Field0x6ec { get { return _field0x6ec; } }
        public byte Field0x6ed { get { return _field0x6ed; } }
        public byte Field0x6ee { get { return _field0x6ee; } }
        public byte Field0x6ef { get { return _field0x6ef; } }
        public byte Field0x6f0 { get { return _field0x6f0; } }
        public byte Field0x6f1 { get { return _field0x6f1; } }
        public byte Field0x6f2 { get { return _field0x6f2; } }
        public byte Field0x6f3 { get { return _field0x6f3; } }
        public byte Field0x6f4 { get { return _field0x6f4; } }
        public byte Field0x6f5 { get { return _field0x6f5; } }
        public byte Field0x6f6 { get { return _field0x6f6; } }
        public byte Field0x6f7 { get { return _field0x6f7; } }
        public byte Field0x6f8 { get { return _field0x6f8; } }
        public byte Field0x6f9 { get { return _field0x6f9; } }
        public byte Field0x6fa { get { return _field0x6fa; } }
        public byte Field0x6fb { get { return _field0x6fb; } }
        public byte Field0x6fc { get { return _field0x6fc; } }
        public byte Field0x6fd { get { return _field0x6fd; } }
        public byte Field0x6fe { get { return _field0x6fe; } }
        public byte Field0x6ff { get { return _field0x6ff; } }
        public byte Field0x700 { get { return _field0x700; } }
        public byte Field0x701 { get { return _field0x701; } }
        public byte Field0x702 { get { return _field0x702; } }
        public byte Field0x703 { get { return _field0x703; } }
        public byte Field0x704 { get { return _field0x704; } }
        public byte Field0x705 { get { return _field0x705; } }
        public byte Field0x706 { get { return _field0x706; } }
        public byte Field0x707 { get { return _field0x707; } }
        public byte Field0x708 { get { return _field0x708; } }
        public byte Field0x709 { get { return _field0x709; } }
        public byte Field0x70a { get { return _field0x70a; } }
        public byte Field0x70b { get { return _field0x70b; } }
        public byte Field0x70c { get { return _field0x70c; } }
        public byte Field0x70d { get { return _field0x70d; } }
        public byte Field0x70e { get { return _field0x70e; } }
        public byte Field0x70f { get { return _field0x70f; } }
        public byte Field0x710 { get { return _field0x710; } }
        public byte Field0x711 { get { return _field0x711; } }
        public byte Field0x712 { get { return _field0x712; } }
        public byte Field0x713 { get { return _field0x713; } }
        public byte Field0x714 { get { return _field0x714; } }
        public byte Field0x715 { get { return _field0x715; } }
        public byte Field0x716 { get { return _field0x716; } }
        public byte Field0x717 { get { return _field0x717; } }
        public byte Field0x718 { get { return _field0x718; } }
        public byte Field0x719 { get { return _field0x719; } }
        public byte Field0x71a { get { return _field0x71a; } }
        public byte Field0x71b { get { return _field0x71b; } }
        public byte Field0x71c { get { return _field0x71c; } }
        public byte Field0x71d { get { return _field0x71d; } }
        public byte Field0x71e { get { return _field0x71e; } }
        public byte Field0x71f { get { return _field0x71f; } }
        public byte Field0x720 { get { return _field0x720; } }
        public byte Field0x721 { get { return _field0x721; } }
        public byte Field0x722 { get { return _field0x722; } }
        public byte Field0x723 { get { return _field0x723; } }
        public byte Field0x724 { get { return _field0x724; } }
        public byte Field0x725 { get { return _field0x725; } }
        public byte Field0x726 { get { return _field0x726; } }
        public byte Field0x727 { get { return _field0x727; } }
        public byte Field0x728 { get { return _field0x728; } }
        public byte Field0x729 { get { return _field0x729; } }
        public byte Field0x72a { get { return _field0x72a; } }
        public byte Field0x72b { get { return _field0x72b; } }
        public byte Field0x72c { get { return _field0x72c; } }
        public byte Field0x72d { get { return _field0x72d; } }
        public byte Field0x72e { get { return _field0x72e; } }
        public byte Field0x72f { get { return _field0x72f; } }
        public byte Field0x730 { get { return _field0x730; } }
        public byte Field0x731 { get { return _field0x731; } }
        public byte Field0x732 { get { return _field0x732; } }
        public byte Field0x733 { get { return _field0x733; } }
        public byte Field0x734 { get { return _field0x734; } }
        public byte Field0x735 { get { return _field0x735; } }
        public byte Field0x736 { get { return _field0x736; } }
        public byte Field0x737 { get { return _field0x737; } }
        public byte Field0x738 { get { return _field0x738; } }
        public byte Field0x739 { get { return _field0x739; } }
        public byte Field0x73a { get { return _field0x73a; } }
        public byte Field0x73b { get { return _field0x73b; } }
        public byte Field0x73c { get { return _field0x73c; } }
        public byte Field0x73d { get { return _field0x73d; } }
        public byte Field0x73e { get { return _field0x73e; } }
        public byte Field0x73f { get { return _field0x73f; } }
        public byte Field0x740 { get { return _field0x740; } }
        public byte Field0x741 { get { return _field0x741; } }
        public byte Field0x742 { get { return _field0x742; } }
        public byte Field0x743 { get { return _field0x743; } }
        public byte Field0x744 { get { return _field0x744; } }
        public byte Field0x745 { get { return _field0x745; } }
        public byte Field0x746 { get { return _field0x746; } }
        public byte Field0x747 { get { return _field0x747; } }
        public DungeonId8 Id { get { return _id; } }
        public byte Floor { get { return _floor; } }
        public DungeonGroupAndGroupFloor GroupAndGroupFloorId { get { return _groupAndGroupFloorId; } }
        public ushort Field0x74c { get { return _field0x74c; } }
        public byte Field0x74e { get { return _field0x74e; } }
        public byte Field0x74f { get { return _field0x74f; } }
        public byte Field0x750 { get { return _field0x750; } }
        public byte RescueFloor { get { return _rescueFloor; } }
        public byte Field0x752 { get { return _field0x752; } }
        public byte Field0x753 { get { return _field0x753; } }
        public uint PrngPreseed23Bit { get { return _prngPreseed23Bit; } }
        public FloorLoopStatus8 FloorLoopStatus { get { return _floorLoopStatus; } }
        public byte RecruitingEnabled { get { return _recruitingEnabled; } }
        public byte Field0x75a { get { return _field0x75a; } }
        public byte BagEnabled { get { return _bagEnabled; } }
        public byte NonstoryFlag { get { return _nonstoryFlag; } }
        public byte SendHomeDisabled { get { return _sendHomeDisabled; } }
        public byte HiddenLandFlag { get { return _hiddenLandFlag; } }
        public byte SkipFaintAnimationFlag { get { return _skipFaintAnimationFlag; } }
        public MissionDestinationInfo MissionDestination { get { return _missionDestination; } }
        public byte BazaarMimeJrHeal { get { return _bazaarMimeJrHeal; } }
        public byte Field0x77f { get { return _field0x77f; } }
        public ushort FractionalTurn { get { return _fractionalTurn; } }
        public ushort EnemySpawnCounter { get { return _enemySpawnCounter; } }
        public short WindTurns { get { return _windTurns; } }
        public ushort EnemyDensity { get { return _enemyDensity; } }
        public ushort NextSpawnGenid { get { return _nextSpawnGenid; } }
        public byte Field0x78a { get { return _field0x78a; } }
        public byte LeaderRunning { get { return _leaderRunning; } }
        public byte PreventMisinputs { get { return _preventMisinputs; } }
        public byte IdentifyOrbFlag { get { return _identifyOrbFlag; } }
        public byte PassTurn { get { return _passTurn; } }
        public byte DroughtOrbFlag { get { return _droughtOrbFlag; } }
        public byte ThiefAlert { get { return _thiefAlert; } }
        public byte ThiefAlertEvent { get { return _thiefAlertEvent; } }
        public byte UnkMusicFlag { get { return _unkMusicFlag; } }
        public byte MonsterHouseTriggered { get { return _monsterHouseTriggered; } }
        public byte MonsterHouseTriggeredEvent { get { return _monsterHouseTriggeredEvent; } }
        public byte Field0x795 { get { return _field0x795; } }
        public ushort Field0x796 { get { return _field0x796; } }
        public DungeonObjective8 DungeonObjective { get { return _dungeonObjective; } }
        public byte LeaderHungerMessageTracker { get { return _leaderHungerMessageTracker; } }
        public byte TurnLimitWarningTracker { get { return _turnLimitWarningTracker; } }
        public sbyte RescueAttemptsLeft { get { return _rescueAttemptsLeft; } }
        public uint PrngSeed { get { return _prngSeed; } }
        public uint RescuePrngPreseed23Bit { get { return _rescuePrngPreseed23Bit; } }
        public Position FixedRoomAction109Position { get { return _fixedRoomAction109Position; } }
        public MonsterId16 SomeMonsterSpriteToLoad { get { return _someMonsterSpriteToLoad; } }
        public byte SomeMonsterLevel { get { return _someMonsterLevel; } }
        public byte Field0x7ab { get { return _field0x7ab; } }
        public uint PrngPreseed { get { return _prngPreseed; } }
        public byte Field0x7b0 { get { return _field0x7b0; } }
        public byte Field0x7b1 { get { return _field0x7b1; } }
        public byte Field0x7b2 { get { return _field0x7b2; } }
        public byte Field0x7b3 { get { return _field0x7b3; } }
        public byte Field0x7b4 { get { return _field0x7b4; } }
        public byte Field0x7b5 { get { return _field0x7b5; } }
        public byte Field0x7b6 { get { return _field0x7b6; } }
        public byte Field0x7b7 { get { return _field0x7b7; } }
        public byte Field0x7b8 { get { return _field0x7b8; } }
        public byte Field0x7b9 { get { return _field0x7b9; } }
        public byte Field0x7ba { get { return _field0x7ba; } }
        public byte Field0x7bb { get { return _field0x7bb; } }
        public uint PokeBuyKecleonShop { get { return _pokeBuyKecleonShop; } }
        public uint PokeSoldKecleonShop { get { return _pokeSoldKecleonShop; } }
        public uint UnkPokeKecleonShopTracker { get { return _unkPokeKecleonShopTracker; } }
        public byte LeaderStandingInKecleonShop { get { return _leaderStandingInKecleonShop; } }
        public byte StandingInKecleonShop { get { return _standingInKecleonShop; } }
        public byte Field0x7ca { get { return _field0x7ca; } }
        public byte Field0x7cb { get { return _field0x7cb; } }
        public GameId DungeonGameVersionId { get { return _dungeonGameVersionId; } }
        public byte Field0x7d0 { get { return _field0x7d0; } }
        public byte Field0x7d1 { get { return _field0x7d1; } }
        public byte Field0x7d2 { get { return _field0x7d2; } }
        public byte Field0x7d3 { get { return _field0x7d3; } }
        public byte Field0x7d4 { get { return _field0x7d4; } }
        public byte Field0x7d5 { get { return _field0x7d5; } }
        public byte Field0x7d6 { get { return _field0x7d6; } }
        public byte Field0x7d7 { get { return _field0x7d7; } }
        public byte Field0x7d8 { get { return _field0x7d8; } }
        public byte Field0x7d9 { get { return _field0x7d9; } }
        public byte Field0x7da { get { return _field0x7da; } }
        public byte Field0x7db { get { return _field0x7db; } }
        public byte Field0x7dc { get { return _field0x7dc; } }
        public byte Field0x7dd { get { return _field0x7dd; } }
        public byte Field0x7de { get { return _field0x7de; } }
        public byte Field0x7df { get { return _field0x7df; } }
        public byte Field0x7e0 { get { return _field0x7e0; } }
        public byte Field0x7e1 { get { return _field0x7e1; } }
        public byte Field0x7e2 { get { return _field0x7e2; } }
        public byte Field0x7e3 { get { return _field0x7e3; } }
        public byte Field0x7e4 { get { return _field0x7e4; } }
        public byte Field0x7e5 { get { return _field0x7e5; } }
        public byte Field0x7e6 { get { return _field0x7e6; } }
        public byte Field0x7e7 { get { return _field0x7e7; } }
        public byte Field0x7e8 { get { return _field0x7e8; } }
        public byte Field0x7e9 { get { return _field0x7e9; } }
        public byte Field0x7ea { get { return _field0x7ea; } }
        public byte Field0x7eb { get { return _field0x7eb; } }
        public byte Field0x7ec { get { return _field0x7ec; } }
        public byte Field0x7ed { get { return _field0x7ed; } }
        public byte Field0x7ee { get { return _field0x7ee; } }
        public byte Field0x7ef { get { return _field0x7ef; } }
        public ushort NumEntriesForField0x7d0 { get { return _numEntriesForField0x7d0; } }
        public MonsterId16 SomeMonsterSprite { get { return _someMonsterSprite; } }
        public DungeonMonstersArray Monsters { get { return _monsters; } }
        public DungeonEnemySpawnStatsArray EnemySpawnStats { get { return _enemySpawnStats; } }
        public DungeonSpawnEntriesArray SpawnEntries { get { return _spawnEntries; } }
        public byte Field0x39f4 { get { return _field0x39f4; } }
        public byte Field0x39f5 { get { return _field0x39f5; } }
        public byte Field0x39f6 { get { return _field0x39f6; } }
        public byte Field0x39f7 { get { return _field0x39f7; } }
        public byte Field0x39f8 { get { return _field0x39f8; } }
        public byte Field0x39f9 { get { return _field0x39f9; } }
        public byte Field0x39fa { get { return _field0x39fa; } }
        public byte Field0x39fb { get { return _field0x39fb; } }
        public byte Field0x39fc { get { return _field0x39fc; } }
        public byte Field0x39fd { get { return _field0x39fd; } }
        public byte Field0x39fe { get { return _field0x39fe; } }
        public byte Field0x39ff { get { return _field0x39ff; } }
        public byte Field0x3a00 { get { return _field0x3a00; } }
        public byte Field0x3a01 { get { return _field0x3a01; } }
        public byte Field0x3a02 { get { return _field0x3a02; } }
        public byte Field0x3a03 { get { return _field0x3a03; } }
        public byte Field0x3a04 { get { return _field0x3a04; } }
        public byte Field0x3a05 { get { return _field0x3a05; } }
        public byte Field0x3a06 { get { return _field0x3a06; } }
        public byte Field0x3a07 { get { return _field0x3a07; } }
        public byte Field0x3a08 { get { return _field0x3a08; } }
        public byte Field0x3a09 { get { return _field0x3a09; } }
        public byte Field0x3a0a { get { return _field0x3a0a; } }
        public byte Field0x3a0b { get { return _field0x3a0b; } }
        public byte Field0x3a0c { get { return _field0x3a0c; } }
        public byte Field0x3a0d { get { return _field0x3a0d; } }
        public byte Field0x3a0e { get { return _field0x3a0e; } }
        public byte Field0x3a0f { get { return _field0x3a0f; } }
        public byte Field0x3a10 { get { return _field0x3a10; } }
        public byte Field0x3a11 { get { return _field0x3a11; } }
        public byte Field0x3a12 { get { return _field0x3a12; } }
        public byte Field0x3a13 { get { return _field0x3a13; } }
        public byte Field0x3a14 { get { return _field0x3a14; } }
        public byte Field0x3a15 { get { return _field0x3a15; } }
        public byte Field0x3a16 { get { return _field0x3a16; } }
        public byte Field0x3a17 { get { return _field0x3a17; } }
        public byte Field0x3a18 { get { return _field0x3a18; } }
        public byte Field0x3a19 { get { return _field0x3a19; } }
        public byte Field0x3a1a { get { return _field0x3a1a; } }
        public byte Field0x3a1b { get { return _field0x3a1b; } }
        public byte Field0x3a1c { get { return _field0x3a1c; } }
        public byte Field0x3a1d { get { return _field0x3a1d; } }
        public byte Field0x3a1e { get { return _field0x3a1e; } }
        public byte Field0x3a1f { get { return _field0x3a1f; } }
        public byte Field0x3a20 { get { return _field0x3a20; } }
        public byte Field0x3a21 { get { return _field0x3a21; } }
        public byte Field0x3a22 { get { return _field0x3a22; } }
        public byte Field0x3a23 { get { return _field0x3a23; } }
        public byte Field0x3a24 { get { return _field0x3a24; } }
        public byte Field0x3a25 { get { return _field0x3a25; } }
        public byte Field0x3a26 { get { return _field0x3a26; } }
        public byte Field0x3a27 { get { return _field0x3a27; } }
        public byte Field0x3a28 { get { return _field0x3a28; } }
        public byte Field0x3a29 { get { return _field0x3a29; } }
        public byte Field0x3a2a { get { return _field0x3a2a; } }
        public byte Field0x3a2b { get { return _field0x3a2b; } }
        public byte Field0x3a2c { get { return _field0x3a2c; } }
        public byte Field0x3a2d { get { return _field0x3a2d; } }
        public byte Field0x3a2e { get { return _field0x3a2e; } }
        public byte Field0x3a2f { get { return _field0x3a2f; } }
        public byte Field0x3a30 { get { return _field0x3a30; } }
        public byte Field0x3a31 { get { return _field0x3a31; } }
        public byte Field0x3a32 { get { return _field0x3a32; } }
        public byte Field0x3a33 { get { return _field0x3a33; } }
        public byte Field0x3a34 { get { return _field0x3a34; } }
        public byte Field0x3a35 { get { return _field0x3a35; } }
        public byte Field0x3a36 { get { return _field0x3a36; } }
        public byte Field0x3a37 { get { return _field0x3a37; } }
        public byte Field0x3a38 { get { return _field0x3a38; } }
        public byte Field0x3a39 { get { return _field0x3a39; } }
        public byte Field0x3a3a { get { return _field0x3a3a; } }
        public byte Field0x3a3b { get { return _field0x3a3b; } }
        public byte Field0x3a3c { get { return _field0x3a3c; } }
        public byte Field0x3a3d { get { return _field0x3a3d; } }
        public byte Field0x3a3e { get { return _field0x3a3e; } }
        public byte Field0x3a3f { get { return _field0x3a3f; } }
        public byte Field0x3a40 { get { return _field0x3a40; } }
        public byte Field0x3a41 { get { return _field0x3a41; } }
        public byte Field0x3a42 { get { return _field0x3a42; } }
        public byte Field0x3a43 { get { return _field0x3a43; } }
        public byte Field0x3a44 { get { return _field0x3a44; } }
        public byte Field0x3a45 { get { return _field0x3a45; } }
        public byte Field0x3a46 { get { return _field0x3a46; } }
        public byte Field0x3a47 { get { return _field0x3a47; } }
        public byte Field0x3a48 { get { return _field0x3a48; } }
        public byte Field0x3a49 { get { return _field0x3a49; } }
        public byte Field0x3a4a { get { return _field0x3a4a; } }
        public byte Field0x3a4b { get { return _field0x3a4b; } }
        public byte Field0x3a4c { get { return _field0x3a4c; } }
        public byte Field0x3a4d { get { return _field0x3a4d; } }
        public byte Field0x3a4e { get { return _field0x3a4e; } }
        public byte Field0x3a4f { get { return _field0x3a4f; } }
        public byte Field0x3a50 { get { return _field0x3a50; } }
        public byte Field0x3a51 { get { return _field0x3a51; } }
        public byte Field0x3a52 { get { return _field0x3a52; } }
        public byte Field0x3a53 { get { return _field0x3a53; } }
        public byte Field0x3a54 { get { return _field0x3a54; } }
        public byte Field0x3a55 { get { return _field0x3a55; } }
        public byte Field0x3a56 { get { return _field0x3a56; } }
        public byte Field0x3a57 { get { return _field0x3a57; } }
        public byte Field0x3a58 { get { return _field0x3a58; } }
        public byte Field0x3a59 { get { return _field0x3a59; } }
        public byte Field0x3a5a { get { return _field0x3a5a; } }
        public byte Field0x3a5b { get { return _field0x3a5b; } }
        public byte Field0x3a5c { get { return _field0x3a5c; } }
        public byte Field0x3a5d { get { return _field0x3a5d; } }
        public byte Field0x3a5e { get { return _field0x3a5e; } }
        public byte Field0x3a5f { get { return _field0x3a5f; } }
        public byte Field0x3a60 { get { return _field0x3a60; } }
        public byte Field0x3a61 { get { return _field0x3a61; } }
        public byte Field0x3a62 { get { return _field0x3a62; } }
        public byte Field0x3a63 { get { return _field0x3a63; } }
        public byte Field0x3a64 { get { return _field0x3a64; } }
        public byte Field0x3a65 { get { return _field0x3a65; } }
        public byte Field0x3a66 { get { return _field0x3a66; } }
        public byte Field0x3a67 { get { return _field0x3a67; } }
        public byte Field0x3a68 { get { return _field0x3a68; } }
        public byte Field0x3a69 { get { return _field0x3a69; } }
        public byte Field0x3a6a { get { return _field0x3a6a; } }
        public byte Field0x3a6b { get { return _field0x3a6b; } }
        public byte Field0x3a6c { get { return _field0x3a6c; } }
        public byte Field0x3a6d { get { return _field0x3a6d; } }
        public byte Field0x3a6e { get { return _field0x3a6e; } }
        public byte Field0x3a6f { get { return _field0x3a6f; } }
        public byte Field0x3a70 { get { return _field0x3a70; } }
        public byte Field0x3a71 { get { return _field0x3a71; } }
        public byte Field0x3a72 { get { return _field0x3a72; } }
        public byte Field0x3a73 { get { return _field0x3a73; } }
        public byte Field0x3a74 { get { return _field0x3a74; } }
        public byte Field0x3a75 { get { return _field0x3a75; } }
        public byte Field0x3a76 { get { return _field0x3a76; } }
        public byte Field0x3a77 { get { return _field0x3a77; } }
        public byte Field0x3a78 { get { return _field0x3a78; } }
        public byte Field0x3a79 { get { return _field0x3a79; } }
        public byte Field0x3a7a { get { return _field0x3a7a; } }
        public byte Field0x3a7b { get { return _field0x3a7b; } }
        public byte Field0x3a7c { get { return _field0x3a7c; } }
        public byte Field0x3a7d { get { return _field0x3a7d; } }
        public byte Field0x3a7e { get { return _field0x3a7e; } }
        public byte Field0x3a7f { get { return _field0x3a7f; } }
        public byte Field0x3a80 { get { return _field0x3a80; } }
        public byte Field0x3a81 { get { return _field0x3a81; } }
        public byte Field0x3a82 { get { return _field0x3a82; } }
        public byte Field0x3a83 { get { return _field0x3a83; } }
        public byte Field0x3a84 { get { return _field0x3a84; } }
        public byte Field0x3a85 { get { return _field0x3a85; } }
        public byte Field0x3a86 { get { return _field0x3a86; } }
        public byte Field0x3a87 { get { return _field0x3a87; } }
        public byte Field0x3a88 { get { return _field0x3a88; } }
        public byte Field0x3a89 { get { return _field0x3a89; } }
        public byte Field0x3a8a { get { return _field0x3a8a; } }
        public byte Field0x3a8b { get { return _field0x3a8b; } }
        public byte Field0x3a8c { get { return _field0x3a8c; } }
        public byte Field0x3a8d { get { return _field0x3a8d; } }
        public byte Field0x3a8e { get { return _field0x3a8e; } }
        public byte Field0x3a8f { get { return _field0x3a8f; } }
        public byte Field0x3a90 { get { return _field0x3a90; } }
        public byte Field0x3a91 { get { return _field0x3a91; } }
        public byte Field0x3a92 { get { return _field0x3a92; } }
        public byte Field0x3a93 { get { return _field0x3a93; } }
        public byte Field0x3a94 { get { return _field0x3a94; } }
        public byte Field0x3a95 { get { return _field0x3a95; } }
        public byte Field0x3a96 { get { return _field0x3a96; } }
        public byte Field0x3a97 { get { return _field0x3a97; } }
        public byte Field0x3a98 { get { return _field0x3a98; } }
        public byte Field0x3a99 { get { return _field0x3a99; } }
        public byte Field0x3a9a { get { return _field0x3a9a; } }
        public byte Field0x3a9b { get { return _field0x3a9b; } }
        public byte Field0x3a9c { get { return _field0x3a9c; } }
        public byte Field0x3a9d { get { return _field0x3a9d; } }
        public byte Field0x3a9e { get { return _field0x3a9e; } }
        public byte Field0x3a9f { get { return _field0x3a9f; } }
        public byte Field0x3aa0 { get { return _field0x3aa0; } }
        public byte Field0x3aa1 { get { return _field0x3aa1; } }
        public byte Field0x3aa2 { get { return _field0x3aa2; } }
        public byte Field0x3aa3 { get { return _field0x3aa3; } }
        public byte Field0x3aa4 { get { return _field0x3aa4; } }
        public byte Field0x3aa5 { get { return _field0x3aa5; } }
        public byte Field0x3aa6 { get { return _field0x3aa6; } }
        public byte Field0x3aa7 { get { return _field0x3aa7; } }
        public byte Field0x3aa8 { get { return _field0x3aa8; } }
        public byte Field0x3aa9 { get { return _field0x3aa9; } }
        public byte Field0x3aaa { get { return _field0x3aaa; } }
        public byte Field0x3aab { get { return _field0x3aab; } }
        public byte Field0x3aac { get { return _field0x3aac; } }
        public byte Field0x3aad { get { return _field0x3aad; } }
        public byte Field0x3aae { get { return _field0x3aae; } }
        public byte Field0x3aaf { get { return _field0x3aaf; } }
        public byte Field0x3ab0 { get { return _field0x3ab0; } }
        public byte Field0x3ab1 { get { return _field0x3ab1; } }
        public byte Field0x3ab2 { get { return _field0x3ab2; } }
        public byte Field0x3ab3 { get { return _field0x3ab3; } }
        public byte Field0x3ab4 { get { return _field0x3ab4; } }
        public byte Field0x3ab5 { get { return _field0x3ab5; } }
        public byte Field0x3ab6 { get { return _field0x3ab6; } }
        public byte Field0x3ab7 { get { return _field0x3ab7; } }
        public byte Field0x3ab8 { get { return _field0x3ab8; } }
        public byte Field0x3ab9 { get { return _field0x3ab9; } }
        public byte Field0x3aba { get { return _field0x3aba; } }
        public byte Field0x3abb { get { return _field0x3abb; } }
        public byte Field0x3abc { get { return _field0x3abc; } }
        public byte Field0x3abd { get { return _field0x3abd; } }
        public byte Field0x3abe { get { return _field0x3abe; } }
        public byte Field0x3abf { get { return _field0x3abf; } }
        public byte Field0x3ac0 { get { return _field0x3ac0; } }
        public byte Field0x3ac1 { get { return _field0x3ac1; } }
        public byte Field0x3ac2 { get { return _field0x3ac2; } }
        public byte Field0x3ac3 { get { return _field0x3ac3; } }
        public byte Field0x3ac4 { get { return _field0x3ac4; } }
        public byte Field0x3ac5 { get { return _field0x3ac5; } }
        public byte Field0x3ac6 { get { return _field0x3ac6; } }
        public byte Field0x3ac7 { get { return _field0x3ac7; } }
        public byte Field0x3ac8 { get { return _field0x3ac8; } }
        public byte Field0x3ac9 { get { return _field0x3ac9; } }
        public byte Field0x3aca { get { return _field0x3aca; } }
        public byte Field0x3acb { get { return _field0x3acb; } }
        public byte Field0x3acc { get { return _field0x3acc; } }
        public byte Field0x3acd { get { return _field0x3acd; } }
        public byte Field0x3ace { get { return _field0x3ace; } }
        public byte Field0x3acf { get { return _field0x3acf; } }
        public byte Field0x3ad0 { get { return _field0x3ad0; } }
        public byte Field0x3ad1 { get { return _field0x3ad1; } }
        public byte Field0x3ad2 { get { return _field0x3ad2; } }
        public byte Field0x3ad3 { get { return _field0x3ad3; } }
        public byte Field0x3ad4 { get { return _field0x3ad4; } }
        public byte Field0x3ad5 { get { return _field0x3ad5; } }
        public byte Field0x3ad6 { get { return _field0x3ad6; } }
        public byte Field0x3ad7 { get { return _field0x3ad7; } }
        public byte Field0x3ad8 { get { return _field0x3ad8; } }
        public byte Field0x3ad9 { get { return _field0x3ad9; } }
        public byte Field0x3ada { get { return _field0x3ada; } }
        public byte Field0x3adb { get { return _field0x3adb; } }
        public byte Field0x3adc { get { return _field0x3adc; } }
        public byte Field0x3add { get { return _field0x3add; } }
        public byte Field0x3ade { get { return _field0x3ade; } }
        public byte Field0x3adf { get { return _field0x3adf; } }
        public byte Field0x3ae0 { get { return _field0x3ae0; } }
        public byte Field0x3ae1 { get { return _field0x3ae1; } }
        public byte Field0x3ae2 { get { return _field0x3ae2; } }
        public byte Field0x3ae3 { get { return _field0x3ae3; } }
        public byte Field0x3ae4 { get { return _field0x3ae4; } }
        public byte Field0x3ae5 { get { return _field0x3ae5; } }
        public byte Field0x3ae6 { get { return _field0x3ae6; } }
        public byte Field0x3ae7 { get { return _field0x3ae7; } }
        public byte Field0x3ae8 { get { return _field0x3ae8; } }
        public byte Field0x3ae9 { get { return _field0x3ae9; } }
        public byte Field0x3aea { get { return _field0x3aea; } }
        public byte Field0x3aeb { get { return _field0x3aeb; } }
        public byte Field0x3aec { get { return _field0x3aec; } }
        public byte Field0x3aed { get { return _field0x3aed; } }
        public byte Field0x3aee { get { return _field0x3aee; } }
        public byte Field0x3aef { get { return _field0x3aef; } }
        public byte Field0x3af0 { get { return _field0x3af0; } }
        public byte Field0x3af1 { get { return _field0x3af1; } }
        public byte Field0x3af2 { get { return _field0x3af2; } }
        public byte Field0x3af3 { get { return _field0x3af3; } }
        public byte Field0x3af4 { get { return _field0x3af4; } }
        public byte Field0x3af5 { get { return _field0x3af5; } }
        public byte Field0x3af6 { get { return _field0x3af6; } }
        public byte Field0x3af7 { get { return _field0x3af7; } }
        public byte Field0x3af8 { get { return _field0x3af8; } }
        public byte Field0x3af9 { get { return _field0x3af9; } }
        public byte Field0x3afa { get { return _field0x3afa; } }
        public byte Field0x3afb { get { return _field0x3afb; } }
        public byte Field0x3afc { get { return _field0x3afc; } }
        public byte Field0x3afd { get { return _field0x3afd; } }
        public byte Field0x3afe { get { return _field0x3afe; } }
        public byte Field0x3aff { get { return _field0x3aff; } }
        public byte Field0x3b00 { get { return _field0x3b00; } }
        public byte Field0x3b01 { get { return _field0x3b01; } }
        public byte Field0x3b02 { get { return _field0x3b02; } }
        public byte Field0x3b03 { get { return _field0x3b03; } }
        public byte Field0x3b04 { get { return _field0x3b04; } }
        public byte Field0x3b05 { get { return _field0x3b05; } }
        public byte Field0x3b06 { get { return _field0x3b06; } }
        public byte Field0x3b07 { get { return _field0x3b07; } }
        public byte Field0x3b08 { get { return _field0x3b08; } }
        public byte Field0x3b09 { get { return _field0x3b09; } }
        public byte Field0x3b0a { get { return _field0x3b0a; } }
        public byte Field0x3b0b { get { return _field0x3b0b; } }
        public byte Field0x3b0c { get { return _field0x3b0c; } }
        public byte Field0x3b0d { get { return _field0x3b0d; } }
        public byte Field0x3b0e { get { return _field0x3b0e; } }
        public byte Field0x3b0f { get { return _field0x3b0f; } }
        public byte Field0x3b10 { get { return _field0x3b10; } }
        public byte Field0x3b11 { get { return _field0x3b11; } }
        public byte Field0x3b12 { get { return _field0x3b12; } }
        public byte Field0x3b13 { get { return _field0x3b13; } }
        public byte Field0x3b14 { get { return _field0x3b14; } }
        public byte Field0x3b15 { get { return _field0x3b15; } }
        public byte Field0x3b16 { get { return _field0x3b16; } }
        public byte Field0x3b17 { get { return _field0x3b17; } }
        public byte Field0x3b18 { get { return _field0x3b18; } }
        public byte Field0x3b19 { get { return _field0x3b19; } }
        public byte Field0x3b1a { get { return _field0x3b1a; } }
        public byte Field0x3b1b { get { return _field0x3b1b; } }
        public byte Field0x3b1c { get { return _field0x3b1c; } }
        public byte Field0x3b1d { get { return _field0x3b1d; } }
        public byte Field0x3b1e { get { return _field0x3b1e; } }
        public byte Field0x3b1f { get { return _field0x3b1f; } }
        public byte Field0x3b20 { get { return _field0x3b20; } }
        public byte Field0x3b21 { get { return _field0x3b21; } }
        public byte Field0x3b22 { get { return _field0x3b22; } }
        public byte Field0x3b23 { get { return _field0x3b23; } }
        public byte Field0x3b24 { get { return _field0x3b24; } }
        public byte Field0x3b25 { get { return _field0x3b25; } }
        public byte Field0x3b26 { get { return _field0x3b26; } }
        public byte Field0x3b27 { get { return _field0x3b27; } }
        public byte Field0x3b28 { get { return _field0x3b28; } }
        public byte Field0x3b29 { get { return _field0x3b29; } }
        public byte Field0x3b2a { get { return _field0x3b2a; } }
        public byte Field0x3b2b { get { return _field0x3b2b; } }
        public byte Field0x3b2c { get { return _field0x3b2c; } }
        public byte Field0x3b2d { get { return _field0x3b2d; } }
        public byte Field0x3b2e { get { return _field0x3b2e; } }
        public byte Field0x3b2f { get { return _field0x3b2f; } }
        public byte Field0x3b30 { get { return _field0x3b30; } }
        public byte Field0x3b31 { get { return _field0x3b31; } }
        public byte Field0x3b32 { get { return _field0x3b32; } }
        public byte Field0x3b33 { get { return _field0x3b33; } }
        public byte Field0x3b34 { get { return _field0x3b34; } }
        public byte Field0x3b35 { get { return _field0x3b35; } }
        public byte Field0x3b36 { get { return _field0x3b36; } }
        public byte Field0x3b37 { get { return _field0x3b37; } }
        public byte Field0x3b38 { get { return _field0x3b38; } }
        public byte Field0x3b39 { get { return _field0x3b39; } }
        public byte Field0x3b3a { get { return _field0x3b3a; } }
        public byte Field0x3b3b { get { return _field0x3b3b; } }
        public byte Field0x3b3c { get { return _field0x3b3c; } }
        public byte Field0x3b3d { get { return _field0x3b3d; } }
        public byte Field0x3b3e { get { return _field0x3b3e; } }
        public byte Field0x3b3f { get { return _field0x3b3f; } }
        public byte Field0x3b40 { get { return _field0x3b40; } }
        public byte Field0x3b41 { get { return _field0x3b41; } }
        public byte Field0x3b42 { get { return _field0x3b42; } }
        public byte Field0x3b43 { get { return _field0x3b43; } }
        public byte Field0x3b44 { get { return _field0x3b44; } }
        public byte Field0x3b45 { get { return _field0x3b45; } }
        public byte Field0x3b46 { get { return _field0x3b46; } }
        public byte Field0x3b47 { get { return _field0x3b47; } }
        public byte Field0x3b48 { get { return _field0x3b48; } }
        public byte Field0x3b49 { get { return _field0x3b49; } }
        public byte Field0x3b4a { get { return _field0x3b4a; } }
        public byte Field0x3b4b { get { return _field0x3b4b; } }
        public byte Field0x3b4c { get { return _field0x3b4c; } }
        public byte Field0x3b4d { get { return _field0x3b4d; } }
        public byte Field0x3b4e { get { return _field0x3b4e; } }
        public byte Field0x3b4f { get { return _field0x3b4f; } }
        public byte Field0x3b50 { get { return _field0x3b50; } }
        public byte Field0x3b51 { get { return _field0x3b51; } }
        public byte Field0x3b52 { get { return _field0x3b52; } }
        public byte Field0x3b53 { get { return _field0x3b53; } }
        public byte Field0x3b54 { get { return _field0x3b54; } }
        public byte Field0x3b55 { get { return _field0x3b55; } }
        public byte Field0x3b56 { get { return _field0x3b56; } }
        public byte Field0x3b57 { get { return _field0x3b57; } }
        public byte Field0x3b58 { get { return _field0x3b58; } }
        public byte Field0x3b59 { get { return _field0x3b59; } }
        public byte Field0x3b5a { get { return _field0x3b5a; } }
        public byte Field0x3b5b { get { return _field0x3b5b; } }
        public byte Field0x3b5c { get { return _field0x3b5c; } }
        public byte Field0x3b5d { get { return _field0x3b5d; } }
        public byte Field0x3b5e { get { return _field0x3b5e; } }
        public byte Field0x3b5f { get { return _field0x3b5f; } }
        public byte Field0x3b60 { get { return _field0x3b60; } }
        public byte Field0x3b61 { get { return _field0x3b61; } }
        public byte Field0x3b62 { get { return _field0x3b62; } }
        public byte Field0x3b63 { get { return _field0x3b63; } }
        public byte Field0x3b64 { get { return _field0x3b64; } }
        public byte Field0x3b65 { get { return _field0x3b65; } }
        public byte Field0x3b66 { get { return _field0x3b66; } }
        public byte Field0x3b67 { get { return _field0x3b67; } }
        public byte Field0x3b68 { get { return _field0x3b68; } }
        public byte Field0x3b69 { get { return _field0x3b69; } }
        public byte Field0x3b6a { get { return _field0x3b6a; } }
        public byte Field0x3b6b { get { return _field0x3b6b; } }
        public byte Field0x3b6c { get { return _field0x3b6c; } }
        public byte Field0x3b6d { get { return _field0x3b6d; } }
        public byte Field0x3b6e { get { return _field0x3b6e; } }
        public byte Field0x3b6f { get { return _field0x3b6f; } }
        public byte Field0x3b70 { get { return _field0x3b70; } }
        public byte Field0x3b71 { get { return _field0x3b71; } }
        public byte Field0x3b72 { get { return _field0x3b72; } }
        public byte Field0x3b73 { get { return _field0x3b73; } }
        public DungeonUnknownArray0x3b74Array UnknownArray0x3b74 { get { return _unknownArray0x3b74; } }
        public DungeonMonsterUniqueIdArray MonsterUniqueId { get { return _monsterUniqueId; } }
        public uint UniqueIdIndex { get { return _uniqueIdIndex; } }
        public int MonsterSpawnEntriesLength { get { return _monsterSpawnEntriesLength; } }
        public byte Field0x3e24 { get { return _field0x3e24; } }
        public byte Field0x3e25 { get { return _field0x3e25; } }
        public byte Field0x3e26 { get { return _field0x3e26; } }
        public byte Field0x3e27 { get { return _field0x3e27; } }
        public byte UnkSpawnEntryIdCheck { get { return _unkSpawnEntryIdCheck; } }
        public byte Field0x3e29 { get { return _field0x3e29; } }
        public byte Field0x3e2a { get { return _field0x3e2a; } }
        public byte Field0x3e2b { get { return _field0x3e2b; } }
        public uint MonsterUniqueIdCounter { get { return _monsterUniqueIdCounter; } }
        public uint MonsterUniqueWrapCounter { get { return _monsterUniqueWrapCounter; } }
        public DungeonPlusIsActiveArray PlusIsActive { get { return _plusIsActive; } }
        public DungeonMinusIsActiveArray MinusIsActive { get { return _minusIsActive; } }
        public byte DecoyIsActive { get { return _decoyIsActive; } }
        public byte MewCannotSpawn { get { return _mewCannotSpawn; } }
        public MonsterId16 DeoxysFloorId { get { return _deoxysFloorId; } }
        public byte ShayminSkyFormLoaded { get { return _shayminSkyFormLoaded; } }
        public byte Field0x3e3d { get { return _field0x3e3d; } }
        public byte Field0x3e3e { get { return _field0x3e3e; } }
        public byte Field0x3e3f { get { return _field0x3e3f; } }
        public DungeonItemsArray Items { get { return _items; } }
        public ushort NItems { get { return _nItems; } }
        public short NFixedRoomItems { get { return _nFixedRoomItems; } }
        public DungeonTrapsArray Traps { get { return _traps; } }
        public DungeonGenerationInfo GenInfo { get { return _genInfo; } }
        public byte Field0xccfc { get { return _field0xccfc; } }
        public byte Field0xccfd { get { return _field0xccfd; } }
        public byte Field0xccfe { get { return _field0xccfe; } }
        public byte Field0xccff { get { return _field0xccff; } }
        public byte Field0xcd00 { get { return _field0xcd00; } }
        public byte Field0xcd01 { get { return _field0xcd01; } }
        public byte Field0xcd02 { get { return _field0xcd02; } }
        public byte Field0xcd03 { get { return _field0xcd03; } }
        public byte Field0xcd04 { get { return _field0xcd04; } }
        public byte Field0xcd05 { get { return _field0xcd05; } }
        public byte Field0xcd06 { get { return _field0xcd06; } }
        public byte Field0xcd07 { get { return _field0xcd07; } }
        public byte Field0xcd08 { get { return _field0xcd08; } }
        public byte Field0xcd09 { get { return _field0xcd09; } }
        public byte Field0xcd0a { get { return _field0xcd0a; } }
        public byte Field0xcd0b { get { return _field0xcd0b; } }
        public DungeonUnkTeamDirectionArrayArray UnkTeamDirectionArray { get { return _unkTeamDirectionArray; } }
        public int KecleonShopMinX { get { return _kecleonShopMinX; } }
        public int KecleonShopMinY { get { return _kecleonShopMinY; } }
        public int KecleonShopMaxX { get { return _kecleonShopMaxX; } }
        public int KecleonShopMaxY { get { return _kecleonShopMaxY; } }
        public int FixedRoomMinX { get { return _fixedRoomMinX; } }
        public int FixedRoomMinY { get { return _fixedRoomMinY; } }
        public int FixedRoomMaxX { get { return _fixedRoomMaxX; } }
        public int FixedRoomMaxY { get { return _fixedRoomMaxY; } }
        public ushort FixedRoomWidth { get { return _fixedRoomWidth; } }
        public ushort FixedRoomHeight { get { return _fixedRoomHeight; } }
        public WeatherId8 Weather { get { return _weather; } }
        public WeatherId8 NaturalWeather { get { return _naturalWeather; } }
        public DungeonWeatherTurnsArray WeatherTurns { get { return _weatherTurns; } }
        public DungeonArtificialPermaweatherTurnsArray ArtificialPermaweatherTurns { get { return _artificialPermaweatherTurns; } }
        public byte WeatherDamageCounter { get { return _weatherDamageCounter; } }
        public byte MudSportTurns { get { return _mudSportTurns; } }
        public byte WaterSportTurns { get { return _waterSportTurns; } }
        public byte NullifyWeather { get { return _nullifyWeather; } }
        public byte Field0xcd5e { get { return _field0xcd5e; } }
        public byte Field0xcd5f { get { return _field0xcd5f; } }
        public DungeonFixedRoomTilesArray FixedRoomTiles { get { return _fixedRoomTiles; } }
        public byte Field0xd260 { get { return _field0xd260; } }
        public byte Field0xd261 { get { return _field0xd261; } }
        public byte Field0xd262 { get { return _field0xd262; } }
        public byte Field0xd263 { get { return _field0xd263; } }
        public byte Field0xd264 { get { return _field0xd264; } }
        public byte Field0xd265 { get { return _field0xd265; } }
        public byte Field0xd266 { get { return _field0xd266; } }
        public byte Field0xd267 { get { return _field0xd267; } }
        public byte Field0xd268 { get { return _field0xd268; } }
        public byte Field0xd269 { get { return _field0xd269; } }
        public byte Field0xd26a { get { return _field0xd26a; } }
        public byte Field0xd26b { get { return _field0xd26b; } }
        public byte Field0xd26c { get { return _field0xd26c; } }
        public byte Field0xd26d { get { return _field0xd26d; } }
        public byte Field0xd26e { get { return _field0xd26e; } }
        public byte Field0xd26f { get { return _field0xd26f; } }
        public byte Field0xd270 { get { return _field0xd270; } }
        public byte Field0xd271 { get { return _field0xd271; } }
        public byte Field0xd272 { get { return _field0xd272; } }
        public byte Field0xd273 { get { return _field0xd273; } }
        public byte Field0xd274 { get { return _field0xd274; } }
        public byte Field0xd275 { get { return _field0xd275; } }
        public byte Field0xd276 { get { return _field0xd276; } }
        public byte Field0xd277 { get { return _field0xd277; } }
        public byte Field0xd278 { get { return _field0xd278; } }
        public byte Field0xd279 { get { return _field0xd279; } }
        public byte Field0xd27a { get { return _field0xd27a; } }
        public byte Field0xd27b { get { return _field0xd27b; } }
        public byte Field0xd27c { get { return _field0xd27c; } }
        public byte Field0xd27d { get { return _field0xd27d; } }
        public byte Field0xd27e { get { return _field0xd27e; } }
        public byte Field0xd27f { get { return _field0xd27f; } }
        public byte Field0xd280 { get { return _field0xd280; } }
        public byte Field0xd281 { get { return _field0xd281; } }
        public byte Field0xd282 { get { return _field0xd282; } }
        public byte Field0xd283 { get { return _field0xd283; } }
        public byte Field0xd284 { get { return _field0xd284; } }
        public byte Field0xd285 { get { return _field0xd285; } }
        public byte Field0xd286 { get { return _field0xd286; } }
        public byte Field0xd287 { get { return _field0xd287; } }
        public byte Field0xd288 { get { return _field0xd288; } }
        public byte Field0xd289 { get { return _field0xd289; } }
        public byte Field0xd28a { get { return _field0xd28a; } }
        public byte Field0xd28b { get { return _field0xd28b; } }
        public byte Field0xd28c { get { return _field0xd28c; } }
        public byte Field0xd28d { get { return _field0xd28d; } }
        public byte Field0xd28e { get { return _field0xd28e; } }
        public byte Field0xd28f { get { return _field0xd28f; } }
        public byte Field0xd290 { get { return _field0xd290; } }
        public byte Field0xd291 { get { return _field0xd291; } }
        public byte Field0xd292 { get { return _field0xd292; } }
        public byte Field0xd293 { get { return _field0xd293; } }
        public byte Field0xd294 { get { return _field0xd294; } }
        public byte Field0xd295 { get { return _field0xd295; } }
        public byte Field0xd296 { get { return _field0xd296; } }
        public byte Field0xd297 { get { return _field0xd297; } }
        public byte Field0xd298 { get { return _field0xd298; } }
        public byte Field0xd299 { get { return _field0xd299; } }
        public byte Field0xd29a { get { return _field0xd29a; } }
        public byte Field0xd29b { get { return _field0xd29b; } }
        public byte Field0xd29c { get { return _field0xd29c; } }
        public byte Field0xd29d { get { return _field0xd29d; } }
        public byte Field0xd29e { get { return _field0xd29e; } }
        public byte Field0xd29f { get { return _field0xd29f; } }
        public byte Field0xd2a0 { get { return _field0xd2a0; } }
        public byte Field0xd2a1 { get { return _field0xd2a1; } }
        public byte Field0xd2a2 { get { return _field0xd2a2; } }
        public byte Field0xd2a3 { get { return _field0xd2a3; } }
        public byte Field0xd2a4 { get { return _field0xd2a4; } }
        public byte Field0xd2a5 { get { return _field0xd2a5; } }
        public byte Field0xd2a6 { get { return _field0xd2a6; } }
        public byte Field0xd2a7 { get { return _field0xd2a7; } }
        public byte Field0xd2a8 { get { return _field0xd2a8; } }
        public byte Field0xd2a9 { get { return _field0xd2a9; } }
        public byte Field0xd2aa { get { return _field0xd2aa; } }
        public byte Field0xd2ab { get { return _field0xd2ab; } }
        public byte Field0xd2ac { get { return _field0xd2ac; } }
        public byte Field0xd2ad { get { return _field0xd2ad; } }
        public byte Field0xd2ae { get { return _field0xd2ae; } }
        public byte Field0xd2af { get { return _field0xd2af; } }
        public byte Field0xd2b0 { get { return _field0xd2b0; } }
        public byte Field0xd2b1 { get { return _field0xd2b1; } }
        public byte Field0xd2b2 { get { return _field0xd2b2; } }
        public byte Field0xd2b3 { get { return _field0xd2b3; } }
        public byte Field0xd2b4 { get { return _field0xd2b4; } }
        public byte Field0xd2b5 { get { return _field0xd2b5; } }
        public byte Field0xd2b6 { get { return _field0xd2b6; } }
        public byte Field0xd2b7 { get { return _field0xd2b7; } }
        public byte Field0xd2b8 { get { return _field0xd2b8; } }
        public byte Field0xd2b9 { get { return _field0xd2b9; } }
        public byte Field0xd2ba { get { return _field0xd2ba; } }
        public byte Field0xd2bb { get { return _field0xd2bb; } }
        public byte Field0xd2bc { get { return _field0xd2bc; } }
        public byte Field0xd2bd { get { return _field0xd2bd; } }
        public byte Field0xd2be { get { return _field0xd2be; } }
        public byte Field0xd2bf { get { return _field0xd2bf; } }
        public byte Field0xd2c0 { get { return _field0xd2c0; } }
        public byte Field0xd2c1 { get { return _field0xd2c1; } }
        public byte Field0xd2c2 { get { return _field0xd2c2; } }
        public byte Field0xd2c3 { get { return _field0xd2c3; } }
        public byte Field0xd2c4 { get { return _field0xd2c4; } }
        public byte Field0xd2c5 { get { return _field0xd2c5; } }
        public byte Field0xd2c6 { get { return _field0xd2c6; } }
        public byte Field0xd2c7 { get { return _field0xd2c7; } }
        public byte Field0xd2c8 { get { return _field0xd2c8; } }
        public byte Field0xd2c9 { get { return _field0xd2c9; } }
        public byte Field0xd2ca { get { return _field0xd2ca; } }
        public byte Field0xd2cb { get { return _field0xd2cb; } }
        public byte Field0xd2cc { get { return _field0xd2cc; } }
        public byte Field0xd2cd { get { return _field0xd2cd; } }
        public byte Field0xd2ce { get { return _field0xd2ce; } }
        public byte Field0xd2cf { get { return _field0xd2cf; } }
        public byte Field0xd2d0 { get { return _field0xd2d0; } }
        public byte Field0xd2d1 { get { return _field0xd2d1; } }
        public byte Field0xd2d2 { get { return _field0xd2d2; } }
        public byte Field0xd2d3 { get { return _field0xd2d3; } }
        public byte Field0xd2d4 { get { return _field0xd2d4; } }
        public byte Field0xd2d5 { get { return _field0xd2d5; } }
        public byte Field0xd2d6 { get { return _field0xd2d6; } }
        public byte Field0xd2d7 { get { return _field0xd2d7; } }
        public byte Field0xd2d8 { get { return _field0xd2d8; } }
        public byte Field0xd2d9 { get { return _field0xd2d9; } }
        public byte Field0xd2da { get { return _field0xd2da; } }
        public byte Field0xd2db { get { return _field0xd2db; } }
        public byte Field0xd2dc { get { return _field0xd2dc; } }
        public byte Field0xd2dd { get { return _field0xd2dd; } }
        public byte Field0xd2de { get { return _field0xd2de; } }
        public byte Field0xd2df { get { return _field0xd2df; } }
        public byte FixedRoomRoomIndex { get { return _fixedRoomRoomIndex; } }
        public byte Field0xd2e1 { get { return _field0xd2e1; } }
        public byte Field0xd2e2 { get { return _field0xd2e2; } }
        public byte Field0xd2e3 { get { return _field0xd2e3; } }
        public DungeonTilePtrsArray TilePtrs { get { return _tilePtrs; } }
        public byte NRooms { get { return _nRooms; } }
        public byte Field0xeee5 { get { return _field0xeee5; } }
        public byte Field0xeee6 { get { return _field0xeee6; } }
        public byte Field0xeee7 { get { return _field0xeee7; } }
        public DungeonRoomDataArray RoomData { get { return _roomData; } }
        public DungeonNaturalJunctionListCountsArray NaturalJunctionListCounts { get { return _naturalJunctionListCounts; } }
        public DungeonNaturalJunctionListArray NaturalJunctionList { get { return _naturalJunctionList; } }
        public DungeonUnknownFileBuffer0x102a8Array UnknownFileBuffer0x102a8 { get { return _unknownFileBuffer0x102a8; } }
        public DungeonUnknownTileMatrixArray UnknownTileMatrix { get { return _unknownTileMatrix; } }
        public DungeonUnknownMatrix0x1212cArray UnknownMatrix0x1212c { get { return _unknownMatrix0x1212c; } }
        public DungeonUnknownFileBuffer0x12162Array UnknownFileBuffer0x12162 { get { return _unknownFileBuffer0x12162; } }
        public DungeonUnknownArray0x12a92Array UnknownArray0x12a92 { get { return _unknownArray0x12a92; } }
        public Pointer UnkFixedRoomPointer { get { return _unkFixedRoomPointer; } }
        public byte TrapperOrbFlag { get { return _trapperOrbFlag; } }
        public byte Field0x12aa9 { get { return _field0x12aa9; } }
        public Position TrapperOrbTrapPos { get { return _trapperOrbTrapPos; } }
        public TrapId8 TrapperOrbTrapId { get { return _trapperOrbTrapId; } }
        public byte TrapperOrbTrapTeam { get { return _trapperOrbTrapTeam; } }
        public byte Field0x12ab0 { get { return _field0x12ab0; } }
        public byte Field0x12ab1 { get { return _field0x12ab1; } }
        public byte Field0x12ab2 { get { return _field0x12ab2; } }
        public byte Field0x12ab3 { get { return _field0x12ab3; } }
        public byte Field0x12ab4 { get { return _field0x12ab4; } }
        public byte Field0x12ab5 { get { return _field0x12ab5; } }
        public byte Field0x12ab6 { get { return _field0x12ab6; } }
        public byte Field0x12ab7 { get { return _field0x12ab7; } }
        public byte Field0x12ab8 { get { return _field0x12ab8; } }
        public byte Field0x12ab9 { get { return _field0x12ab9; } }
        public byte Field0x12aba { get { return _field0x12aba; } }
        public byte Field0x12abb { get { return _field0x12abb; } }
        public byte Field0x12abc { get { return _field0x12abc; } }
        public byte Field0x12abd { get { return _field0x12abd; } }
        public byte Field0x12abe { get { return _field0x12abe; } }
        public byte Field0x12abf { get { return _field0x12abf; } }
        public byte Field0x12ac0 { get { return _field0x12ac0; } }
        public byte Field0x12ac1 { get { return _field0x12ac1; } }
        public byte Field0x12ac2 { get { return _field0x12ac2; } }
        public byte Field0x12ac3 { get { return _field0x12ac3; } }
        public byte Field0x12ac4 { get { return _field0x12ac4; } }
        public byte Field0x12ac5 { get { return _field0x12ac5; } }
        public byte Field0x12ac6 { get { return _field0x12ac6; } }
        public byte Field0x12ac7 { get { return _field0x12ac7; } }
        public byte Field0x12ac8 { get { return _field0x12ac8; } }
        public byte Field0x12ac9 { get { return _field0x12ac9; } }
        public byte Field0x12aca { get { return _field0x12aca; } }
        public byte Field0x12acb { get { return _field0x12acb; } }
        public byte Field0x12acc { get { return _field0x12acc; } }
        public byte Field0x12acd { get { return _field0x12acd; } }
        public byte Field0x12ace { get { return _field0x12ace; } }
        public byte Field0x12acf { get { return _field0x12acf; } }
        public byte Field0x12ad0 { get { return _field0x12ad0; } }
        public byte Field0x12ad1 { get { return _field0x12ad1; } }
        public byte Field0x12ad2 { get { return _field0x12ad2; } }
        public byte Field0x12ad3 { get { return _field0x12ad3; } }
        public byte Field0x12ad4 { get { return _field0x12ad4; } }
        public byte Field0x12ad5 { get { return _field0x12ad5; } }
        public byte Field0x12ad6 { get { return _field0x12ad6; } }
        public byte Field0x12ad7 { get { return _field0x12ad7; } }
        public byte Field0x12ad8 { get { return _field0x12ad8; } }
        public byte Field0x12ad9 { get { return _field0x12ad9; } }
        public byte Field0x12ada { get { return _field0x12ada; } }
        public byte Field0x12adb { get { return _field0x12adb; } }
        public byte Field0x12adc { get { return _field0x12adc; } }
        public byte Field0x12add { get { return _field0x12add; } }
        public byte Field0x12ade { get { return _field0x12ade; } }
        public byte Field0x12adf { get { return _field0x12adf; } }
        public byte Field0x12ae0 { get { return _field0x12ae0; } }
        public byte Field0x12ae1 { get { return _field0x12ae1; } }
        public byte Field0x12ae2 { get { return _field0x12ae2; } }
        public byte Field0x12ae3 { get { return _field0x12ae3; } }
        public byte Field0x12ae4 { get { return _field0x12ae4; } }
        public byte Field0x12ae5 { get { return _field0x12ae5; } }
        public byte Field0x12ae6 { get { return _field0x12ae6; } }
        public byte Field0x12ae7 { get { return _field0x12ae7; } }
        public byte Field0x12ae8 { get { return _field0x12ae8; } }
        public byte Field0x12ae9 { get { return _field0x12ae9; } }
        public byte Field0x12aea { get { return _field0x12aea; } }
        public byte Field0x12aeb { get { return _field0x12aeb; } }
        public byte Field0x12aec { get { return _field0x12aec; } }
        public byte Field0x12aed { get { return _field0x12aed; } }
        public byte Field0x12aee { get { return _field0x12aee; } }
        public byte Field0x12aef { get { return _field0x12aef; } }
        public byte Field0x12af0 { get { return _field0x12af0; } }
        public byte Field0x12af1 { get { return _field0x12af1; } }
        public byte Field0x12af2 { get { return _field0x12af2; } }
        public byte Field0x12af3 { get { return _field0x12af3; } }
        public byte Field0x12af4 { get { return _field0x12af4; } }
        public byte Field0x12af5 { get { return _field0x12af5; } }
        public byte Field0x12af6 { get { return _field0x12af6; } }
        public byte Field0x12af7 { get { return _field0x12af7; } }
        public ushort AcuteSnifferItemCount { get { return _acuteSnifferItemCount; } }
        public ushort NNormalItemSpawns { get { return _nNormalItemSpawns; } }
        public byte Gravity { get { return _gravity; } }
        public byte Field0x12afd { get { return _field0x12afd; } }
        public short VictoryCounter { get { return _victoryCounter; } }
        public byte Field0x12b00 { get { return _field0x12b00; } }
        public byte Field0x12b01 { get { return _field0x12b01; } }
        public byte Field0x12b02 { get { return _field0x12b02; } }
        public byte Field0x12b03 { get { return _field0x12b03; } }
        public byte Field0x12b04 { get { return _field0x12b04; } }
        public byte Field0x12b05 { get { return _field0x12b05; } }
        public byte Field0x12b06 { get { return _field0x12b06; } }
        public byte Field0x12b07 { get { return _field0x12b07; } }
        public byte Field0x12b08 { get { return _field0x12b08; } }
        public byte Field0x12b09 { get { return _field0x12b09; } }
        public byte Field0x12b0a { get { return _field0x12b0a; } }
        public byte Field0x12b0b { get { return _field0x12b0b; } }
        public byte Field0x12b0c { get { return _field0x12b0c; } }
        public byte Field0x12b0d { get { return _field0x12b0d; } }
        public byte Field0x12b0e { get { return _field0x12b0e; } }
        public byte Field0x12b0f { get { return _field0x12b0f; } }
        public byte Field0x12b10 { get { return _field0x12b10; } }
        public byte Field0x12b11 { get { return _field0x12b11; } }
        public byte Field0x12b12 { get { return _field0x12b12; } }
        public byte Field0x12b13 { get { return _field0x12b13; } }
        public byte Field0x12b14 { get { return _field0x12b14; } }
        public byte Field0x12b15 { get { return _field0x12b15; } }
        public byte Field0x12b16 { get { return _field0x12b16; } }
        public byte Field0x12b17 { get { return _field0x12b17; } }
        public byte Field0x12b18 { get { return _field0x12b18; } }
        public byte Field0x12b19 { get { return _field0x12b19; } }
        public byte Field0x12b1a { get { return _field0x12b1a; } }
        public byte Field0x12b1b { get { return _field0x12b1b; } }
        public byte Field0x12b1c { get { return _field0x12b1c; } }
        public byte Field0x12b1d { get { return _field0x12b1d; } }
        public byte Field0x12b1e { get { return _field0x12b1e; } }
        public byte Field0x12b1f { get { return _field0x12b1f; } }
        public uint FixedRoomMonsterSpriteCounter { get { return _fixedRoomMonsterSpriteCounter; } }
        public byte BoostKecleonShopSpawnChance { get { return _boostKecleonShopSpawnChance; } }
        public byte BoostHiddenStairsSpawnChance { get { return _boostHiddenStairsSpawnChance; } }
        public byte Field0x12b26 { get { return _field0x12b26; } }
        public byte Field0x12b27 { get { return _field0x12b27; } }
        public EntityTable EntityTable { get { return _entityTable; } }
        public Pointer UnkAllyMonster1 { get { return _unkAllyMonster1; } }
        public uint UnkAllyMonsterUniqueId1 { get { return _unkAllyMonsterUniqueId1; } }
        public Pointer UnkAllyMonster2 { get { return _unkAllyMonster2; } }
        public uint UnkAllyMonsterUniqueId2 { get { return _unkAllyMonsterUniqueId2; } }
        public Pointer UnkEnemyMonster1 { get { return _unkEnemyMonster1; } }
        public uint UnkEnemyMonsterUniqueId1 { get { return _unkEnemyMonsterUniqueId1; } }
        public Pointer UnkEnemyMonster2 { get { return _unkEnemyMonster2; } }
        public uint UnkEnemyMonsterUniqueId2 { get { return _unkEnemyMonsterUniqueId2; } }
        public Pointer SnatchMonster { get { return _snatchMonster; } }
        public Pointer IlluminateSpawnEntity { get { return _illuminateSpawnEntity; } }
        public uint SnatchStatusUniqueId { get { return _snatchStatusUniqueId; } }
        public ushort IlluminateSpawnGenid { get { return _illuminateSpawnGenid; } }
        public byte Field0x19912 { get { return _field0x19912; } }
        public byte Field0x19913 { get { return _field0x19913; } }
        public DungeonSpriteIndexesArray SpriteIndexes { get { return _spriteIndexes; } }
        public byte Field0x1a21a { get { return _field0x1a21a; } }
        public byte Field0x1a21b { get { return _field0x1a21b; } }
        public DisplayData DisplayData { get { return _displayData; } }
        public MinimapDisplayData MinimapDisplayData { get { return _minimapDisplayData; } }
        public DungeonGroupAndGroupFloor GroupAndGroupFloorIdCopy { get { return _groupAndGroupFloorIdCopy; } }
        public FloorProperties FloorProperties { get { return _floorProperties; } }
        public ushort Field0x286d2 { get { return _field0x286d2; } }
        public ushort Field0x286d4 { get { return _field0x286d4; } }
        public ushort Field0x286d6 { get { return _field0x286d6; } }
        public ushort Field0x286d8 { get { return _field0x286d8; } }
        public ushort Field0x286da { get { return _field0x286da; } }
        public ushort Field0x286dc { get { return _field0x286dc; } }
        public ushort Field0x286de { get { return _field0x286de; } }
        public ushort Field0x286e0 { get { return _field0x286e0; } }
        public ushort Field0x286e2 { get { return _field0x286e2; } }
        public ushort Field0x286e4 { get { return _field0x286e4; } }
        public ushort Field0x286e6 { get { return _field0x286e6; } }
        public ushort Field0x286e8 { get { return _field0x286e8; } }
        public ushort Field0x286ea { get { return _field0x286ea; } }
        public ushort Field0x286ec { get { return _field0x286ec; } }
        public ushort Field0x286ee { get { return _field0x286ee; } }
        public ushort Field0x286f0 { get { return _field0x286f0; } }
        public DungeonRegularItemWeightsArray RegularItemWeights { get { return _regularItemWeights; } }
        public DungeonKecleonItemWeightsArray KecleonItemWeights { get { return _kecleonItemWeights; } }
        public DungeonMonsterHouseItemWeightsArray MonsterHouseItemWeights { get { return _monsterHouseItemWeights; } }
        public DungeonBuriedItemWeightsArray BuriedItemWeights { get { return _buriedItemWeights; } }
        public DungeonGrabBagItemWeightsArray GrabBagItemWeights { get { return _grabBagItemWeights; } }
        public DungeonSecretRoomItemWeightsArray SecretRoomItemWeights { get { return _secretRoomItemWeights; } }
        public DungeonTrapWeightsArray TrapWeights { get { return _trapWeights; } }
        public DungeonSpawnEntriesMasterArray SpawnEntriesMaster { get { return _spawnEntriesMaster; } }
        public ushort NumberSpritesLoaded { get { return _numberSpritesLoaded; } }
        public ushort HighestEnemyLevel { get { return _highestEnemyLevel; } }
        public ItemId16 GuaranteedItemId { get { return _guaranteedItemId; } }
        public DungeonSpawnTableEntriesChosenArray SpawnTableEntriesChosen { get { return _spawnTableEntriesChosen; } }
        public byte Field0x2ca0a { get { return _field0x2ca0a; } }
        public byte Field0x2ca0b { get { return _field0x2ca0b; } }
        public DungeonFaintedMonsterCauseEntityNameArray FaintedMonsterCauseEntityName { get { return _faintedMonsterCauseEntityName; } }
        public DungeonFaintedMonsterNameArray FaintedMonsterName { get { return _faintedMonsterName; } }
        public DungeonFallenEscortMonsterNameArray FallenEscortMonsterName { get { return _fallenEscortMonsterName; } }
        public DamageSource16 FaintedMonsterDungeonEndReason { get { return _faintedMonsterDungeonEndReason; } }
        public DungeonId8 FaintedId { get { return _faintedId; } }
        public byte FaintedFloor { get { return _faintedFloor; } }
        public Item FaintedMonsterHeldItem { get { return _faintedMonsterHeldItem; } }
        public int FaintedMonsterExp { get { return _faintedMonsterExp; } }
        public short FaintedMonsterMaxHp { get { return _faintedMonsterMaxHp; } }
        public DungeonFaintedMonsterOffensiveStatsArray FaintedMonsterOffensiveStats { get { return _faintedMonsterOffensiveStats; } }
        public DungeonFaintedMonsterDefensiveStatsArray FaintedMonsterDefensiveStats { get { return _faintedMonsterDefensiveStats; } }
        public byte FaintedMonsterLevel { get { return _faintedMonsterLevel; } }
        public byte Field0x2ca7b { get { return _field0x2ca7b; } }
        public MonsterSummary GetoutMonsterSummary { get { return _getoutMonsterSummary; } }
        public byte NFloorsPlusOne { get { return _nFloorsPlusOne; } }
        public byte Field0x2caf5 { get { return _field0x2caf5; } }
        public byte Field0x2caf6 { get { return _field0x2caf6; } }
        public byte Field0x2caf7 { get { return _field0x2caf7; } }
        public uint Field0x2caf8 { get { return _field0x2caf8; } }
        public uint Field0x2cafc { get { return _field0x2cafc; } }
        public ushort Field0x2cb00 { get { return _field0x2cb00; } }
        public ushort Field0x2cb02 { get { return _field0x2cb02; } }
        public ushort Field0x2cb04 { get { return _field0x2cb04; } }
        public MusicId16 DungeonMusicPlayingId { get { return _dungeonMusicPlayingId; } }
        public byte Field0x2cb08 { get { return _field0x2cb08; } }
        public byte Field0x2cb09 { get { return _field0x2cb09; } }
        public byte Field0x2cb0a { get { return _field0x2cb0a; } }
        public byte Field0x2cb0b { get { return _field0x2cb0b; } }
        public byte Field0x2cb0c { get { return _field0x2cb0c; } }
        public byte Field0x2cb0d { get { return _field0x2cb0d; } }
        public byte Field0x2cb0e { get { return _field0x2cb0e; } }
        public byte Field0x2cb0f { get { return _field0x2cb0f; } }
        public byte UnkCameraTracker { get { return _unkCameraTracker; } }
        public byte Field0x2cb11 { get { return _field0x2cb11; } }
        public byte Field0x2cb12 { get { return _field0x2cb12; } }
        public byte Field0x2cb13 { get { return _field0x2cb13; } }
        public Dungeon M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
