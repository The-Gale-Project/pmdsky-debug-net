// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array dungeon_unknown_file_buffer_0x12162 defined within pmdsky.
    /// </summary>
    public partial class DungeonUnknownFileBuffer0x12162Array : KaitaiStruct
    {
        public static DungeonUnknownFileBuffer0x12162Array FromFile(string fileName)
        {
            return new DungeonUnknownFileBuffer0x12162Array(new KaitaiStream(fileName));
        }

        public DungeonUnknownFileBuffer0x12162Array(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonUnknownFileBuffer0x12162Array p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonUnknownFileBuffer0x12162ArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonUnknownFileBuffer0x12162ArrayDim0 : KaitaiStruct
        {
            public static DungeonUnknownFileBuffer0x12162ArrayDim0 FromFile(string fileName)
            {
                return new DungeonUnknownFileBuffer0x12162ArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonUnknownFileBuffer0x12162ArrayDim0(KaitaiStream p__io, DungeonUnknownFileBuffer0x12162Array p__parent = null, DungeonUnknownFileBuffer0x12162Array p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<byte>();
                for (var i = 0; i < 2352; i++)
                {
                    _entries.Add(m_io.ReadU1());
                }
            }
            private List<byte> _entries;
            private DungeonUnknownFileBuffer0x12162Array m_root;
            private DungeonUnknownFileBuffer0x12162Array m_parent;
            public List<byte> Entries { get { return _entries; } }
            public DungeonUnknownFileBuffer0x12162Array M_Root { get { return m_root; } }
            public DungeonUnknownFileBuffer0x12162Array M_Parent { get { return m_parent; } }
        }
        private DungeonUnknownFileBuffer0x12162ArrayDim0 _entries;
        private DungeonUnknownFileBuffer0x12162Array m_root;
        private KaitaiStruct m_parent;
        public DungeonUnknownFileBuffer0x12162ArrayDim0 Entries { get { return _entries; } }
        public DungeonUnknownFileBuffer0x12162Array M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
