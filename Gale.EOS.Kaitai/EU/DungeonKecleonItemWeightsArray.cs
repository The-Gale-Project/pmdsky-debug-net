// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array dungeon_kecleon_item_weights defined within pmdsky.
    /// </summary>
    public partial class DungeonKecleonItemWeightsArray : KaitaiStruct
    {
        public static DungeonKecleonItemWeightsArray FromFile(string fileName)
        {
            return new DungeonKecleonItemWeightsArray(new KaitaiStream(fileName));
        }

        public DungeonKecleonItemWeightsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonKecleonItemWeightsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonKecleonItemWeightsArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonKecleonItemWeightsArrayDim0 : KaitaiStruct
        {
            public static DungeonKecleonItemWeightsArrayDim0 FromFile(string fileName)
            {
                return new DungeonKecleonItemWeightsArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonKecleonItemWeightsArrayDim0(KaitaiStream p__io, DungeonKecleonItemWeightsArray p__parent = null, DungeonKecleonItemWeightsArray p__root = null) : base(p__io)
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
            private DungeonKecleonItemWeightsArray m_root;
            private DungeonKecleonItemWeightsArray m_parent;
            public List<ushort> Entries { get { return _entries; } }
            public DungeonKecleonItemWeightsArray M_Root { get { return m_root; } }
            public DungeonKecleonItemWeightsArray M_Parent { get { return m_parent; } }
        }
        private DungeonKecleonItemWeightsArrayDim0 _entries;
        private DungeonKecleonItemWeightsArray m_root;
        private KaitaiStruct m_parent;
        public DungeonKecleonItemWeightsArrayDim0 Entries { get { return _entries; } }
        public DungeonKecleonItemWeightsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
