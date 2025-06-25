// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array STRING_BALANCE_M_LEVEL_BIN defined within pmdsky.
    /// </summary>
    public partial class StringBalanceMLevelBinArray : KaitaiStruct
    {
        public static StringBalanceMLevelBinArray FromFile(string fileName)
        {
            return new StringBalanceMLevelBinArray(new KaitaiStream(fileName));
        }

        public StringBalanceMLevelBinArray(KaitaiStream p__io, KaitaiStruct p__parent = null, StringBalanceMLevelBinArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StringBalanceMLevelBinArrayDim0(m_io, this, m_root);
        }
        public partial class StringBalanceMLevelBinArrayDim0 : KaitaiStruct
        {
            public static StringBalanceMLevelBinArrayDim0 FromFile(string fileName)
            {
                return new StringBalanceMLevelBinArrayDim0(new KaitaiStream(fileName));
            }

            public StringBalanceMLevelBinArrayDim0(KaitaiStream p__io, StringBalanceMLevelBinArray p__parent = null, StringBalanceMLevelBinArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<sbyte>();
                for (var i = 0; i < 20; i++)
                {
                    _entries.Add(m_io.ReadS1());
                }
            }
            private List<sbyte> _entries;
            private StringBalanceMLevelBinArray m_root;
            private StringBalanceMLevelBinArray m_parent;
            public List<sbyte> Entries { get { return _entries; } }
            public StringBalanceMLevelBinArray M_Root { get { return m_root; } }
            public StringBalanceMLevelBinArray M_Parent { get { return m_parent; } }
        }
        private StringBalanceMLevelBinArrayDim0 _entries;
        private StringBalanceMLevelBinArray m_root;
        private KaitaiStruct m_parent;
        public StringBalanceMLevelBinArrayDim0 Entries { get { return _entries; } }
        public StringBalanceMLevelBinArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
