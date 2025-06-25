// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array OVERLAY11_DEBUG_STRINGS defined within pmdsky.
    /// </summary>
    public partial class Overlay11DebugStringsArray : KaitaiStruct
    {
        public static Overlay11DebugStringsArray FromFile(string fileName)
        {
            return new Overlay11DebugStringsArray(new KaitaiStream(fileName));
        }

        public Overlay11DebugStringsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay11DebugStringsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new Overlay11DebugStringsArrayDim0(m_io, this, m_root);
        }
        public partial class Overlay11DebugStringsArrayDim0 : KaitaiStruct
        {
            public static Overlay11DebugStringsArrayDim0 FromFile(string fileName)
            {
                return new Overlay11DebugStringsArrayDim0(new KaitaiStream(fileName));
            }

            public Overlay11DebugStringsArrayDim0(KaitaiStream p__io, Overlay11DebugStringsArray p__parent = null, Overlay11DebugStringsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<sbyte>();
                for (var i = 0; i < 0; i++)
                {
                    _entries.Add(m_io.ReadS1());
                }
            }
            private List<sbyte> _entries;
            private Overlay11DebugStringsArray m_root;
            private Overlay11DebugStringsArray m_parent;
            public List<sbyte> Entries { get { return _entries; } }
            public Overlay11DebugStringsArray M_Root { get { return m_root; } }
            public Overlay11DebugStringsArray M_Parent { get { return m_parent; } }
        }
        private Overlay11DebugStringsArrayDim0 _entries;
        private Overlay11DebugStringsArray m_root;
        private KaitaiStruct m_parent;
        public Overlay11DebugStringsArrayDim0 Entries { get { return _entries; } }
        public Overlay11DebugStringsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
