// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array TEX_PLTT_START_ADDR_TABLE defined within pmdsky.
    /// </summary>
    public partial class TexPlttStartAddrTableArray : KaitaiStruct
    {
        public static TexPlttStartAddrTableArray FromFile(string fileName)
        {
            return new TexPlttStartAddrTableArray(new KaitaiStream(fileName));
        }

        public TexPlttStartAddrTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, TexPlttStartAddrTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new TexPlttStartAddrTableArrayDim0(m_io, this, m_root);
        }
        public partial class TexPlttStartAddrTableArrayDim0 : KaitaiStruct
        {
            public static TexPlttStartAddrTableArrayDim0 FromFile(string fileName)
            {
                return new TexPlttStartAddrTableArrayDim0(new KaitaiStream(fileName));
            }

            public TexPlttStartAddrTableArrayDim0(KaitaiStream p__io, TexPlttStartAddrTableArray p__parent = null, TexPlttStartAddrTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<short>();
                for (var i = 0; i < 8; i++)
                {
                    _entries.Add(m_io.ReadS2le());
                }
            }
            private List<short> _entries;
            private TexPlttStartAddrTableArray m_root;
            private TexPlttStartAddrTableArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public TexPlttStartAddrTableArray M_Root { get { return m_root; } }
            public TexPlttStartAddrTableArray M_Parent { get { return m_parent; } }
        }
        private TexPlttStartAddrTableArrayDim0 _entries;
        private TexPlttStartAddrTableArray m_root;
        private KaitaiStruct m_parent;
        public TexPlttStartAddrTableArrayDim0 Entries { get { return _entries; } }
        public TexPlttStartAddrTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
