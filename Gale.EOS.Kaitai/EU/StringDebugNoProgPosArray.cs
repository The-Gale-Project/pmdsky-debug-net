// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array STRING_DEBUG_NO_PROG_POS defined within pmdsky.
    /// </summary>
    public partial class StringDebugNoProgPosArray : KaitaiStruct
    {
        public static StringDebugNoProgPosArray FromFile(string fileName)
        {
            return new StringDebugNoProgPosArray(new KaitaiStream(fileName));
        }

        public StringDebugNoProgPosArray(KaitaiStream p__io, KaitaiStruct p__parent = null, StringDebugNoProgPosArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StringDebugNoProgPosArrayDim0(m_io, this, m_root);
        }
        public partial class StringDebugNoProgPosArrayDim0 : KaitaiStruct
        {
            public static StringDebugNoProgPosArrayDim0 FromFile(string fileName)
            {
                return new StringDebugNoProgPosArrayDim0(new KaitaiStream(fileName));
            }

            public StringDebugNoProgPosArrayDim0(KaitaiStream p__io, StringDebugNoProgPosArray p__parent = null, StringDebugNoProgPosArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<sbyte>();
                for (var i = 0; i < 24; i++)
                {
                    _entries.Add(m_io.ReadS1());
                }
            }
            private List<sbyte> _entries;
            private StringDebugNoProgPosArray m_root;
            private StringDebugNoProgPosArray m_parent;
            public List<sbyte> Entries { get { return _entries; } }
            public StringDebugNoProgPosArray M_Root { get { return m_root; } }
            public StringDebugNoProgPosArray M_Parent { get { return m_parent; } }
        }
        private StringDebugNoProgPosArrayDim0 _entries;
        private StringDebugNoProgPosArray m_root;
        private KaitaiStruct m_parent;
        public StringDebugNoProgPosArrayDim0 Entries { get { return _entries; } }
        public StringDebugNoProgPosArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
