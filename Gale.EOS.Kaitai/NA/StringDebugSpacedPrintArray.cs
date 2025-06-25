// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array STRING_DEBUG_SPACED_PRINT defined within pmdsky.
    /// </summary>
    public partial class StringDebugSpacedPrintArray : KaitaiStruct
    {
        public static StringDebugSpacedPrintArray FromFile(string fileName)
        {
            return new StringDebugSpacedPrintArray(new KaitaiStream(fileName));
        }

        public StringDebugSpacedPrintArray(KaitaiStream p__io, KaitaiStruct p__parent = null, StringDebugSpacedPrintArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StringDebugSpacedPrintArrayDim0(m_io, this, m_root);
        }
        public partial class StringDebugSpacedPrintArrayDim0 : KaitaiStruct
        {
            public static StringDebugSpacedPrintArrayDim0 FromFile(string fileName)
            {
                return new StringDebugSpacedPrintArrayDim0(new KaitaiStream(fileName));
            }

            public StringDebugSpacedPrintArrayDim0(KaitaiStream p__io, StringDebugSpacedPrintArray p__parent = null, StringDebugSpacedPrintArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<sbyte>();
                for (var i = 0; i < 12; i++)
                {
                    _entries.Add(m_io.ReadS1());
                }
            }
            private List<sbyte> _entries;
            private StringDebugSpacedPrintArray m_root;
            private StringDebugSpacedPrintArray m_parent;
            public List<sbyte> Entries { get { return _entries; } }
            public StringDebugSpacedPrintArray M_Root { get { return m_root; } }
            public StringDebugSpacedPrintArray M_Parent { get { return m_parent; } }
        }
        private StringDebugSpacedPrintArrayDim0 _entries;
        private StringDebugSpacedPrintArray m_root;
        private KaitaiStruct m_parent;
        public StringDebugSpacedPrintArrayDim0 Entries { get { return _entries; } }
        public StringDebugSpacedPrintArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
