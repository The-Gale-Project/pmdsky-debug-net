// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array STATUS_ICON_ARRAY_CRINGE defined within pmdsky.
    /// </summary>
    public partial class StatusIconArrayCringeArray : KaitaiStruct
    {
        public static StatusIconArrayCringeArray FromFile(string fileName)
        {
            return new StatusIconArrayCringeArray(new KaitaiStream(fileName));
        }

        public StatusIconArrayCringeArray(KaitaiStream p__io, KaitaiStruct p__parent = null, StatusIconArrayCringeArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StatusIconArrayCringeArrayDim0(m_io, this, m_root);
        }
        public partial class StatusIconArrayCringeArrayDim0 : KaitaiStruct
        {
            public static StatusIconArrayCringeArrayDim0 FromFile(string fileName)
            {
                return new StatusIconArrayCringeArrayDim0(new KaitaiStream(fileName));
            }

            public StatusIconArrayCringeArrayDim0(KaitaiStream p__io, StatusIconArrayCringeArray p__parent = null, StatusIconArrayCringeArray p__root = null) : base(p__io)
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
            private StatusIconArrayCringeArray m_root;
            private StatusIconArrayCringeArray m_parent;
            public List<StatusIconFlags> Entries { get { return _entries; } }
            public StatusIconArrayCringeArray M_Root { get { return m_root; } }
            public StatusIconArrayCringeArray M_Parent { get { return m_parent; } }
        }
        private StatusIconArrayCringeArrayDim0 _entries;
        private StatusIconArrayCringeArray m_root;
        private KaitaiStruct m_parent;
        public StatusIconArrayCringeArrayDim0 Entries { get { return _entries; } }
        public StatusIconArrayCringeArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
