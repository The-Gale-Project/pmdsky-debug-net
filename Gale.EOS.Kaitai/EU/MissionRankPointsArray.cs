// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array MISSION_RANK_POINTS defined within pmdsky.
    /// </summary>
    public partial class MissionRankPointsArray : KaitaiStruct
    {
        public static MissionRankPointsArray FromFile(string fileName)
        {
            return new MissionRankPointsArray(new KaitaiStream(fileName));
        }

        public MissionRankPointsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MissionRankPointsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MissionRankPointsArrayDim0(m_io, this, m_root);
        }
        public partial class MissionRankPointsArrayDim0 : KaitaiStruct
        {
            public static MissionRankPointsArrayDim0 FromFile(string fileName)
            {
                return new MissionRankPointsArrayDim0(new KaitaiStream(fileName));
            }

            public MissionRankPointsArrayDim0(KaitaiStream p__io, MissionRankPointsArray p__parent = null, MissionRankPointsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<int>();
                for (var i = 0; i < 16; i++)
                {
                    _entries.Add(m_io.ReadS4le());
                }
            }
            private List<int> _entries;
            private MissionRankPointsArray m_root;
            private MissionRankPointsArray m_parent;
            public List<int> Entries { get { return _entries; } }
            public MissionRankPointsArray M_Root { get { return m_root; } }
            public MissionRankPointsArray M_Parent { get { return m_parent; } }
        }
        private MissionRankPointsArrayDim0 _entries;
        private MissionRankPointsArray m_root;
        private KaitaiStruct m_parent;
        public MissionRankPointsArrayDim0 Entries { get { return _entries; } }
        public MissionRankPointsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
