// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array WONDER_MAIL_ENCRYPTION_TABLE defined within pmdsky.
    /// </summary>
    public partial class WonderMailEncryptionTableArray : KaitaiStruct
    {
        public static WonderMailEncryptionTableArray FromFile(string fileName)
        {
            return new WonderMailEncryptionTableArray(new KaitaiStream(fileName));
        }

        public WonderMailEncryptionTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, WonderMailEncryptionTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new WonderMailEncryptionTableArrayDim0(m_io, this, m_root);
        }
        public partial class WonderMailEncryptionTableArrayDim0 : KaitaiStruct
        {
            public static WonderMailEncryptionTableArrayDim0 FromFile(string fileName)
            {
                return new WonderMailEncryptionTableArrayDim0(new KaitaiStream(fileName));
            }

            public WonderMailEncryptionTableArrayDim0(KaitaiStream p__io, WonderMailEncryptionTableArray p__parent = null, WonderMailEncryptionTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<byte>();
                for (var i = 0; i < 256; i++)
                {
                    _entries.Add(m_io.ReadU1());
                }
            }
            private List<byte> _entries;
            private WonderMailEncryptionTableArray m_root;
            private WonderMailEncryptionTableArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public WonderMailEncryptionTableArray M_Root { get { return m_root; } }
            public WonderMailEncryptionTableArray M_Parent { get { return m_parent; } }
        }
        private WonderMailEncryptionTableArrayDim0 _entries;
        private WonderMailEncryptionTableArray m_root;
        private KaitaiStruct m_parent;
        public WonderMailEncryptionTableArrayDim0 Entries { get { return _entries; } }
        public WonderMailEncryptionTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
