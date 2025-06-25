// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array APPLES_AND_BERRIES_ITEM_IDS defined within pmdsky.
    /// </summary>
    public partial class ApplesAndBerriesItemIdsArray : KaitaiStruct
    {
        public static ApplesAndBerriesItemIdsArray FromFile(string fileName)
        {
            return new ApplesAndBerriesItemIdsArray(new KaitaiStream(fileName));
        }

        public ApplesAndBerriesItemIdsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ApplesAndBerriesItemIdsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ApplesAndBerriesItemIdsArrayDim0(m_io, this, m_root);
        }
        public partial class ApplesAndBerriesItemIdsArrayDim0 : KaitaiStruct
        {
            public static ApplesAndBerriesItemIdsArrayDim0 FromFile(string fileName)
            {
                return new ApplesAndBerriesItemIdsArrayDim0(new KaitaiStream(fileName));
            }

            public ApplesAndBerriesItemIdsArrayDim0(KaitaiStream p__io, ApplesAndBerriesItemIdsArray p__parent = null, ApplesAndBerriesItemIdsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<ItemId16>();
                for (var i = 0; i < 66; i++)
                {
                    _entries.Add(new ItemId16(m_io));
                }
            }
            private List<ItemId16> _entries;
            private ApplesAndBerriesItemIdsArray m_root;
            private ApplesAndBerriesItemIdsArray m_parent;
            public List<ItemId16> Entries { get { return _entries; } }
            public ApplesAndBerriesItemIdsArray M_Root { get { return m_root; } }
            public ApplesAndBerriesItemIdsArray M_Parent { get { return m_parent; } }
        }
        private ApplesAndBerriesItemIdsArrayDim0 _entries;
        private ApplesAndBerriesItemIdsArray m_root;
        private KaitaiStruct m_parent;
        public ApplesAndBerriesItemIdsArrayDim0 Entries { get { return _entries; } }
        public ApplesAndBerriesItemIdsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
