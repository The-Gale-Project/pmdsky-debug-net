// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array MISSION_FLOORS_FORBIDDEN defined within pmdsky.
    /// </summary>
    public partial class MissionFloorsForbiddenArray : KaitaiStruct
    {
        public static MissionFloorsForbiddenArray FromFile(string fileName)
        {
            return new MissionFloorsForbiddenArray(new KaitaiStream(fileName));
        }

        public MissionFloorsForbiddenArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MissionFloorsForbiddenArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MissionFloorsForbiddenArrayDim0(m_io, this, m_root);
        }
        public partial class MissionFloorsForbiddenArrayDim0 : KaitaiStruct
        {
            public static MissionFloorsForbiddenArrayDim0 FromFile(string fileName)
            {
                return new MissionFloorsForbiddenArrayDim0(new KaitaiStream(fileName));
            }

            public MissionFloorsForbiddenArrayDim0(KaitaiStream p__io, MissionFloorsForbiddenArray p__parent = null, MissionFloorsForbiddenArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<MissionFloorsForbidden>();
                for (var i = 0; i < 100; i++)
                {
                    _entries.Add(new MissionFloorsForbidden(m_io));
                }
            }
            private List<MissionFloorsForbidden> _entries;
            private MissionFloorsForbiddenArray m_root;
            private MissionFloorsForbiddenArray m_parent;
            public List<MissionFloorsForbidden> Entries { get { return _entries; } }
            public MissionFloorsForbiddenArray M_Root { get { return m_root; } }
            public MissionFloorsForbiddenArray M_Parent { get { return m_parent; } }
        }
        private MissionFloorsForbiddenArrayDim0 _entries;
        private MissionFloorsForbiddenArray m_root;
        private KaitaiStruct m_parent;
        public MissionFloorsForbiddenArrayDim0 Entries { get { return _entries; } }
        public MissionFloorsForbiddenArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
