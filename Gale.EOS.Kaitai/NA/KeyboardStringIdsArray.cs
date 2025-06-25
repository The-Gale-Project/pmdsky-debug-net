// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array KEYBOARD_STRING_IDS defined within pmdsky.
    /// </summary>
    public partial class KeyboardStringIdsArray : KaitaiStruct
    {
        public static KeyboardStringIdsArray FromFile(string fileName)
        {
            return new KeyboardStringIdsArray(new KaitaiStream(fileName));
        }

        public KeyboardStringIdsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, KeyboardStringIdsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new KeyboardStringIdsArrayDim0(m_io, this, m_root);
        }
        public partial class KeyboardStringIdsArrayDim0 : KaitaiStruct
        {
            public static KeyboardStringIdsArrayDim0 FromFile(string fileName)
            {
                return new KeyboardStringIdsArrayDim0(new KaitaiStream(fileName));
            }

            public KeyboardStringIdsArrayDim0(KaitaiStream p__io, KeyboardStringIdsArray p__parent = null, KeyboardStringIdsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<short>();
                for (var i = 0; i < 30; i++)
                {
                    _entries.Add(m_io.ReadS2le());
                }
            }
            private List<short> _entries;
            private KeyboardStringIdsArray m_root;
            private KeyboardStringIdsArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public KeyboardStringIdsArray M_Root { get { return m_root; } }
            public KeyboardStringIdsArray M_Parent { get { return m_parent; } }
        }
        private KeyboardStringIdsArrayDim0 _entries;
        private KeyboardStringIdsArray m_root;
        private KaitaiStruct m_parent;
        public KeyboardStringIdsArrayDim0 Entries { get { return _entries; } }
        public KeyboardStringIdsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
