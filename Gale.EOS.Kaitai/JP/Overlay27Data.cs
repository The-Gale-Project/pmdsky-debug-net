// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{
    public partial class Overlay27Data : KaitaiStruct
    {
        public static Overlay27Data FromFile(string fileName)
        {
            return new Overlay27Data(new KaitaiStream(fileName));
        }

        public Overlay27Data(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay27Data p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_discardItemsSubmenuItems1 = false;
            f_discardItemsSubmenuItems2 = false;
            f_discardItemsMenuItemsConfirm = false;
            f_discardItemsMainMenuItems = false;
            f_discardWindowParams7 = false;
            f_discardWindowParams6 = false;
            f_discardWindowParams5 = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_discardItemsSubmenuItems1;
        private DiscardItemsSubmenuItems1Array _discardItemsSubmenuItems1;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public DiscardItemsSubmenuItems1Array DiscardItemsSubmenuItems1
        {
            get
            {
                if (f_discardItemsSubmenuItems1)
                    return _discardItemsSubmenuItems1;
                long _pos = m_io.Pos;
                m_io.Seek(10340);
                _discardItemsSubmenuItems1 = new DiscardItemsSubmenuItems1Array(m_io);
                m_io.Seek(_pos);
                f_discardItemsSubmenuItems1 = true;
                return _discardItemsSubmenuItems1;
            }
        }
        private bool f_discardItemsSubmenuItems2;
        private DiscardItemsSubmenuItems2Array _discardItemsSubmenuItems2;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public DiscardItemsSubmenuItems2Array DiscardItemsSubmenuItems2
        {
            get
            {
                if (f_discardItemsSubmenuItems2)
                    return _discardItemsSubmenuItems2;
                long _pos = m_io.Pos;
                m_io.Seek(10372);
                _discardItemsSubmenuItems2 = new DiscardItemsSubmenuItems2Array(m_io);
                m_io.Seek(_pos);
                f_discardItemsSubmenuItems2 = true;
                return _discardItemsSubmenuItems2;
            }
        }
        private bool f_discardItemsMenuItemsConfirm;
        private DiscardItemsMenuItemsConfirmArray _discardItemsMenuItemsConfirm;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public DiscardItemsMenuItemsConfirmArray DiscardItemsMenuItemsConfirm
        {
            get
            {
                if (f_discardItemsMenuItemsConfirm)
                    return _discardItemsMenuItemsConfirm;
                long _pos = m_io.Pos;
                m_io.Seek(10316);
                _discardItemsMenuItemsConfirm = new DiscardItemsMenuItemsConfirmArray(m_io);
                m_io.Seek(_pos);
                f_discardItemsMenuItemsConfirm = true;
                return _discardItemsMenuItemsConfirm;
            }
        }
        private bool f_discardItemsMainMenuItems;
        private DiscardItemsMainMenuItemsArray _discardItemsMainMenuItems;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public DiscardItemsMainMenuItemsArray DiscardItemsMainMenuItems
        {
            get
            {
                if (f_discardItemsMainMenuItems)
                    return _discardItemsMainMenuItems;
                long _pos = m_io.Pos;
                m_io.Seek(10404);
                _discardItemsMainMenuItems = new DiscardItemsMainMenuItemsArray(m_io);
                m_io.Seek(_pos);
                f_discardItemsMainMenuItems = true;
                return _discardItemsMainMenuItems;
            }
        }
        private bool f_discardWindowParams7;
        private WindowParams _discardWindowParams7;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DiscardWindowParams7
        {
            get
            {
                if (f_discardWindowParams7)
                    return _discardWindowParams7;
                long _pos = m_io.Pos;
                m_io.Seek(10588);
                _discardWindowParams7 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_discardWindowParams7 = true;
                return _discardWindowParams7;
            }
        }
        private bool f_discardWindowParams6;
        private WindowParams _discardWindowParams6;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DiscardWindowParams6
        {
            get
            {
                if (f_discardWindowParams6)
                    return _discardWindowParams6;
                long _pos = m_io.Pos;
                m_io.Seek(10572);
                _discardWindowParams6 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_discardWindowParams6 = true;
                return _discardWindowParams6;
            }
        }
        private bool f_discardWindowParams5;
        private WindowParams _discardWindowParams5;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DiscardWindowParams5
        {
            get
            {
                if (f_discardWindowParams5)
                    return _discardWindowParams5;
                long _pos = m_io.Pos;
                m_io.Seek(10556);
                _discardWindowParams5 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_discardWindowParams5 = true;
                return _discardWindowParams5;
            }
        }
        private Overlay27Data m_root;
        private KaitaiStruct m_parent;
        public Overlay27Data M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
