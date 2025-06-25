// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array EAT_ITEM_EFFECT_IGNORE_LIST defined within pmdsky.
    /// </summary>
    public partial class EatItemEffectIgnoreListArray : KaitaiStruct
    {
        public static EatItemEffectIgnoreListArray FromFile(string fileName)
        {
            return new EatItemEffectIgnoreListArray(new KaitaiStream(fileName));
        }

        public EatItemEffectIgnoreListArray(KaitaiStream p__io, KaitaiStruct p__parent = null, EatItemEffectIgnoreListArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new EatItemEffectIgnoreListArrayDim0(m_io, this, m_root);
        }
        public partial class EatItemEffectIgnoreListArrayDim0 : KaitaiStruct
        {
            public static EatItemEffectIgnoreListArrayDim0 FromFile(string fileName)
            {
                return new EatItemEffectIgnoreListArrayDim0(new KaitaiStream(fileName));
            }

            public EatItemEffectIgnoreListArrayDim0(KaitaiStream p__io, EatItemEffectIgnoreListArray p__parent = null, EatItemEffectIgnoreListArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<ItemId16>();
                for (var i = 0; i < 36; i++)
                {
                    _entries.Add(new ItemId16(m_io));
                }
            }
            private List<ItemId16> _entries;
            private EatItemEffectIgnoreListArray m_root;
            private EatItemEffectIgnoreListArray m_parent;
            public List<ItemId16> Entries { get { return _entries; } }
            public EatItemEffectIgnoreListArray M_Root { get { return m_root; } }
            public EatItemEffectIgnoreListArray M_Parent { get { return m_parent; } }
        }
        private EatItemEffectIgnoreListArrayDim0 _entries;
        private EatItemEffectIgnoreListArray m_root;
        private KaitaiStruct m_parent;
        public EatItemEffectIgnoreListArrayDim0 Entries { get { return _entries; } }
        public EatItemEffectIgnoreListArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
