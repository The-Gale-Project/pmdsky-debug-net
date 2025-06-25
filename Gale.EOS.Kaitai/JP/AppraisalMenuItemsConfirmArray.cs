// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array APPRAISAL_MENU_ITEMS_CONFIRM defined within pmdsky.
    /// </summary>
    public partial class AppraisalMenuItemsConfirmArray : KaitaiStruct
    {
        public static AppraisalMenuItemsConfirmArray FromFile(string fileName)
        {
            return new AppraisalMenuItemsConfirmArray(new KaitaiStream(fileName));
        }

        public AppraisalMenuItemsConfirmArray(KaitaiStream p__io, KaitaiStruct p__parent = null, AppraisalMenuItemsConfirmArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new AppraisalMenuItemsConfirmArrayDim0(m_io, this, m_root);
        }
        public partial class AppraisalMenuItemsConfirmArrayDim0 : KaitaiStruct
        {
            public static AppraisalMenuItemsConfirmArrayDim0 FromFile(string fileName)
            {
                return new AppraisalMenuItemsConfirmArrayDim0(new KaitaiStream(fileName));
            }

            public AppraisalMenuItemsConfirmArrayDim0(KaitaiStream p__io, AppraisalMenuItemsConfirmArray p__parent = null, AppraisalMenuItemsConfirmArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<SimpleMenuIdItem>();
                for (var i = 0; i < 3; i++)
                {
                    _entries.Add(new SimpleMenuIdItem(m_io));
                }
            }
            private List<SimpleMenuIdItem> _entries;
            private AppraisalMenuItemsConfirmArray m_root;
            private AppraisalMenuItemsConfirmArray m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public AppraisalMenuItemsConfirmArray M_Root { get { return m_root; } }
            public AppraisalMenuItemsConfirmArray M_Parent { get { return m_parent; } }
        }
        private AppraisalMenuItemsConfirmArrayDim0 _entries;
        private AppraisalMenuItemsConfirmArray m_root;
        private KaitaiStruct m_parent;
        public AppraisalMenuItemsConfirmArrayDim0 Entries { get { return _entries; } }
        public AppraisalMenuItemsConfirmArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
