// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array STATUS_ICON_ARRAY_LEECH_SEED defined within pmdsky.
    /// </summary>
    public partial class StatusIconArrayLeechSeedArray : KaitaiStruct
    {
        public static StatusIconArrayLeechSeedArray FromFile(string fileName)
        {
            return new StatusIconArrayLeechSeedArray(new KaitaiStream(fileName));
        }

        public StatusIconArrayLeechSeedArray(KaitaiStream p__io, KaitaiStruct p__parent = null, StatusIconArrayLeechSeedArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StatusIconArrayLeechSeedArrayDim0(m_io, this, m_root);
        }
        public partial class StatusIconArrayLeechSeedArrayDim0 : KaitaiStruct
        {
            public static StatusIconArrayLeechSeedArrayDim0 FromFile(string fileName)
            {
                return new StatusIconArrayLeechSeedArrayDim0(new KaitaiStream(fileName));
            }

            public StatusIconArrayLeechSeedArrayDim0(KaitaiStream p__io, StatusIconArrayLeechSeedArray p__parent = null, StatusIconArrayLeechSeedArray p__root = null) : base(p__io)
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
            private StatusIconArrayLeechSeedArray m_root;
            private StatusIconArrayLeechSeedArray m_parent;
            public List<StatusIconFlags> Entries { get { return _entries; } }
            public StatusIconArrayLeechSeedArray M_Root { get { return m_root; } }
            public StatusIconArrayLeechSeedArray M_Parent { get { return m_parent; } }
        }
        private StatusIconArrayLeechSeedArrayDim0 _entries;
        private StatusIconArrayLeechSeedArray m_root;
        private KaitaiStruct m_parent;
        public StatusIconArrayLeechSeedArrayDim0 Entries { get { return _entries; } }
        public StatusIconArrayLeechSeedArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
