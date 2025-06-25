// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array dungeon_unknown_array_0x12A92 defined within pmdsky.
    /// </summary>
    public partial class DungeonUnknownArray0x12a92Array : KaitaiStruct
    {
        public static DungeonUnknownArray0x12a92Array FromFile(string fileName)
        {
            return new DungeonUnknownArray0x12a92Array(new KaitaiStream(fileName));
        }

        public DungeonUnknownArray0x12a92Array(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonUnknownArray0x12a92Array p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonUnknownArray0x12a92ArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonUnknownArray0x12a92ArrayDim0 : KaitaiStruct
        {
            public static DungeonUnknownArray0x12a92ArrayDim0 FromFile(string fileName)
            {
                return new DungeonUnknownArray0x12a92ArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonUnknownArray0x12a92ArrayDim0(KaitaiStream p__io, DungeonUnknownArray0x12a92Array p__parent = null, DungeonUnknownArray0x12a92Array p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<ushort>();
                for (var i = 0; i < 9; i++)
                {
                    _entries.Add(m_io.ReadU2le());
                }
            }
            private List<ushort> _entries;
            private DungeonUnknownArray0x12a92Array m_root;
            private DungeonUnknownArray0x12a92Array m_parent;
            public List<ushort> Entries { get { return _entries; } }
            public DungeonUnknownArray0x12a92Array M_Root { get { return m_root; } }
            public DungeonUnknownArray0x12a92Array M_Parent { get { return m_parent; } }
        }
        private DungeonUnknownArray0x12a92ArrayDim0 _entries;
        private DungeonUnknownArray0x12a92Array m_root;
        private KaitaiStruct m_parent;
        public DungeonUnknownArray0x12a92ArrayDim0 Entries { get { return _entries; } }
        public DungeonUnknownArray0x12a92Array M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
