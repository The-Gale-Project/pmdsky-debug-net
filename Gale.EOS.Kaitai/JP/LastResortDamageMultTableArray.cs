// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array LAST_RESORT_DAMAGE_MULT_TABLE defined within pmdsky.
    /// </summary>
    public partial class LastResortDamageMultTableArray : KaitaiStruct
    {
        public static LastResortDamageMultTableArray FromFile(string fileName)
        {
            return new LastResortDamageMultTableArray(new KaitaiStream(fileName));
        }

        public LastResortDamageMultTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, LastResortDamageMultTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new LastResortDamageMultTableArrayDim0(m_io, this, m_root);
        }
        public partial class LastResortDamageMultTableArrayDim0 : KaitaiStruct
        {
            public static LastResortDamageMultTableArrayDim0 FromFile(string fileName)
            {
                return new LastResortDamageMultTableArrayDim0(new KaitaiStream(fileName));
            }

            public LastResortDamageMultTableArrayDim0(KaitaiStream p__io, LastResortDamageMultTableArray p__parent = null, LastResortDamageMultTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<int>();
                for (var i = 0; i < 4; i++)
                {
                    _entries.Add(m_io.ReadS4le());
                }
            }
            private List<int> _entries;
            private LastResortDamageMultTableArray m_root;
            private LastResortDamageMultTableArray m_parent;
            public List<int> Entries { get { return _entries; } }
            public LastResortDamageMultTableArray M_Root { get { return m_root; } }
            public LastResortDamageMultTableArray M_Parent { get { return m_parent; } }
        }
        private LastResortDamageMultTableArrayDim0 _entries;
        private LastResortDamageMultTableArray m_root;
        private KaitaiStruct m_parent;
        public LastResortDamageMultTableArrayDim0 Entries { get { return _entries; } }
        public LastResortDamageMultTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
