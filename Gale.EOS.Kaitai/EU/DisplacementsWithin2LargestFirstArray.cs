// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array DISPLACEMENTS_WITHIN_2_LARGEST_FIRST defined within pmdsky.
    /// </summary>
    public partial class DisplacementsWithin2LargestFirstArray : KaitaiStruct
    {
        public static DisplacementsWithin2LargestFirstArray FromFile(string fileName)
        {
            return new DisplacementsWithin2LargestFirstArray(new KaitaiStream(fileName));
        }

        public DisplacementsWithin2LargestFirstArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DisplacementsWithin2LargestFirstArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DisplacementsWithin2LargestFirstArrayDim0(m_io, this, m_root);
        }
        public partial class DisplacementsWithin2LargestFirstArrayDim0 : KaitaiStruct
        {
            public static DisplacementsWithin2LargestFirstArrayDim0 FromFile(string fileName)
            {
                return new DisplacementsWithin2LargestFirstArrayDim0(new KaitaiStream(fileName));
            }

            public DisplacementsWithin2LargestFirstArrayDim0(KaitaiStream p__io, DisplacementsWithin2LargestFirstArray p__parent = null, DisplacementsWithin2LargestFirstArray p__root = null) : base(p__io)
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
            private DisplacementsWithin2LargestFirstArray m_root;
            private DisplacementsWithin2LargestFirstArray m_parent;
            public List<Position> Entries { get { return _entries; } }
            public DisplacementsWithin2LargestFirstArray M_Root { get { return m_root; } }
            public DisplacementsWithin2LargestFirstArray M_Parent { get { return m_parent; } }
        }
        private DisplacementsWithin2LargestFirstArrayDim0 _entries;
        private DisplacementsWithin2LargestFirstArray m_root;
        private KaitaiStruct m_parent;
        public DisplacementsWithin2LargestFirstArrayDim0 Entries { get { return _entries; } }
        public DisplacementsWithin2LargestFirstArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
