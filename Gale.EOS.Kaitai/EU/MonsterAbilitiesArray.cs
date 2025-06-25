// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array monster_abilities defined within pmdsky.
    /// </summary>
    public partial class MonsterAbilitiesArray : KaitaiStruct
    {
        public static MonsterAbilitiesArray FromFile(string fileName)
        {
            return new MonsterAbilitiesArray(new KaitaiStream(fileName));
        }

        public MonsterAbilitiesArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MonsterAbilitiesArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MonsterAbilitiesArrayDim0(m_io, this, m_root);
        }
        public partial class MonsterAbilitiesArrayDim0 : KaitaiStruct
        {
            public static MonsterAbilitiesArrayDim0 FromFile(string fileName)
            {
                return new MonsterAbilitiesArrayDim0(new KaitaiStream(fileName));
            }

            public MonsterAbilitiesArrayDim0(KaitaiStream p__io, MonsterAbilitiesArray p__parent = null, MonsterAbilitiesArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<AbilityId8>();
                for (var i = 0; i < 2; i++)
                {
                    _entries.Add(new AbilityId8(m_io));
                }
            }
            private List<AbilityId8> _entries;
            private MonsterAbilitiesArray m_root;
            private MonsterAbilitiesArray m_parent;
            public List<AbilityId8> Entries { get { return _entries; } }
            public MonsterAbilitiesArray M_Root { get { return m_root; } }
            public MonsterAbilitiesArray M_Parent { get { return m_parent; } }
        }
        private MonsterAbilitiesArrayDim0 _entries;
        private MonsterAbilitiesArray m_root;
        private KaitaiStruct m_parent;
        public MonsterAbilitiesArrayDim0 Entries { get { return _entries; } }
        public MonsterAbilitiesArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
