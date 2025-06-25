// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array DUNGEON_RETURN_STATUS_TABLE defined within pmdsky.
    /// </summary>
    public partial class DungeonReturnStatusTableArray : KaitaiStruct
    {
        public static DungeonReturnStatusTableArray FromFile(string fileName)
        {
            return new DungeonReturnStatusTableArray(new KaitaiStream(fileName));
        }

        public DungeonReturnStatusTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonReturnStatusTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonReturnStatusTableArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonReturnStatusTableArrayDim0 : KaitaiStruct
        {
            public static DungeonReturnStatusTableArrayDim0 FromFile(string fileName)
            {
                return new DungeonReturnStatusTableArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonReturnStatusTableArrayDim0(KaitaiStream p__io, DungeonReturnStatusTableArray p__parent = null, DungeonReturnStatusTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<DungeonReturnStatus>();
                for (var i = 0; i < 91; i++)
                {
                    _entries.Add(new DungeonReturnStatus(m_io));
                }
            }
            private List<DungeonReturnStatus> _entries;
            private DungeonReturnStatusTableArray m_root;
            private DungeonReturnStatusTableArray m_parent;
            public List<DungeonReturnStatus> Entries { get { return _entries; } }
            public DungeonReturnStatusTableArray M_Root { get { return m_root; } }
            public DungeonReturnStatusTableArray M_Parent { get { return m_parent; } }
        }
        private DungeonReturnStatusTableArrayDim0 _entries;
        private DungeonReturnStatusTableArray m_root;
        private KaitaiStruct m_parent;
        public DungeonReturnStatusTableArrayDim0 Entries { get { return _entries; } }
        public DungeonReturnStatusTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
