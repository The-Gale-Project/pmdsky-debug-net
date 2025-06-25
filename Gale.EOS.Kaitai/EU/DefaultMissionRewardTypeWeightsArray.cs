// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array DEFAULT_MISSION_REWARD_TYPE_WEIGHTS defined within pmdsky.
    /// </summary>
    public partial class DefaultMissionRewardTypeWeightsArray : KaitaiStruct
    {
        public static DefaultMissionRewardTypeWeightsArray FromFile(string fileName)
        {
            return new DefaultMissionRewardTypeWeightsArray(new KaitaiStream(fileName));
        }

        public DefaultMissionRewardTypeWeightsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DefaultMissionRewardTypeWeightsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DefaultMissionRewardTypeWeightsArrayDim0(m_io, this, m_root);
        }
        public partial class DefaultMissionRewardTypeWeightsArrayDim0 : KaitaiStruct
        {
            public static DefaultMissionRewardTypeWeightsArrayDim0 FromFile(string fileName)
            {
                return new DefaultMissionRewardTypeWeightsArrayDim0(new KaitaiStream(fileName));
            }

            public DefaultMissionRewardTypeWeightsArrayDim0(KaitaiStream p__io, DefaultMissionRewardTypeWeightsArray p__parent = null, DefaultMissionRewardTypeWeightsArray p__root = null) : base(p__io)
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
            private DefaultMissionRewardTypeWeightsArray m_root;
            private DefaultMissionRewardTypeWeightsArray m_parent;
            public List<ushort> Entries { get { return _entries; } }
            public DefaultMissionRewardTypeWeightsArray M_Root { get { return m_root; } }
            public DefaultMissionRewardTypeWeightsArray M_Parent { get { return m_parent; } }
        }
        private DefaultMissionRewardTypeWeightsArrayDim0 _entries;
        private DefaultMissionRewardTypeWeightsArray m_root;
        private KaitaiStruct m_parent;
        public DefaultMissionRewardTypeWeightsArrayDim0 Entries { get { return _entries; } }
        public DefaultMissionRewardTypeWeightsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
