// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array ROOST_HP_RESTORATION_TABLE defined within pmdsky.
    /// </summary>
    public partial class RoostHpRestorationTableArray : KaitaiStruct
    {
        public static RoostHpRestorationTableArray FromFile(string fileName)
        {
            return new RoostHpRestorationTableArray(new KaitaiStream(fileName));
        }

        public RoostHpRestorationTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, RoostHpRestorationTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new RoostHpRestorationTableArrayDim0(m_io, this, m_root);
        }
        public partial class RoostHpRestorationTableArrayDim0 : KaitaiStruct
        {
            public static RoostHpRestorationTableArrayDim0 FromFile(string fileName)
            {
                return new RoostHpRestorationTableArrayDim0(new KaitaiStream(fileName));
            }

            public RoostHpRestorationTableArrayDim0(KaitaiStream p__io, RoostHpRestorationTableArray p__parent = null, RoostHpRestorationTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<short>();
                for (var i = 0; i < 8; i++)
                {
                    _entries.Add(m_io.ReadS2le());
                }
            }
            private List<short> _entries;
            private RoostHpRestorationTableArray m_root;
            private RoostHpRestorationTableArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public RoostHpRestorationTableArray M_Root { get { return m_root; } }
            public RoostHpRestorationTableArray M_Parent { get { return m_parent; } }
        }
        private RoostHpRestorationTableArrayDim0 _entries;
        private RoostHpRestorationTableArray m_root;
        private KaitaiStruct m_parent;
        public RoostHpRestorationTableArrayDim0 Entries { get { return _entries; } }
        public RoostHpRestorationTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
