// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array STRING_DEBUG_NEWLINE defined within pmdsky.
    /// </summary>
    public partial class StringDebugNewlineArray : KaitaiStruct
    {
        public static StringDebugNewlineArray FromFile(string fileName)
        {
            return new StringDebugNewlineArray(new KaitaiStream(fileName));
        }

        public StringDebugNewlineArray(KaitaiStream p__io, KaitaiStruct p__parent = null, StringDebugNewlineArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StringDebugNewlineArrayDim0(m_io, this, m_root);
        }
        public partial class StringDebugNewlineArrayDim0 : KaitaiStruct
        {
            public static StringDebugNewlineArrayDim0 FromFile(string fileName)
            {
                return new StringDebugNewlineArrayDim0(new KaitaiStream(fileName));
            }

            public StringDebugNewlineArrayDim0(KaitaiStream p__io, StringDebugNewlineArray p__parent = null, StringDebugNewlineArray p__root = null) : base(p__io)
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
            private StringDebugNewlineArray m_root;
            private StringDebugNewlineArray m_parent;
            public List<sbyte> Entries { get { return _entries; } }
            public StringDebugNewlineArray M_Root { get { return m_root; } }
            public StringDebugNewlineArray M_Parent { get { return m_parent; } }
        }
        private StringDebugNewlineArrayDim0 _entries;
        private StringDebugNewlineArray m_root;
        private KaitaiStruct m_parent;
        public StringDebugNewlineArrayDim0 Entries { get { return _entries; } }
        public StringDebugNewlineArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
