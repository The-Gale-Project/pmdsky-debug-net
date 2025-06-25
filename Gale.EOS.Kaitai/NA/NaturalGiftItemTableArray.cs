// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array NATURAL_GIFT_ITEM_TABLE defined within pmdsky.
    /// </summary>
    public partial class NaturalGiftItemTableArray : KaitaiStruct
    {
        public static NaturalGiftItemTableArray FromFile(string fileName)
        {
            return new NaturalGiftItemTableArray(new KaitaiStream(fileName));
        }

        public NaturalGiftItemTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, NaturalGiftItemTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new NaturalGiftItemTableArrayDim0(m_io, this, m_root);
        }
        public partial class NaturalGiftItemTableArrayDim0 : KaitaiStruct
        {
            public static NaturalGiftItemTableArrayDim0 FromFile(string fileName)
            {
                return new NaturalGiftItemTableArrayDim0(new KaitaiStream(fileName));
            }

            public NaturalGiftItemTableArrayDim0(KaitaiStream p__io, NaturalGiftItemTableArray p__parent = null, NaturalGiftItemTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<NaturalGiftItemInfo>();
                for (var i = 0; i < 34; i++)
                {
                    _entries.Add(new NaturalGiftItemInfo(m_io));
                }
            }
            private List<NaturalGiftItemInfo> _entries;
            private NaturalGiftItemTableArray m_root;
            private NaturalGiftItemTableArray m_parent;
            public List<NaturalGiftItemInfo> Entries { get { return _entries; } }
            public NaturalGiftItemTableArray M_Root { get { return m_root; } }
            public NaturalGiftItemTableArray M_Parent { get { return m_parent; } }
        }
        private NaturalGiftItemTableArrayDim0 _entries;
        private NaturalGiftItemTableArray m_root;
        private KaitaiStruct m_parent;
        public NaturalGiftItemTableArrayDim0 Entries { get { return _entries; } }
        public NaturalGiftItemTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
