// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array guest_monster_moves defined within pmdsky.
    /// </summary>
    public partial class GuestMonsterMovesArray : KaitaiStruct
    {
        public static GuestMonsterMovesArray FromFile(string fileName)
        {
            return new GuestMonsterMovesArray(new KaitaiStream(fileName));
        }

        public GuestMonsterMovesArray(KaitaiStream p__io, KaitaiStruct p__parent = null, GuestMonsterMovesArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new GuestMonsterMovesArrayDim0(m_io, this, m_root);
        }
        public partial class GuestMonsterMovesArrayDim0 : KaitaiStruct
        {
            public static GuestMonsterMovesArrayDim0 FromFile(string fileName)
            {
                return new GuestMonsterMovesArrayDim0(new KaitaiStream(fileName));
            }

            public GuestMonsterMovesArrayDim0(KaitaiStream p__io, GuestMonsterMovesArray p__parent = null, GuestMonsterMovesArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<MoveId16>();
                for (var i = 0; i < 4; i++)
                {
                    _entries.Add(new MoveId16(m_io));
                }
            }
            private List<MoveId16> _entries;
            private GuestMonsterMovesArray m_root;
            private GuestMonsterMovesArray m_parent;
            public List<MoveId16> Entries { get { return _entries; } }
            public GuestMonsterMovesArray M_Root { get { return m_root; } }
            public GuestMonsterMovesArray M_Parent { get { return m_parent; } }
        }
        private GuestMonsterMovesArrayDim0 _entries;
        private GuestMonsterMovesArray m_root;
        private KaitaiStruct m_parent;
        public GuestMonsterMovesArrayDim0 Entries { get { return _entries; } }
        public GuestMonsterMovesArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
