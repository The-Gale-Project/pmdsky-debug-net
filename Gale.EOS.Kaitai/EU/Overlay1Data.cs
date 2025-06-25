// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{
    public partial class Overlay1Data : KaitaiStruct
    {
        public static Overlay1Data FromFile(string fileName)
        {
            return new Overlay1Data(new KaitaiStream(fileName));
        }

        public Overlay1Data(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay1Data p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_submenu = false;
            f_mainMenuWindowParams2 = false;
            f_continueChoice = false;
            f_mainMenuWindowParams4 = false;
            f_mainDebugMenuItems1 = false;
            f_mainMenuWindowParams7 = false;
            f_printsStrings = false;
            f_mainMenuWindowParams10 = false;
            f_mainMenuWindowParams5 = false;
            f_mainMenuWindowParams3 = false;
            f_mainMenu = false;
            f_mainMenuWindowParams1 = false;
            f_mainMenuWindowParams9 = false;
            f_printsStruct = false;
            f_mainMenuItemsConfirm = false;
            f_mainDebugMenuItems2 = false;
            f_mainMenuWindowParams6 = false;
            f_mainMenuWindowParams8 = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_submenu;
        private List<byte> _submenu;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public List<byte> Submenu
        {
            get
            {
                if (f_submenu)
                    return _submenu;
                long _pos = m_io.Pos;
                m_io.Seek(73620);
                _submenu = new List<byte>();
                for (var i = 0; i < 72; i++)
                {
                    _submenu.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_submenu = true;
                return _submenu;
            }
        }
        private bool f_mainMenuWindowParams2;
        private WindowParams _mainMenuWindowParams2;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams MainMenuWindowParams2
        {
            get
            {
                if (f_mainMenuWindowParams2)
                    return _mainMenuWindowParams2;
                long _pos = m_io.Pos;
                m_io.Seek(73524);
                _mainMenuWindowParams2 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_mainMenuWindowParams2 = true;
                return _mainMenuWindowParams2;
            }
        }
        private bool f_continueChoice;
        private List<byte> _continueChoice;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public List<byte> ContinueChoice
        {
            get
            {
                if (f_continueChoice)
                    return _continueChoice;
                long _pos = m_io.Pos;
                m_io.Seek(73588);
                _continueChoice = new List<byte>();
                for (var i = 0; i < 32; i++)
                {
                    _continueChoice.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_continueChoice = true;
                return _continueChoice;
            }
        }
        private bool f_mainMenuWindowParams4;
        private WindowParams _mainMenuWindowParams4;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams MainMenuWindowParams4
        {
            get
            {
                if (f_mainMenuWindowParams4)
                    return _mainMenuWindowParams4;
                long _pos = m_io.Pos;
                m_io.Seek(73556);
                _mainMenuWindowParams4 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_mainMenuWindowParams4 = true;
                return _mainMenuWindowParams4;
            }
        }
        private bool f_mainDebugMenuItems1;
        private MainDebugMenuItems1Array _mainDebugMenuItems1;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public MainDebugMenuItems1Array MainDebugMenuItems1
        {
            get
            {
                if (f_mainDebugMenuItems1)
                    return _mainDebugMenuItems1;
                long _pos = m_io.Pos;
                m_io.Seek(74268);
                _mainDebugMenuItems1 = new MainDebugMenuItems1Array(m_io);
                m_io.Seek(_pos);
                f_mainDebugMenuItems1 = true;
                return _mainDebugMenuItems1;
            }
        }
        private bool f_mainMenuWindowParams7;
        private WindowParams _mainMenuWindowParams7;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams MainMenuWindowParams7
        {
            get
            {
                if (f_mainMenuWindowParams7)
                    return _mainMenuWindowParams7;
                long _pos = m_io.Pos;
                m_io.Seek(74056);
                _mainMenuWindowParams7 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_mainMenuWindowParams7 = true;
                return _mainMenuWindowParams7;
            }
        }
        private bool f_printsStrings;
        private List<byte> _printsStrings;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> PrintsStrings
        {
            get
            {
                if (f_printsStrings)
                    return _printsStrings;
                long _pos = m_io.Pos;
                m_io.Seek(72504);
                _printsStrings = new List<byte>();
                for (var i = 0; i < 488; i++)
                {
                    _printsStrings.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_printsStrings = true;
                return _printsStrings;
            }
        }
        private bool f_mainMenuWindowParams10;
        private WindowParams _mainMenuWindowParams10;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams MainMenuWindowParams10
        {
            get
            {
                if (f_mainMenuWindowParams10)
                    return _mainMenuWindowParams10;
                long _pos = m_io.Pos;
                m_io.Seek(74364);
                _mainMenuWindowParams10 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_mainMenuWindowParams10 = true;
                return _mainMenuWindowParams10;
            }
        }
        private bool f_mainMenuWindowParams5;
        private WindowParams _mainMenuWindowParams5;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams MainMenuWindowParams5
        {
            get
            {
                if (f_mainMenuWindowParams5)
                    return _mainMenuWindowParams5;
                long _pos = m_io.Pos;
                m_io.Seek(74024);
                _mainMenuWindowParams5 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_mainMenuWindowParams5 = true;
                return _mainMenuWindowParams5;
            }
        }
        private bool f_mainMenuWindowParams3;
        private WindowParams _mainMenuWindowParams3;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams MainMenuWindowParams3
        {
            get
            {
                if (f_mainMenuWindowParams3)
                    return _mainMenuWindowParams3;
                long _pos = m_io.Pos;
                m_io.Seek(73540);
                _mainMenuWindowParams3 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_mainMenuWindowParams3 = true;
                return _mainMenuWindowParams3;
            }
        }
        private bool f_mainMenu;
        private List<byte> _mainMenu;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public List<byte> MainMenu
        {
            get
            {
                if (f_mainMenu)
                    return _mainMenu;
                long _pos = m_io.Pos;
                m_io.Seek(73692);
                _mainMenu = new List<byte>();
                for (var i = 0; i < 160; i++)
                {
                    _mainMenu.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_mainMenu = true;
                return _mainMenu;
            }
        }
        private bool f_mainMenuWindowParams1;
        private WindowParams _mainMenuWindowParams1;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams MainMenuWindowParams1
        {
            get
            {
                if (f_mainMenuWindowParams1)
                    return _mainMenuWindowParams1;
                long _pos = m_io.Pos;
                m_io.Seek(73508);
                _mainMenuWindowParams1 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_mainMenuWindowParams1 = true;
                return _mainMenuWindowParams1;
            }
        }
        private bool f_mainMenuWindowParams9;
        private WindowParams _mainMenuWindowParams9;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams MainMenuWindowParams9
        {
            get
            {
                if (f_mainMenuWindowParams9)
                    return _mainMenuWindowParams9;
                long _pos = m_io.Pos;
                m_io.Seek(74236);
                _mainMenuWindowParams9 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_mainMenuWindowParams9 = true;
                return _mainMenuWindowParams9;
            }
        }
        private bool f_printsStruct;
        private List<byte> _printsStruct;

        /// <summary>
        /// 62*0x8
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> PrintsStruct
        {
            get
            {
                if (f_printsStruct)
                    return _printsStruct;
                long _pos = m_io.Pos;
                m_io.Seek(72992);
                _printsStruct = new List<byte>();
                for (var i = 0; i < 496; i++)
                {
                    _printsStruct.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_printsStruct = true;
                return _printsStruct;
            }
        }
        private bool f_mainMenuItemsConfirm;
        private MainMenuItemsConfirmArray _mainMenuItemsConfirm;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public MainMenuItemsConfirmArray MainMenuItemsConfirm
        {
            get
            {
                if (f_mainMenuItemsConfirm)
                    return _mainMenuItemsConfirm;
                long _pos = m_io.Pos;
                m_io.Seek(74072);
                _mainMenuItemsConfirm = new MainMenuItemsConfirmArray(m_io);
                m_io.Seek(_pos);
                f_mainMenuItemsConfirm = true;
                return _mainMenuItemsConfirm;
            }
        }
        private bool f_mainDebugMenuItems2;
        private MainDebugMenuItems2Array _mainDebugMenuItems2;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public MainDebugMenuItems2Array MainDebugMenuItems2
        {
            get
            {
                if (f_mainDebugMenuItems2)
                    return _mainDebugMenuItems2;
                long _pos = m_io.Pos;
                m_io.Seek(74396);
                _mainDebugMenuItems2 = new MainDebugMenuItems2Array(m_io);
                m_io.Seek(_pos);
                f_mainDebugMenuItems2 = true;
                return _mainDebugMenuItems2;
            }
        }
        private bool f_mainMenuWindowParams6;
        private WindowParams _mainMenuWindowParams6;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams MainMenuWindowParams6
        {
            get
            {
                if (f_mainMenuWindowParams6)
                    return _mainMenuWindowParams6;
                long _pos = m_io.Pos;
                m_io.Seek(74040);
                _mainMenuWindowParams6 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_mainMenuWindowParams6 = true;
                return _mainMenuWindowParams6;
            }
        }
        private bool f_mainMenuWindowParams8;
        private WindowParams _mainMenuWindowParams8;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams MainMenuWindowParams8
        {
            get
            {
                if (f_mainMenuWindowParams8)
                    return _mainMenuWindowParams8;
                long _pos = m_io.Pos;
                m_io.Seek(74204);
                _mainMenuWindowParams8 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_mainMenuWindowParams8 = true;
                return _mainMenuWindowParams8;
            }
        }
        private Overlay1Data m_root;
        private KaitaiStruct m_parent;
        public Overlay1Data M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
