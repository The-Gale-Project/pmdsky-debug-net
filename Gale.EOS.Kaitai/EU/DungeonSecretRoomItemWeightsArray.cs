// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array dungeon_secret_room_item_weights defined within pmdsky.
    /// </summary>
    public partial class DungeonSecretRoomItemWeightsArray : KaitaiStruct
    {
        public static DungeonSecretRoomItemWeightsArray FromFile(string fileName)
        {
            return new DungeonSecretRoomItemWeightsArray(new KaitaiStream(fileName));
        }

        public DungeonSecretRoomItemWeightsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonSecretRoomItemWeightsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonSecretRoomItemWeightsArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonSecretRoomItemWeightsArrayDim0 : KaitaiStruct
        {
            public static DungeonSecretRoomItemWeightsArrayDim0 FromFile(string fileName)
            {
                return new DungeonSecretRoomItemWeightsArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonSecretRoomItemWeightsArrayDim0(KaitaiStream p__io, DungeonSecretRoomItemWeightsArray p__parent = null, DungeonSecretRoomItemWeightsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<ushort>();
                for (var i = 0; i < 1400; i++)
                {
                    _entries.Add(m_io.ReadU2le());
                }
            }
            private List<ushort> _entries;
            private DungeonSecretRoomItemWeightsArray m_root;
            private DungeonSecretRoomItemWeightsArray m_parent;
            public List<ushort> Entries { get { return _entries; } }
            public DungeonSecretRoomItemWeightsArray M_Root { get { return m_root; } }
            public DungeonSecretRoomItemWeightsArray M_Parent { get { return m_parent; } }
        }
        private DungeonSecretRoomItemWeightsArrayDim0 _entries;
        private DungeonSecretRoomItemWeightsArray m_root;
        private KaitaiStruct m_parent;
        public DungeonSecretRoomItemWeightsArrayDim0 Entries { get { return _entries; } }
        public DungeonSecretRoomItemWeightsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
