// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array BAD_POISON_DAMAGE_TABLE defined within pmdsky.
    /// </summary>
    public partial class BadPoisonDamageTableArray : KaitaiStruct
    {
        public static BadPoisonDamageTableArray FromFile(string fileName)
        {
            return new BadPoisonDamageTableArray(new KaitaiStream(fileName));
        }

        public BadPoisonDamageTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, BadPoisonDamageTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new BadPoisonDamageTableArrayDim0(m_io, this, m_root);
        }
        public partial class BadPoisonDamageTableArrayDim0 : KaitaiStruct
        {
            public static BadPoisonDamageTableArrayDim0 FromFile(string fileName)
            {
                return new BadPoisonDamageTableArrayDim0(new KaitaiStream(fileName));
            }

            public BadPoisonDamageTableArrayDim0(KaitaiStream p__io, BadPoisonDamageTableArray p__parent = null, BadPoisonDamageTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<short>();
                for (var i = 0; i < 30; i++)
                {
                    _entries.Add(m_io.ReadS2le());
                }
            }
            private List<short> _entries;
            private BadPoisonDamageTableArray m_root;
            private BadPoisonDamageTableArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public BadPoisonDamageTableArray M_Root { get { return m_root; } }
            public BadPoisonDamageTableArray M_Parent { get { return m_parent; } }
        }
        private BadPoisonDamageTableArrayDim0 _entries;
        private BadPoisonDamageTableArray m_root;
        private KaitaiStruct m_parent;
        public BadPoisonDamageTableArrayDim0 Entries { get { return _entries; } }
        public BadPoisonDamageTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
