// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array DUNGEON_PRNG_STATE_SECONDARY_VALUES defined within pmdsky.
    /// </summary>
    public partial class DungeonPrngStateSecondaryValuesArray : KaitaiStruct
    {
        public static DungeonPrngStateSecondaryValuesArray FromFile(string fileName)
        {
            return new DungeonPrngStateSecondaryValuesArray(new KaitaiStream(fileName));
        }

        public DungeonPrngStateSecondaryValuesArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonPrngStateSecondaryValuesArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonPrngStateSecondaryValuesArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonPrngStateSecondaryValuesArrayDim0 : KaitaiStruct
        {
            public static DungeonPrngStateSecondaryValuesArrayDim0 FromFile(string fileName)
            {
                return new DungeonPrngStateSecondaryValuesArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonPrngStateSecondaryValuesArrayDim0(KaitaiStream p__io, DungeonPrngStateSecondaryValuesArray p__parent = null, DungeonPrngStateSecondaryValuesArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<uint>();
                for (var i = 0; i < 5; i++)
                {
                    _entries.Add(m_io.ReadU4le());
                }
            }
            private List<uint> _entries;
            private DungeonPrngStateSecondaryValuesArray m_root;
            private DungeonPrngStateSecondaryValuesArray m_parent;
            public List<uint> Entries { get { return _entries; } }
            public DungeonPrngStateSecondaryValuesArray M_Root { get { return m_root; } }
            public DungeonPrngStateSecondaryValuesArray M_Parent { get { return m_parent; } }
        }
        private DungeonPrngStateSecondaryValuesArrayDim0 _entries;
        private DungeonPrngStateSecondaryValuesArray m_root;
        private KaitaiStruct m_parent;
        public DungeonPrngStateSecondaryValuesArrayDim0 Entries { get { return _entries; } }
        public DungeonPrngStateSecondaryValuesArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
