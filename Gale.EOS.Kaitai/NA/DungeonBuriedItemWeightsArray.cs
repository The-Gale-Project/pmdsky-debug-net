// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array dungeon_buried_item_weights defined within pmdsky.
    /// </summary>
    public partial class DungeonBuriedItemWeightsArray : KaitaiStruct
    {
        public static DungeonBuriedItemWeightsArray FromFile(string fileName)
        {
            return new DungeonBuriedItemWeightsArray(new KaitaiStream(fileName));
        }

        public DungeonBuriedItemWeightsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonBuriedItemWeightsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonBuriedItemWeightsArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonBuriedItemWeightsArrayDim0 : KaitaiStruct
        {
            public static DungeonBuriedItemWeightsArrayDim0 FromFile(string fileName)
            {
                return new DungeonBuriedItemWeightsArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonBuriedItemWeightsArrayDim0(KaitaiStream p__io, DungeonBuriedItemWeightsArray p__parent = null, DungeonBuriedItemWeightsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<ushort>();
                for (var i = 0; i < 1416; i++)
                {
                    _entries.Add(m_io.ReadU2le());
                }
            }
            private List<ushort> _entries;
            private DungeonBuriedItemWeightsArray m_root;
            private DungeonBuriedItemWeightsArray m_parent;
            public List<ushort> Entries { get { return _entries; } }
            public DungeonBuriedItemWeightsArray M_Root { get { return m_root; } }
            public DungeonBuriedItemWeightsArray M_Parent { get { return m_parent; } }
        }
        private DungeonBuriedItemWeightsArrayDim0 _entries;
        private DungeonBuriedItemWeightsArray m_root;
        private KaitaiStruct m_parent;
        public DungeonBuriedItemWeightsArrayDim0 Entries { get { return _entries; } }
        public DungeonBuriedItemWeightsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
