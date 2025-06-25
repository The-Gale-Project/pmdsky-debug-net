// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array STRING_DEBUG_LOG_NULL defined within pmdsky.
    /// </summary>
    public partial class StringDebugLogNullArray : KaitaiStruct
    {
        public static StringDebugLogNullArray FromFile(string fileName)
        {
            return new StringDebugLogNullArray(new KaitaiStream(fileName));
        }

        public StringDebugLogNullArray(KaitaiStream p__io, KaitaiStruct p__parent = null, StringDebugLogNullArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StringDebugLogNullArrayDim0(m_io, this, m_root);
        }
        public partial class StringDebugLogNullArrayDim0 : KaitaiStruct
        {
            public static StringDebugLogNullArrayDim0 FromFile(string fileName)
            {
                return new StringDebugLogNullArrayDim0(new KaitaiStream(fileName));
            }

            public StringDebugLogNullArrayDim0(KaitaiStream p__io, StringDebugLogNullArray p__parent = null, StringDebugLogNullArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<sbyte>();
                for (var i = 0; i < 8; i++)
                {
                    _entries.Add(m_io.ReadS1());
                }
            }
            private List<sbyte> _entries;
            private StringDebugLogNullArray m_root;
            private StringDebugLogNullArray m_parent;
            public List<sbyte> Entries { get { return _entries; } }
            public StringDebugLogNullArray M_Root { get { return m_root; } }
            public StringDebugLogNullArray M_Parent { get { return m_parent; } }
        }
        private StringDebugLogNullArrayDim0 _entries;
        private StringDebugLogNullArray m_root;
        private KaitaiStruct m_parent;
        public StringDebugLogNullArrayDim0 Entries { get { return _entries; } }
        public StringDebugLogNullArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
