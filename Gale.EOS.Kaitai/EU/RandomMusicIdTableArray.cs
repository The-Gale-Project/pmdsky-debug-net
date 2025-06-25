// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array RANDOM_MUSIC_ID_TABLE defined within pmdsky.
    /// </summary>
    public partial class RandomMusicIdTableArray : KaitaiStruct
    {
        public static RandomMusicIdTableArray FromFile(string fileName)
        {
            return new RandomMusicIdTableArray(new KaitaiStream(fileName));
        }

        public RandomMusicIdTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, RandomMusicIdTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new RandomMusicIdTableArrayDim1(m_io, this, m_root);
        }
        public partial class RandomMusicIdTableArrayDim0 : KaitaiStruct
        {
            public static RandomMusicIdTableArrayDim0 FromFile(string fileName)
            {
                return new RandomMusicIdTableArrayDim0(new KaitaiStream(fileName));
            }

            public RandomMusicIdTableArrayDim0(KaitaiStream p__io, RandomMusicIdTableArray.RandomMusicIdTableArrayDim1 p__parent = null, RandomMusicIdTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<MusicId16>();
                for (var i = 0; i < 4; i++)
                {
                    _entries.Add(new MusicId16(m_io));
                }
            }
            private List<MusicId16> _entries;
            private RandomMusicIdTableArray m_root;
            private RandomMusicIdTableArray.RandomMusicIdTableArrayDim1 m_parent;
            public List<MusicId16> Entries { get { return _entries; } }
            public RandomMusicIdTableArray M_Root { get { return m_root; } }
            public RandomMusicIdTableArray.RandomMusicIdTableArrayDim1 M_Parent { get { return m_parent; } }
        }
        public partial class RandomMusicIdTableArrayDim1 : KaitaiStruct
        {
            public static RandomMusicIdTableArrayDim1 FromFile(string fileName)
            {
                return new RandomMusicIdTableArrayDim1(new KaitaiStream(fileName));
            }

            public RandomMusicIdTableArrayDim1(KaitaiStream p__io, RandomMusicIdTableArray p__parent = null, RandomMusicIdTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<RandomMusicIdTableArrayDim0>();
                for (var i = 0; i < 30; i++)
                {
                    _entries.Add(new RandomMusicIdTableArrayDim0(m_io, this, m_root));
                }
            }
            private List<RandomMusicIdTableArrayDim0> _entries;
            private RandomMusicIdTableArray m_root;
            private RandomMusicIdTableArray m_parent;
            public List<RandomMusicIdTableArrayDim0> Entries { get { return _entries; } }
            public RandomMusicIdTableArray M_Root { get { return m_root; } }
            public RandomMusicIdTableArray M_Parent { get { return m_parent; } }
        }
        private RandomMusicIdTableArrayDim1 _entries;
        private RandomMusicIdTableArray m_root;
        private KaitaiStruct m_parent;
        public RandomMusicIdTableArrayDim1 Entries { get { return _entries; } }
        public RandomMusicIdTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
