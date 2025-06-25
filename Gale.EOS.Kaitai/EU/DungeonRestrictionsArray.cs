// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array DUNGEON_RESTRICTIONS defined within pmdsky.
    /// </summary>
    public partial class DungeonRestrictionsArray : KaitaiStruct
    {
        public static DungeonRestrictionsArray FromFile(string fileName)
        {
            return new DungeonRestrictionsArray(new KaitaiStream(fileName));
        }

        public DungeonRestrictionsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonRestrictionsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonRestrictionsArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonRestrictionsArrayDim0 : KaitaiStruct
        {
            public static DungeonRestrictionsArrayDim0 FromFile(string fileName)
            {
                return new DungeonRestrictionsArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonRestrictionsArrayDim0(KaitaiStream p__io, DungeonRestrictionsArray p__parent = null, DungeonRestrictionsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<DungeonRestriction>();
                for (var i = 0; i < 256; i++)
                {
                    _entries.Add(new DungeonRestriction(m_io));
                }
            }
            private List<DungeonRestriction> _entries;
            private DungeonRestrictionsArray m_root;
            private DungeonRestrictionsArray m_parent;
            public List<DungeonRestriction> Entries { get { return _entries; } }
            public DungeonRestrictionsArray M_Root { get { return m_root; } }
            public DungeonRestrictionsArray M_Parent { get { return m_parent; } }
        }
        private DungeonRestrictionsArrayDim0 _entries;
        private DungeonRestrictionsArray m_root;
        private KaitaiStruct m_parent;
        public DungeonRestrictionsArrayDim0 Entries { get { return _entries; } }
        public DungeonRestrictionsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
