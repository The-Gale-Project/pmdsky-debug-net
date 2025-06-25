// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array WRING_OUT_DAMAGE_MULT_TABLE defined within pmdsky.
    /// </summary>
    public partial class WringOutDamageMultTableArray : KaitaiStruct
    {
        public static WringOutDamageMultTableArray FromFile(string fileName)
        {
            return new WringOutDamageMultTableArray(new KaitaiStream(fileName));
        }

        public WringOutDamageMultTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, WringOutDamageMultTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new WringOutDamageMultTableArrayDim0(m_io, this, m_root);
        }
        public partial class WringOutDamageMultTableArrayDim0 : KaitaiStruct
        {
            public static WringOutDamageMultTableArrayDim0 FromFile(string fileName)
            {
                return new WringOutDamageMultTableArrayDim0(new KaitaiStream(fileName));
            }

            public WringOutDamageMultTableArrayDim0(KaitaiStream p__io, WringOutDamageMultTableArray p__parent = null, WringOutDamageMultTableArray p__root = null) : base(p__io)
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
            private WringOutDamageMultTableArray m_root;
            private WringOutDamageMultTableArray m_parent;
            public List<int> Entries { get { return _entries; } }
            public WringOutDamageMultTableArray M_Root { get { return m_root; } }
            public WringOutDamageMultTableArray M_Parent { get { return m_parent; } }
        }
        private WringOutDamageMultTableArrayDim0 _entries;
        private WringOutDamageMultTableArray m_root;
        private KaitaiStruct m_parent;
        public WringOutDamageMultTableArrayDim0 Entries { get { return _entries; } }
        public WringOutDamageMultTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
