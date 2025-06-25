// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Holds bitsized data for the parent enum move_target.
    /// </summary>
    public partial class MoveTarget4 : KaitaiStruct
    {
        public static MoveTarget4 FromFile(string fileName)
        {
            return new MoveTarget4(new KaitaiStream(fileName));
        }


        public enum MoveTarget4Enum
        {
            TargetEnemies = 0,
            TargetParty = 1,
            TargetAll = 2,
            TargetUser = 3,
            TargetEnemiesAfterCharging = 4,
            TargetAllExceptUser = 5,
            TargetTeammates = 6,
            TargetSpecial = 15,
        }
        public MoveTarget4(KaitaiStream p__io, KaitaiStruct p__parent = null, MoveTarget4 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _moveTarget4Value = ((MoveTarget4Enum) m_io.ReadBitsIntLe(4));
        }
        private MoveTarget4Enum _moveTarget4Value;
        private MoveTarget4 m_root;
        private KaitaiStruct m_parent;
        public MoveTarget4Enum MoveTarget4Value { get { return _moveTarget4Value; } }
        public MoveTarget4 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
