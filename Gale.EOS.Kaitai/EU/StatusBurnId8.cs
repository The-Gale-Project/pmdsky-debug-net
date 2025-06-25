// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Holds bitsized data for the parent enum status_burn_id.
    /// </summary>
    public partial class StatusBurnId8 : KaitaiStruct
    {
        public static StatusBurnId8 FromFile(string fileName)
        {
            return new StatusBurnId8(new KaitaiStream(fileName));
        }


        public enum StatusBurnId8Enum
        {
            StatusBurnNone = 0,
            StatusBurnBurn = 1,
            StatusBurnPoisoned = 2,
            StatusBurnBadlyPoisoned = 3,
            StatusBurnParalysis = 4,
        }
        public StatusBurnId8(KaitaiStream p__io, KaitaiStruct p__parent = null, StatusBurnId8 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _statusBurnId8Value = ((StatusBurnId8Enum) m_io.ReadBitsIntLe(8));
        }
        private StatusBurnId8Enum _statusBurnId8Value;
        private StatusBurnId8 m_root;
        private KaitaiStruct m_parent;
        public StatusBurnId8Enum StatusBurnId8Value { get { return _statusBurnId8Value; } }
        public StatusBurnId8 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
