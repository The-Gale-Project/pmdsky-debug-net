// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array GUMMI_LIKE_STRING_IDS defined within pmdsky.
    /// </summary>
    public partial class GummiLikeStringIdsArray : KaitaiStruct
    {
        public static GummiLikeStringIdsArray FromFile(string fileName)
        {
            return new GummiLikeStringIdsArray(new KaitaiStream(fileName));
        }

        public GummiLikeStringIdsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, GummiLikeStringIdsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new GummiLikeStringIdsArrayDim0(m_io, this, m_root);
        }
        public partial class GummiLikeStringIdsArrayDim0 : KaitaiStruct
        {
            public static GummiLikeStringIdsArrayDim0 FromFile(string fileName)
            {
                return new GummiLikeStringIdsArrayDim0(new KaitaiStream(fileName));
            }

            public GummiLikeStringIdsArrayDim0(KaitaiStream p__io, GummiLikeStringIdsArray p__parent = null, GummiLikeStringIdsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<short>();
                for (var i = 0; i < 4; i++)
                {
                    _entries.Add(m_io.ReadS2le());
                }
            }
            private List<short> _entries;
            private GummiLikeStringIdsArray m_root;
            private GummiLikeStringIdsArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public GummiLikeStringIdsArray M_Root { get { return m_root; } }
            public GummiLikeStringIdsArray M_Parent { get { return m_parent; } }
        }
        private GummiLikeStringIdsArrayDim0 _entries;
        private GummiLikeStringIdsArray m_root;
        private KaitaiStruct m_parent;
        public GummiLikeStringIdsArrayDim0 Entries { get { return _entries; } }
        public GummiLikeStringIdsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
