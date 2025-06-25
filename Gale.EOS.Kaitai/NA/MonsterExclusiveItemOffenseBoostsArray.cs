// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array monster_exclusive_item_offense_boosts defined within pmdsky.
    /// </summary>
    public partial class MonsterExclusiveItemOffenseBoostsArray : KaitaiStruct
    {
        public static MonsterExclusiveItemOffenseBoostsArray FromFile(string fileName)
        {
            return new MonsterExclusiveItemOffenseBoostsArray(new KaitaiStream(fileName));
        }

        public MonsterExclusiveItemOffenseBoostsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MonsterExclusiveItemOffenseBoostsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MonsterExclusiveItemOffenseBoostsArrayDim0(m_io, this, m_root);
        }
        public partial class MonsterExclusiveItemOffenseBoostsArrayDim0 : KaitaiStruct
        {
            public static MonsterExclusiveItemOffenseBoostsArrayDim0 FromFile(string fileName)
            {
                return new MonsterExclusiveItemOffenseBoostsArrayDim0(new KaitaiStream(fileName));
            }

            public MonsterExclusiveItemOffenseBoostsArrayDim0(KaitaiStream p__io, MonsterExclusiveItemOffenseBoostsArray p__parent = null, MonsterExclusiveItemOffenseBoostsArray p__root = null) : base(p__io)
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
            private MonsterExclusiveItemOffenseBoostsArray m_root;
            private MonsterExclusiveItemOffenseBoostsArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public MonsterExclusiveItemOffenseBoostsArray M_Root { get { return m_root; } }
            public MonsterExclusiveItemOffenseBoostsArray M_Parent { get { return m_parent; } }
        }
        private MonsterExclusiveItemOffenseBoostsArrayDim0 _entries;
        private MonsterExclusiveItemOffenseBoostsArray m_root;
        private KaitaiStruct m_parent;
        public MonsterExclusiveItemOffenseBoostsArrayDim0 Entries { get { return _entries; } }
        public MonsterExclusiveItemOffenseBoostsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
