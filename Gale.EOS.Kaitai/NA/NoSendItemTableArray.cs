// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array NO_SEND_ITEM_TABLE defined within pmdsky.
    /// </summary>
    public partial class NoSendItemTableArray : KaitaiStruct
    {
        public static NoSendItemTableArray FromFile(string fileName)
        {
            return new NoSendItemTableArray(new KaitaiStream(fileName));
        }

        public NoSendItemTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, NoSendItemTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new NoSendItemTableArrayDim0(m_io, this, m_root);
        }
        public partial class NoSendItemTableArrayDim0 : KaitaiStruct
        {
            public static NoSendItemTableArrayDim0 FromFile(string fileName)
            {
                return new NoSendItemTableArrayDim0(new KaitaiStream(fileName));
            }

            public NoSendItemTableArrayDim0(KaitaiStream p__io, NoSendItemTableArray p__parent = null, NoSendItemTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<ItemId16>();
                for (var i = 0; i < 3; i++)
                {
                    _entries.Add(new ItemId16(m_io));
                }
            }
            private List<ItemId16> _entries;
            private NoSendItemTableArray m_root;
            private NoSendItemTableArray m_parent;
            public List<ItemId16> Entries { get { return _entries; } }
            public NoSendItemTableArray M_Root { get { return m_root; } }
            public NoSendItemTableArray M_Parent { get { return m_parent; } }
        }
        private NoSendItemTableArrayDim0 _entries;
        private NoSendItemTableArray m_root;
        private KaitaiStruct m_parent;
        public NoSendItemTableArrayDim0 Entries { get { return _entries; } }
        public NoSendItemTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
