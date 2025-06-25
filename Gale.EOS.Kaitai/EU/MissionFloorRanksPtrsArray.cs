// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array MISSION_FLOOR_RANKS_PTRS defined within pmdsky.
    /// </summary>
    public partial class MissionFloorRanksPtrsArray : KaitaiStruct
    {
        public static MissionFloorRanksPtrsArray FromFile(string fileName)
        {
            return new MissionFloorRanksPtrsArray(new KaitaiStream(fileName));
        }

        public MissionFloorRanksPtrsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MissionFloorRanksPtrsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MissionFloorRanksPtrsArrayDim0(m_io, this, m_root);
        }
        public partial class MissionFloorRanksPtrsArrayDim0 : KaitaiStruct
        {
            public static MissionFloorRanksPtrsArrayDim0 FromFile(string fileName)
            {
                return new MissionFloorRanksPtrsArrayDim0(new KaitaiStream(fileName));
            }

            public MissionFloorRanksPtrsArrayDim0(KaitaiStream p__io, MissionFloorRanksPtrsArray p__parent = null, MissionFloorRanksPtrsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<Pointer>();
                for (var i = 0; i < 100; i++)
                {
                    _entries.Add(new Pointer(m_io));
                }
            }
            private List<Pointer> _entries;
            private MissionFloorRanksPtrsArray m_root;
            private MissionFloorRanksPtrsArray m_parent;
            public List<Pointer> Entries { get { return _entries; } }
            public MissionFloorRanksPtrsArray M_Root { get { return m_root; } }
            public MissionFloorRanksPtrsArray M_Parent { get { return m_parent; } }
        }
        private MissionFloorRanksPtrsArrayDim0 _entries;
        private MissionFloorRanksPtrsArray m_root;
        private KaitaiStruct m_parent;
        public MissionFloorRanksPtrsArrayDim0 Entries { get { return _entries; } }
        public MissionFloorRanksPtrsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
