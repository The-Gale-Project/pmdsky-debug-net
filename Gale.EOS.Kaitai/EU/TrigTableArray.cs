// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array TRIG_TABLE defined within pmdsky.
    /// </summary>
    public partial class TrigTableArray : KaitaiStruct
    {
        public static TrigTableArray FromFile(string fileName)
        {
            return new TrigTableArray(new KaitaiStream(fileName));
        }

        public TrigTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, TrigTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new TrigTableArrayDim0(m_io, this, m_root);
        }
        public partial class TrigTableArrayDim0 : KaitaiStruct
        {
            public static TrigTableArrayDim0 FromFile(string fileName)
            {
                return new TrigTableArrayDim0(new KaitaiStream(fileName));
            }

            public TrigTableArrayDim0(KaitaiStream p__io, TrigTableArray p__parent = null, TrigTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<TrigValues>();
                for (var i = 0; i < 4096; i++)
                {
                    _entries.Add(new TrigValues(m_io));
                }
            }
            private List<TrigValues> _entries;
            private TrigTableArray m_root;
            private TrigTableArray m_parent;
            public List<TrigValues> Entries { get { return _entries; } }
            public TrigTableArray M_Root { get { return m_root; } }
            public TrigTableArray M_Parent { get { return m_parent; } }
        }
        private TrigTableArrayDim0 _entries;
        private TrigTableArray m_root;
        private KaitaiStruct m_parent;
        public TrigTableArrayDim0 Entries { get { return _entries; } }
        public TrigTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
