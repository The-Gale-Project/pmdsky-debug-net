// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array CAFE_MISSION_REWARD_TYPE_WEIGHTS defined within pmdsky.
    /// </summary>
    public partial class CafeMissionRewardTypeWeightsArray : KaitaiStruct
    {
        public static CafeMissionRewardTypeWeightsArray FromFile(string fileName)
        {
            return new CafeMissionRewardTypeWeightsArray(new KaitaiStream(fileName));
        }

        public CafeMissionRewardTypeWeightsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, CafeMissionRewardTypeWeightsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new CafeMissionRewardTypeWeightsArrayDim0(m_io, this, m_root);
        }
        public partial class CafeMissionRewardTypeWeightsArrayDim0 : KaitaiStruct
        {
            public static CafeMissionRewardTypeWeightsArrayDim0 FromFile(string fileName)
            {
                return new CafeMissionRewardTypeWeightsArrayDim0(new KaitaiStream(fileName));
            }

            public CafeMissionRewardTypeWeightsArrayDim0(KaitaiStream p__io, CafeMissionRewardTypeWeightsArray p__parent = null, CafeMissionRewardTypeWeightsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<ushort>();
                for (var i = 0; i < 7; i++)
                {
                    _entries.Add(m_io.ReadU2le());
                }
            }
            private List<ushort> _entries;
            private CafeMissionRewardTypeWeightsArray m_root;
            private CafeMissionRewardTypeWeightsArray m_parent;
            public List<ushort> Entries { get { return _entries; } }
            public CafeMissionRewardTypeWeightsArray M_Root { get { return m_root; } }
            public CafeMissionRewardTypeWeightsArray M_Parent { get { return m_parent; } }
        }
        private CafeMissionRewardTypeWeightsArrayDim0 _entries;
        private CafeMissionRewardTypeWeightsArray m_root;
        private KaitaiStruct m_parent;
        public CafeMissionRewardTypeWeightsArrayDim0 Entries { get { return _entries; } }
        public CafeMissionRewardTypeWeightsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
