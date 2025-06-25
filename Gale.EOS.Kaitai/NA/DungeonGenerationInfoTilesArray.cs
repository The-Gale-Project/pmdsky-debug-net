// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array dungeon_generation_info_tiles defined within pmdsky.
    /// </summary>
    public partial class DungeonGenerationInfoTilesArray : KaitaiStruct
    {
        public static DungeonGenerationInfoTilesArray FromFile(string fileName)
        {
            return new DungeonGenerationInfoTilesArray(new KaitaiStream(fileName));
        }

        public DungeonGenerationInfoTilesArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonGenerationInfoTilesArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonGenerationInfoTilesArrayDim1(m_io, this, m_root);
        }
        public partial class DungeonGenerationInfoTilesArrayDim0 : KaitaiStruct
        {
            public static DungeonGenerationInfoTilesArrayDim0 FromFile(string fileName)
            {
                return new DungeonGenerationInfoTilesArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonGenerationInfoTilesArrayDim0(KaitaiStream p__io, DungeonGenerationInfoTilesArray.DungeonGenerationInfoTilesArrayDim1 p__parent = null, DungeonGenerationInfoTilesArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<Tile>();
                for (var i = 0; i < 56; i++)
                {
                    _entries.Add(new Tile(m_io));
                }
            }
            private List<Tile> _entries;
            private DungeonGenerationInfoTilesArray m_root;
            private DungeonGenerationInfoTilesArray.DungeonGenerationInfoTilesArrayDim1 m_parent;
            public List<Tile> Entries { get { return _entries; } }
            public DungeonGenerationInfoTilesArray M_Root { get { return m_root; } }
            public DungeonGenerationInfoTilesArray.DungeonGenerationInfoTilesArrayDim1 M_Parent { get { return m_parent; } }
        }
        public partial class DungeonGenerationInfoTilesArrayDim1 : KaitaiStruct
        {
            public static DungeonGenerationInfoTilesArrayDim1 FromFile(string fileName)
            {
                return new DungeonGenerationInfoTilesArrayDim1(new KaitaiStream(fileName));
            }

            public DungeonGenerationInfoTilesArrayDim1(KaitaiStream p__io, DungeonGenerationInfoTilesArray p__parent = null, DungeonGenerationInfoTilesArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<DungeonGenerationInfoTilesArrayDim0>();
                for (var i = 0; i < 32; i++)
                {
                    _entries.Add(new DungeonGenerationInfoTilesArrayDim0(m_io, this, m_root));
                }
            }
            private List<DungeonGenerationInfoTilesArrayDim0> _entries;
            private DungeonGenerationInfoTilesArray m_root;
            private DungeonGenerationInfoTilesArray m_parent;
            public List<DungeonGenerationInfoTilesArrayDim0> Entries { get { return _entries; } }
            public DungeonGenerationInfoTilesArray M_Root { get { return m_root; } }
            public DungeonGenerationInfoTilesArray M_Parent { get { return m_parent; } }
        }
        private DungeonGenerationInfoTilesArrayDim1 _entries;
        private DungeonGenerationInfoTilesArray m_root;
        private KaitaiStruct m_parent;
        public DungeonGenerationInfoTilesArrayDim1 Entries { get { return _entries; } }
        public DungeonGenerationInfoTilesArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
