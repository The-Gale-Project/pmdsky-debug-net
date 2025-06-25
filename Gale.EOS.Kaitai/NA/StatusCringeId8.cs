// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Holds bitsized data for the parent enum status_cringe_id.
    /// </summary>
    public partial class StatusCringeId8 : KaitaiStruct
    {
        public static StatusCringeId8 FromFile(string fileName)
        {
            return new StatusCringeId8(new KaitaiStream(fileName));
        }


        public enum StatusCringeId8Enum
        {
            StatusCringeNone = 0,
            StatusCringeCringe = 1,
            StatusCringeConfused = 2,
            StatusCringePaused = 3,
            StatusCringeCowering = 4,
            StatusCringeTaunted = 5,
            StatusCringeEncore = 6,
            StatusCringeInfatuated = 7,
        }
        public StatusCringeId8(KaitaiStream p__io, KaitaiStruct p__parent = null, StatusCringeId8 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _statusCringeId8Value = ((StatusCringeId8Enum) m_io.ReadBitsIntLe(8));
        }
        private StatusCringeId8Enum _statusCringeId8Value;
        private StatusCringeId8 m_root;
        private KaitaiStruct m_parent;
        public StatusCringeId8Enum StatusCringeId8Value { get { return _statusCringeId8Value; } }
        public StatusCringeId8 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
