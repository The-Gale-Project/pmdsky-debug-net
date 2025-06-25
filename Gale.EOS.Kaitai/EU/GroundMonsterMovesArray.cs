// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array ground_monster_moves defined within pmdsky.
    /// </summary>
    public partial class GroundMonsterMovesArray : KaitaiStruct
    {
        public static GroundMonsterMovesArray FromFile(string fileName)
        {
            return new GroundMonsterMovesArray(new KaitaiStream(fileName));
        }

        public GroundMonsterMovesArray(KaitaiStream p__io, KaitaiStruct p__parent = null, GroundMonsterMovesArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new GroundMonsterMovesArrayDim0(m_io, this, m_root);
        }
        public partial class GroundMonsterMovesArrayDim0 : KaitaiStruct
        {
            public static GroundMonsterMovesArrayDim0 FromFile(string fileName)
            {
                return new GroundMonsterMovesArrayDim0(new KaitaiStream(fileName));
            }

            public GroundMonsterMovesArrayDim0(KaitaiStream p__io, GroundMonsterMovesArray p__parent = null, GroundMonsterMovesArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<GroundMove>();
                for (var i = 0; i < 4; i++)
                {
                    _entries.Add(new GroundMove(m_io));
                }
            }
            private List<GroundMove> _entries;
            private GroundMonsterMovesArray m_root;
            private GroundMonsterMovesArray m_parent;
            public List<GroundMove> Entries { get { return _entries; } }
            public GroundMonsterMovesArray M_Root { get { return m_root; } }
            public GroundMonsterMovesArray M_Parent { get { return m_parent; } }
        }
        private GroundMonsterMovesArrayDim0 _entries;
        private GroundMonsterMovesArray m_root;
        private KaitaiStruct m_parent;
        public GroundMonsterMovesArrayDim0 Entries { get { return _entries; } }
        public GroundMonsterMovesArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
