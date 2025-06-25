// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array TEX_START_ADDR_TABLE defined within pmdsky.
    /// </summary>
    public partial class TexStartAddrTableArray : KaitaiStruct
    {
        public static TexStartAddrTableArray FromFile(string fileName)
        {
            return new TexStartAddrTableArray(new KaitaiStream(fileName));
        }

        public TexStartAddrTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, TexStartAddrTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new TexStartAddrTableArrayDim0(m_io, this, m_root);
        }
        public partial class TexStartAddrTableArrayDim0 : KaitaiStruct
        {
            public static TexStartAddrTableArrayDim0 FromFile(string fileName)
            {
                return new TexStartAddrTableArrayDim0(new KaitaiStream(fileName));
            }

            public TexStartAddrTableArrayDim0(KaitaiStream p__io, TexStartAddrTableArray p__parent = null, TexStartAddrTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<short>();
                for (var i = 0; i < 48; i++)
                {
                    _entries.Add(m_io.ReadS2le());
                }
            }
            private List<short> _entries;
            private TexStartAddrTableArray m_root;
            private TexStartAddrTableArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public TexStartAddrTableArray M_Root { get { return m_root; } }
            public TexStartAddrTableArray M_Parent { get { return m_parent; } }
        }
        private TexStartAddrTableArrayDim0 _entries;
        private TexStartAddrTableArray m_root;
        private KaitaiStruct m_parent;
        public TexStartAddrTableArrayDim0 Entries { get { return _entries; } }
        public TexStartAddrTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
