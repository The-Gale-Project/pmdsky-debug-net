// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array dungeon_unk_team_direction_array defined within pmdsky.
    /// </summary>
    public partial class DungeonUnkTeamDirectionArrayArray : KaitaiStruct
    {
        public static DungeonUnkTeamDirectionArrayArray FromFile(string fileName)
        {
            return new DungeonUnkTeamDirectionArrayArray(new KaitaiStream(fileName));
        }

        public DungeonUnkTeamDirectionArrayArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonUnkTeamDirectionArrayArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonUnkTeamDirectionArrayArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonUnkTeamDirectionArrayArrayDim0 : KaitaiStruct
        {
            public static DungeonUnkTeamDirectionArrayArrayDim0 FromFile(string fileName)
            {
                return new DungeonUnkTeamDirectionArrayArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonUnkTeamDirectionArrayArrayDim0(KaitaiStream p__io, DungeonUnkTeamDirectionArrayArray p__parent = null, DungeonUnkTeamDirectionArrayArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<DirectionId8>();
                for (var i = 0; i < 8; i++)
                {
                    _entries.Add(new DirectionId8(m_io));
                }
            }
            private List<DirectionId8> _entries;
            private DungeonUnkTeamDirectionArrayArray m_root;
            private DungeonUnkTeamDirectionArrayArray m_parent;
            public List<DirectionId8> Entries { get { return _entries; } }
            public DungeonUnkTeamDirectionArrayArray M_Root { get { return m_root; } }
            public DungeonUnkTeamDirectionArrayArray M_Parent { get { return m_parent; } }
        }
        private DungeonUnkTeamDirectionArrayArrayDim0 _entries;
        private DungeonUnkTeamDirectionArrayArray m_root;
        private KaitaiStruct m_parent;
        public DungeonUnkTeamDirectionArrayArrayDim0 Entries { get { return _entries; } }
        public DungeonUnkTeamDirectionArrayArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
