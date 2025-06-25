// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array dungeon_minus_is_active defined within pmdsky.
    /// </summary>
    public partial class DungeonMinusIsActiveArray : KaitaiStruct
    {
        public static DungeonMinusIsActiveArray FromFile(string fileName)
        {
            return new DungeonMinusIsActiveArray(new KaitaiStream(fileName));
        }

        public DungeonMinusIsActiveArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonMinusIsActiveArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonMinusIsActiveArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonMinusIsActiveArrayDim0 : KaitaiStruct
        {
            public static DungeonMinusIsActiveArrayDim0 FromFile(string fileName)
            {
                return new DungeonMinusIsActiveArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonMinusIsActiveArrayDim0(KaitaiStream p__io, DungeonMinusIsActiveArray p__parent = null, DungeonMinusIsActiveArray p__root = null) : base(p__io)
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
            private DungeonMinusIsActiveArray m_root;
            private DungeonMinusIsActiveArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public DungeonMinusIsActiveArray M_Root { get { return m_root; } }
            public DungeonMinusIsActiveArray M_Parent { get { return m_parent; } }
        }
        private DungeonMinusIsActiveArrayDim0 _entries;
        private DungeonMinusIsActiveArray m_root;
        private KaitaiStruct m_parent;
        public DungeonMinusIsActiveArrayDim0 Entries { get { return _entries; } }
        public DungeonMinusIsActiveArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
