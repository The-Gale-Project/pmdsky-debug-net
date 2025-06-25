// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array STATUS_ICON_ARRAY_BURN defined within pmdsky.
    /// </summary>
    public partial class StatusIconArrayBurnArray : KaitaiStruct
    {
        public static StatusIconArrayBurnArray FromFile(string fileName)
        {
            return new StatusIconArrayBurnArray(new KaitaiStream(fileName));
        }

        public StatusIconArrayBurnArray(KaitaiStream p__io, KaitaiStruct p__parent = null, StatusIconArrayBurnArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StatusIconArrayBurnArrayDim0(m_io, this, m_root);
        }
        public partial class StatusIconArrayBurnArrayDim0 : KaitaiStruct
        {
            public static StatusIconArrayBurnArrayDim0 FromFile(string fileName)
            {
                return new StatusIconArrayBurnArrayDim0(new KaitaiStream(fileName));
            }

            public StatusIconArrayBurnArrayDim0(KaitaiStream p__io, StatusIconArrayBurnArray p__parent = null, StatusIconArrayBurnArray p__root = null) : base(p__io)
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
            private StatusIconArrayBurnArray m_root;
            private StatusIconArrayBurnArray m_parent;
            public List<StatusIconFlags> Entries { get { return _entries; } }
            public StatusIconArrayBurnArray M_Root { get { return m_root; } }
            public StatusIconArrayBurnArray M_Parent { get { return m_parent; } }
        }
        private StatusIconArrayBurnArrayDim0 _entries;
        private StatusIconArrayBurnArray m_root;
        private KaitaiStruct m_parent;
        public StatusIconArrayBurnArrayDim0 Entries { get { return _entries; } }
        public StatusIconArrayBurnArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
