// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array statuses_speed_up_counters defined within pmdsky.
    /// </summary>
    public partial class StatusesSpeedUpCountersArray : KaitaiStruct
    {
        public static StatusesSpeedUpCountersArray FromFile(string fileName)
        {
            return new StatusesSpeedUpCountersArray(new KaitaiStream(fileName));
        }

        public StatusesSpeedUpCountersArray(KaitaiStream p__io, KaitaiStruct p__parent = null, StatusesSpeedUpCountersArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StatusesSpeedUpCountersArrayDim0(m_io, this, m_root);
        }
        public partial class StatusesSpeedUpCountersArrayDim0 : KaitaiStruct
        {
            public static StatusesSpeedUpCountersArrayDim0 FromFile(string fileName)
            {
                return new StatusesSpeedUpCountersArrayDim0(new KaitaiStream(fileName));
            }

            public StatusesSpeedUpCountersArrayDim0(KaitaiStream p__io, StatusesSpeedUpCountersArray p__parent = null, StatusesSpeedUpCountersArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<byte>();
                for (var i = 0; i < 5; i++)
                {
                    _entries.Add(m_io.ReadU1());
                }
            }
            private List<byte> _entries;
            private StatusesSpeedUpCountersArray m_root;
            private StatusesSpeedUpCountersArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public StatusesSpeedUpCountersArray M_Root { get { return m_root; } }
            public StatusesSpeedUpCountersArray M_Parent { get { return m_parent; } }
        }
        private StatusesSpeedUpCountersArrayDim0 _entries;
        private StatusesSpeedUpCountersArray m_root;
        private KaitaiStruct m_parent;
        public StatusesSpeedUpCountersArrayDim0 Entries { get { return _entries; } }
        public StatusesSpeedUpCountersArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
