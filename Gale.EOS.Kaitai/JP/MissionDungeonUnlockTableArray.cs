// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array MISSION_DUNGEON_UNLOCK_TABLE defined within pmdsky.
    /// </summary>
    public partial class MissionDungeonUnlockTableArray : KaitaiStruct
    {
        public static MissionDungeonUnlockTableArray FromFile(string fileName)
        {
            return new MissionDungeonUnlockTableArray(new KaitaiStream(fileName));
        }

        public MissionDungeonUnlockTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MissionDungeonUnlockTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MissionDungeonUnlockTableArrayDim0(m_io, this, m_root);
        }
        public partial class MissionDungeonUnlockTableArrayDim0 : KaitaiStruct
        {
            public static MissionDungeonUnlockTableArrayDim0 FromFile(string fileName)
            {
                return new MissionDungeonUnlockTableArrayDim0(new KaitaiStream(fileName));
            }

            public MissionDungeonUnlockTableArrayDim0(KaitaiStream p__io, MissionDungeonUnlockTableArray p__parent = null, MissionDungeonUnlockTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<DungeonUnlockEntry>();
                for (var i = 0; i < 3; i++)
                {
                    _entries.Add(new DungeonUnlockEntry(m_io));
                }
            }
            private List<DungeonUnlockEntry> _entries;
            private MissionDungeonUnlockTableArray m_root;
            private MissionDungeonUnlockTableArray m_parent;
            public List<DungeonUnlockEntry> Entries { get { return _entries; } }
            public MissionDungeonUnlockTableArray M_Root { get { return m_root; } }
            public MissionDungeonUnlockTableArray M_Parent { get { return m_parent; } }
        }
        private MissionDungeonUnlockTableArrayDim0 _entries;
        private MissionDungeonUnlockTableArray m_root;
        private KaitaiStruct m_parent;
        public MissionDungeonUnlockTableArrayDim0 Entries { get { return _entries; } }
        public MissionDungeonUnlockTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
