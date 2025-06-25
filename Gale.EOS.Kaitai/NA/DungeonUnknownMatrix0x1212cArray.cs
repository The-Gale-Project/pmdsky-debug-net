// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array dungeon_unknown_matrix_0x1212C defined within pmdsky.
    /// </summary>
    public partial class DungeonUnknownMatrix0x1212cArray : KaitaiStruct
    {
        public static DungeonUnknownMatrix0x1212cArray FromFile(string fileName)
        {
            return new DungeonUnknownMatrix0x1212cArray(new KaitaiStream(fileName));
        }

        public DungeonUnknownMatrix0x1212cArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonUnknownMatrix0x1212cArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonUnknownMatrix0x1212cArrayDim1(m_io, this, m_root);
        }
        public partial class DungeonUnknownMatrix0x1212cArrayDim0 : KaitaiStruct
        {
            public static DungeonUnknownMatrix0x1212cArrayDim0 FromFile(string fileName)
            {
                return new DungeonUnknownMatrix0x1212cArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonUnknownMatrix0x1212cArrayDim0(KaitaiStream p__io, DungeonUnknownMatrix0x1212cArray.DungeonUnknownMatrix0x1212cArrayDim1 p__parent = null, DungeonUnknownMatrix0x1212cArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<ushort>();
                for (var i = 0; i < 3; i++)
                {
                    _entries.Add(m_io.ReadU2le());
                }
            }
            private List<ushort> _entries;
            private DungeonUnknownMatrix0x1212cArray m_root;
            private DungeonUnknownMatrix0x1212cArray.DungeonUnknownMatrix0x1212cArrayDim1 m_parent;
            public List<ushort> Entries { get { return _entries; } }
            public DungeonUnknownMatrix0x1212cArray M_Root { get { return m_root; } }
            public DungeonUnknownMatrix0x1212cArray.DungeonUnknownMatrix0x1212cArrayDim1 M_Parent { get { return m_parent; } }
        }
        public partial class DungeonUnknownMatrix0x1212cArrayDim1 : KaitaiStruct
        {
            public static DungeonUnknownMatrix0x1212cArrayDim1 FromFile(string fileName)
            {
                return new DungeonUnknownMatrix0x1212cArrayDim1(new KaitaiStream(fileName));
            }

            public DungeonUnknownMatrix0x1212cArrayDim1(KaitaiStream p__io, DungeonUnknownMatrix0x1212cArray p__parent = null, DungeonUnknownMatrix0x1212cArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<DungeonUnknownMatrix0x1212cArrayDim0>();
                for (var i = 0; i < 9; i++)
                {
                    _entries.Add(new DungeonUnknownMatrix0x1212cArrayDim0(m_io, this, m_root));
                }
            }
            private List<DungeonUnknownMatrix0x1212cArrayDim0> _entries;
            private DungeonUnknownMatrix0x1212cArray m_root;
            private DungeonUnknownMatrix0x1212cArray m_parent;
            public List<DungeonUnknownMatrix0x1212cArrayDim0> Entries { get { return _entries; } }
            public DungeonUnknownMatrix0x1212cArray M_Root { get { return m_root; } }
            public DungeonUnknownMatrix0x1212cArray M_Parent { get { return m_parent; } }
        }
        private DungeonUnknownMatrix0x1212cArrayDim1 _entries;
        private DungeonUnknownMatrix0x1212cArray m_root;
        private KaitaiStruct m_parent;
        public DungeonUnknownMatrix0x1212cArrayDim1 Entries { get { return _entries; } }
        public DungeonUnknownMatrix0x1212cArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
