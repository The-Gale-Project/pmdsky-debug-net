// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array ITEM_ANIMATION_INFO defined within pmdsky.
    /// </summary>
    public partial class ItemAnimationInfoArray : KaitaiStruct
    {
        public static ItemAnimationInfoArray FromFile(string fileName)
        {
            return new ItemAnimationInfoArray(new KaitaiStream(fileName));
        }

        public ItemAnimationInfoArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ItemAnimationInfoArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ItemAnimationInfoArrayDim0(m_io, this, m_root);
        }
        public partial class ItemAnimationInfoArrayDim0 : KaitaiStruct
        {
            public static ItemAnimationInfoArrayDim0 FromFile(string fileName)
            {
                return new ItemAnimationInfoArrayDim0(new KaitaiStream(fileName));
            }

            public ItemAnimationInfoArrayDim0(KaitaiStream p__io, ItemAnimationInfoArray p__parent = null, ItemAnimationInfoArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<ItemAnimation>();
                for (var i = 0; i < 1400; i++)
                {
                    _entries.Add(new ItemAnimation(m_io));
                }
            }
            private List<ItemAnimation> _entries;
            private ItemAnimationInfoArray m_root;
            private ItemAnimationInfoArray m_parent;
            public List<ItemAnimation> Entries { get { return _entries; } }
            public ItemAnimationInfoArray M_Root { get { return m_root; } }
            public ItemAnimationInfoArray M_Parent { get { return m_parent; } }
        }
        private ItemAnimationInfoArrayDim0 _entries;
        private ItemAnimationInfoArray m_root;
        private KaitaiStruct m_parent;
        public ItemAnimationInfoArrayDim0 Entries { get { return _entries; } }
        public ItemAnimationInfoArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
