// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array dungeon_natural_junction_list_counts defined within pmdsky.
    /// </summary>
    public partial class DungeonNaturalJunctionListCountsArray : KaitaiStruct
    {
        public static DungeonNaturalJunctionListCountsArray FromFile(string fileName)
        {
            return new DungeonNaturalJunctionListCountsArray(new KaitaiStream(fileName));
        }

        public DungeonNaturalJunctionListCountsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonNaturalJunctionListCountsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonNaturalJunctionListCountsArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonNaturalJunctionListCountsArrayDim0 : KaitaiStruct
        {
            public static DungeonNaturalJunctionListCountsArrayDim0 FromFile(string fileName)
            {
                return new DungeonNaturalJunctionListCountsArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonNaturalJunctionListCountsArrayDim0(KaitaiStream p__io, DungeonNaturalJunctionListCountsArray p__parent = null, DungeonNaturalJunctionListCountsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<ushort>();
                for (var i = 0; i < 32; i++)
                {
                    _entries.Add(m_io.ReadU2le());
                }
            }
            private List<ushort> _entries;
            private DungeonNaturalJunctionListCountsArray m_root;
            private DungeonNaturalJunctionListCountsArray m_parent;
            public List<ushort> Entries { get { return _entries; } }
            public DungeonNaturalJunctionListCountsArray M_Root { get { return m_root; } }
            public DungeonNaturalJunctionListCountsArray M_Parent { get { return m_parent; } }
        }
        private DungeonNaturalJunctionListCountsArrayDim0 _entries;
        private DungeonNaturalJunctionListCountsArray m_root;
        private KaitaiStruct m_parent;
        public DungeonNaturalJunctionListCountsArrayDim0 Entries { get { return _entries; } }
        public DungeonNaturalJunctionListCountsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
