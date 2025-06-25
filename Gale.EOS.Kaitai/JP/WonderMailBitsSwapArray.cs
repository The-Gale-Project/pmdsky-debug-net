// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array WONDER_MAIL_BITS_SWAP defined within pmdsky.
    /// </summary>
    public partial class WonderMailBitsSwapArray : KaitaiStruct
    {
        public static WonderMailBitsSwapArray FromFile(string fileName)
        {
            return new WonderMailBitsSwapArray(new KaitaiStream(fileName));
        }

        public WonderMailBitsSwapArray(KaitaiStream p__io, KaitaiStruct p__parent = null, WonderMailBitsSwapArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new WonderMailBitsSwapArrayDim0(m_io, this, m_root);
        }
        public partial class WonderMailBitsSwapArrayDim0 : KaitaiStruct
        {
            public static WonderMailBitsSwapArrayDim0 FromFile(string fileName)
            {
                return new WonderMailBitsSwapArrayDim0(new KaitaiStream(fileName));
            }

            public WonderMailBitsSwapArrayDim0(KaitaiStream p__io, WonderMailBitsSwapArray p__parent = null, WonderMailBitsSwapArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<byte>();
                for (var i = 0; i < 36; i++)
                {
                    _entries.Add(m_io.ReadU1());
                }
            }
            private List<byte> _entries;
            private WonderMailBitsSwapArray m_root;
            private WonderMailBitsSwapArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public WonderMailBitsSwapArray M_Root { get { return m_root; } }
            public WonderMailBitsSwapArray M_Parent { get { return m_parent; } }
        }
        private WonderMailBitsSwapArrayDim0 _entries;
        private WonderMailBitsSwapArray m_root;
        private KaitaiStruct m_parent;
        public WonderMailBitsSwapArrayDim0 Entries { get { return _entries; } }
        public WonderMailBitsSwapArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
