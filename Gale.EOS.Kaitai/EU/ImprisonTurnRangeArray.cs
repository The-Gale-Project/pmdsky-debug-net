// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array IMPRISON_TURN_RANGE defined within pmdsky.
    /// </summary>
    public partial class ImprisonTurnRangeArray : KaitaiStruct
    {
        public static ImprisonTurnRangeArray FromFile(string fileName)
        {
            return new ImprisonTurnRangeArray(new KaitaiStream(fileName));
        }

        public ImprisonTurnRangeArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ImprisonTurnRangeArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ImprisonTurnRangeArrayDim0(m_io, this, m_root);
        }
        public partial class ImprisonTurnRangeArrayDim0 : KaitaiStruct
        {
            public static ImprisonTurnRangeArrayDim0 FromFile(string fileName)
            {
                return new ImprisonTurnRangeArrayDim0(new KaitaiStream(fileName));
            }

            public ImprisonTurnRangeArrayDim0(KaitaiStream p__io, ImprisonTurnRangeArray p__parent = null, ImprisonTurnRangeArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<short>();
                for (var i = 0; i < 2; i++)
                {
                    _entries.Add(m_io.ReadS2le());
                }
            }
            private List<short> _entries;
            private ImprisonTurnRangeArray m_root;
            private ImprisonTurnRangeArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public ImprisonTurnRangeArray M_Root { get { return m_root; } }
            public ImprisonTurnRangeArray M_Parent { get { return m_parent; } }
        }
        private ImprisonTurnRangeArrayDim0 _entries;
        private ImprisonTurnRangeArray m_root;
        private KaitaiStruct m_parent;
        public ImprisonTurnRangeArrayDim0 Entries { get { return _entries; } }
        public ImprisonTurnRangeArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
