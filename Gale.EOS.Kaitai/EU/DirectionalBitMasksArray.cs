// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array DIRECTIONAL_BIT_MASKS defined within pmdsky.
    /// </summary>
    public partial class DirectionalBitMasksArray : KaitaiStruct
    {
        public static DirectionalBitMasksArray FromFile(string fileName)
        {
            return new DirectionalBitMasksArray(new KaitaiStream(fileName));
        }

        public DirectionalBitMasksArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DirectionalBitMasksArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DirectionalBitMasksArrayDim0(m_io, this, m_root);
        }
        public partial class DirectionalBitMasksArrayDim0 : KaitaiStruct
        {
            public static DirectionalBitMasksArrayDim0 FromFile(string fileName)
            {
                return new DirectionalBitMasksArrayDim0(new KaitaiStream(fileName));
            }

            public DirectionalBitMasksArrayDim0(KaitaiStream p__io, DirectionalBitMasksArray p__parent = null, DirectionalBitMasksArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<byte>();
                for (var i = 0; i < 8; i++)
                {
                    _entries.Add(m_io.ReadU1());
                }
            }
            private List<byte> _entries;
            private DirectionalBitMasksArray m_root;
            private DirectionalBitMasksArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public DirectionalBitMasksArray M_Root { get { return m_root; } }
            public DirectionalBitMasksArray M_Parent { get { return m_parent; } }
        }
        private DirectionalBitMasksArrayDim0 _entries;
        private DirectionalBitMasksArray m_root;
        private KaitaiStruct m_parent;
        public DirectionalBitMasksArrayDim0 Entries { get { return _entries; } }
        public DirectionalBitMasksArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
