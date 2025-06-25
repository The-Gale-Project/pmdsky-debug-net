// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union window_list defined within pmdsky-debug.
    /// </summary>
    public partial class WindowList : KaitaiStruct
    {
        public static WindowList FromFile(string fileName)
        {
            return new WindowList(new KaitaiStream(fileName));
        }

        public WindowList(KaitaiStream p__io, KaitaiStruct p__parent = null, WindowList p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _windows = new WindowListWindowsArray(m_io);
        }
        private WindowListWindowsArray _windows;
        private WindowList m_root;
        private KaitaiStruct m_parent;
        public WindowListWindowsArray Windows { get { return _windows; } }
        public WindowList M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
