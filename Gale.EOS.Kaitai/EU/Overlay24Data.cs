// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{
    public partial class Overlay24Data : KaitaiStruct
    {
        public static Overlay24Data FromFile(string fileName)
        {
            return new Overlay24Data(new KaitaiStream(fileName));
        }

        public Overlay24Data(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay24Data p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_daycareMenuItemsConfirm = false;
            f_daycareMainMenuItems = false;
            f_daycareWindowParams4 = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_daycareMenuItemsConfirm;
        private DaycareMenuItemsConfirmArray _daycareMenuItemsConfirm;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public DaycareMenuItemsConfirmArray DaycareMenuItemsConfirm
        {
            get
            {
                if (f_daycareMenuItemsConfirm)
                    return _daycareMenuItemsConfirm;
                long _pos = m_io.Pos;
                m_io.Seek(9184);
                _daycareMenuItemsConfirm = new DaycareMenuItemsConfirmArray(m_io);
                m_io.Seek(_pos);
                f_daycareMenuItemsConfirm = true;
                return _daycareMenuItemsConfirm;
            }
        }
        private bool f_daycareMainMenuItems;
        private DaycareMainMenuItemsArray _daycareMainMenuItems;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public DaycareMainMenuItemsArray DaycareMainMenuItems
        {
            get
            {
                if (f_daycareMainMenuItems)
                    return _daycareMainMenuItems;
                long _pos = m_io.Pos;
                m_io.Seek(9208);
                _daycareMainMenuItems = new DaycareMainMenuItemsArray(m_io);
                m_io.Seek(_pos);
                f_daycareMainMenuItems = true;
                return _daycareMainMenuItems;
            }
        }
        private bool f_daycareWindowParams4;
        private WindowParams _daycareWindowParams4;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DaycareWindowParams4
        {
            get
            {
                if (f_daycareWindowParams4)
                    return _daycareWindowParams4;
                long _pos = m_io.Pos;
                m_io.Seek(9344);
                _daycareWindowParams4 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_daycareWindowParams4 = true;
                return _daycareWindowParams4;
            }
        }
        private Overlay24Data m_root;
        private KaitaiStruct m_parent;
        public Overlay24Data M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
