// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array DISPLACEMENTS_WITHIN_2_SMALLEST_FIRST defined within pmdsky.
    /// </summary>
    public partial class DisplacementsWithin2SmallestFirstArray : KaitaiStruct
    {
        public static DisplacementsWithin2SmallestFirstArray FromFile(string fileName)
        {
            return new DisplacementsWithin2SmallestFirstArray(new KaitaiStream(fileName));
        }

        public DisplacementsWithin2SmallestFirstArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DisplacementsWithin2SmallestFirstArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DisplacementsWithin2SmallestFirstArrayDim0(m_io, this, m_root);
        }
        public partial class DisplacementsWithin2SmallestFirstArrayDim0 : KaitaiStruct
        {
            public static DisplacementsWithin2SmallestFirstArrayDim0 FromFile(string fileName)
            {
                return new DisplacementsWithin2SmallestFirstArrayDim0(new KaitaiStream(fileName));
            }

            public DisplacementsWithin2SmallestFirstArrayDim0(KaitaiStream p__io, DisplacementsWithin2SmallestFirstArray p__parent = null, DisplacementsWithin2SmallestFirstArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<Position>();
                for (var i = 0; i < 26; i++)
                {
                    _entries.Add(new Position(m_io));
                }
            }
            private List<Position> _entries;
            private DisplacementsWithin2SmallestFirstArray m_root;
            private DisplacementsWithin2SmallestFirstArray m_parent;
            public List<Position> Entries { get { return _entries; } }
            public DisplacementsWithin2SmallestFirstArray M_Root { get { return m_root; } }
            public DisplacementsWithin2SmallestFirstArray M_Parent { get { return m_parent; } }
        }
        private DisplacementsWithin2SmallestFirstArrayDim0 _entries;
        private DisplacementsWithin2SmallestFirstArray m_root;
        private KaitaiStruct m_parent;
        public DisplacementsWithin2SmallestFirstArrayDim0 Entries { get { return _entries; } }
        public DisplacementsWithin2SmallestFirstArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
