// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array SYNTHESIS_HP_RESTORATION_TABLE defined within pmdsky.
    /// </summary>
    public partial class SynthesisHpRestorationTableArray : KaitaiStruct
    {
        public static SynthesisHpRestorationTableArray FromFile(string fileName)
        {
            return new SynthesisHpRestorationTableArray(new KaitaiStream(fileName));
        }

        public SynthesisHpRestorationTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, SynthesisHpRestorationTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new SynthesisHpRestorationTableArrayDim0(m_io, this, m_root);
        }
        public partial class SynthesisHpRestorationTableArrayDim0 : KaitaiStruct
        {
            public static SynthesisHpRestorationTableArrayDim0 FromFile(string fileName)
            {
                return new SynthesisHpRestorationTableArrayDim0(new KaitaiStream(fileName));
            }

            public SynthesisHpRestorationTableArrayDim0(KaitaiStream p__io, SynthesisHpRestorationTableArray p__parent = null, SynthesisHpRestorationTableArray p__root = null) : base(p__io)
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
            private SynthesisHpRestorationTableArray m_root;
            private SynthesisHpRestorationTableArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public SynthesisHpRestorationTableArray M_Root { get { return m_root; } }
            public SynthesisHpRestorationTableArray M_Parent { get { return m_parent; } }
        }
        private SynthesisHpRestorationTableArrayDim0 _entries;
        private SynthesisHpRestorationTableArray m_root;
        private KaitaiStruct m_parent;
        public SynthesisHpRestorationTableArrayDim0 Entries { get { return _entries; } }
        public SynthesisHpRestorationTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
