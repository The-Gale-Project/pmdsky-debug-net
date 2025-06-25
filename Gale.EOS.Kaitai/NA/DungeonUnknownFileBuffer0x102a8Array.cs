// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array dungeon_unknown_file_buffer_0x102A8 defined within pmdsky.
    /// </summary>
    public partial class DungeonUnknownFileBuffer0x102a8Array : KaitaiStruct
    {
        public static DungeonUnknownFileBuffer0x102a8Array FromFile(string fileName)
        {
            return new DungeonUnknownFileBuffer0x102a8Array(new KaitaiStream(fileName));
        }

        public DungeonUnknownFileBuffer0x102a8Array(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonUnknownFileBuffer0x102a8Array p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonUnknownFileBuffer0x102a8ArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonUnknownFileBuffer0x102a8ArrayDim0 : KaitaiStruct
        {
            public static DungeonUnknownFileBuffer0x102a8ArrayDim0 FromFile(string fileName)
            {
                return new DungeonUnknownFileBuffer0x102a8ArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonUnknownFileBuffer0x102a8ArrayDim0(KaitaiStream p__io, DungeonUnknownFileBuffer0x102a8Array p__parent = null, DungeonUnknownFileBuffer0x102a8Array p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<byte>();
                for (var i = 0; i < 7200; i++)
                {
                    _entries.Add(m_io.ReadU1());
                }
            }
            private List<byte> _entries;
            private DungeonUnknownFileBuffer0x102a8Array m_root;
            private DungeonUnknownFileBuffer0x102a8Array m_parent;
            public List<byte> Entries { get { return _entries; } }
            public DungeonUnknownFileBuffer0x102a8Array M_Root { get { return m_root; } }
            public DungeonUnknownFileBuffer0x102a8Array M_Parent { get { return m_parent; } }
        }
        private DungeonUnknownFileBuffer0x102a8ArrayDim0 _entries;
        private DungeonUnknownFileBuffer0x102a8Array m_root;
        private KaitaiStruct m_parent;
        public DungeonUnknownFileBuffer0x102a8ArrayDim0 Entries { get { return _entries; } }
        public DungeonUnknownFileBuffer0x102a8Array M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
