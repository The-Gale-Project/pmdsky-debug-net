// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Holds the data for the enum forced_loss_reason.
    /// </summary>
    public partial class ForcedLossReason : KaitaiStruct
    {
        public static ForcedLossReason FromFile(string fileName)
        {
            return new ForcedLossReason(new KaitaiStream(fileName));
        }


        public enum ForcedLossReasonEnum
        {
            ForcedLossNone = 0,
            ForcedLossPartnerFainted = 1,
            ForcedLossClientFainted = 2,
            ForcedLossEscortFainted = 3,
            ForcedLossClientCantJoin = 4,
        }
        public ForcedLossReason(KaitaiStream p__io, KaitaiStruct p__parent = null, ForcedLossReason p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _forcedLossReasonValue = ((ForcedLossReasonEnum) m_io.ReadBitsIntLe(32));
        }
        private ForcedLossReasonEnum _forcedLossReasonValue;
        private ForcedLossReason m_root;
        private KaitaiStruct m_parent;
        public ForcedLossReasonEnum ForcedLossReasonValue { get { return _forcedLossReasonValue; } }
        public ForcedLossReason M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
