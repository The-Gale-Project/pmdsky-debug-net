// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array DUNGEON_SWAP_ID_TABLE defined within pmdsky.
    /// </summary>
    public partial class DungeonSwapIdTableArray : KaitaiStruct
    {
        public static DungeonSwapIdTableArray FromFile(string fileName)
        {
            return new DungeonSwapIdTableArray(new KaitaiStream(fileName));
        }

        public DungeonSwapIdTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonSwapIdTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonSwapIdTableArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonSwapIdTableArrayDim0 : KaitaiStruct
        {
            public static DungeonSwapIdTableArrayDim0 FromFile(string fileName)
            {
                return new DungeonSwapIdTableArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonSwapIdTableArrayDim0(KaitaiStream p__io, DungeonSwapIdTableArray p__parent = null, DungeonSwapIdTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<DungeonId8>();
                for (var i = 0; i < 212; i++)
                {
                    _entries.Add(new DungeonId8(m_io));
                }
            }
            private List<DungeonId8> _entries;
            private DungeonSwapIdTableArray m_root;
            private DungeonSwapIdTableArray m_parent;
            public List<DungeonId8> Entries { get { return _entries; } }
            public DungeonSwapIdTableArray M_Root { get { return m_root; } }
            public DungeonSwapIdTableArray M_Parent { get { return m_parent; } }
        }
        private DungeonSwapIdTableArrayDim0 _entries;
        private DungeonSwapIdTableArray m_root;
        private KaitaiStruct m_parent;
        public DungeonSwapIdTableArrayDim0 Entries { get { return _entries; } }
        public DungeonSwapIdTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
