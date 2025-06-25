// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array dungeon_monster_house_item_weights defined within pmdsky.
    /// </summary>
    public partial class DungeonMonsterHouseItemWeightsArray : KaitaiStruct
    {
        public static DungeonMonsterHouseItemWeightsArray FromFile(string fileName)
        {
            return new DungeonMonsterHouseItemWeightsArray(new KaitaiStream(fileName));
        }

        public DungeonMonsterHouseItemWeightsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonMonsterHouseItemWeightsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonMonsterHouseItemWeightsArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonMonsterHouseItemWeightsArrayDim0 : KaitaiStruct
        {
            public static DungeonMonsterHouseItemWeightsArrayDim0 FromFile(string fileName)
            {
                return new DungeonMonsterHouseItemWeightsArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonMonsterHouseItemWeightsArrayDim0(KaitaiStream p__io, DungeonMonsterHouseItemWeightsArray p__parent = null, DungeonMonsterHouseItemWeightsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<ushort>();
                for (var i = 0; i < 1416; i++)
                {
                    _entries.Add(m_io.ReadU2le());
                }
            }
            private List<ushort> _entries;
            private DungeonMonsterHouseItemWeightsArray m_root;
            private DungeonMonsterHouseItemWeightsArray m_parent;
            public List<ushort> Entries { get { return _entries; } }
            public DungeonMonsterHouseItemWeightsArray M_Root { get { return m_root; } }
            public DungeonMonsterHouseItemWeightsArray M_Parent { get { return m_parent; } }
        }
        private DungeonMonsterHouseItemWeightsArrayDim0 _entries;
        private DungeonMonsterHouseItemWeightsArray m_root;
        private KaitaiStruct m_parent;
        public DungeonMonsterHouseItemWeightsArrayDim0 Entries { get { return _entries; } }
        public DungeonMonsterHouseItemWeightsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
