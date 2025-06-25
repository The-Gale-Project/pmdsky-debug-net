// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Holds bitsized data for the parent enum status_two_turn_id.
    /// </summary>
    public partial class StatusTwoTurnId8 : KaitaiStruct
    {
        public static StatusTwoTurnId8 FromFile(string fileName)
        {
            return new StatusTwoTurnId8(new KaitaiStream(fileName));
        }


        public enum StatusTwoTurnId8Enum
        {
            StatusTwoTurnNone = 0,
            StatusTwoTurnBide = 1,
            StatusTwoTurnSolarbeam = 2,
            StatusTwoTurnSkyAttack = 3,
            StatusTwoTurnRazorWind = 4,
            StatusTwoTurnFocusPunch = 5,
            StatusTwoTurnSkullBash = 6,
            StatusTwoTurnFlying = 7,
            StatusTwoTurnBouncing = 8,
            StatusTwoTurnDiving = 9,
            StatusTwoTurnDigging = 10,
            StatusTwoTurnCharging = 11,
            StatusTwoTurnEnraged = 12,
            StatusTwoTurnShadowForce = 13,
        }
        public StatusTwoTurnId8(KaitaiStream p__io, KaitaiStruct p__parent = null, StatusTwoTurnId8 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _statusTwoTurnId8Value = ((StatusTwoTurnId8Enum) m_io.ReadBitsIntLe(8));
        }
        private StatusTwoTurnId8Enum _statusTwoTurnId8Value;
        private StatusTwoTurnId8 m_root;
        private KaitaiStruct m_parent;
        public StatusTwoTurnId8Enum StatusTwoTurnId8Value { get { return _statusTwoTurnId8Value; } }
        public StatusTwoTurnId8 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
