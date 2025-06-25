// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Holds bitsized data for the parent enum status_sleep_id.
    /// </summary>
    public partial class StatusSleepId8 : KaitaiStruct
    {
        public static StatusSleepId8 FromFile(string fileName)
        {
            return new StatusSleepId8(new KaitaiStream(fileName));
        }


        public enum StatusSleepId8Enum
        {
            StatusSleepNone = 0,
            StatusSleepSleep = 1,
            StatusSleepSleepless = 2,
            StatusSleepNightmare = 3,
            StatusSleepYawning = 4,
            StatusSleepNapping = 5,
        }
        public StatusSleepId8(KaitaiStream p__io, KaitaiStruct p__parent = null, StatusSleepId8 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _statusSleepId8Value = ((StatusSleepId8Enum) m_io.ReadBitsIntLe(8));
        }
        private StatusSleepId8Enum _statusSleepId8Value;
        private StatusSleepId8 m_root;
        private KaitaiStruct m_parent;
        public StatusSleepId8Enum StatusSleepId8Value { get { return _statusSleepId8Value; } }
        public StatusSleepId8 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
