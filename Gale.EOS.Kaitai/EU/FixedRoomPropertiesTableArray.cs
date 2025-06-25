// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array FIXED_ROOM_PROPERTIES_TABLE defined within pmdsky.
    /// </summary>
    public partial class FixedRoomPropertiesTableArray : KaitaiStruct
    {
        public static FixedRoomPropertiesTableArray FromFile(string fileName)
        {
            return new FixedRoomPropertiesTableArray(new KaitaiStream(fileName));
        }

        public FixedRoomPropertiesTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, FixedRoomPropertiesTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new FixedRoomPropertiesTableArrayDim0(m_io, this, m_root);
        }
        public partial class FixedRoomPropertiesTableArrayDim0 : KaitaiStruct
        {
            public static FixedRoomPropertiesTableArrayDim0 FromFile(string fileName)
            {
                return new FixedRoomPropertiesTableArrayDim0(new KaitaiStream(fileName));
            }

            public FixedRoomPropertiesTableArrayDim0(KaitaiStream p__io, FixedRoomPropertiesTableArray p__parent = null, FixedRoomPropertiesTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<FixedRoomPropertiesEntry>();
                for (var i = 0; i < 256; i++)
                {
                    _entries.Add(new FixedRoomPropertiesEntry(m_io));
                }
            }
            private List<FixedRoomPropertiesEntry> _entries;
            private FixedRoomPropertiesTableArray m_root;
            private FixedRoomPropertiesTableArray m_parent;
            public List<FixedRoomPropertiesEntry> Entries { get { return _entries; } }
            public FixedRoomPropertiesTableArray M_Root { get { return m_root; } }
            public FixedRoomPropertiesTableArray M_Parent { get { return m_parent; } }
        }
        private FixedRoomPropertiesTableArrayDim0 _entries;
        private FixedRoomPropertiesTableArray m_root;
        private KaitaiStruct m_parent;
        public FixedRoomPropertiesTableArrayDim0 Entries { get { return _entries; } }
        public FixedRoomPropertiesTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
