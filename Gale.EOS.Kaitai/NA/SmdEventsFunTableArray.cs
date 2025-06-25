// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array SMD_EVENTS_FUN_TABLE defined within pmdsky.
    /// </summary>
    public partial class SmdEventsFunTableArray : KaitaiStruct
    {
        public static SmdEventsFunTableArray FromFile(string fileName)
        {
            return new SmdEventsFunTableArray(new KaitaiStream(fileName));
        }

        public SmdEventsFunTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, SmdEventsFunTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new SmdEventsFunTableArrayDim0(m_io, this, m_root);
        }
        public partial class SmdEventsFunTableArrayDim0 : KaitaiStruct
        {
            public static SmdEventsFunTableArrayDim0 FromFile(string fileName)
            {
                return new SmdEventsFunTableArrayDim0(new KaitaiStream(fileName));
            }

            public SmdEventsFunTableArrayDim0(KaitaiStream p__io, SmdEventsFunTableArray p__parent = null, SmdEventsFunTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<Pointer>();
                for (var i = 0; i < 127; i++)
                {
                    _entries.Add(new Pointer(m_io));
                }
            }
            private List<Pointer> _entries;
            private SmdEventsFunTableArray m_root;
            private SmdEventsFunTableArray m_parent;
            public List<Pointer> Entries { get { return _entries; } }
            public SmdEventsFunTableArray M_Root { get { return m_root; } }
            public SmdEventsFunTableArray M_Parent { get { return m_parent; } }
        }
        private SmdEventsFunTableArrayDim0 _entries;
        private SmdEventsFunTableArray m_root;
        private KaitaiStruct m_parent;
        public SmdEventsFunTableArrayDim0 Entries { get { return _entries; } }
        public SmdEventsFunTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
