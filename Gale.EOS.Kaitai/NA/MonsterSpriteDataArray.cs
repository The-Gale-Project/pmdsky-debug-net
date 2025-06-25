// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array MONSTER_SPRITE_DATA defined within pmdsky.
    /// </summary>
    public partial class MonsterSpriteDataArray : KaitaiStruct
    {
        public static MonsterSpriteDataArray FromFile(string fileName)
        {
            return new MonsterSpriteDataArray(new KaitaiStream(fileName));
        }

        public MonsterSpriteDataArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MonsterSpriteDataArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MonsterSpriteDataArrayDim0(m_io, this, m_root);
        }
        public partial class MonsterSpriteDataArrayDim0 : KaitaiStruct
        {
            public static MonsterSpriteDataArrayDim0 FromFile(string fileName)
            {
                return new MonsterSpriteDataArrayDim0(new KaitaiStream(fileName));
            }

            public MonsterSpriteDataArrayDim0(KaitaiStream p__io, MonsterSpriteDataArray p__parent = null, MonsterSpriteDataArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<MonsterSpriteDataEntry>();
                for (var i = 0; i < 600; i++)
                {
                    _entries.Add(new MonsterSpriteDataEntry(m_io));
                }
            }
            private List<MonsterSpriteDataEntry> _entries;
            private MonsterSpriteDataArray m_root;
            private MonsterSpriteDataArray m_parent;
            public List<MonsterSpriteDataEntry> Entries { get { return _entries; } }
            public MonsterSpriteDataArray M_Root { get { return m_root; } }
            public MonsterSpriteDataArray M_Parent { get { return m_parent; } }
        }
        private MonsterSpriteDataArrayDim0 _entries;
        private MonsterSpriteDataArray m_root;
        private KaitaiStruct m_parent;
        public MonsterSpriteDataArrayDim0 Entries { get { return _entries; } }
        public MonsterSpriteDataArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
