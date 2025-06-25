// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array dungeon_tile_ptrs defined within pmdsky.
    /// </summary>
    public partial class DungeonTilePtrsArray : KaitaiStruct
    {
        public static DungeonTilePtrsArray FromFile(string fileName)
        {
            return new DungeonTilePtrsArray(new KaitaiStream(fileName));
        }

        public DungeonTilePtrsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonTilePtrsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonTilePtrsArrayDim1(m_io, this, m_root);
        }
        public partial class DungeonTilePtrsArrayDim0 : KaitaiStruct
        {
            public static DungeonTilePtrsArrayDim0 FromFile(string fileName)
            {
                return new DungeonTilePtrsArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonTilePtrsArrayDim0(KaitaiStream p__io, DungeonTilePtrsArray.DungeonTilePtrsArrayDim1 p__parent = null, DungeonTilePtrsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<Pointer>();
                for (var i = 0; i < 56; i++)
                {
                    _entries.Add(new Pointer(m_io));
                }
            }
            private List<Pointer> _entries;
            private DungeonTilePtrsArray m_root;
            private DungeonTilePtrsArray.DungeonTilePtrsArrayDim1 m_parent;
            public List<Pointer> Entries { get { return _entries; } }
            public DungeonTilePtrsArray M_Root { get { return m_root; } }
            public DungeonTilePtrsArray.DungeonTilePtrsArrayDim1 M_Parent { get { return m_parent; } }
        }
        public partial class DungeonTilePtrsArrayDim1 : KaitaiStruct
        {
            public static DungeonTilePtrsArrayDim1 FromFile(string fileName)
            {
                return new DungeonTilePtrsArrayDim1(new KaitaiStream(fileName));
            }

            public DungeonTilePtrsArrayDim1(KaitaiStream p__io, DungeonTilePtrsArray p__parent = null, DungeonTilePtrsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<DungeonTilePtrsArrayDim0>();
                for (var i = 0; i < 32; i++)
                {
                    _entries.Add(new DungeonTilePtrsArrayDim0(m_io, this, m_root));
                }
            }
            private List<DungeonTilePtrsArrayDim0> _entries;
            private DungeonTilePtrsArray m_root;
            private DungeonTilePtrsArray m_parent;
            public List<DungeonTilePtrsArrayDim0> Entries { get { return _entries; } }
            public DungeonTilePtrsArray M_Root { get { return m_root; } }
            public DungeonTilePtrsArray M_Parent { get { return m_parent; } }
        }
        private DungeonTilePtrsArrayDim1 _entries;
        private DungeonTilePtrsArray m_root;
        private KaitaiStruct m_parent;
        public DungeonTilePtrsArrayDim1 Entries { get { return _entries; } }
        public DungeonTilePtrsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
