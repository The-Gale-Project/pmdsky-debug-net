// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array STRING_DEBUG_FATAL defined within pmdsky.
    /// </summary>
    public partial class StringDebugFatalArray : KaitaiStruct
    {
        public static StringDebugFatalArray FromFile(string fileName)
        {
            return new StringDebugFatalArray(new KaitaiStream(fileName));
        }

        public StringDebugFatalArray(KaitaiStream p__io, KaitaiStruct p__parent = null, StringDebugFatalArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StringDebugFatalArrayDim0(m_io, this, m_root);
        }
        public partial class StringDebugFatalArrayDim0 : KaitaiStruct
        {
            public static StringDebugFatalArrayDim0 FromFile(string fileName)
            {
                return new StringDebugFatalArrayDim0(new KaitaiStream(fileName));
            }

            public StringDebugFatalArrayDim0(KaitaiStream p__io, StringDebugFatalArray p__parent = null, StringDebugFatalArray p__root = null) : base(p__io)
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
            private StringDebugFatalArray m_root;
            private StringDebugFatalArray m_parent;
            public List<sbyte> Entries { get { return _entries; } }
            public StringDebugFatalArray M_Root { get { return m_root; } }
            public StringDebugFatalArray M_Parent { get { return m_parent; } }
        }
        private StringDebugFatalArrayDim0 _entries;
        private StringDebugFatalArray m_root;
        private KaitaiStruct m_parent;
        public StringDebugFatalArrayDim0 Entries { get { return _entries; } }
        public StringDebugFatalArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
