// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array GUMMI_IQ_STRING_IDS defined within pmdsky.
    /// </summary>
    public partial class GummiIqStringIdsArray : KaitaiStruct
    {
        public static GummiIqStringIdsArray FromFile(string fileName)
        {
            return new GummiIqStringIdsArray(new KaitaiStream(fileName));
        }

        public GummiIqStringIdsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, GummiIqStringIdsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new GummiIqStringIdsArrayDim0(m_io, this, m_root);
        }
        public partial class GummiIqStringIdsArrayDim0 : KaitaiStruct
        {
            public static GummiIqStringIdsArrayDim0 FromFile(string fileName)
            {
                return new GummiIqStringIdsArrayDim0(new KaitaiStream(fileName));
            }

            public GummiIqStringIdsArrayDim0(KaitaiStream p__io, GummiIqStringIdsArray p__parent = null, GummiIqStringIdsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<short>();
                for (var i = 0; i < 5; i++)
                {
                    _entries.Add(m_io.ReadS2le());
                }
            }
            private List<short> _entries;
            private GummiIqStringIdsArray m_root;
            private GummiIqStringIdsArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public GummiIqStringIdsArray M_Root { get { return m_root; } }
            public GummiIqStringIdsArray M_Parent { get { return m_parent; } }
        }
        private GummiIqStringIdsArrayDim0 _entries;
        private GummiIqStringIdsArray m_root;
        private KaitaiStruct m_parent;
        public GummiIqStringIdsArrayDim0 Entries { get { return _entries; } }
        public GummiIqStringIdsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
