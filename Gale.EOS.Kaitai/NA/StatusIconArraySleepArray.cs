// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array STATUS_ICON_ARRAY_SLEEP defined within pmdsky.
    /// </summary>
    public partial class StatusIconArraySleepArray : KaitaiStruct
    {
        public static StatusIconArraySleepArray FromFile(string fileName)
        {
            return new StatusIconArraySleepArray(new KaitaiStream(fileName));
        }

        public StatusIconArraySleepArray(KaitaiStream p__io, KaitaiStruct p__parent = null, StatusIconArraySleepArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StatusIconArraySleepArrayDim0(m_io, this, m_root);
        }
        public partial class StatusIconArraySleepArrayDim0 : KaitaiStruct
        {
            public static StatusIconArraySleepArrayDim0 FromFile(string fileName)
            {
                return new StatusIconArraySleepArrayDim0(new KaitaiStream(fileName));
            }

            public StatusIconArraySleepArrayDim0(KaitaiStream p__io, StatusIconArraySleepArray p__parent = null, StatusIconArraySleepArray p__root = null) : base(p__io)
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
            private StatusIconArraySleepArray m_root;
            private StatusIconArraySleepArray m_parent;
            public List<StatusIconFlags> Entries { get { return _entries; } }
            public StatusIconArraySleepArray M_Root { get { return m_root; } }
            public StatusIconArraySleepArray M_Parent { get { return m_parent; } }
        }
        private StatusIconArraySleepArrayDim0 _entries;
        private StatusIconArraySleepArray m_root;
        private KaitaiStruct m_parent;
        public StatusIconArraySleepArrayDim0 Entries { get { return _entries; } }
        public StatusIconArraySleepArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
