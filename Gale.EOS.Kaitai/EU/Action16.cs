// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Holds bitsized data for the parent enum action.
    /// </summary>
    public partial class Action16 : KaitaiStruct
    {
        public static Action16 FromFile(string fileName)
        {
            return new Action16(new KaitaiStream(fileName));
        }


        public enum Action16Enum
        {
            ActionNothing = 0,
            ActionPassTurn = 1,
            ActionWalk = 2,
            ActionUnk3 = 3,
            ActionUnk4 = 4,
            ActionUnk5 = 5,
            ActionNext = 6,
            ActionPrevious = 7,
            ActionPlaceItem = 8,
            ActionPickUpPlayer = 9,
            ActionUnkA = 10,
            ActionThrowItemPlayer = 11,
            ActionCheckItemDescription = 12,
            ActionEatBerrySeedDrink = 13,
            ActionEatGummi = 14,
            ActionUnkF = 15,
            ActionUseTm = 16,
            ActionUnk11 = 17,
            ActionUseItem = 18,
            ActionTalkField = 19,
            ActionUseMovePlayer = 20,
            ActionUseMoveAi = 21,
            ActionUnk16 = 22,
            ActionStruggle = 23,
            ActionUnk18 = 24,
            ActionCheckMoves = 25,
            ActionChangeTactics = 26,
            ActionCheckSummary = 27,
            ActionTalkMenu = 28,
            ActionUnk1d = 29,
            ActionSetMove = 30,
            ActionSwitchMove = 31,
            ActionUnk20 = 32,
            ActionUnk21 = 33,
            ActionUnk22 = 34,
            ActionEatAi = 35,
            ActionThrowItemAi = 36,
            ActionUnk25 = 37,
            ActionUseStairs = 38,
            ActionThrowStraightPlayer = 39,
            ActionUnk28 = 40,
            ActionUnk29 = 41,
            ActionUnk2a = 42,
            ActionQuicksave = 43,
            ActionUseLinkBox = 44,
            ActionUnk2d = 45,
            ActionGiveUp = 46,
            ActionUnk2f = 47,
            ActionViewIq = 48,
            ActionUseOrb = 49,
            ActionRegularAttack = 50,
            ActionUnsetMove = 51,
            ActionSendHome = 52,
            ActionUnk35 = 53,
            ActionGiveItem = 54,
            ActionTakeItem = 55,
            ActionUnk38 = 56,
            ActionSecondThoughts = 57,
            ActionSwapItem = 58,
            ActionChangeLeader = 59,
            ActionSetItem = 60,
            ActionUnsetItem = 61,
            ActionUnk3e = 62,
            ActionPickUpAi = 63,
            ActionUnk40 = 64,
            ActionThrowArcPlayer = 65,
        }
        public Action16(KaitaiStream p__io, KaitaiStruct p__parent = null, Action16 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _action16Value = ((Action16Enum) m_io.ReadBitsIntLe(16));
        }
        private Action16Enum _action16Value;
        private Action16 m_root;
        private KaitaiStruct m_parent;
        public Action16Enum Action16Value { get { return _action16Value; } }
        public Action16 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
