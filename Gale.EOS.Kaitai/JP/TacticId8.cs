// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Holds bitsized data for the parent enum tactic_id.
    /// </summary>
    public partial class TacticId8 : KaitaiStruct
    {
        public static TacticId8 FromFile(string fileName)
        {
            return new TacticId8(new KaitaiStream(fileName));
        }


        public enum TacticId8Enum
        {
            TacticLetsGoTogether = 0,
            TacticYouGoTheOtherWay = 1,
            TacticGoAfterFoes = 2,
            TacticAvoidTheFirstHit = 3,
            TacticAllForOne = 4,
            TacticGroupSafety = 5,
            TacticAvoidTrouble = 6,
            TacticBePatient = 7,
            TacticKeepYourDistance = 8,
            TacticWaitThere = 9,
            TacticGetAwayFromHere = 10,
            TacticNone = 11,
        }
        public TacticId8(KaitaiStream p__io, KaitaiStruct p__parent = null, TacticId8 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _tacticId8Value = ((TacticId8Enum) m_io.ReadBitsIntLe(8));
        }
        private TacticId8Enum _tacticId8Value;
        private TacticId8 m_root;
        private KaitaiStruct m_parent;
        public TacticId8Enum TacticId8Value { get { return _tacticId8Value; } }
        public TacticId8 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
