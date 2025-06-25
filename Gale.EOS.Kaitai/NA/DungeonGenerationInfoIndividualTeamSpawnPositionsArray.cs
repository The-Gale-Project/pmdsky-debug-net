// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array dungeon_generation_info_individual_team_spawn_positions defined within pmdsky.
    /// </summary>
    public partial class DungeonGenerationInfoIndividualTeamSpawnPositionsArray : KaitaiStruct
    {
        public static DungeonGenerationInfoIndividualTeamSpawnPositionsArray FromFile(string fileName)
        {
            return new DungeonGenerationInfoIndividualTeamSpawnPositionsArray(new KaitaiStream(fileName));
        }

        public DungeonGenerationInfoIndividualTeamSpawnPositionsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonGenerationInfoIndividualTeamSpawnPositionsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonGenerationInfoIndividualTeamSpawnPositionsArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonGenerationInfoIndividualTeamSpawnPositionsArrayDim0 : KaitaiStruct
        {
            public static DungeonGenerationInfoIndividualTeamSpawnPositionsArrayDim0 FromFile(string fileName)
            {
                return new DungeonGenerationInfoIndividualTeamSpawnPositionsArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonGenerationInfoIndividualTeamSpawnPositionsArrayDim0(KaitaiStream p__io, DungeonGenerationInfoIndividualTeamSpawnPositionsArray p__parent = null, DungeonGenerationInfoIndividualTeamSpawnPositionsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<Position>();
                for (var i = 0; i < 4; i++)
                {
                    _entries.Add(new Position(m_io));
                }
            }
            private List<Position> _entries;
            private DungeonGenerationInfoIndividualTeamSpawnPositionsArray m_root;
            private DungeonGenerationInfoIndividualTeamSpawnPositionsArray m_parent;
            public List<Position> Entries { get { return _entries; } }
            public DungeonGenerationInfoIndividualTeamSpawnPositionsArray M_Root { get { return m_root; } }
            public DungeonGenerationInfoIndividualTeamSpawnPositionsArray M_Parent { get { return m_parent; } }
        }
        private DungeonGenerationInfoIndividualTeamSpawnPositionsArrayDim0 _entries;
        private DungeonGenerationInfoIndividualTeamSpawnPositionsArray m_root;
        private KaitaiStruct m_parent;
        public DungeonGenerationInfoIndividualTeamSpawnPositionsArrayDim0 Entries { get { return _entries; } }
        public DungeonGenerationInfoIndividualTeamSpawnPositionsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
