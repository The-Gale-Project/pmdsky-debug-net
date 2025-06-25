// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array MONEY_QUANTITY_TABLE defined within pmdsky.
    /// </summary>
    public partial class MoneyQuantityTableArray : KaitaiStruct
    {
        public static MoneyQuantityTableArray FromFile(string fileName)
        {
            return new MoneyQuantityTableArray(new KaitaiStream(fileName));
        }

        public MoneyQuantityTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MoneyQuantityTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MoneyQuantityTableArrayDim0(m_io, this, m_root);
        }
        public partial class MoneyQuantityTableArrayDim0 : KaitaiStruct
        {
            public static MoneyQuantityTableArrayDim0 FromFile(string fileName)
            {
                return new MoneyQuantityTableArrayDim0(new KaitaiStream(fileName));
            }

            public MoneyQuantityTableArrayDim0(KaitaiStream p__io, MoneyQuantityTableArray p__parent = null, MoneyQuantityTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<int>();
                for (var i = 0; i < 100; i++)
                {
                    _entries.Add(m_io.ReadS4le());
                }
            }
            private List<int> _entries;
            private MoneyQuantityTableArray m_root;
            private MoneyQuantityTableArray m_parent;
            public List<int> Entries { get { return _entries; } }
            public MoneyQuantityTableArray M_Root { get { return m_root; } }
            public MoneyQuantityTableArray M_Parent { get { return m_parent; } }
        }
        private MoneyQuantityTableArrayDim0 _entries;
        private MoneyQuantityTableArray m_root;
        private KaitaiStruct m_parent;
        public MoneyQuantityTableArrayDim0 Entries { get { return _entries; } }
        public MoneyQuantityTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
