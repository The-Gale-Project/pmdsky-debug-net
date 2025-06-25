// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array dungeon_plus_is_active defined within pmdsky.
    /// </summary>
    public partial class DungeonPlusIsActiveArray : KaitaiStruct
    {
        public static DungeonPlusIsActiveArray FromFile(string fileName)
        {
            return new DungeonPlusIsActiveArray(new KaitaiStream(fileName));
        }

        public DungeonPlusIsActiveArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonPlusIsActiveArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonPlusIsActiveArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonPlusIsActiveArrayDim0 : KaitaiStruct
        {
            public static DungeonPlusIsActiveArrayDim0 FromFile(string fileName)
            {
                return new DungeonPlusIsActiveArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonPlusIsActiveArrayDim0(KaitaiStream p__io, DungeonPlusIsActiveArray p__parent = null, DungeonPlusIsActiveArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<byte>();
                for (var i = 0; i < 2; i++)
                {
                    _entries.Add(m_io.ReadU1());
                }
            }
            private List<byte> _entries;
            private DungeonPlusIsActiveArray m_root;
            private DungeonPlusIsActiveArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public DungeonPlusIsActiveArray M_Root { get { return m_root; } }
            public DungeonPlusIsActiveArray M_Parent { get { return m_parent; } }
        }
        private DungeonPlusIsActiveArrayDim0 _entries;
        private DungeonPlusIsActiveArray m_root;
        private KaitaiStruct m_parent;
        public DungeonPlusIsActiveArrayDim0 Entries { get { return _entries; } }
        public DungeonPlusIsActiveArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
