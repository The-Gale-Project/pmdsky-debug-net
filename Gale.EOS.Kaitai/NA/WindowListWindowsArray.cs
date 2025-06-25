// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array window_list_windows defined within pmdsky.
    /// </summary>
    public partial class WindowListWindowsArray : KaitaiStruct
    {
        public static WindowListWindowsArray FromFile(string fileName)
        {
            return new WindowListWindowsArray(new KaitaiStream(fileName));
        }

        public WindowListWindowsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, WindowListWindowsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new WindowListWindowsArrayDim0(m_io, this, m_root);
        }
        public partial class WindowListWindowsArrayDim0 : KaitaiStruct
        {
            public static WindowListWindowsArrayDim0 FromFile(string fileName)
            {
                return new WindowListWindowsArrayDim0(new KaitaiStream(fileName));
            }

            public WindowListWindowsArrayDim0(KaitaiStream p__io, WindowListWindowsArray p__parent = null, WindowListWindowsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<Window>();
                for (var i = 0; i < 20; i++)
                {
                    _entries.Add(new Window(m_io));
                }
            }
            private List<Window> _entries;
            private WindowListWindowsArray m_root;
            private WindowListWindowsArray m_parent;
            public List<Window> Entries { get { return _entries; } }
            public WindowListWindowsArray M_Root { get { return m_root; } }
            public WindowListWindowsArray M_Parent { get { return m_parent; } }
        }
        private WindowListWindowsArrayDim0 _entries;
        private WindowListWindowsArray m_root;
        private KaitaiStruct m_parent;
        public WindowListWindowsArrayDim0 Entries { get { return _entries; } }
        public WindowListWindowsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
