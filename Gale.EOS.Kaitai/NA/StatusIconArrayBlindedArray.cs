// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array STATUS_ICON_ARRAY_BLINDED defined within pmdsky.
    /// </summary>
    public partial class StatusIconArrayBlindedArray : KaitaiStruct
    {
        public static StatusIconArrayBlindedArray FromFile(string fileName)
        {
            return new StatusIconArrayBlindedArray(new KaitaiStream(fileName));
        }

        public StatusIconArrayBlindedArray(KaitaiStream p__io, KaitaiStruct p__parent = null, StatusIconArrayBlindedArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StatusIconArrayBlindedArrayDim0(m_io, this, m_root);
        }
        public partial class StatusIconArrayBlindedArrayDim0 : KaitaiStruct
        {
            public static StatusIconArrayBlindedArrayDim0 FromFile(string fileName)
            {
                return new StatusIconArrayBlindedArrayDim0(new KaitaiStream(fileName));
            }

            public StatusIconArrayBlindedArrayDim0(KaitaiStream p__io, StatusIconArrayBlindedArray p__parent = null, StatusIconArrayBlindedArray p__root = null) : base(p__io)
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
            private StatusIconArrayBlindedArray m_root;
            private StatusIconArrayBlindedArray m_parent;
            public List<StatusIconFlags> Entries { get { return _entries; } }
            public StatusIconArrayBlindedArray M_Root { get { return m_root; } }
            public StatusIconArrayBlindedArray M_Parent { get { return m_parent; } }
        }
        private StatusIconArrayBlindedArrayDim0 _entries;
        private StatusIconArrayBlindedArray m_root;
        private KaitaiStruct m_parent;
        public StatusIconArrayBlindedArrayDim0 Entries { get { return _entries; } }
        public StatusIconArrayBlindedArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
