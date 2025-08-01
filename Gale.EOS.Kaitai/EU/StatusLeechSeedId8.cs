// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Holds bitsized data for the parent enum status_leech_seed_id.
    /// </summary>
    public partial class StatusLeechSeedId8 : KaitaiStruct
    {
        public static StatusLeechSeedId8 FromFile(string fileName)
        {
            return new StatusLeechSeedId8(new KaitaiStream(fileName));
        }


        public enum StatusLeechSeedId8Enum
        {
            StatusLeechSeedNone = 0,
            StatusLeechSeedLeechSeed = 1,
            StatusLeechSeedDestinyBond = 2,
        }
        public StatusLeechSeedId8(KaitaiStream p__io, KaitaiStruct p__parent = null, StatusLeechSeedId8 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _statusLeechSeedId8Value = ((StatusLeechSeedId8Enum) m_io.ReadBitsIntLe(8));
        }
        private StatusLeechSeedId8Enum _statusLeechSeedId8Value;
        private StatusLeechSeedId8 m_root;
        private KaitaiStruct m_parent;
        public StatusLeechSeedId8Enum StatusLeechSeedId8Value { get { return _statusLeechSeedId8Value; } }
        public StatusLeechSeedId8 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
