// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{
    public partial class Overlay18Data : KaitaiStruct
    {
        public static Overlay18Data FromFile(string fileName)
        {
            return new Overlay18Data(new KaitaiStream(fileName));
        }

        public Overlay18Data(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay18Data p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_linkShopSubmenuItems1 = false;
            f_linkShopWindowParams6 = false;
            f_linkShopSubmenuItems3 = false;
            f_linkShopWindowParams5 = false;
            f_linkShopWindowParams2 = false;
            f_linkShopSubmenuItems5 = false;
            f_linkShopWindowParams7 = false;
            f_linkShopWindowParams1 = false;
            f_linkShopWindowParams4 = false;
            f_linkShopWindowParams10 = false;
            f_linkShopMainMenuItems = false;
            f_linkShopWindowParams3 = false;
            f_linkShopWindowParams11 = false;
            f_linkShopMenuItemsConfirm = false;
            f_linkShopWindowParams8 = false;
            f_linkShopWindowParams9 = false;
            f_linkShopSubmenuItems7 = false;
            f_linkShopSubmenuItems4 = false;
            f_linkShopSubmenuItems6 = false;
            f_overlay18FunctionPointerTable = false;
            f_linkShopSubmenuItems2 = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_linkShopSubmenuItems1;
        private LinkShopSubmenuItems1Array _linkShopSubmenuItems1;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public LinkShopSubmenuItems1Array LinkShopSubmenuItems1
        {
            get
            {
                if (f_linkShopSubmenuItems1)
                    return _linkShopSubmenuItems1;
                long _pos = m_io.Pos;
                m_io.Seek(12792);
                _linkShopSubmenuItems1 = new LinkShopSubmenuItems1Array(m_io);
                m_io.Seek(_pos);
                f_linkShopSubmenuItems1 = true;
                return _linkShopSubmenuItems1;
            }
        }
        private bool f_linkShopWindowParams6;
        private WindowParams _linkShopWindowParams6;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams LinkShopWindowParams6
        {
            get
            {
                if (f_linkShopWindowParams6)
                    return _linkShopWindowParams6;
                long _pos = m_io.Pos;
                m_io.Seek(12672);
                _linkShopWindowParams6 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_linkShopWindowParams6 = true;
                return _linkShopWindowParams6;
            }
        }
        private bool f_linkShopSubmenuItems3;
        private LinkShopSubmenuItems3Array _linkShopSubmenuItems3;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public LinkShopSubmenuItems3Array LinkShopSubmenuItems3
        {
            get
            {
                if (f_linkShopSubmenuItems3)
                    return _linkShopSubmenuItems3;
                long _pos = m_io.Pos;
                m_io.Seek(12888);
                _linkShopSubmenuItems3 = new LinkShopSubmenuItems3Array(m_io);
                m_io.Seek(_pos);
                f_linkShopSubmenuItems3 = true;
                return _linkShopSubmenuItems3;
            }
        }
        private bool f_linkShopWindowParams5;
        private WindowParams _linkShopWindowParams5;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams LinkShopWindowParams5
        {
            get
            {
                if (f_linkShopWindowParams5)
                    return _linkShopWindowParams5;
                long _pos = m_io.Pos;
                m_io.Seek(12656);
                _linkShopWindowParams5 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_linkShopWindowParams5 = true;
                return _linkShopWindowParams5;
            }
        }
        private bool f_linkShopWindowParams2;
        private WindowParams _linkShopWindowParams2;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams LinkShopWindowParams2
        {
            get
            {
                if (f_linkShopWindowParams2)
                    return _linkShopWindowParams2;
                long _pos = m_io.Pos;
                m_io.Seek(12608);
                _linkShopWindowParams2 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_linkShopWindowParams2 = true;
                return _linkShopWindowParams2;
            }
        }
        private bool f_linkShopSubmenuItems5;
        private LinkShopSubmenuItems5Array _linkShopSubmenuItems5;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public LinkShopSubmenuItems5Array LinkShopSubmenuItems5
        {
            get
            {
                if (f_linkShopSubmenuItems5)
                    return _linkShopSubmenuItems5;
                long _pos = m_io.Pos;
                m_io.Seek(12976);
                _linkShopSubmenuItems5 = new LinkShopSubmenuItems5Array(m_io);
                m_io.Seek(_pos);
                f_linkShopSubmenuItems5 = true;
                return _linkShopSubmenuItems5;
            }
        }
        private bool f_linkShopWindowParams7;
        private WindowParams _linkShopWindowParams7;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams LinkShopWindowParams7
        {
            get
            {
                if (f_linkShopWindowParams7)
                    return _linkShopWindowParams7;
                long _pos = m_io.Pos;
                m_io.Seek(12688);
                _linkShopWindowParams7 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_linkShopWindowParams7 = true;
                return _linkShopWindowParams7;
            }
        }
        private bool f_linkShopWindowParams1;
        private WindowParams _linkShopWindowParams1;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams LinkShopWindowParams1
        {
            get
            {
                if (f_linkShopWindowParams1)
                    return _linkShopWindowParams1;
                long _pos = m_io.Pos;
                m_io.Seek(12592);
                _linkShopWindowParams1 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_linkShopWindowParams1 = true;
                return _linkShopWindowParams1;
            }
        }
        private bool f_linkShopWindowParams4;
        private WindowParams _linkShopWindowParams4;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams LinkShopWindowParams4
        {
            get
            {
                if (f_linkShopWindowParams4)
                    return _linkShopWindowParams4;
                long _pos = m_io.Pos;
                m_io.Seek(12640);
                _linkShopWindowParams4 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_linkShopWindowParams4 = true;
                return _linkShopWindowParams4;
            }
        }
        private bool f_linkShopWindowParams10;
        private WindowParams _linkShopWindowParams10;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams LinkShopWindowParams10
        {
            get
            {
                if (f_linkShopWindowParams10)
                    return _linkShopWindowParams10;
                long _pos = m_io.Pos;
                m_io.Seek(12736);
                _linkShopWindowParams10 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_linkShopWindowParams10 = true;
                return _linkShopWindowParams10;
            }
        }
        private bool f_linkShopMainMenuItems;
        private LinkShopMainMenuItemsArray _linkShopMainMenuItems;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public LinkShopMainMenuItemsArray LinkShopMainMenuItems
        {
            get
            {
                if (f_linkShopMainMenuItems)
                    return _linkShopMainMenuItems;
                long _pos = m_io.Pos;
                m_io.Seek(12856);
                _linkShopMainMenuItems = new LinkShopMainMenuItemsArray(m_io);
                m_io.Seek(_pos);
                f_linkShopMainMenuItems = true;
                return _linkShopMainMenuItems;
            }
        }
        private bool f_linkShopWindowParams3;
        private WindowParams _linkShopWindowParams3;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams LinkShopWindowParams3
        {
            get
            {
                if (f_linkShopWindowParams3)
                    return _linkShopWindowParams3;
                long _pos = m_io.Pos;
                m_io.Seek(12624);
                _linkShopWindowParams3 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_linkShopWindowParams3 = true;
                return _linkShopWindowParams3;
            }
        }
        private bool f_linkShopWindowParams11;
        private WindowParams _linkShopWindowParams11;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams LinkShopWindowParams11
        {
            get
            {
                if (f_linkShopWindowParams11)
                    return _linkShopWindowParams11;
                long _pos = m_io.Pos;
                m_io.Seek(12752);
                _linkShopWindowParams11 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_linkShopWindowParams11 = true;
                return _linkShopWindowParams11;
            }
        }
        private bool f_linkShopMenuItemsConfirm;
        private LinkShopMenuItemsConfirmArray _linkShopMenuItemsConfirm;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public LinkShopMenuItemsConfirmArray LinkShopMenuItemsConfirm
        {
            get
            {
                if (f_linkShopMenuItemsConfirm)
                    return _linkShopMenuItemsConfirm;
                long _pos = m_io.Pos;
                m_io.Seek(12768);
                _linkShopMenuItemsConfirm = new LinkShopMenuItemsConfirmArray(m_io);
                m_io.Seek(_pos);
                f_linkShopMenuItemsConfirm = true;
                return _linkShopMenuItemsConfirm;
            }
        }
        private bool f_linkShopWindowParams8;
        private WindowParams _linkShopWindowParams8;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams LinkShopWindowParams8
        {
            get
            {
                if (f_linkShopWindowParams8)
                    return _linkShopWindowParams8;
                long _pos = m_io.Pos;
                m_io.Seek(12704);
                _linkShopWindowParams8 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_linkShopWindowParams8 = true;
                return _linkShopWindowParams8;
            }
        }
        private bool f_linkShopWindowParams9;
        private WindowParams _linkShopWindowParams9;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams LinkShopWindowParams9
        {
            get
            {
                if (f_linkShopWindowParams9)
                    return _linkShopWindowParams9;
                long _pos = m_io.Pos;
                m_io.Seek(12720);
                _linkShopWindowParams9 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_linkShopWindowParams9 = true;
                return _linkShopWindowParams9;
            }
        }
        private bool f_linkShopSubmenuItems7;
        private LinkShopSubmenuItems7Array _linkShopSubmenuItems7;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public LinkShopSubmenuItems7Array LinkShopSubmenuItems7
        {
            get
            {
                if (f_linkShopSubmenuItems7)
                    return _linkShopSubmenuItems7;
                long _pos = m_io.Pos;
                m_io.Seek(13120);
                _linkShopSubmenuItems7 = new LinkShopSubmenuItems7Array(m_io);
                m_io.Seek(_pos);
                f_linkShopSubmenuItems7 = true;
                return _linkShopSubmenuItems7;
            }
        }
        private bool f_linkShopSubmenuItems4;
        private LinkShopSubmenuItems4Array _linkShopSubmenuItems4;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public LinkShopSubmenuItems4Array LinkShopSubmenuItems4
        {
            get
            {
                if (f_linkShopSubmenuItems4)
                    return _linkShopSubmenuItems4;
                long _pos = m_io.Pos;
                m_io.Seek(12928);
                _linkShopSubmenuItems4 = new LinkShopSubmenuItems4Array(m_io);
                m_io.Seek(_pos);
                f_linkShopSubmenuItems4 = true;
                return _linkShopSubmenuItems4;
            }
        }
        private bool f_linkShopSubmenuItems6;
        private LinkShopSubmenuItems6Array _linkShopSubmenuItems6;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public LinkShopSubmenuItems6Array LinkShopSubmenuItems6
        {
            get
            {
                if (f_linkShopSubmenuItems6)
                    return _linkShopSubmenuItems6;
                long _pos = m_io.Pos;
                m_io.Seek(13048);
                _linkShopSubmenuItems6 = new LinkShopSubmenuItems6Array(m_io);
                m_io.Seek(_pos);
                f_linkShopSubmenuItems6 = true;
                return _linkShopSubmenuItems6;
            }
        }
        private bool f_overlay18FunctionPointerTable;
        private Overlay18FunctionPointerTableArray _overlay18FunctionPointerTable;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public Overlay18FunctionPointerTableArray Overlay18FunctionPointerTable
        {
            get
            {
                if (f_overlay18FunctionPointerTable)
                    return _overlay18FunctionPointerTable;
                long _pos = m_io.Pos;
                m_io.Seek(13192);
                _overlay18FunctionPointerTable = new Overlay18FunctionPointerTableArray(m_io);
                m_io.Seek(_pos);
                f_overlay18FunctionPointerTable = true;
                return _overlay18FunctionPointerTable;
            }
        }
        private bool f_linkShopSubmenuItems2;
        private LinkShopSubmenuItems2Array _linkShopSubmenuItems2;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public LinkShopSubmenuItems2Array LinkShopSubmenuItems2
        {
            get
            {
                if (f_linkShopSubmenuItems2)
                    return _linkShopSubmenuItems2;
                long _pos = m_io.Pos;
                m_io.Seek(12824);
                _linkShopSubmenuItems2 = new LinkShopSubmenuItems2Array(m_io);
                m_io.Seek(_pos);
                f_linkShopSubmenuItems2 = true;
                return _linkShopSubmenuItems2;
            }
        }
        private Overlay18Data m_root;
        private KaitaiStruct m_parent;
        public Overlay18Data M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
