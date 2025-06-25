// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array CLIENT_LEVEL_TABLE defined within pmdsky.
    /// </summary>
    public partial class ClientLevelTableArray : KaitaiStruct
    {
        public static ClientLevelTableArray FromFile(string fileName)
        {
            return new ClientLevelTableArray(new KaitaiStream(fileName));
        }

        public ClientLevelTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ClientLevelTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ClientLevelTableArrayDim0(m_io, this, m_root);
        }
        public partial class ClientLevelTableArrayDim0 : KaitaiStruct
        {
            public static ClientLevelTableArrayDim0 FromFile(string fileName)
            {
                return new ClientLevelTableArrayDim0(new KaitaiStream(fileName));
            }

            public ClientLevelTableArrayDim0(KaitaiStream p__io, ClientLevelTableArray p__parent = null, ClientLevelTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<short>();
                for (var i = 0; i < 16; i++)
                {
                    _entries.Add(m_io.ReadS2le());
                }
            }
            private List<short> _entries;
            private ClientLevelTableArray m_root;
            private ClientLevelTableArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public ClientLevelTableArray M_Root { get { return m_root; } }
            public ClientLevelTableArray M_Parent { get { return m_parent; } }
        }
        private ClientLevelTableArrayDim0 _entries;
        private ClientLevelTableArray m_root;
        private KaitaiStruct m_parent;
        public ClientLevelTableArrayDim0 Entries { get { return _entries; } }
        public ClientLevelTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
