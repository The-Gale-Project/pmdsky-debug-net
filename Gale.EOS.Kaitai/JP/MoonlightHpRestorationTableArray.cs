// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array MOONLIGHT_HP_RESTORATION_TABLE defined within pmdsky.
    /// </summary>
    public partial class MoonlightHpRestorationTableArray : KaitaiStruct
    {
        public static MoonlightHpRestorationTableArray FromFile(string fileName)
        {
            return new MoonlightHpRestorationTableArray(new KaitaiStream(fileName));
        }

        public MoonlightHpRestorationTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MoonlightHpRestorationTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MoonlightHpRestorationTableArrayDim0(m_io, this, m_root);
        }
        public partial class MoonlightHpRestorationTableArrayDim0 : KaitaiStruct
        {
            public static MoonlightHpRestorationTableArrayDim0 FromFile(string fileName)
            {
                return new MoonlightHpRestorationTableArrayDim0(new KaitaiStream(fileName));
            }

            public MoonlightHpRestorationTableArrayDim0(KaitaiStream p__io, MoonlightHpRestorationTableArray p__parent = null, MoonlightHpRestorationTableArray p__root = null) : base(p__io)
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
            private MoonlightHpRestorationTableArray m_root;
            private MoonlightHpRestorationTableArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public MoonlightHpRestorationTableArray M_Root { get { return m_root; } }
            public MoonlightHpRestorationTableArray M_Parent { get { return m_parent; } }
        }
        private MoonlightHpRestorationTableArrayDim0 _entries;
        private MoonlightHpRestorationTableArray m_root;
        private KaitaiStruct m_parent;
        public MoonlightHpRestorationTableArrayDim0 Entries { get { return _entries; } }
        public MoonlightHpRestorationTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
