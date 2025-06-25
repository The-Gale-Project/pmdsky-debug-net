// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array FIXED_ROOM_REVISIT_OVERRIDES defined within pmdsky.
    /// </summary>
    public partial class FixedRoomRevisitOverridesArray : KaitaiStruct
    {
        public static FixedRoomRevisitOverridesArray FromFile(string fileName)
        {
            return new FixedRoomRevisitOverridesArray(new KaitaiStream(fileName));
        }

        public FixedRoomRevisitOverridesArray(KaitaiStream p__io, KaitaiStruct p__parent = null, FixedRoomRevisitOverridesArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new FixedRoomRevisitOverridesArrayDim0(m_io, this, m_root);
        }
        public partial class FixedRoomRevisitOverridesArrayDim0 : KaitaiStruct
        {
            public static FixedRoomRevisitOverridesArrayDim0 FromFile(string fileName)
            {
                return new FixedRoomRevisitOverridesArrayDim0(new KaitaiStream(fileName));
            }

            public FixedRoomRevisitOverridesArrayDim0(KaitaiStream p__io, FixedRoomRevisitOverridesArray p__parent = null, FixedRoomRevisitOverridesArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<FixedRoomId8>();
                for (var i = 0; i < 256; i++)
                {
                    _entries.Add(new FixedRoomId8(m_io));
                }
            }
            private List<FixedRoomId8> _entries;
            private FixedRoomRevisitOverridesArray m_root;
            private FixedRoomRevisitOverridesArray m_parent;
            public List<FixedRoomId8> Entries { get { return _entries; } }
            public FixedRoomRevisitOverridesArray M_Root { get { return m_root; } }
            public FixedRoomRevisitOverridesArray M_Parent { get { return m_parent; } }
        }
        private FixedRoomRevisitOverridesArrayDim0 _entries;
        private FixedRoomRevisitOverridesArray m_root;
        private KaitaiStruct m_parent;
        public FixedRoomRevisitOverridesArrayDim0 Entries { get { return _entries; } }
        public FixedRoomRevisitOverridesArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
