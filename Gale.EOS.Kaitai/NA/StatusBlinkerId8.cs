// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Holds bitsized data for the parent enum status_blinker_id.
    /// </summary>
    public partial class StatusBlinkerId8 : KaitaiStruct
    {
        public static StatusBlinkerId8 FromFile(string fileName)
        {
            return new StatusBlinkerId8(new KaitaiStream(fileName));
        }


        public enum StatusBlinkerId8Enum
        {
            StatusBlinkerNone = 0,
            StatusBlinkerBlinker = 1,
            StatusBlinkerCrossEyed = 2,
            StatusBlinkerEyedrops = 3,
            StatusBlinkerDropeye = 4,
        }
        public StatusBlinkerId8(KaitaiStream p__io, KaitaiStruct p__parent = null, StatusBlinkerId8 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _statusBlinkerId8Value = ((StatusBlinkerId8Enum) m_io.ReadBitsIntLe(8));
        }
        private StatusBlinkerId8Enum _statusBlinkerId8Value;
        private StatusBlinkerId8 m_root;
        private KaitaiStruct m_parent;
        public StatusBlinkerId8Enum StatusBlinkerId8Value { get { return _statusBlinkerId8Value; } }
        public StatusBlinkerId8 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
