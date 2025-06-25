// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array dungeon_shopkeeper_spawns defined within pmdsky.
    /// </summary>
    public partial class DungeonShopkeeperSpawnsArray : KaitaiStruct
    {
        public static DungeonShopkeeperSpawnsArray FromFile(string fileName)
        {
            return new DungeonShopkeeperSpawnsArray(new KaitaiStream(fileName));
        }

        public DungeonShopkeeperSpawnsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonShopkeeperSpawnsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonShopkeeperSpawnsArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonShopkeeperSpawnsArrayDim0 : KaitaiStruct
        {
            public static DungeonShopkeeperSpawnsArrayDim0 FromFile(string fileName)
            {
                return new DungeonShopkeeperSpawnsArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonShopkeeperSpawnsArrayDim0(KaitaiStream p__io, DungeonShopkeeperSpawnsArray p__parent = null, DungeonShopkeeperSpawnsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<SpawnedShopkeeperData>();
                for (var i = 0; i < 8; i++)
                {
                    _entries.Add(new SpawnedShopkeeperData(m_io));
                }
            }
            private List<SpawnedShopkeeperData> _entries;
            private DungeonShopkeeperSpawnsArray m_root;
            private DungeonShopkeeperSpawnsArray m_parent;
            public List<SpawnedShopkeeperData> Entries { get { return _entries; } }
            public DungeonShopkeeperSpawnsArray M_Root { get { return m_root; } }
            public DungeonShopkeeperSpawnsArray M_Parent { get { return m_parent; } }
        }
        private DungeonShopkeeperSpawnsArrayDim0 _entries;
        private DungeonShopkeeperSpawnsArray m_root;
        private KaitaiStruct m_parent;
        public DungeonShopkeeperSpawnsArrayDim0 Entries { get { return _entries; } }
        public DungeonShopkeeperSpawnsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
