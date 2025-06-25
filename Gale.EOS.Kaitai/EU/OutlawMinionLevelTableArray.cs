// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array OUTLAW_MINION_LEVEL_TABLE defined within pmdsky.
    /// </summary>
    public partial class OutlawMinionLevelTableArray : KaitaiStruct
    {
        public static OutlawMinionLevelTableArray FromFile(string fileName)
        {
            return new OutlawMinionLevelTableArray(new KaitaiStream(fileName));
        }

        public OutlawMinionLevelTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, OutlawMinionLevelTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new OutlawMinionLevelTableArrayDim0(m_io, this, m_root);
        }
        public partial class OutlawMinionLevelTableArrayDim0 : KaitaiStruct
        {
            public static OutlawMinionLevelTableArrayDim0 FromFile(string fileName)
            {
                return new OutlawMinionLevelTableArrayDim0(new KaitaiStream(fileName));
            }

            public OutlawMinionLevelTableArrayDim0(KaitaiStream p__io, OutlawMinionLevelTableArray p__parent = null, OutlawMinionLevelTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<short>();
                for (var i = 0; i < 16; i++)
                {
                    _entries.Add(m_io.ReadS2le());
                }
            }
            private List<short> _entries;
            private OutlawMinionLevelTableArray m_root;
            private OutlawMinionLevelTableArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public OutlawMinionLevelTableArray M_Root { get { return m_root; } }
            public OutlawMinionLevelTableArray M_Parent { get { return m_parent; } }
        }
        private OutlawMinionLevelTableArrayDim0 _entries;
        private OutlawMinionLevelTableArray m_root;
        private KaitaiStruct m_parent;
        public OutlawMinionLevelTableArrayDim0 Entries { get { return _entries; } }
        public OutlawMinionLevelTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
