// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array dungeon_grab_bag_item_weights defined within pmdsky.
    /// </summary>
    public partial class DungeonGrabBagItemWeightsArray : KaitaiStruct
    {
        public static DungeonGrabBagItemWeightsArray FromFile(string fileName)
        {
            return new DungeonGrabBagItemWeightsArray(new KaitaiStream(fileName));
        }

        public DungeonGrabBagItemWeightsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonGrabBagItemWeightsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonGrabBagItemWeightsArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonGrabBagItemWeightsArrayDim0 : KaitaiStruct
        {
            public static DungeonGrabBagItemWeightsArrayDim0 FromFile(string fileName)
            {
                return new DungeonGrabBagItemWeightsArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonGrabBagItemWeightsArrayDim0(KaitaiStream p__io, DungeonGrabBagItemWeightsArray p__parent = null, DungeonGrabBagItemWeightsArray p__root = null) : base(p__io)
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
            private DungeonGrabBagItemWeightsArray m_root;
            private DungeonGrabBagItemWeightsArray m_parent;
            public List<ushort> Entries { get { return _entries; } }
            public DungeonGrabBagItemWeightsArray M_Root { get { return m_root; } }
            public DungeonGrabBagItemWeightsArray M_Parent { get { return m_parent; } }
        }
        private DungeonGrabBagItemWeightsArrayDim0 _entries;
        private DungeonGrabBagItemWeightsArray m_root;
        private KaitaiStruct m_parent;
        public DungeonGrabBagItemWeightsArrayDim0 Entries { get { return _entries; } }
        public DungeonGrabBagItemWeightsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
