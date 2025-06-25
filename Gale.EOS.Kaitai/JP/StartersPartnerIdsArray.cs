// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array STARTERS_PARTNER_IDS defined within pmdsky.
    /// </summary>
    public partial class StartersPartnerIdsArray : KaitaiStruct
    {
        public static StartersPartnerIdsArray FromFile(string fileName)
        {
            return new StartersPartnerIdsArray(new KaitaiStream(fileName));
        }

        public StartersPartnerIdsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, StartersPartnerIdsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StartersPartnerIdsArrayDim0(m_io, this, m_root);
        }
        public partial class StartersPartnerIdsArrayDim0 : KaitaiStruct
        {
            public static StartersPartnerIdsArrayDim0 FromFile(string fileName)
            {
                return new StartersPartnerIdsArrayDim0(new KaitaiStream(fileName));
            }

            public StartersPartnerIdsArrayDim0(KaitaiStream p__io, StartersPartnerIdsArray p__parent = null, StartersPartnerIdsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<MonsterId16>();
                for (var i = 0; i < 21; i++)
                {
                    _entries.Add(new MonsterId16(m_io));
                }
            }
            private List<MonsterId16> _entries;
            private StartersPartnerIdsArray m_root;
            private StartersPartnerIdsArray m_parent;
            public List<MonsterId16> Entries { get { return _entries; } }
            public StartersPartnerIdsArray M_Root { get { return m_root; } }
            public StartersPartnerIdsArray M_Parent { get { return m_parent; } }
        }
        private StartersPartnerIdsArrayDim0 _entries;
        private StartersPartnerIdsArray m_root;
        private KaitaiStruct m_parent;
        public StartersPartnerIdsArrayDim0 Entries { get { return _entries; } }
        public StartersPartnerIdsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
