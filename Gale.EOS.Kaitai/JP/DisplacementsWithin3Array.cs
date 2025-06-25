// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array DISPLACEMENTS_WITHIN_3 defined within pmdsky.
    /// </summary>
    public partial class DisplacementsWithin3Array : KaitaiStruct
    {
        public static DisplacementsWithin3Array FromFile(string fileName)
        {
            return new DisplacementsWithin3Array(new KaitaiStream(fileName));
        }

        public DisplacementsWithin3Array(KaitaiStream p__io, KaitaiStruct p__parent = null, DisplacementsWithin3Array p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DisplacementsWithin3ArrayDim0(m_io, this, m_root);
        }
        public partial class DisplacementsWithin3ArrayDim0 : KaitaiStruct
        {
            public static DisplacementsWithin3ArrayDim0 FromFile(string fileName)
            {
                return new DisplacementsWithin3ArrayDim0(new KaitaiStream(fileName));
            }

            public DisplacementsWithin3ArrayDim0(KaitaiStream p__io, DisplacementsWithin3Array p__parent = null, DisplacementsWithin3Array p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<Position>();
                for (var i = 0; i < 50; i++)
                {
                    _entries.Add(new Position(m_io));
                }
            }
            private List<Position> _entries;
            private DisplacementsWithin3Array m_root;
            private DisplacementsWithin3Array m_parent;
            public List<Position> Entries { get { return _entries; } }
            public DisplacementsWithin3Array M_Root { get { return m_root; } }
            public DisplacementsWithin3Array M_Parent { get { return m_parent; } }
        }
        private DisplacementsWithin3ArrayDim0 _entries;
        private DisplacementsWithin3Array m_root;
        private KaitaiStruct m_parent;
        public DisplacementsWithin3ArrayDim0 Entries { get { return _entries; } }
        public DisplacementsWithin3Array M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
