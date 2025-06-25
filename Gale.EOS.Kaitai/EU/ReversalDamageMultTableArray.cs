// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array REVERSAL_DAMAGE_MULT_TABLE defined within pmdsky.
    /// </summary>
    public partial class ReversalDamageMultTableArray : KaitaiStruct
    {
        public static ReversalDamageMultTableArray FromFile(string fileName)
        {
            return new ReversalDamageMultTableArray(new KaitaiStream(fileName));
        }

        public ReversalDamageMultTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ReversalDamageMultTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ReversalDamageMultTableArrayDim0(m_io, this, m_root);
        }
        public partial class ReversalDamageMultTableArrayDim0 : KaitaiStruct
        {
            public static ReversalDamageMultTableArrayDim0 FromFile(string fileName)
            {
                return new ReversalDamageMultTableArrayDim0(new KaitaiStream(fileName));
            }

            public ReversalDamageMultTableArrayDim0(KaitaiStream p__io, ReversalDamageMultTableArray p__parent = null, ReversalDamageMultTableArray p__root = null) : base(p__io)
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
            private ReversalDamageMultTableArray m_root;
            private ReversalDamageMultTableArray m_parent;
            public List<int> Entries { get { return _entries; } }
            public ReversalDamageMultTableArray M_Root { get { return m_root; } }
            public ReversalDamageMultTableArray M_Parent { get { return m_parent; } }
        }
        private ReversalDamageMultTableArrayDim0 _entries;
        private ReversalDamageMultTableArray m_root;
        private KaitaiStruct m_parent;
        public ReversalDamageMultTableArrayDim0 Entries { get { return _entries; } }
        public ReversalDamageMultTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
