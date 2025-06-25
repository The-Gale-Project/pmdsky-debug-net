// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array MISSION_BANNED_STORY_MONSTERS defined within pmdsky.
    /// </summary>
    public partial class MissionBannedStoryMonstersArray : KaitaiStruct
    {
        public static MissionBannedStoryMonstersArray FromFile(string fileName)
        {
            return new MissionBannedStoryMonstersArray(new KaitaiStream(fileName));
        }

        public MissionBannedStoryMonstersArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MissionBannedStoryMonstersArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MissionBannedStoryMonstersArrayDim0(m_io, this, m_root);
        }
        public partial class MissionBannedStoryMonstersArrayDim0 : KaitaiStruct
        {
            public static MissionBannedStoryMonstersArrayDim0 FromFile(string fileName)
            {
                return new MissionBannedStoryMonstersArrayDim0(new KaitaiStream(fileName));
            }

            public MissionBannedStoryMonstersArrayDim0(KaitaiStream p__io, MissionBannedStoryMonstersArray p__parent = null, MissionBannedStoryMonstersArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<MonsterId16>();
                for (var i = 0; i < 21; i++)
                {
                    _entries.Add(new MonsterId16(m_io));
                }
            }
            private List<MonsterId16> _entries;
            private MissionBannedStoryMonstersArray m_root;
            private MissionBannedStoryMonstersArray m_parent;
            public List<MonsterId16> Entries { get { return _entries; } }
            public MissionBannedStoryMonstersArray M_Root { get { return m_root; } }
            public MissionBannedStoryMonstersArray M_Parent { get { return m_parent; } }
        }
        private MissionBannedStoryMonstersArrayDim0 _entries;
        private MissionBannedStoryMonstersArray m_root;
        private KaitaiStruct m_parent;
        public MissionBannedStoryMonstersArrayDim0 Entries { get { return _entries; } }
        public MissionBannedStoryMonstersArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
