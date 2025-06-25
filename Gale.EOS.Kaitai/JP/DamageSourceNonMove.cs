// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Holds the data for the enum damage_source_non_move.
    /// </summary>
    public partial class DamageSourceNonMove : KaitaiStruct
    {
        public static DamageSourceNonMove FromFile(string fileName)
        {
            return new DamageSourceNonMove(new KaitaiStream(fileName));
        }


        public enum DamageSourceNonMoveEnum
        {
            DamageSourceTransformFriend = 563,
            DamageSourceNotBefriended = 564,
            DamageSourceDebugAttack = 565,
            DamageSourceJumpKick = 566,
            DamageSourceHiJumpKick = 567,
            DamageSourceDestinyBond = 568,
            DamageSourceSludge = 569,
            DamageSourcePowerfulMove1 = 570,
            DamageSourcePowerfulMove2 = 571,
            DamageSourceRecoil = 572,
            DamageSourceSplash = 573,
            DamageSourceEnergy = 574,
            DamageSourcePowerfulMove3 = 575,
            DamageSourcePowerfulMove4 = 576,
            DamageSourcePowerfulMove5 = 577,
            DamageSourcePowerfulMove6 = 578,
            DamageSourcePowerfulMove7 = 579,
            DamageSourcePowerfulMove8 = 580,
            DamageSourceSpikes = 581,
            DamageSourceDebugDamage = 582,
            DamageSourceBurn = 583,
            DamageSourceConstriction = 584,
            DamageSourcePoison = 585,
            DamageSourceWrap = 586,
            DamageSourceCurse = 587,
            DamageSourceLeechSeed = 588,
            DamageSourcePerishSong = 589,
            DamageSourceNightmare = 590,
            DamageSourceThrownRock = 591,
            DamageSourceHunger = 592,
            DamageSourceExploded = 593,
            DamageSourceChestnutTrap = 594,
            DamageSourceTrap = 595,
            DamageSourcePitfallTrap = 596,
            DamageSourceBlastSeed = 597,
            DamageSourceThrownItem = 598,
            DamageSourceTransformItem = 599,
            DamageSourceKnockedFlying = 600,
            DamageSourceFlyingMonster = 601,
            DamageSourceGaveUp = 602,
            DamageSourceDeleted = 603,
            DamageSourceWentAway = 604,
            DamageSourceUnseenForce = 605,
            DamageSourcePartnerFainted = 606,
            DamageSourceWeather = 607,
            DamageSourcePossess = 608,
            DamageSourceClientFainted = 609,
            DamageSourceItemOrb = 610,
            DamageSourceItemNonOrb = 611,
            DamageSourceUnk612 = 612,
            DamageSourceEscortFainted = 613,
            DamageSourceOtherMonsterFainted = 614,
            DamageSourceBidoofFainted = 615,
            DamageSourceGrovyleFainted = 616,
            DamageSourceCelebiFainted = 617,
            DamageSourceChatotFainted = 618,
            DamageSourceCresseliaFainted = 619,
            DamageSourceToxicSpikes = 620,
            DamageSourceStealthRock = 621,
            DamageSourceBadDreams = 622,
            DamageSourceExplosion = 623,
            DamageSourceOrenBerry = 624,
            DamageSourceDummy625 = 625,
            DamageSourceDummy626 = 626,
            DamageSourceDummy627 = 627,
            DamageSourceDummy628 = 628,
            DamageSourceDummy629 = 629,
            DamageSourceDummy630 = 630,
            DamageSourceDummy631 = 631,
            DamageSourceDummy632 = 632,
            DamageSourceEscape = 633,
            DamageSourceDungeonClear = 634,
            DamageSourceRescueSuccess = 635,
            DamageSourceMissionComplete = 636,
            DamageSourceBefriendMew = 637,
        }
        public DamageSourceNonMove(KaitaiStream p__io, KaitaiStruct p__parent = null, DamageSourceNonMove p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _damageSourceNonMoveValue = ((DamageSourceNonMoveEnum) m_io.ReadBitsIntLe(32));
        }
        private DamageSourceNonMoveEnum _damageSourceNonMoveValue;
        private DamageSourceNonMove m_root;
        private KaitaiStruct m_parent;
        public DamageSourceNonMoveEnum DamageSourceNonMoveValue { get { return _damageSourceNonMoveValue; } }
        public DamageSourceNonMove M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
