// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Holds bitsized data for the parent enum status_long_toss_id.
    /// </summary>
    public partial class StatusLongTossId8 : KaitaiStruct
    {
        public static StatusLongTossId8 FromFile(string fileName)
        {
            return new StatusLongTossId8(new KaitaiStream(fileName));
        }


        public enum StatusLongTossId8Enum
        {
            StatusLongTossNone = 0,
            StatusLongTossLongToss = 1,
            StatusLongTossPierce = 2,
        }
        public StatusLongTossId8(KaitaiStream p__io, KaitaiStruct p__parent = null, StatusLongTossId8 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _statusLongTossId8Value = ((StatusLongTossId8Enum) m_io.ReadBitsIntLe(8));
        }
        private StatusLongTossId8Enum _statusLongTossId8Value;
        private StatusLongTossId8 m_root;
        private KaitaiStruct m_parent;
        public StatusLongTossId8Enum StatusLongTossId8Value { get { return _statusLongTossId8Value; } }
        public StatusLongTossId8 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
