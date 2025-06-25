// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array dungeon_regular_item_weights defined within pmdsky.
    /// </summary>
    public partial class DungeonRegularItemWeightsArray : KaitaiStruct
    {
        public static DungeonRegularItemWeightsArray FromFile(string fileName)
        {
            return new DungeonRegularItemWeightsArray(new KaitaiStream(fileName));
        }

        public DungeonRegularItemWeightsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonRegularItemWeightsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonRegularItemWeightsArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonRegularItemWeightsArrayDim0 : KaitaiStruct
        {
            public static DungeonRegularItemWeightsArrayDim0 FromFile(string fileName)
            {
                return new DungeonRegularItemWeightsArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonRegularItemWeightsArrayDim0(KaitaiStream p__io, DungeonRegularItemWeightsArray p__parent = null, DungeonRegularItemWeightsArray p__root = null) : base(p__io)
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
            private DungeonRegularItemWeightsArray m_root;
            private DungeonRegularItemWeightsArray m_parent;
            public List<ushort> Entries { get { return _entries; } }
            public DungeonRegularItemWeightsArray M_Root { get { return m_root; } }
            public DungeonRegularItemWeightsArray M_Parent { get { return m_parent; } }
        }
        private DungeonRegularItemWeightsArrayDim0 _entries;
        private DungeonRegularItemWeightsArray m_root;
        private KaitaiStruct m_parent;
        public DungeonRegularItemWeightsArrayDim0 Entries { get { return _entries; } }
        public DungeonRegularItemWeightsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
