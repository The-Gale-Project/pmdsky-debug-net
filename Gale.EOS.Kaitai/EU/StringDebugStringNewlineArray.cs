// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array STRING_DEBUG_STRING_NEWLINE defined within pmdsky.
    /// </summary>
    public partial class StringDebugStringNewlineArray : KaitaiStruct
    {
        public static StringDebugStringNewlineArray FromFile(string fileName)
        {
            return new StringDebugStringNewlineArray(new KaitaiStream(fileName));
        }

        public StringDebugStringNewlineArray(KaitaiStream p__io, KaitaiStruct p__parent = null, StringDebugStringNewlineArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StringDebugStringNewlineArrayDim0(m_io, this, m_root);
        }
        public partial class StringDebugStringNewlineArrayDim0 : KaitaiStruct
        {
            public static StringDebugStringNewlineArrayDim0 FromFile(string fileName)
            {
                return new StringDebugStringNewlineArrayDim0(new KaitaiStream(fileName));
            }

            public StringDebugStringNewlineArrayDim0(KaitaiStream p__io, StringDebugStringNewlineArray p__parent = null, StringDebugStringNewlineArray p__root = null) : base(p__io)
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
            private StringDebugStringNewlineArray m_root;
            private StringDebugStringNewlineArray m_parent;
            public List<sbyte> Entries { get { return _entries; } }
            public StringDebugStringNewlineArray M_Root { get { return m_root; } }
            public StringDebugStringNewlineArray M_Parent { get { return m_parent; } }
        }
        private StringDebugStringNewlineArrayDim0 _entries;
        private StringDebugStringNewlineArray m_root;
        private KaitaiStruct m_parent;
        public StringDebugStringNewlineArrayDim0 Entries { get { return _entries; } }
        public StringDebugStringNewlineArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
