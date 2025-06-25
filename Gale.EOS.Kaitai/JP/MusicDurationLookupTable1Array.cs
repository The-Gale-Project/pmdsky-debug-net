// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array MUSIC_DURATION_LOOKUP_TABLE_1 defined within pmdsky.
    /// </summary>
    public partial class MusicDurationLookupTable1Array : KaitaiStruct
    {
        public static MusicDurationLookupTable1Array FromFile(string fileName)
        {
            return new MusicDurationLookupTable1Array(new KaitaiStream(fileName));
        }

        public MusicDurationLookupTable1Array(KaitaiStream p__io, KaitaiStruct p__parent = null, MusicDurationLookupTable1Array p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MusicDurationLookupTable1ArrayDim0(m_io, this, m_root);
        }
        public partial class MusicDurationLookupTable1ArrayDim0 : KaitaiStruct
        {
            public static MusicDurationLookupTable1ArrayDim0 FromFile(string fileName)
            {
                return new MusicDurationLookupTable1ArrayDim0(new KaitaiStream(fileName));
            }

            public MusicDurationLookupTable1ArrayDim0(KaitaiStream p__io, MusicDurationLookupTable1Array p__parent = null, MusicDurationLookupTable1Array p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<short>();
                for (var i = 0; i < 128; i++)
                {
                    _entries.Add(m_io.ReadS2le());
                }
            }
            private List<short> _entries;
            private MusicDurationLookupTable1Array m_root;
            private MusicDurationLookupTable1Array m_parent;
            public List<short> Entries { get { return _entries; } }
            public MusicDurationLookupTable1Array M_Root { get { return m_root; } }
            public MusicDurationLookupTable1Array M_Parent { get { return m_parent; } }
        }
        private MusicDurationLookupTable1ArrayDim0 _entries;
        private MusicDurationLookupTable1Array m_root;
        private KaitaiStruct m_parent;
        public MusicDurationLookupTable1ArrayDim0 Entries { get { return _entries; } }
        public MusicDurationLookupTable1Array M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
