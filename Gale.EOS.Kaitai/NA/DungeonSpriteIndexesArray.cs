// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array dungeon_sprite_indexes defined within pmdsky.
    /// </summary>
    public partial class DungeonSpriteIndexesArray : KaitaiStruct
    {
        public static DungeonSpriteIndexesArray FromFile(string fileName)
        {
            return new DungeonSpriteIndexesArray(new KaitaiStream(fileName));
        }

        public DungeonSpriteIndexesArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonSpriteIndexesArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonSpriteIndexesArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonSpriteIndexesArrayDim0 : KaitaiStruct
        {
            public static DungeonSpriteIndexesArrayDim0 FromFile(string fileName)
            {
                return new DungeonSpriteIndexesArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonSpriteIndexesArrayDim0(KaitaiStream p__io, DungeonSpriteIndexesArray p__parent = null, DungeonSpriteIndexesArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<MonsterId16>();
                for (var i = 0; i < 1155; i++)
                {
                    _entries.Add(new MonsterId16(m_io));
                }
            }
            private List<MonsterId16> _entries;
            private DungeonSpriteIndexesArray m_root;
            private DungeonSpriteIndexesArray m_parent;
            public List<MonsterId16> Entries { get { return _entries; } }
            public DungeonSpriteIndexesArray M_Root { get { return m_root; } }
            public DungeonSpriteIndexesArray M_Parent { get { return m_parent; } }
        }
        private DungeonSpriteIndexesArrayDim0 _entries;
        private DungeonSpriteIndexesArray m_root;
        private KaitaiStruct m_parent;
        public DungeonSpriteIndexesArrayDim0 Entries { get { return _entries; } }
        public DungeonSpriteIndexesArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
