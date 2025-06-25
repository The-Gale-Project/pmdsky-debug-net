// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array STATUS_ICON_ARRAY_FREEZE defined within pmdsky.
    /// </summary>
    public partial class StatusIconArrayFreezeArray : KaitaiStruct
    {
        public static StatusIconArrayFreezeArray FromFile(string fileName)
        {
            return new StatusIconArrayFreezeArray(new KaitaiStream(fileName));
        }

        public StatusIconArrayFreezeArray(KaitaiStream p__io, KaitaiStruct p__parent = null, StatusIconArrayFreezeArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StatusIconArrayFreezeArrayDim0(m_io, this, m_root);
        }
        public partial class StatusIconArrayFreezeArrayDim0 : KaitaiStruct
        {
            public static StatusIconArrayFreezeArrayDim0 FromFile(string fileName)
            {
                return new StatusIconArrayFreezeArrayDim0(new KaitaiStream(fileName));
            }

            public StatusIconArrayFreezeArrayDim0(KaitaiStream p__io, StatusIconArrayFreezeArray p__parent = null, StatusIconArrayFreezeArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<StatusIconFlags>();
                for (var i = 0; i < 8; i++)
                {
                    _entries.Add(new StatusIconFlags(m_io));
                }
            }
            private List<StatusIconFlags> _entries;
            private StatusIconArrayFreezeArray m_root;
            private StatusIconArrayFreezeArray m_parent;
            public List<StatusIconFlags> Entries { get { return _entries; } }
            public StatusIconArrayFreezeArray M_Root { get { return m_root; } }
            public StatusIconArrayFreezeArray M_Parent { get { return m_parent; } }
        }
        private StatusIconArrayFreezeArrayDim0 _entries;
        private StatusIconArrayFreezeArray m_root;
        private KaitaiStruct m_parent;
        public StatusIconArrayFreezeArrayDim0 Entries { get { return _entries; } }
        public StatusIconArrayFreezeArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
