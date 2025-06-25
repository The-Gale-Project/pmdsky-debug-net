// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array statuses_speed_down_counters defined within pmdsky.
    /// </summary>
    public partial class StatusesSpeedDownCountersArray : KaitaiStruct
    {
        public static StatusesSpeedDownCountersArray FromFile(string fileName)
        {
            return new StatusesSpeedDownCountersArray(new KaitaiStream(fileName));
        }

        public StatusesSpeedDownCountersArray(KaitaiStream p__io, KaitaiStruct p__parent = null, StatusesSpeedDownCountersArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StatusesSpeedDownCountersArrayDim0(m_io, this, m_root);
        }
        public partial class StatusesSpeedDownCountersArrayDim0 : KaitaiStruct
        {
            public static StatusesSpeedDownCountersArrayDim0 FromFile(string fileName)
            {
                return new StatusesSpeedDownCountersArrayDim0(new KaitaiStream(fileName));
            }

            public StatusesSpeedDownCountersArrayDim0(KaitaiStream p__io, StatusesSpeedDownCountersArray p__parent = null, StatusesSpeedDownCountersArray p__root = null) : base(p__io)
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
            private StatusesSpeedDownCountersArray m_root;
            private StatusesSpeedDownCountersArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public StatusesSpeedDownCountersArray M_Root { get { return m_root; } }
            public StatusesSpeedDownCountersArray M_Parent { get { return m_parent; } }
        }
        private StatusesSpeedDownCountersArrayDim0 _entries;
        private StatusesSpeedDownCountersArray m_root;
        private KaitaiStruct m_parent;
        public StatusesSpeedDownCountersArrayDim0 Entries { get { return _entries; } }
        public StatusesSpeedDownCountersArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
