// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array CART_REMOVED_IMG_DATA defined within pmdsky.
    /// </summary>
    public partial class CartRemovedImgDataArray : KaitaiStruct
    {
        public static CartRemovedImgDataArray FromFile(string fileName)
        {
            return new CartRemovedImgDataArray(new KaitaiStream(fileName));
        }

        public CartRemovedImgDataArray(KaitaiStream p__io, KaitaiStruct p__parent = null, CartRemovedImgDataArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new CartRemovedImgDataArrayDim0(m_io, this, m_root);
        }
        public partial class CartRemovedImgDataArrayDim0 : KaitaiStruct
        {
            public static CartRemovedImgDataArrayDim0 FromFile(string fileName)
            {
                return new CartRemovedImgDataArrayDim0(new KaitaiStream(fileName));
            }

            public CartRemovedImgDataArrayDim0(KaitaiStream p__io, CartRemovedImgDataArray p__parent = null, CartRemovedImgDataArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<byte>();
                for (var i = 0; i < 0; i++)
                {
                    _entries.Add(m_io.ReadU1());
                }
            }
            private List<byte> _entries;
            private CartRemovedImgDataArray m_root;
            private CartRemovedImgDataArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public CartRemovedImgDataArray M_Root { get { return m_root; } }
            public CartRemovedImgDataArray M_Parent { get { return m_parent; } }
        }
        private CartRemovedImgDataArrayDim0 _entries;
        private CartRemovedImgDataArray m_root;
        private KaitaiStruct m_parent;
        public CartRemovedImgDataArrayDim0 Entries { get { return _entries; } }
        public CartRemovedImgDataArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
