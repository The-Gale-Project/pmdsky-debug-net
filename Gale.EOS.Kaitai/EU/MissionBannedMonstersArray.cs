// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array MISSION_BANNED_MONSTERS defined within pmdsky.
    /// </summary>
    public partial class MissionBannedMonstersArray : KaitaiStruct
    {
        public static MissionBannedMonstersArray FromFile(string fileName)
        {
            return new MissionBannedMonstersArray(new KaitaiStream(fileName));
        }

        public MissionBannedMonstersArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MissionBannedMonstersArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MissionBannedMonstersArrayDim0(m_io, this, m_root);
        }
        public partial class MissionBannedMonstersArrayDim0 : KaitaiStruct
        {
            public static MissionBannedMonstersArrayDim0 FromFile(string fileName)
            {
                return new MissionBannedMonstersArrayDim0(new KaitaiStream(fileName));
            }

            public MissionBannedMonstersArrayDim0(KaitaiStream p__io, MissionBannedMonstersArray p__parent = null, MissionBannedMonstersArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<MonsterId16>();
                for (var i = 0; i < 124; i++)
                {
                    _entries.Add(new MonsterId16(m_io));
                }
            }
            private List<MonsterId16> _entries;
            private MissionBannedMonstersArray m_root;
            private MissionBannedMonstersArray m_parent;
            public List<MonsterId16> Entries { get { return _entries; } }
            public MissionBannedMonstersArray M_Root { get { return m_root; } }
            public MissionBannedMonstersArray M_Parent { get { return m_parent; } }
        }
        private MissionBannedMonstersArrayDim0 _entries;
        private MissionBannedMonstersArray m_root;
        private KaitaiStruct m_parent;
        public MissionBannedMonstersArrayDim0 Entries { get { return _entries; } }
        public MissionBannedMonstersArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
