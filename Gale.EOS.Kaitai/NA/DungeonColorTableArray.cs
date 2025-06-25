// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array dungeon_color_table defined within pmdsky.
    /// </summary>
    public partial class DungeonColorTableArray : KaitaiStruct
    {
        public static DungeonColorTableArray FromFile(string fileName)
        {
            return new DungeonColorTableArray(new KaitaiStream(fileName));
        }

        public DungeonColorTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonColorTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonColorTableArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonColorTableArrayDim0 : KaitaiStruct
        {
            public static DungeonColorTableArrayDim0 FromFile(string fileName)
            {
                return new DungeonColorTableArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonColorTableArrayDim0(KaitaiStream p__io, DungeonColorTableArray p__parent = null, DungeonColorTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<Rgba>();
                for (var i = 0; i < 256; i++)
                {
                    _entries.Add(new Rgba(m_io));
                }
            }
            private List<Rgba> _entries;
            private DungeonColorTableArray m_root;
            private DungeonColorTableArray m_parent;
            public List<Rgba> Entries { get { return _entries; } }
            public DungeonColorTableArray M_Root { get { return m_root; } }
            public DungeonColorTableArray M_Parent { get { return m_parent; } }
        }
        private DungeonColorTableArrayDim0 _entries;
        private DungeonColorTableArray m_root;
        private KaitaiStruct m_parent;
        public DungeonColorTableArrayDim0 Entries { get { return _entries; } }
        public DungeonColorTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
