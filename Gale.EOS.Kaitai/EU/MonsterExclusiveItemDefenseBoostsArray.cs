// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array monster_exclusive_item_defense_boosts defined within pmdsky.
    /// </summary>
    public partial class MonsterExclusiveItemDefenseBoostsArray : KaitaiStruct
    {
        public static MonsterExclusiveItemDefenseBoostsArray FromFile(string fileName)
        {
            return new MonsterExclusiveItemDefenseBoostsArray(new KaitaiStream(fileName));
        }

        public MonsterExclusiveItemDefenseBoostsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MonsterExclusiveItemDefenseBoostsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MonsterExclusiveItemDefenseBoostsArrayDim0(m_io, this, m_root);
        }
        public partial class MonsterExclusiveItemDefenseBoostsArrayDim0 : KaitaiStruct
        {
            public static MonsterExclusiveItemDefenseBoostsArrayDim0 FromFile(string fileName)
            {
                return new MonsterExclusiveItemDefenseBoostsArrayDim0(new KaitaiStream(fileName));
            }

            public MonsterExclusiveItemDefenseBoostsArrayDim0(KaitaiStream p__io, MonsterExclusiveItemDefenseBoostsArray p__parent = null, MonsterExclusiveItemDefenseBoostsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<byte>();
                for (var i = 0; i < 2; i++)
                {
                    _entries.Add(m_io.ReadU1());
                }
            }
            private List<byte> _entries;
            private MonsterExclusiveItemDefenseBoostsArray m_root;
            private MonsterExclusiveItemDefenseBoostsArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public MonsterExclusiveItemDefenseBoostsArray M_Root { get { return m_root; } }
            public MonsterExclusiveItemDefenseBoostsArray M_Parent { get { return m_parent; } }
        }
        private MonsterExclusiveItemDefenseBoostsArrayDim0 _entries;
        private MonsterExclusiveItemDefenseBoostsArray m_root;
        private KaitaiStruct m_parent;
        public MonsterExclusiveItemDefenseBoostsArrayDim0 Entries { get { return _entries; } }
        public MonsterExclusiveItemDefenseBoostsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
