// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array NATURAL_LOG_VALUE_TABLE defined within pmdsky.
    /// </summary>
    public partial class NaturalLogValueTableArray : KaitaiStruct
    {
        public static NaturalLogValueTableArray FromFile(string fileName)
        {
            return new NaturalLogValueTableArray(new KaitaiStream(fileName));
        }

        public NaturalLogValueTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, NaturalLogValueTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new NaturalLogValueTableArrayDim0(m_io, this, m_root);
        }
        public partial class NaturalLogValueTableArrayDim0 : KaitaiStruct
        {
            public static NaturalLogValueTableArrayDim0 FromFile(string fileName)
            {
                return new NaturalLogValueTableArrayDim0(new KaitaiStream(fileName));
            }

            public NaturalLogValueTableArrayDim0(KaitaiStream p__io, NaturalLogValueTableArray p__parent = null, NaturalLogValueTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<short>();
                for (var i = 0; i < 2048; i++)
                {
                    _entries.Add(m_io.ReadS2le());
                }
            }
            private List<short> _entries;
            private NaturalLogValueTableArray m_root;
            private NaturalLogValueTableArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public NaturalLogValueTableArray M_Root { get { return m_root; } }
            public NaturalLogValueTableArray M_Parent { get { return m_parent; } }
        }
        private NaturalLogValueTableArrayDim0 _entries;
        private NaturalLogValueTableArray m_root;
        private KaitaiStruct m_parent;
        public NaturalLogValueTableArrayDim0 Entries { get { return _entries; } }
        public NaturalLogValueTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
