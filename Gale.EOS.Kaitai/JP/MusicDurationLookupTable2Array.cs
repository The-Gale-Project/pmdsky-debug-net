// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array MUSIC_DURATION_LOOKUP_TABLE_2 defined within pmdsky.
    /// </summary>
    public partial class MusicDurationLookupTable2Array : KaitaiStruct
    {
        public static MusicDurationLookupTable2Array FromFile(string fileName)
        {
            return new MusicDurationLookupTable2Array(new KaitaiStream(fileName));
        }

        public MusicDurationLookupTable2Array(KaitaiStream p__io, KaitaiStruct p__parent = null, MusicDurationLookupTable2Array p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MusicDurationLookupTable2ArrayDim0(m_io, this, m_root);
        }
        public partial class MusicDurationLookupTable2ArrayDim0 : KaitaiStruct
        {
            public static MusicDurationLookupTable2ArrayDim0 FromFile(string fileName)
            {
                return new MusicDurationLookupTable2ArrayDim0(new KaitaiStream(fileName));
            }

            public MusicDurationLookupTable2ArrayDim0(KaitaiStream p__io, MusicDurationLookupTable2Array p__parent = null, MusicDurationLookupTable2Array p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<int>();
                for (var i = 0; i < 128; i++)
                {
                    _entries.Add(m_io.ReadS4le());
                }
            }
            private List<int> _entries;
            private MusicDurationLookupTable2Array m_root;
            private MusicDurationLookupTable2Array m_parent;
            public List<int> Entries { get { return _entries; } }
            public MusicDurationLookupTable2Array M_Root { get { return m_root; } }
            public MusicDurationLookupTable2Array M_Parent { get { return m_parent; } }
        }
        private MusicDurationLookupTable2ArrayDim0 _entries;
        private MusicDurationLookupTable2Array m_root;
        private KaitaiStruct m_parent;
        public MusicDurationLookupTable2ArrayDim0 Entries { get { return _entries; } }
        public MusicDurationLookupTable2Array M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
