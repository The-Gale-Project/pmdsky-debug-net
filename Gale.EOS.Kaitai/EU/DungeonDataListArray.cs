// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array DUNGEON_DATA_LIST defined within pmdsky.
    /// </summary>
    public partial class DungeonDataListArray : KaitaiStruct
    {
        public static DungeonDataListArray FromFile(string fileName)
        {
            return new DungeonDataListArray(new KaitaiStream(fileName));
        }

        public DungeonDataListArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonDataListArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonDataListArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonDataListArrayDim0 : KaitaiStruct
        {
            public static DungeonDataListArrayDim0 FromFile(string fileName)
            {
                return new DungeonDataListArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonDataListArrayDim0(KaitaiStream p__io, DungeonDataListArray p__parent = null, DungeonDataListArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<DungeonDataListEntry>();
                for (var i = 0; i < 180; i++)
                {
                    _entries.Add(new DungeonDataListEntry(m_io));
                }
            }
            private List<DungeonDataListEntry> _entries;
            private DungeonDataListArray m_root;
            private DungeonDataListArray m_parent;
            public List<DungeonDataListEntry> Entries { get { return _entries; } }
            public DungeonDataListArray M_Root { get { return m_root; } }
            public DungeonDataListArray M_Parent { get { return m_parent; } }
        }
        private DungeonDataListArrayDim0 _entries;
        private DungeonDataListArray m_root;
        private KaitaiStruct m_parent;
        public DungeonDataListArrayDim0 Entries { get { return _entries; } }
        public DungeonDataListArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
