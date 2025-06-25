// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array PERISH_SONG_TURN_RANGE defined within pmdsky.
    /// </summary>
    public partial class PerishSongTurnRangeArray : KaitaiStruct
    {
        public static PerishSongTurnRangeArray FromFile(string fileName)
        {
            return new PerishSongTurnRangeArray(new KaitaiStream(fileName));
        }

        public PerishSongTurnRangeArray(KaitaiStream p__io, KaitaiStruct p__parent = null, PerishSongTurnRangeArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new PerishSongTurnRangeArrayDim0(m_io, this, m_root);
        }
        public partial class PerishSongTurnRangeArrayDim0 : KaitaiStruct
        {
            public static PerishSongTurnRangeArrayDim0 FromFile(string fileName)
            {
                return new PerishSongTurnRangeArrayDim0(new KaitaiStream(fileName));
            }

            public PerishSongTurnRangeArrayDim0(KaitaiStream p__io, PerishSongTurnRangeArray p__parent = null, PerishSongTurnRangeArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<short>();
                for (var i = 0; i < 2; i++)
                {
                    _entries.Add(m_io.ReadS2le());
                }
            }
            private List<short> _entries;
            private PerishSongTurnRangeArray m_root;
            private PerishSongTurnRangeArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public PerishSongTurnRangeArray M_Root { get { return m_root; } }
            public PerishSongTurnRangeArray M_Parent { get { return m_parent; } }
        }
        private PerishSongTurnRangeArrayDim0 _entries;
        private PerishSongTurnRangeArray m_root;
        private KaitaiStruct m_parent;
        public PerishSongTurnRangeArrayDim0 Entries { get { return _entries; } }
        public PerishSongTurnRangeArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
