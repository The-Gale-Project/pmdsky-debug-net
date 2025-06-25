// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union partner_talk_kind_table_entry defined within pmdsky-debug.
    /// </summary>
    public partial class PartnerTalkKindTableEntry : KaitaiStruct
    {
        public static PartnerTalkKindTableEntry FromFile(string fileName)
        {
            return new PartnerTalkKindTableEntry(new KaitaiStream(fileName));
        }

        public PartnerTalkKindTableEntry(KaitaiStream p__io, KaitaiStruct p__parent = null, PartnerTalkKindTableEntry p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _talkKind = new TalkKind(m_io);
            _id = new MonsterId(m_io);
        }
        private TalkKind _talkKind;
        private MonsterId _id;
        private PartnerTalkKindTableEntry m_root;
        private KaitaiStruct m_parent;
        public TalkKind TalkKind { get { return _talkKind; } }
        public MonsterId Id { get { return _id; } }
        public PartnerTalkKindTableEntry M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
