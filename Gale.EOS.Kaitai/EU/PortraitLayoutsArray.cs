// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array PORTRAIT_LAYOUTS defined within pmdsky.
    /// </summary>
    public partial class PortraitLayoutsArray : KaitaiStruct
    {
        public static PortraitLayoutsArray FromFile(string fileName)
        {
            return new PortraitLayoutsArray(new KaitaiStream(fileName));
        }

        public PortraitLayoutsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, PortraitLayoutsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new PortraitLayoutsArrayDim0(m_io, this, m_root);
        }
        public partial class PortraitLayoutsArrayDim0 : KaitaiStruct
        {
            public static PortraitLayoutsArrayDim0 FromFile(string fileName)
            {
                return new PortraitLayoutsArrayDim0(new KaitaiStream(fileName));
            }

            public PortraitLayoutsArrayDim0(KaitaiStream p__io, PortraitLayoutsArray p__parent = null, PortraitLayoutsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<PortraitLayout>();
                for (var i = 0; i < 32; i++)
                {
                    _entries.Add(new PortraitLayout(m_io));
                }
            }
            private List<PortraitLayout> _entries;
            private PortraitLayoutsArray m_root;
            private PortraitLayoutsArray m_parent;
            public List<PortraitLayout> Entries { get { return _entries; } }
            public PortraitLayoutsArray M_Root { get { return m_root; } }
            public PortraitLayoutsArray M_Parent { get { return m_parent; } }
        }
        private PortraitLayoutsArrayDim0 _entries;
        private PortraitLayoutsArray m_root;
        private KaitaiStruct m_parent;
        public PortraitLayoutsArrayDim0 Entries { get { return _entries; } }
        public PortraitLayoutsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
