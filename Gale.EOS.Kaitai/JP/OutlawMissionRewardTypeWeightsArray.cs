// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array OUTLAW_MISSION_REWARD_TYPE_WEIGHTS defined within pmdsky.
    /// </summary>
    public partial class OutlawMissionRewardTypeWeightsArray : KaitaiStruct
    {
        public static OutlawMissionRewardTypeWeightsArray FromFile(string fileName)
        {
            return new OutlawMissionRewardTypeWeightsArray(new KaitaiStream(fileName));
        }

        public OutlawMissionRewardTypeWeightsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, OutlawMissionRewardTypeWeightsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new OutlawMissionRewardTypeWeightsArrayDim0(m_io, this, m_root);
        }
        public partial class OutlawMissionRewardTypeWeightsArrayDim0 : KaitaiStruct
        {
            public static OutlawMissionRewardTypeWeightsArrayDim0 FromFile(string fileName)
            {
                return new OutlawMissionRewardTypeWeightsArrayDim0(new KaitaiStream(fileName));
            }

            public OutlawMissionRewardTypeWeightsArrayDim0(KaitaiStream p__io, OutlawMissionRewardTypeWeightsArray p__parent = null, OutlawMissionRewardTypeWeightsArray p__root = null) : base(p__io)
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
            private OutlawMissionRewardTypeWeightsArray m_root;
            private OutlawMissionRewardTypeWeightsArray m_parent;
            public List<ushort> Entries { get { return _entries; } }
            public OutlawMissionRewardTypeWeightsArray M_Root { get { return m_root; } }
            public OutlawMissionRewardTypeWeightsArray M_Parent { get { return m_parent; } }
        }
        private OutlawMissionRewardTypeWeightsArrayDim0 _entries;
        private OutlawMissionRewardTypeWeightsArray m_root;
        private KaitaiStruct m_parent;
        public OutlawMissionRewardTypeWeightsArrayDim0 Entries { get { return _entries; } }
        public OutlawMissionRewardTypeWeightsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
