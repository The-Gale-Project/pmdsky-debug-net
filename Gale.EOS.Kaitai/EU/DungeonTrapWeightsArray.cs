// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array dungeon_trap_weights defined within pmdsky.
    /// </summary>
    public partial class DungeonTrapWeightsArray : KaitaiStruct
    {
        public static DungeonTrapWeightsArray FromFile(string fileName)
        {
            return new DungeonTrapWeightsArray(new KaitaiStream(fileName));
        }

        public DungeonTrapWeightsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonTrapWeightsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonTrapWeightsArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonTrapWeightsArrayDim0 : KaitaiStruct
        {
            public static DungeonTrapWeightsArrayDim0 FromFile(string fileName)
            {
                return new DungeonTrapWeightsArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonTrapWeightsArrayDim0(KaitaiStream p__io, DungeonTrapWeightsArray p__parent = null, DungeonTrapWeightsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<ushort>();
                for (var i = 0; i < 25; i++)
                {
                    _entries.Add(m_io.ReadU2le());
                }
            }
            private List<ushort> _entries;
            private DungeonTrapWeightsArray m_root;
            private DungeonTrapWeightsArray m_parent;
            public List<ushort> Entries { get { return _entries; } }
            public DungeonTrapWeightsArray M_Root { get { return m_root; } }
            public DungeonTrapWeightsArray M_Parent { get { return m_parent; } }
        }
        private DungeonTrapWeightsArrayDim0 _entries;
        private DungeonTrapWeightsArray m_root;
        private KaitaiStruct m_parent;
        public DungeonTrapWeightsArrayDim0 Entries { get { return _entries; } }
        public DungeonTrapWeightsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
