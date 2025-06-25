// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array MORNING_SUN_HP_RESTORATION_TABLE defined within pmdsky.
    /// </summary>
    public partial class MorningSunHpRestorationTableArray : KaitaiStruct
    {
        public static MorningSunHpRestorationTableArray FromFile(string fileName)
        {
            return new MorningSunHpRestorationTableArray(new KaitaiStream(fileName));
        }

        public MorningSunHpRestorationTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MorningSunHpRestorationTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MorningSunHpRestorationTableArrayDim0(m_io, this, m_root);
        }
        public partial class MorningSunHpRestorationTableArrayDim0 : KaitaiStruct
        {
            public static MorningSunHpRestorationTableArrayDim0 FromFile(string fileName)
            {
                return new MorningSunHpRestorationTableArrayDim0(new KaitaiStream(fileName));
            }

            public MorningSunHpRestorationTableArrayDim0(KaitaiStream p__io, MorningSunHpRestorationTableArray p__parent = null, MorningSunHpRestorationTableArray p__root = null) : base(p__io)
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
            private MorningSunHpRestorationTableArray m_root;
            private MorningSunHpRestorationTableArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public MorningSunHpRestorationTableArray M_Root { get { return m_root; } }
            public MorningSunHpRestorationTableArray M_Parent { get { return m_parent; } }
        }
        private MorningSunHpRestorationTableArrayDim0 _entries;
        private MorningSunHpRestorationTableArray m_root;
        private KaitaiStruct m_parent;
        public MorningSunHpRestorationTableArrayDim0 Entries { get { return _entries; } }
        public MorningSunHpRestorationTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
