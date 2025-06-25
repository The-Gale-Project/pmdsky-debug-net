// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array STARTERS_STRINGS defined within pmdsky.
    /// </summary>
    public partial class StartersStringsArray : KaitaiStruct
    {
        public static StartersStringsArray FromFile(string fileName)
        {
            return new StartersStringsArray(new KaitaiStream(fileName));
        }

        public StartersStringsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, StartersStringsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StartersStringsArrayDim0(m_io, this, m_root);
        }
        public partial class StartersStringsArrayDim0 : KaitaiStruct
        {
            public static StartersStringsArrayDim0 FromFile(string fileName)
            {
                return new StartersStringsArrayDim0(new KaitaiStream(fileName));
            }

            public StartersStringsArrayDim0(KaitaiStream p__io, StartersStringsArray p__parent = null, StartersStringsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<ushort>();
                for (var i = 0; i < 48; i++)
                {
                    _entries.Add(m_io.ReadU2le());
                }
            }
            private List<ushort> _entries;
            private StartersStringsArray m_root;
            private StartersStringsArray m_parent;
            public List<ushort> Entries { get { return _entries; } }
            public StartersStringsArray M_Root { get { return m_root; } }
            public StartersStringsArray M_Parent { get { return m_parent; } }
        }
        private StartersStringsArrayDim0 _entries;
        private StartersStringsArray m_root;
        private KaitaiStruct m_parent;
        public StartersStringsArrayDim0 Entries { get { return _entries; } }
        public StartersStringsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
