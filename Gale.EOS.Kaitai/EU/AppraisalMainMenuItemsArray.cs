// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array APPRAISAL_MAIN_MENU_ITEMS defined within pmdsky.
    /// </summary>
    public partial class AppraisalMainMenuItemsArray : KaitaiStruct
    {
        public static AppraisalMainMenuItemsArray FromFile(string fileName)
        {
            return new AppraisalMainMenuItemsArray(new KaitaiStream(fileName));
        }

        public AppraisalMainMenuItemsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, AppraisalMainMenuItemsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new AppraisalMainMenuItemsArrayDim0(m_io, this, m_root);
        }
        public partial class AppraisalMainMenuItemsArrayDim0 : KaitaiStruct
        {
            public static AppraisalMainMenuItemsArrayDim0 FromFile(string fileName)
            {
                return new AppraisalMainMenuItemsArrayDim0(new KaitaiStream(fileName));
            }

            public AppraisalMainMenuItemsArrayDim0(KaitaiStream p__io, AppraisalMainMenuItemsArray p__parent = null, AppraisalMainMenuItemsArray p__root = null) : base(p__io)
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
            private AppraisalMainMenuItemsArray m_root;
            private AppraisalMainMenuItemsArray m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public AppraisalMainMenuItemsArray M_Root { get { return m_root; } }
            public AppraisalMainMenuItemsArray M_Parent { get { return m_parent; } }
        }
        private AppraisalMainMenuItemsArrayDim0 _entries;
        private AppraisalMainMenuItemsArray m_root;
        private KaitaiStruct m_parent;
        public AppraisalMainMenuItemsArrayDim0 Entries { get { return _entries; } }
        public AppraisalMainMenuItemsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
