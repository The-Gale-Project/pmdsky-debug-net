// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array MUSIC_ID_TABLE defined within pmdsky.
    /// </summary>
    public partial class MusicIdTableArray : KaitaiStruct
    {
        public static MusicIdTableArray FromFile(string fileName)
        {
            return new MusicIdTableArray(new KaitaiStream(fileName));
        }

        public MusicIdTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MusicIdTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MusicIdTableArrayDim0(m_io, this, m_root);
        }
        public partial class MusicIdTableArrayDim0 : KaitaiStruct
        {
            public static MusicIdTableArrayDim0 FromFile(string fileName)
            {
                return new MusicIdTableArrayDim0(new KaitaiStream(fileName));
            }

            public MusicIdTableArrayDim0(KaitaiStream p__io, MusicIdTableArray p__parent = null, MusicIdTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<MusicId16>();
                for (var i = 0; i < 170; i++)
                {
                    _entries.Add(new MusicId16(m_io));
                }
            }
            private List<MusicId16> _entries;
            private MusicIdTableArray m_root;
            private MusicIdTableArray m_parent;
            public List<MusicId16> Entries { get { return _entries; } }
            public MusicIdTableArray M_Root { get { return m_root; } }
            public MusicIdTableArray M_Parent { get { return m_parent; } }
        }
        private MusicIdTableArrayDim0 _entries;
        private MusicIdTableArray m_root;
        private KaitaiStruct m_parent;
        public MusicIdTableArrayDim0 Entries { get { return _entries; } }
        public MusicIdTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
