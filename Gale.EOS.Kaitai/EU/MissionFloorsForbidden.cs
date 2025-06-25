// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union mission_floors_forbidden defined within pmdsky-debug.
    /// </summary>
    public partial class MissionFloorsForbidden : KaitaiStruct
    {
        public static MissionFloorsForbidden FromFile(string fileName)
        {
            return new MissionFloorsForbidden(new KaitaiStream(fileName));
        }

        public MissionFloorsForbidden(KaitaiStream p__io, KaitaiStruct p__parent = null, MissionFloorsForbidden p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _field0x0 = m_io.ReadU1();
            _field0x1 = m_io.ReadU1();
        }
        private byte _field0x0;
        private byte _field0x1;
        private MissionFloorsForbidden m_root;
        private KaitaiStruct m_parent;
        public byte Field0x0 { get { return _field0x0; } }
        public byte Field0x1 { get { return _field0x1; } }
        public MissionFloorsForbidden M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
