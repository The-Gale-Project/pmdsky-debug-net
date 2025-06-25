// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array TBL_TALK_GROUP_STRING_ID_START defined within pmdsky.
    /// </summary>
    public partial class TblTalkGroupStringIdStartArray : KaitaiStruct
    {
        public static TblTalkGroupStringIdStartArray FromFile(string fileName)
        {
            return new TblTalkGroupStringIdStartArray(new KaitaiStream(fileName));
        }

        public TblTalkGroupStringIdStartArray(KaitaiStream p__io, KaitaiStruct p__parent = null, TblTalkGroupStringIdStartArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new TblTalkGroupStringIdStartArrayDim0(m_io, this, m_root);
        }
        public partial class TblTalkGroupStringIdStartArrayDim0 : KaitaiStruct
        {
            public static TblTalkGroupStringIdStartArrayDim0 FromFile(string fileName)
            {
                return new TblTalkGroupStringIdStartArrayDim0(new KaitaiStream(fileName));
            }

            public TblTalkGroupStringIdStartArrayDim0(KaitaiStream p__io, TblTalkGroupStringIdStartArray p__parent = null, TblTalkGroupStringIdStartArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<short>();
                for (var i = 0; i < 6; i++)
                {
                    _entries.Add(m_io.ReadS2le());
                }
            }
            private List<short> _entries;
            private TblTalkGroupStringIdStartArray m_root;
            private TblTalkGroupStringIdStartArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public TblTalkGroupStringIdStartArray M_Root { get { return m_root; } }
            public TblTalkGroupStringIdStartArray M_Parent { get { return m_parent; } }
        }
        private TblTalkGroupStringIdStartArrayDim0 _entries;
        private TblTalkGroupStringIdStartArray m_root;
        private KaitaiStruct m_parent;
        public TblTalkGroupStringIdStartArrayDim0 Entries { get { return _entries; } }
        public TblTalkGroupStringIdStartArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
