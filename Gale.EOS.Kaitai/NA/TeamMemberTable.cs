// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union team_member_table defined within pmdsky-debug.
    /// </summary>
    public partial class TeamMemberTable : KaitaiStruct
    {
        public static TeamMemberTable FromFile(string fileName)
        {
            return new TeamMemberTable(new KaitaiStream(fileName));
        }

        public TeamMemberTable(KaitaiStream p__io, KaitaiStruct p__parent = null, TeamMemberTable p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _members = new TeamMemberTableMembersArray(m_io);
            _activeTeamRosters = new TeamMemberTableActiveTeamRostersArray(m_io);
            _activeRoster = new Pointer(m_io);
            _numberActiveTeamMembersMain = m_io.ReadS2le();
            _numberActiveTeamMembersSe = m_io.ReadS2le();
            _numberActiveTeamMembersRescue = m_io.ReadS2le();
            _activeTeamRosterMemberIdxs = new TeamMemberTableActiveTeamRosterMemberIdxsArray(m_io);
            _field0x986e = m_io.ReadU1();
            _field0x986f = m_io.ReadU1();
            _activeRosterMemberIdxs = new Pointer(m_io);
            _field0x9874 = m_io.ReadU1();
            _field0x9875 = m_io.ReadU1();
            _field0x9876 = m_io.ReadU1();
            _activeTeam = new TeamId8(m_io);
            _field0x9878 = m_io.ReadU4le();
            _field0x987c = m_io.ReadU4le();
            _explorerMazeTeamNativeLanguage = m_io.ReadS1();
            _field0x9881 = m_io.ReadU1();
            _explorerMazeTeamName = new TeamMemberTableExplorerMazeTeamNameArray(m_io);
            _field0x9896 = m_io.ReadU1();
            _field0x9897 = m_io.ReadU1();
            _explorerMazeMonsters = new TeamMemberTableExplorerMazeMonstersArray(m_io);
        }
        private TeamMemberTableMembersArray _members;
        private TeamMemberTableActiveTeamRostersArray _activeTeamRosters;
        private Pointer _activeRoster;
        private short _numberActiveTeamMembersMain;
        private short _numberActiveTeamMembersSe;
        private short _numberActiveTeamMembersRescue;
        private TeamMemberTableActiveTeamRosterMemberIdxsArray _activeTeamRosterMemberIdxs;
        private byte _field0x986e;
        private byte _field0x986f;
        private Pointer _activeRosterMemberIdxs;
        private byte _field0x9874;
        private byte _field0x9875;
        private byte _field0x9876;
        private TeamId8 _activeTeam;
        private uint _field0x9878;
        private uint _field0x987c;
        private sbyte _explorerMazeTeamNativeLanguage;
        private byte _field0x9881;
        private TeamMemberTableExplorerMazeTeamNameArray _explorerMazeTeamName;
        private byte _field0x9896;
        private byte _field0x9897;
        private TeamMemberTableExplorerMazeMonstersArray _explorerMazeMonsters;
        private TeamMemberTable m_root;
        private KaitaiStruct m_parent;
        public TeamMemberTableMembersArray Members { get { return _members; } }
        public TeamMemberTableActiveTeamRostersArray ActiveTeamRosters { get { return _activeTeamRosters; } }
        public Pointer ActiveRoster { get { return _activeRoster; } }
        public short NumberActiveTeamMembersMain { get { return _numberActiveTeamMembersMain; } }
        public short NumberActiveTeamMembersSe { get { return _numberActiveTeamMembersSe; } }
        public short NumberActiveTeamMembersRescue { get { return _numberActiveTeamMembersRescue; } }
        public TeamMemberTableActiveTeamRosterMemberIdxsArray ActiveTeamRosterMemberIdxs { get { return _activeTeamRosterMemberIdxs; } }
        public byte Field0x986e { get { return _field0x986e; } }
        public byte Field0x986f { get { return _field0x986f; } }
        public Pointer ActiveRosterMemberIdxs { get { return _activeRosterMemberIdxs; } }
        public byte Field0x9874 { get { return _field0x9874; } }
        public byte Field0x9875 { get { return _field0x9875; } }
        public byte Field0x9876 { get { return _field0x9876; } }
        public TeamId8 ActiveTeam { get { return _activeTeam; } }
        public uint Field0x9878 { get { return _field0x9878; } }
        public uint Field0x987c { get { return _field0x987c; } }
        public sbyte ExplorerMazeTeamNativeLanguage { get { return _explorerMazeTeamNativeLanguage; } }
        public byte Field0x9881 { get { return _field0x9881; } }
        public TeamMemberTableExplorerMazeTeamNameArray ExplorerMazeTeamName { get { return _explorerMazeTeamName; } }
        public byte Field0x9896 { get { return _field0x9896; } }
        public byte Field0x9897 { get { return _field0x9897; } }
        public TeamMemberTableExplorerMazeMonstersArray ExplorerMazeMonsters { get { return _explorerMazeMonsters; } }
        public TeamMemberTable M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
