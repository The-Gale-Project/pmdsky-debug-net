// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array OVERLAY11_OVERLAY_LOAD_TABLE defined within pmdsky.
    /// </summary>
    public partial class Overlay11OverlayLoadTableArray : KaitaiStruct
    {
        public static Overlay11OverlayLoadTableArray FromFile(string fileName)
        {
            return new Overlay11OverlayLoadTableArray(new KaitaiStream(fileName));
        }

        public Overlay11OverlayLoadTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay11OverlayLoadTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new Overlay11OverlayLoadTableArrayDim0(m_io, this, m_root);
        }
        public partial class Overlay11OverlayLoadTableArrayDim0 : KaitaiStruct
        {
            public static Overlay11OverlayLoadTableArrayDim0 FromFile(string fileName)
            {
                return new Overlay11OverlayLoadTableArrayDim0(new KaitaiStream(fileName));
            }

            public Overlay11OverlayLoadTableArrayDim0(KaitaiStream p__io, Overlay11OverlayLoadTableArray p__parent = null, Overlay11OverlayLoadTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<OverlayLoadEntry>();
                for (var i = 0; i < 21; i++)
                {
                    _entries.Add(new OverlayLoadEntry(m_io));
                }
            }
            private List<OverlayLoadEntry> _entries;
            private Overlay11OverlayLoadTableArray m_root;
            private Overlay11OverlayLoadTableArray m_parent;
            public List<OverlayLoadEntry> Entries { get { return _entries; } }
            public Overlay11OverlayLoadTableArray M_Root { get { return m_root; } }
            public Overlay11OverlayLoadTableArray M_Parent { get { return m_parent; } }
        }
        private Overlay11OverlayLoadTableArrayDim0 _entries;
        private Overlay11OverlayLoadTableArray m_root;
        private KaitaiStruct m_parent;
        public Overlay11OverlayLoadTableArrayDim0 Entries { get { return _entries; } }
        public Overlay11OverlayLoadTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
