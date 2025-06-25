// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array monster_moves defined within pmdsky.
    /// </summary>
    public partial class MonsterMovesArray : KaitaiStruct
    {
        public static MonsterMovesArray FromFile(string fileName)
        {
            return new MonsterMovesArray(new KaitaiStream(fileName));
        }

        public MonsterMovesArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MonsterMovesArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MonsterMovesArrayDim0(m_io, this, m_root);
        }
        public partial class MonsterMovesArrayDim0 : KaitaiStruct
        {
            public static MonsterMovesArrayDim0 FromFile(string fileName)
            {
                return new MonsterMovesArrayDim0(new KaitaiStream(fileName));
            }

            public MonsterMovesArrayDim0(KaitaiStream p__io, MonsterMovesArray p__parent = null, MonsterMovesArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<Move>();
                for (var i = 0; i < 4; i++)
                {
                    _entries.Add(new Move(m_io));
                }
            }
            private List<Move> _entries;
            private MonsterMovesArray m_root;
            private MonsterMovesArray m_parent;
            public List<Move> Entries { get { return _entries; } }
            public MonsterMovesArray M_Root { get { return m_root; } }
            public MonsterMovesArray M_Parent { get { return m_parent; } }
        }
        private MonsterMovesArrayDim0 _entries;
        private MonsterMovesArray m_root;
        private KaitaiStruct m_parent;
        public MonsterMovesArrayDim0 Entries { get { return _entries; } }
        public MonsterMovesArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
