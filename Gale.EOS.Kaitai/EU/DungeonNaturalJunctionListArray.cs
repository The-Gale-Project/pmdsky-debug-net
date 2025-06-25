// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array dungeon_natural_junction_list defined within pmdsky.
    /// </summary>
    public partial class DungeonNaturalJunctionListArray : KaitaiStruct
    {
        public static DungeonNaturalJunctionListArray FromFile(string fileName)
        {
            return new DungeonNaturalJunctionListArray(new KaitaiStream(fileName));
        }

        public DungeonNaturalJunctionListArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonNaturalJunctionListArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonNaturalJunctionListArrayDim1(m_io, this, m_root);
        }
        public partial class DungeonNaturalJunctionListArrayDim0 : KaitaiStruct
        {
            public static DungeonNaturalJunctionListArrayDim0 FromFile(string fileName)
            {
                return new DungeonNaturalJunctionListArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonNaturalJunctionListArrayDim0(KaitaiStream p__io, DungeonNaturalJunctionListArray.DungeonNaturalJunctionListArrayDim1 p__parent = null, DungeonNaturalJunctionListArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<Position>();
                for (var i = 0; i < 32; i++)
                {
                    _entries.Add(new Position(m_io));
                }
            }
            private List<Position> _entries;
            private DungeonNaturalJunctionListArray m_root;
            private DungeonNaturalJunctionListArray.DungeonNaturalJunctionListArrayDim1 m_parent;
            public List<Position> Entries { get { return _entries; } }
            public DungeonNaturalJunctionListArray M_Root { get { return m_root; } }
            public DungeonNaturalJunctionListArray.DungeonNaturalJunctionListArrayDim1 M_Parent { get { return m_parent; } }
        }
        public partial class DungeonNaturalJunctionListArrayDim1 : KaitaiStruct
        {
            public static DungeonNaturalJunctionListArrayDim1 FromFile(string fileName)
            {
                return new DungeonNaturalJunctionListArrayDim1(new KaitaiStream(fileName));
            }

            public DungeonNaturalJunctionListArrayDim1(KaitaiStream p__io, DungeonNaturalJunctionListArray p__parent = null, DungeonNaturalJunctionListArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<DungeonNaturalJunctionListArrayDim0>();
                for (var i = 0; i < 32; i++)
                {
                    _entries.Add(new DungeonNaturalJunctionListArrayDim0(m_io, this, m_root));
                }
            }
            private List<DungeonNaturalJunctionListArrayDim0> _entries;
            private DungeonNaturalJunctionListArray m_root;
            private DungeonNaturalJunctionListArray m_parent;
            public List<DungeonNaturalJunctionListArrayDim0> Entries { get { return _entries; } }
            public DungeonNaturalJunctionListArray M_Root { get { return m_root; } }
            public DungeonNaturalJunctionListArray M_Parent { get { return m_parent; } }
        }
        private DungeonNaturalJunctionListArrayDim1 _entries;
        private DungeonNaturalJunctionListArray m_root;
        private KaitaiStruct m_parent;
        public DungeonNaturalJunctionListArrayDim1 Entries { get { return _entries; } }
        public DungeonNaturalJunctionListArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
