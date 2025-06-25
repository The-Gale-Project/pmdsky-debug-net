// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array OUTLAW_LEVEL_TABLE defined within pmdsky.
    /// </summary>
    public partial class OutlawLevelTableArray : KaitaiStruct
    {
        public static OutlawLevelTableArray FromFile(string fileName)
        {
            return new OutlawLevelTableArray(new KaitaiStream(fileName));
        }

        public OutlawLevelTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, OutlawLevelTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new OutlawLevelTableArrayDim0(m_io, this, m_root);
        }
        public partial class OutlawLevelTableArrayDim0 : KaitaiStruct
        {
            public static OutlawLevelTableArrayDim0 FromFile(string fileName)
            {
                return new OutlawLevelTableArrayDim0(new KaitaiStream(fileName));
            }

            public OutlawLevelTableArrayDim0(KaitaiStream p__io, OutlawLevelTableArray p__parent = null, OutlawLevelTableArray p__root = null) : base(p__io)
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
            private OutlawLevelTableArray m_root;
            private OutlawLevelTableArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public OutlawLevelTableArray M_Root { get { return m_root; } }
            public OutlawLevelTableArray M_Parent { get { return m_parent; } }
        }
        private OutlawLevelTableArrayDim0 _entries;
        private OutlawLevelTableArray m_root;
        private KaitaiStruct m_parent;
        public OutlawLevelTableArrayDim0 Entries { get { return _entries; } }
        public OutlawLevelTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
