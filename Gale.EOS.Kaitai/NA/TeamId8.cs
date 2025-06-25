// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Holds bitsized data for the parent enum team_id.
    /// </summary>
    public partial class TeamId8 : KaitaiStruct
    {
        public static TeamId8 FromFile(string fileName)
        {
            return new TeamId8(new KaitaiStream(fileName));
        }


        public enum TeamId8Enum
        {
            TeamMain = 0,
            TeamSpecialEpisode = 1,
            TeamRescue = 2,
        }
        public TeamId8(KaitaiStream p__io, KaitaiStruct p__parent = null, TeamId8 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _teamId8Value = ((TeamId8Enum) m_io.ReadBitsIntLe(8));
        }
        private TeamId8Enum _teamId8Value;
        private TeamId8 m_root;
        private KaitaiStruct m_parent;
        public TeamId8Enum TeamId8Value { get { return _teamId8Value; } }
        public TeamId8 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
