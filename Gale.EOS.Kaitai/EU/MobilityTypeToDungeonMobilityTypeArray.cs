// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array MOBILITY_TYPE_TO_DUNGEON_MOBILITY_TYPE defined within pmdsky.
    /// </summary>
    public partial class MobilityTypeToDungeonMobilityTypeArray : KaitaiStruct
    {
        public static MobilityTypeToDungeonMobilityTypeArray FromFile(string fileName)
        {
            return new MobilityTypeToDungeonMobilityTypeArray(new KaitaiStream(fileName));
        }

        public MobilityTypeToDungeonMobilityTypeArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MobilityTypeToDungeonMobilityTypeArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MobilityTypeToDungeonMobilityTypeArrayDim0(m_io, this, m_root);
        }
        public partial class MobilityTypeToDungeonMobilityTypeArrayDim0 : KaitaiStruct
        {
            public static MobilityTypeToDungeonMobilityTypeArrayDim0 FromFile(string fileName)
            {
                return new MobilityTypeToDungeonMobilityTypeArrayDim0(new KaitaiStream(fileName));
            }

            public MobilityTypeToDungeonMobilityTypeArrayDim0(KaitaiStream p__io, MobilityTypeToDungeonMobilityTypeArray p__parent = null, MobilityTypeToDungeonMobilityTypeArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<MobilityType>();
                for (var i = 0; i < 8; i++)
                {
                    _entries.Add(new MobilityType(m_io));
                }
            }
            private List<MobilityType> _entries;
            private MobilityTypeToDungeonMobilityTypeArray m_root;
            private MobilityTypeToDungeonMobilityTypeArray m_parent;
            public List<MobilityType> Entries { get { return _entries; } }
            public MobilityTypeToDungeonMobilityTypeArray M_Root { get { return m_root; } }
            public MobilityTypeToDungeonMobilityTypeArray M_Parent { get { return m_parent; } }
        }
        private MobilityTypeToDungeonMobilityTypeArrayDim0 _entries;
        private MobilityTypeToDungeonMobilityTypeArray m_root;
        private KaitaiStruct m_parent;
        public MobilityTypeToDungeonMobilityTypeArrayDim0 Entries { get { return _entries; } }
        public MobilityTypeToDungeonMobilityTypeArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
