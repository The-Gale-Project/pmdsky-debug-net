// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array STATUS_ICON_ARRAY_LONG_TOSS defined within pmdsky.
    /// </summary>
    public partial class StatusIconArrayLongTossArray : KaitaiStruct
    {
        public static StatusIconArrayLongTossArray FromFile(string fileName)
        {
            return new StatusIconArrayLongTossArray(new KaitaiStream(fileName));
        }

        public StatusIconArrayLongTossArray(KaitaiStream p__io, KaitaiStruct p__parent = null, StatusIconArrayLongTossArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StatusIconArrayLongTossArrayDim0(m_io, this, m_root);
        }
        public partial class StatusIconArrayLongTossArrayDim0 : KaitaiStruct
        {
            public static StatusIconArrayLongTossArrayDim0 FromFile(string fileName)
            {
                return new StatusIconArrayLongTossArrayDim0(new KaitaiStream(fileName));
            }

            public StatusIconArrayLongTossArrayDim0(KaitaiStream p__io, StatusIconArrayLongTossArray p__parent = null, StatusIconArrayLongTossArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<StatusIconFlags>();
                for (var i = 0; i < 3; i++)
                {
                    _entries.Add(new StatusIconFlags(m_io));
                }
            }
            private List<StatusIconFlags> _entries;
            private StatusIconArrayLongTossArray m_root;
            private StatusIconArrayLongTossArray m_parent;
            public List<StatusIconFlags> Entries { get { return _entries; } }
            public StatusIconArrayLongTossArray M_Root { get { return m_root; } }
            public StatusIconArrayLongTossArray M_Parent { get { return m_parent; } }
        }
        private StatusIconArrayLongTossArrayDim0 _entries;
        private StatusIconArrayLongTossArray m_root;
        private KaitaiStruct m_parent;
        public StatusIconArrayLongTossArrayDim0 Entries { get { return _entries; } }
        public StatusIconArrayLongTossArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
