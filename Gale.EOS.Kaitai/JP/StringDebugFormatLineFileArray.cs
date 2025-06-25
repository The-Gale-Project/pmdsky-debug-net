// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array STRING_DEBUG_FORMAT_LINE_FILE defined within pmdsky.
    /// </summary>
    public partial class StringDebugFormatLineFileArray : KaitaiStruct
    {
        public static StringDebugFormatLineFileArray FromFile(string fileName)
        {
            return new StringDebugFormatLineFileArray(new KaitaiStream(fileName));
        }

        public StringDebugFormatLineFileArray(KaitaiStream p__io, KaitaiStruct p__parent = null, StringDebugFormatLineFileArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StringDebugFormatLineFileArrayDim0(m_io, this, m_root);
        }
        public partial class StringDebugFormatLineFileArrayDim0 : KaitaiStruct
        {
            public static StringDebugFormatLineFileArrayDim0 FromFile(string fileName)
            {
                return new StringDebugFormatLineFileArrayDim0(new KaitaiStream(fileName));
            }

            public StringDebugFormatLineFileArrayDim0(KaitaiStream p__io, StringDebugFormatLineFileArray p__parent = null, StringDebugFormatLineFileArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<sbyte>();
                for (var i = 0; i < 28; i++)
                {
                    _entries.Add(m_io.ReadS1());
                }
            }
            private List<sbyte> _entries;
            private StringDebugFormatLineFileArray m_root;
            private StringDebugFormatLineFileArray m_parent;
            public List<sbyte> Entries { get { return _entries; } }
            public StringDebugFormatLineFileArray M_Root { get { return m_root; } }
            public StringDebugFormatLineFileArray M_Parent { get { return m_parent; } }
        }
        private StringDebugFormatLineFileArrayDim0 _entries;
        private StringDebugFormatLineFileArray m_root;
        private KaitaiStruct m_parent;
        public StringDebugFormatLineFileArrayDim0 Entries { get { return _entries; } }
        public StringDebugFormatLineFileArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
