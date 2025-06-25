// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array TYPE_DAMAGE_NEGATING_EXCLUSIVE_ITEM_EFFECTS defined within pmdsky.
    /// </summary>
    public partial class TypeDamageNegatingExclusiveItemEffectsArray : KaitaiStruct
    {
        public static TypeDamageNegatingExclusiveItemEffectsArray FromFile(string fileName)
        {
            return new TypeDamageNegatingExclusiveItemEffectsArray(new KaitaiStream(fileName));
        }

        public TypeDamageNegatingExclusiveItemEffectsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, TypeDamageNegatingExclusiveItemEffectsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new TypeDamageNegatingExclusiveItemEffectsArrayDim0(m_io, this, m_root);
        }
        public partial class TypeDamageNegatingExclusiveItemEffectsArrayDim0 : KaitaiStruct
        {
            public static TypeDamageNegatingExclusiveItemEffectsArrayDim0 FromFile(string fileName)
            {
                return new TypeDamageNegatingExclusiveItemEffectsArrayDim0(new KaitaiStream(fileName));
            }

            public TypeDamageNegatingExclusiveItemEffectsArrayDim0(KaitaiStream p__io, TypeDamageNegatingExclusiveItemEffectsArray p__parent = null, TypeDamageNegatingExclusiveItemEffectsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<DamageNegatingExclusiveEffEntry>();
                for (var i = 0; i < 28; i++)
                {
                    _entries.Add(new DamageNegatingExclusiveEffEntry(m_io));
                }
            }
            private List<DamageNegatingExclusiveEffEntry> _entries;
            private TypeDamageNegatingExclusiveItemEffectsArray m_root;
            private TypeDamageNegatingExclusiveItemEffectsArray m_parent;
            public List<DamageNegatingExclusiveEffEntry> Entries { get { return _entries; } }
            public TypeDamageNegatingExclusiveItemEffectsArray M_Root { get { return m_root; } }
            public TypeDamageNegatingExclusiveItemEffectsArray M_Parent { get { return m_parent; } }
        }
        private TypeDamageNegatingExclusiveItemEffectsArrayDim0 _entries;
        private TypeDamageNegatingExclusiveItemEffectsArray m_root;
        private KaitaiStruct m_parent;
        public TypeDamageNegatingExclusiveItemEffectsArrayDim0 Entries { get { return _entries; } }
        public TypeDamageNegatingExclusiveItemEffectsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
