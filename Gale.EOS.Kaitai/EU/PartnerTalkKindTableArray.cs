// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array PARTNER_TALK_KIND_TABLE defined within pmdsky.
    /// </summary>
    public partial class PartnerTalkKindTableArray : KaitaiStruct
    {
        public static PartnerTalkKindTableArray FromFile(string fileName)
        {
            return new PartnerTalkKindTableArray(new KaitaiStream(fileName));
        }

        public PartnerTalkKindTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, PartnerTalkKindTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new PartnerTalkKindTableArrayDim0(m_io, this, m_root);
        }
        public partial class PartnerTalkKindTableArrayDim0 : KaitaiStruct
        {
            public static PartnerTalkKindTableArrayDim0 FromFile(string fileName)
            {
                return new PartnerTalkKindTableArrayDim0(new KaitaiStream(fileName));
            }

            public PartnerTalkKindTableArrayDim0(KaitaiStream p__io, PartnerTalkKindTableArray p__parent = null, PartnerTalkKindTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<PartnerTalkKindTableEntry>();
                for (var i = 0; i < 11; i++)
                {
                    _entries.Add(new PartnerTalkKindTableEntry(m_io));
                }
            }
            private List<PartnerTalkKindTableEntry> _entries;
            private PartnerTalkKindTableArray m_root;
            private PartnerTalkKindTableArray m_parent;
            public List<PartnerTalkKindTableEntry> Entries { get { return _entries; } }
            public PartnerTalkKindTableArray M_Root { get { return m_root; } }
            public PartnerTalkKindTableArray M_Parent { get { return m_parent; } }
        }
        private PartnerTalkKindTableArrayDim0 _entries;
        private PartnerTalkKindTableArray m_root;
        private KaitaiStruct m_parent;
        public PartnerTalkKindTableArrayDim0 Entries { get { return _entries; } }
        public PartnerTalkKindTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
