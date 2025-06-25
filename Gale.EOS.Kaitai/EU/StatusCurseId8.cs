// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Holds bitsized data for the parent enum status_curse_id.
    /// </summary>
    public partial class StatusCurseId8 : KaitaiStruct
    {
        public static StatusCurseId8 FromFile(string fileName)
        {
            return new StatusCurseId8(new KaitaiStream(fileName));
        }


        public enum StatusCurseId8Enum
        {
            StatusCurseNone = 0,
            StatusCurseCursed = 1,
            StatusCurseDecoy = 2,
            StatusCurseSnatch = 3,
            StatusCurseGastroAcid = 4,
            StatusCurseHealBlock = 5,
            StatusCurseEmbargo = 6,
        }
        public StatusCurseId8(KaitaiStream p__io, KaitaiStruct p__parent = null, StatusCurseId8 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _statusCurseId8Value = ((StatusCurseId8Enum) m_io.ReadBitsIntLe(8));
        }
        private StatusCurseId8Enum _statusCurseId8Value;
        private StatusCurseId8 m_root;
        private KaitaiStruct m_parent;
        public StatusCurseId8Enum StatusCurseId8Value { get { return _statusCurseId8Value; } }
        public StatusCurseId8 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
