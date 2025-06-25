// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array APPRAISAL_SUBMENU_ITEMS defined within pmdsky.
    /// </summary>
    public partial class AppraisalSubmenuItemsArray : KaitaiStruct
    {
        public static AppraisalSubmenuItemsArray FromFile(string fileName)
        {
            return new AppraisalSubmenuItemsArray(new KaitaiStream(fileName));
        }

        public AppraisalSubmenuItemsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, AppraisalSubmenuItemsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new AppraisalSubmenuItemsArrayDim0(m_io, this, m_root);
        }
        public partial class AppraisalSubmenuItemsArrayDim0 : KaitaiStruct
        {
            public static AppraisalSubmenuItemsArrayDim0 FromFile(string fileName)
            {
                return new AppraisalSubmenuItemsArrayDim0(new KaitaiStream(fileName));
            }

            public AppraisalSubmenuItemsArrayDim0(KaitaiStream p__io, AppraisalSubmenuItemsArray p__parent = null, AppraisalSubmenuItemsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<SimpleMenuIdItem>();
                for (var i = 0; i < 4; i++)
                {
                    _entries.Add(new SimpleMenuIdItem(m_io));
                }
            }
            private List<SimpleMenuIdItem> _entries;
            private AppraisalSubmenuItemsArray m_root;
            private AppraisalSubmenuItemsArray m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public AppraisalSubmenuItemsArray M_Root { get { return m_root; } }
            public AppraisalSubmenuItemsArray M_Parent { get { return m_parent; } }
        }
        private AppraisalSubmenuItemsArrayDim0 _entries;
        private AppraisalSubmenuItemsArray m_root;
        private KaitaiStruct m_parent;
        public AppraisalSubmenuItemsArrayDim0 Entries { get { return _entries; } }
        public AppraisalSubmenuItemsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
