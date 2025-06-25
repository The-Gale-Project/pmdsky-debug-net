// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array EVENTS defined within pmdsky.
    /// </summary>
    public partial class EventsArray : KaitaiStruct
    {
        public static EventsArray FromFile(string fileName)
        {
            return new EventsArray(new KaitaiStream(fileName));
        }

        public EventsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, EventsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new EventsArrayDim0(m_io, this, m_root);
        }
        public partial class EventsArrayDim0 : KaitaiStruct
        {
            public static EventsArrayDim0 FromFile(string fileName)
            {
                return new EventsArrayDim0(new KaitaiStream(fileName));
            }

            public EventsArrayDim0(KaitaiStream p__io, EventsArray p__parent = null, EventsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<ScriptLevel>();
                for (var i = 0; i < 0; i++)
                {
                    _entries.Add(new ScriptLevel(m_io));
                }
            }
            private List<ScriptLevel> _entries;
            private EventsArray m_root;
            private EventsArray m_parent;
            public List<ScriptLevel> Entries { get { return _entries; } }
            public EventsArray M_Root { get { return m_root; } }
            public EventsArray M_Parent { get { return m_parent; } }
        }
        private EventsArrayDim0 _entries;
        private EventsArray m_root;
        private KaitaiStruct m_parent;
        public EventsArrayDim0 Entries { get { return _entries; } }
        public EventsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
