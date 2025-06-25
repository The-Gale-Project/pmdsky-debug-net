// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array LEVEL_TILEMAP_LIST defined within pmdsky.
    /// </summary>
    public partial class LevelTilemapListArray : KaitaiStruct
    {
        public static LevelTilemapListArray FromFile(string fileName)
        {
            return new LevelTilemapListArray(new KaitaiStream(fileName));
        }

        public LevelTilemapListArray(KaitaiStream p__io, KaitaiStruct p__parent = null, LevelTilemapListArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new LevelTilemapListArrayDim0(m_io, this, m_root);
        }
        public partial class LevelTilemapListArrayDim0 : KaitaiStruct
        {
            public static LevelTilemapListArrayDim0 FromFile(string fileName)
            {
                return new LevelTilemapListArrayDim0(new KaitaiStream(fileName));
            }

            public LevelTilemapListArrayDim0(KaitaiStream p__io, LevelTilemapListArray p__parent = null, LevelTilemapListArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<LevelTilemapListEntry>();
                for (var i = 0; i < 81; i++)
                {
                    _entries.Add(new LevelTilemapListEntry(m_io));
                }
            }
            private List<LevelTilemapListEntry> _entries;
            private LevelTilemapListArray m_root;
            private LevelTilemapListArray m_parent;
            public List<LevelTilemapListEntry> Entries { get { return _entries; } }
            public LevelTilemapListArray M_Root { get { return m_root; } }
            public LevelTilemapListArray M_Parent { get { return m_parent; } }
        }
        private LevelTilemapListArrayDim0 _entries;
        private LevelTilemapListArray m_root;
        private KaitaiStruct m_parent;
        public LevelTilemapListArrayDim0 Entries { get { return _entries; } }
        public LevelTilemapListArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
