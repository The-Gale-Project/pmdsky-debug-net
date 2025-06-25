// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array DAMAGE_STRING_IDS defined within pmdsky.
    /// </summary>
    public partial class DamageStringIdsArray : KaitaiStruct
    {
        public static DamageStringIdsArray FromFile(string fileName)
        {
            return new DamageStringIdsArray(new KaitaiStream(fileName));
        }

        public DamageStringIdsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DamageStringIdsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DamageStringIdsArrayDim0(m_io, this, m_root);
        }
        public partial class DamageStringIdsArrayDim0 : KaitaiStruct
        {
            public static DamageStringIdsArrayDim0 FromFile(string fileName)
            {
                return new DamageStringIdsArrayDim0(new KaitaiStream(fileName));
            }

            public DamageStringIdsArrayDim0(KaitaiStream p__io, DamageStringIdsArray p__parent = null, DamageStringIdsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<short>();
                for (var i = 0; i < 27; i++)
                {
                    _entries.Add(m_io.ReadS2le());
                }
            }
            private List<short> _entries;
            private DamageStringIdsArray m_root;
            private DamageStringIdsArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public DamageStringIdsArray M_Root { get { return m_root; } }
            public DamageStringIdsArray M_Parent { get { return m_parent; } }
        }
        private DamageStringIdsArrayDim0 _entries;
        private DamageStringIdsArray m_root;
        private KaitaiStruct m_parent;
        public DamageStringIdsArrayDim0 Entries { get { return _entries; } }
        public DamageStringIdsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
