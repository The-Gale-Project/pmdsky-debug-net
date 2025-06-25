// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array STRING_DEBUG_EMPTY defined within pmdsky.
    /// </summary>
    public partial class StringDebugEmptyArray : KaitaiStruct
    {
        public static StringDebugEmptyArray FromFile(string fileName)
        {
            return new StringDebugEmptyArray(new KaitaiStream(fileName));
        }

        public StringDebugEmptyArray(KaitaiStream p__io, KaitaiStruct p__parent = null, StringDebugEmptyArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StringDebugEmptyArrayDim0(m_io, this, m_root);
        }
        public partial class StringDebugEmptyArrayDim0 : KaitaiStruct
        {
            public static StringDebugEmptyArrayDim0 FromFile(string fileName)
            {
                return new StringDebugEmptyArrayDim0(new KaitaiStream(fileName));
            }

            public StringDebugEmptyArrayDim0(KaitaiStream p__io, StringDebugEmptyArray p__parent = null, StringDebugEmptyArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<sbyte>();
                for (var i = 0; i < 4; i++)
                {
                    _entries.Add(m_io.ReadS1());
                }
            }
            private List<sbyte> _entries;
            private StringDebugEmptyArray m_root;
            private StringDebugEmptyArray m_parent;
            public List<sbyte> Entries { get { return _entries; } }
            public StringDebugEmptyArray M_Root { get { return m_root; } }
            public StringDebugEmptyArray M_Parent { get { return m_parent; } }
        }
        private StringDebugEmptyArrayDim0 _entries;
        private StringDebugEmptyArray m_root;
        private KaitaiStruct m_parent;
        public StringDebugEmptyArrayDim0 Entries { get { return _entries; } }
        public StringDebugEmptyArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
