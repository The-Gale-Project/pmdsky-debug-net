// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array SPECIAL_EPISODE_MAIN_CHARACTERS defined within pmdsky.
    /// </summary>
    public partial class SpecialEpisodeMainCharactersArray : KaitaiStruct
    {
        public static SpecialEpisodeMainCharactersArray FromFile(string fileName)
        {
            return new SpecialEpisodeMainCharactersArray(new KaitaiStream(fileName));
        }

        public SpecialEpisodeMainCharactersArray(KaitaiStream p__io, KaitaiStruct p__parent = null, SpecialEpisodeMainCharactersArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new SpecialEpisodeMainCharactersArrayDim0(m_io, this, m_root);
        }
        public partial class SpecialEpisodeMainCharactersArrayDim0 : KaitaiStruct
        {
            public static SpecialEpisodeMainCharactersArrayDim0 FromFile(string fileName)
            {
                return new SpecialEpisodeMainCharactersArrayDim0(new KaitaiStream(fileName));
            }

            public SpecialEpisodeMainCharactersArrayDim0(KaitaiStream p__io, SpecialEpisodeMainCharactersArray p__parent = null, SpecialEpisodeMainCharactersArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<MonsterId16>();
                for (var i = 0; i < 100; i++)
                {
                    _entries.Add(new MonsterId16(m_io));
                }
            }
            private List<MonsterId16> _entries;
            private SpecialEpisodeMainCharactersArray m_root;
            private SpecialEpisodeMainCharactersArray m_parent;
            public List<MonsterId16> Entries { get { return _entries; } }
            public SpecialEpisodeMainCharactersArray M_Root { get { return m_root; } }
            public SpecialEpisodeMainCharactersArray M_Parent { get { return m_parent; } }
        }
        private SpecialEpisodeMainCharactersArrayDim0 _entries;
        private SpecialEpisodeMainCharactersArray m_root;
        private KaitaiStruct m_parent;
        public SpecialEpisodeMainCharactersArrayDim0 Entries { get { return _entries; } }
        public SpecialEpisodeMainCharactersArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
