// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array FX_ATAN_IDX_TABLE defined within pmdsky.
    /// </summary>
    public partial class FxAtanIdxTableArray : KaitaiStruct
    {
        public static FxAtanIdxTableArray FromFile(string fileName)
        {
            return new FxAtanIdxTableArray(new KaitaiStream(fileName));
        }

        public FxAtanIdxTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, FxAtanIdxTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new FxAtanIdxTableArrayDim0(m_io, this, m_root);
        }
        public partial class FxAtanIdxTableArrayDim0 : KaitaiStruct
        {
            public static FxAtanIdxTableArrayDim0 FromFile(string fileName)
            {
                return new FxAtanIdxTableArrayDim0(new KaitaiStream(fileName));
            }

            public FxAtanIdxTableArrayDim0(KaitaiStream p__io, FxAtanIdxTableArray p__parent = null, FxAtanIdxTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<short>();
                for (var i = 0; i < 129; i++)
                {
                    _entries.Add(m_io.ReadS2le());
                }
            }
            private List<short> _entries;
            private FxAtanIdxTableArray m_root;
            private FxAtanIdxTableArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public FxAtanIdxTableArray M_Root { get { return m_root; } }
            public FxAtanIdxTableArray M_Parent { get { return m_parent; } }
        }
        private FxAtanIdxTableArrayDim0 _entries;
        private FxAtanIdxTableArray m_root;
        private KaitaiStruct m_parent;
        public FxAtanIdxTableArrayDim0 Entries { get { return _entries; } }
        public FxAtanIdxTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
