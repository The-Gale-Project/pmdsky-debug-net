// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array WONDER_MAIL_BITS_MAP defined within pmdsky.
    /// </summary>
    public partial class WonderMailBitsMapArray : KaitaiStruct
    {
        public static WonderMailBitsMapArray FromFile(string fileName)
        {
            return new WonderMailBitsMapArray(new KaitaiStream(fileName));
        }

        public WonderMailBitsMapArray(KaitaiStream p__io, KaitaiStruct p__parent = null, WonderMailBitsMapArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new WonderMailBitsMapArrayDim0(m_io, this, m_root);
        }
        public partial class WonderMailBitsMapArrayDim0 : KaitaiStruct
        {
            public static WonderMailBitsMapArrayDim0 FromFile(string fileName)
            {
                return new WonderMailBitsMapArrayDim0(new KaitaiStream(fileName));
            }

            public WonderMailBitsMapArrayDim0(KaitaiStream p__io, WonderMailBitsMapArray p__parent = null, WonderMailBitsMapArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<byte>();
                for (var i = 0; i < 32; i++)
                {
                    _entries.Add(m_io.ReadU1());
                }
            }
            private List<byte> _entries;
            private WonderMailBitsMapArray m_root;
            private WonderMailBitsMapArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public WonderMailBitsMapArray M_Root { get { return m_root; } }
            public WonderMailBitsMapArray M_Parent { get { return m_parent; } }
        }
        private WonderMailBitsMapArrayDim0 _entries;
        private WonderMailBitsMapArray m_root;
        private KaitaiStruct m_parent;
        public WonderMailBitsMapArrayDim0 Entries { get { return _entries; } }
        public WonderMailBitsMapArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
