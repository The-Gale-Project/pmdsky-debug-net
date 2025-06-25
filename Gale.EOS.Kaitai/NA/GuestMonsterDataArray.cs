// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array GUEST_MONSTER_DATA defined within pmdsky.
    /// </summary>
    public partial class GuestMonsterDataArray : KaitaiStruct
    {
        public static GuestMonsterDataArray FromFile(string fileName)
        {
            return new GuestMonsterDataArray(new KaitaiStream(fileName));
        }

        public GuestMonsterDataArray(KaitaiStream p__io, KaitaiStruct p__parent = null, GuestMonsterDataArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new GuestMonsterDataArrayDim0(m_io, this, m_root);
        }
        public partial class GuestMonsterDataArrayDim0 : KaitaiStruct
        {
            public static GuestMonsterDataArrayDim0 FromFile(string fileName)
            {
                return new GuestMonsterDataArrayDim0(new KaitaiStream(fileName));
            }

            public GuestMonsterDataArrayDim0(KaitaiStream p__io, GuestMonsterDataArray p__parent = null, GuestMonsterDataArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<GuestMonster>();
                for (var i = 0; i < 18; i++)
                {
                    _entries.Add(new GuestMonster(m_io));
                }
            }
            private List<GuestMonster> _entries;
            private GuestMonsterDataArray m_root;
            private GuestMonsterDataArray m_parent;
            public List<GuestMonster> Entries { get { return _entries; } }
            public GuestMonsterDataArray M_Root { get { return m_root; } }
            public GuestMonsterDataArray M_Parent { get { return m_parent; } }
        }
        private GuestMonsterDataArrayDim0 _entries;
        private GuestMonsterDataArray m_root;
        private KaitaiStruct m_parent;
        public GuestMonsterDataArrayDim0 Entries { get { return _entries; } }
        public GuestMonsterDataArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
