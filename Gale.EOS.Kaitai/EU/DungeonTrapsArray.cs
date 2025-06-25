// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array dungeon_traps defined within pmdsky.
    /// </summary>
    public partial class DungeonTrapsArray : KaitaiStruct
    {
        public static DungeonTrapsArray FromFile(string fileName)
        {
            return new DungeonTrapsArray(new KaitaiStream(fileName));
        }

        public DungeonTrapsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonTrapsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonTrapsArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonTrapsArrayDim0 : KaitaiStruct
        {
            public static DungeonTrapsArrayDim0 FromFile(string fileName)
            {
                return new DungeonTrapsArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonTrapsArrayDim0(KaitaiStream p__io, DungeonTrapsArray p__parent = null, DungeonTrapsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<Trap>();
                for (var i = 0; i < 64; i++)
                {
                    _entries.Add(new Trap(m_io));
                }
            }
            private List<Trap> _entries;
            private DungeonTrapsArray m_root;
            private DungeonTrapsArray m_parent;
            public List<Trap> Entries { get { return _entries; } }
            public DungeonTrapsArray M_Root { get { return m_root; } }
            public DungeonTrapsArray M_Parent { get { return m_parent; } }
        }
        private DungeonTrapsArrayDim0 _entries;
        private DungeonTrapsArray m_root;
        private KaitaiStruct m_parent;
        public DungeonTrapsArrayDim0 Entries { get { return _entries; } }
        public DungeonTrapsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
