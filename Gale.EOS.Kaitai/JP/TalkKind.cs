// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Holds the data for the enum talk_kind.
    /// </summary>
    public partial class TalkKind : KaitaiStruct
    {
        public static TalkKind FromFile(string fileName)
        {
            return new TalkKind(new KaitaiStream(fileName));
        }


        public enum TalkKindEnum
        {
            TalkNone = 0,
            TalkPartnerMaleSpecial = 1,
            TalkPartnerDefault = 2,
            TalkPartnerFemaleSpecial = 3,
            TalkHeroMale = 4,
            TalkHeroFemale = 5,
        }
        public TalkKind(KaitaiStream p__io, KaitaiStruct p__parent = null, TalkKind p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _talkKindValue = ((TalkKindEnum) m_io.ReadBitsIntLe(32));
        }
        private TalkKindEnum _talkKindValue;
        private TalkKind m_root;
        private KaitaiStruct m_parent;
        public TalkKindEnum TalkKindValue { get { return _talkKindValue; } }
        public TalkKind M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
