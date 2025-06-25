// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array TREASURE_BOX_1_ITEM_IDS defined within pmdsky.
    /// </summary>
    public partial class TreasureBox1ItemIdsArray : KaitaiStruct
    {
        public static TreasureBox1ItemIdsArray FromFile(string fileName)
        {
            return new TreasureBox1ItemIdsArray(new KaitaiStream(fileName));
        }

        public TreasureBox1ItemIdsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, TreasureBox1ItemIdsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new TreasureBox1ItemIdsArrayDim0(m_io, this, m_root);
        }
        public partial class TreasureBox1ItemIdsArrayDim0 : KaitaiStruct
        {
            public static TreasureBox1ItemIdsArrayDim0 FromFile(string fileName)
            {
                return new TreasureBox1ItemIdsArrayDim0(new KaitaiStream(fileName));
            }

            public TreasureBox1ItemIdsArrayDim0(KaitaiStream p__io, TreasureBox1ItemIdsArray p__parent = null, TreasureBox1ItemIdsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<ItemId16>();
                for (var i = 0; i < 12; i++)
                {
                    _entries.Add(new ItemId16(m_io));
                }
            }
            private List<ItemId16> _entries;
            private TreasureBox1ItemIdsArray m_root;
            private TreasureBox1ItemIdsArray m_parent;
            public List<ItemId16> Entries { get { return _entries; } }
            public TreasureBox1ItemIdsArray M_Root { get { return m_root; } }
            public TreasureBox1ItemIdsArray M_Parent { get { return m_parent; } }
        }
        private TreasureBox1ItemIdsArrayDim0 _entries;
        private TreasureBox1ItemIdsArray m_root;
        private KaitaiStruct m_parent;
        public TreasureBox1ItemIdsArrayDim0 Entries { get { return _entries; } }
        public TreasureBox1ItemIdsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
