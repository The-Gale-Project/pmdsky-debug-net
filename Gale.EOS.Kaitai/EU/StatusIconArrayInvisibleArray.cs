// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array STATUS_ICON_ARRAY_INVISIBLE defined within pmdsky.
    /// </summary>
    public partial class StatusIconArrayInvisibleArray : KaitaiStruct
    {
        public static StatusIconArrayInvisibleArray FromFile(string fileName)
        {
            return new StatusIconArrayInvisibleArray(new KaitaiStream(fileName));
        }

        public StatusIconArrayInvisibleArray(KaitaiStream p__io, KaitaiStruct p__parent = null, StatusIconArrayInvisibleArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StatusIconArrayInvisibleArrayDim0(m_io, this, m_root);
        }
        public partial class StatusIconArrayInvisibleArrayDim0 : KaitaiStruct
        {
            public static StatusIconArrayInvisibleArrayDim0 FromFile(string fileName)
            {
                return new StatusIconArrayInvisibleArrayDim0(new KaitaiStream(fileName));
            }

            public StatusIconArrayInvisibleArrayDim0(KaitaiStream p__io, StatusIconArrayInvisibleArray p__parent = null, StatusIconArrayInvisibleArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<StatusIconFlags>();
                for (var i = 0; i < 5; i++)
                {
                    _entries.Add(new StatusIconFlags(m_io));
                }
            }
            private List<StatusIconFlags> _entries;
            private StatusIconArrayInvisibleArray m_root;
            private StatusIconArrayInvisibleArray m_parent;
            public List<StatusIconFlags> Entries { get { return _entries; } }
            public StatusIconArrayInvisibleArray M_Root { get { return m_root; } }
            public StatusIconArrayInvisibleArray M_Parent { get { return m_parent; } }
        }
        private StatusIconArrayInvisibleArrayDim0 _entries;
        private StatusIconArrayInvisibleArray m_root;
        private KaitaiStruct m_parent;
        public StatusIconArrayInvisibleArrayDim0 Entries { get { return _entries; } }
        public StatusIconArrayInvisibleArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
