// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array mission_destination_info_enemy_species defined within pmdsky.
    /// </summary>
    public partial class MissionDestinationInfoEnemySpeciesArray : KaitaiStruct
    {
        public static MissionDestinationInfoEnemySpeciesArray FromFile(string fileName)
        {
            return new MissionDestinationInfoEnemySpeciesArray(new KaitaiStream(fileName));
        }

        public MissionDestinationInfoEnemySpeciesArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MissionDestinationInfoEnemySpeciesArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MissionDestinationInfoEnemySpeciesArrayDim0(m_io, this, m_root);
        }
        public partial class MissionDestinationInfoEnemySpeciesArrayDim0 : KaitaiStruct
        {
            public static MissionDestinationInfoEnemySpeciesArrayDim0 FromFile(string fileName)
            {
                return new MissionDestinationInfoEnemySpeciesArrayDim0(new KaitaiStream(fileName));
            }

            public MissionDestinationInfoEnemySpeciesArrayDim0(KaitaiStream p__io, MissionDestinationInfoEnemySpeciesArray p__parent = null, MissionDestinationInfoEnemySpeciesArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<MonsterId16>();
                for (var i = 0; i < 3; i++)
                {
                    _entries.Add(new MonsterId16(m_io));
                }
            }
            private List<MonsterId16> _entries;
            private MissionDestinationInfoEnemySpeciesArray m_root;
            private MissionDestinationInfoEnemySpeciesArray m_parent;
            public List<MonsterId16> Entries { get { return _entries; } }
            public MissionDestinationInfoEnemySpeciesArray M_Root { get { return m_root; } }
            public MissionDestinationInfoEnemySpeciesArray M_Parent { get { return m_parent; } }
        }
        private MissionDestinationInfoEnemySpeciesArrayDim0 _entries;
        private MissionDestinationInfoEnemySpeciesArray m_root;
        private KaitaiStruct m_parent;
        public MissionDestinationInfoEnemySpeciesArrayDim0 Entries { get { return _entries; } }
        public MissionDestinationInfoEnemySpeciesArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
