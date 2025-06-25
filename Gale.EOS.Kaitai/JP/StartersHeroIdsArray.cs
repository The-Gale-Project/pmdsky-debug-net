// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array STARTERS_HERO_IDS defined within pmdsky.
    /// </summary>
    public partial class StartersHeroIdsArray : KaitaiStruct
    {
        public static StartersHeroIdsArray FromFile(string fileName)
        {
            return new StartersHeroIdsArray(new KaitaiStream(fileName));
        }

        public StartersHeroIdsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, StartersHeroIdsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StartersHeroIdsArrayDim0(m_io, this, m_root);
        }
        public partial class StartersHeroIdsArrayDim0 : KaitaiStruct
        {
            public static StartersHeroIdsArrayDim0 FromFile(string fileName)
            {
                return new StartersHeroIdsArrayDim0(new KaitaiStream(fileName));
            }

            public StartersHeroIdsArrayDim0(KaitaiStream p__io, StartersHeroIdsArray p__parent = null, StartersHeroIdsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<MonsterId16>();
                for (var i = 0; i < 32; i++)
                {
                    _entries.Add(new MonsterId16(m_io));
                }
            }
            private List<MonsterId16> _entries;
            private StartersHeroIdsArray m_root;
            private StartersHeroIdsArray m_parent;
            public List<MonsterId16> Entries { get { return _entries; } }
            public StartersHeroIdsArray M_Root { get { return m_root; } }
            public StartersHeroIdsArray M_Parent { get { return m_parent; } }
        }
        private StartersHeroIdsArrayDim0 _entries;
        private StartersHeroIdsArray m_root;
        private KaitaiStruct m_parent;
        public StartersHeroIdsArrayDim0 Entries { get { return _entries; } }
        public StartersHeroIdsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
