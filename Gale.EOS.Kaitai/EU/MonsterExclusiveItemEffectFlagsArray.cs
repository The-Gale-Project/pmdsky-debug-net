// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array monster_exclusive_item_effect_flags defined within pmdsky.
    /// </summary>
    public partial class MonsterExclusiveItemEffectFlagsArray : KaitaiStruct
    {
        public static MonsterExclusiveItemEffectFlagsArray FromFile(string fileName)
        {
            return new MonsterExclusiveItemEffectFlagsArray(new KaitaiStream(fileName));
        }

        public MonsterExclusiveItemEffectFlagsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MonsterExclusiveItemEffectFlagsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MonsterExclusiveItemEffectFlagsArrayDim0(m_io, this, m_root);
        }
        public partial class MonsterExclusiveItemEffectFlagsArrayDim0 : KaitaiStruct
        {
            public static MonsterExclusiveItemEffectFlagsArrayDim0 FromFile(string fileName)
            {
                return new MonsterExclusiveItemEffectFlagsArrayDim0(new KaitaiStream(fileName));
            }

            public MonsterExclusiveItemEffectFlagsArrayDim0(KaitaiStream p__io, MonsterExclusiveItemEffectFlagsArray p__parent = null, MonsterExclusiveItemEffectFlagsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<uint>();
                for (var i = 0; i < 5; i++)
                {
                    _entries.Add(m_io.ReadU4le());
                }
            }
            private List<uint> _entries;
            private MonsterExclusiveItemEffectFlagsArray m_root;
            private MonsterExclusiveItemEffectFlagsArray m_parent;
            public List<uint> Entries { get { return _entries; } }
            public MonsterExclusiveItemEffectFlagsArray M_Root { get { return m_root; } }
            public MonsterExclusiveItemEffectFlagsArray M_Parent { get { return m_parent; } }
        }
        private MonsterExclusiveItemEffectFlagsArrayDim0 _entries;
        private MonsterExclusiveItemEffectFlagsArray m_root;
        private KaitaiStruct m_parent;
        public MonsterExclusiveItemEffectFlagsArrayDim0 Entries { get { return _entries; } }
        public MonsterExclusiveItemEffectFlagsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
