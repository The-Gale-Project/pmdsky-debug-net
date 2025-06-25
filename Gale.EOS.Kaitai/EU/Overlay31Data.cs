// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{
    public partial class Overlay31Data : KaitaiStruct
    {
        public static Overlay31Data FromFile(string fileName)
        {
            return new Overlay31Data(new KaitaiStream(fileName));
        }

        public Overlay31Data(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay31Data p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_dungeonWindowParams13 = false;
            f_dungeonWindowParams7 = false;
            f_dungeonWindowParams24 = false;
            f_dungeonWindowParams10 = false;
            f_dungeonWindowParams30 = false;
            f_dungeonWindowParams9 = false;
            f_dungeonWindowParams2 = false;
            f_dungeonWindowParams8 = false;
            f_dungeonWindowParams25 = false;
            f_dungeonWindowParams14 = false;
            f_dungeonWindowParams12 = false;
            f_dungeonWindowParams26 = false;
            f_dungeonWindowParams1 = false;
            f_dungeonSubmenuItems2 = false;
            f_dungeonWindowParams17 = false;
            f_dungeonWindowParams4 = false;
            f_dungeonSubmenuItems3 = false;
            f_dungeonWindowParams6 = false;
            f_dungeonWindowParams18 = false;
            f_dungeonWindowParams16 = false;
            f_dungeonWindowParams15 = false;
            f_dungeonWindowParams32 = false;
            f_dungeonSubmenuItems4 = false;
            f_dungeonWindowParams22 = false;
            f_dungeonMainMenuItems = false;
            f_dungeonWindowParams31 = false;
            f_dungeonWindowParams23 = false;
            f_dungeonSubmenuItems1 = false;
            f_dungeonWindowParams27 = false;
            f_dungeonWindowParams28 = false;
            f_dungeonWindowParams19 = false;
            f_dungeonSubmenuItems6 = false;
            f_dungeonWindowParams21 = false;
            f_dungeonSubmenuItems5 = false;
            f_dungeonWindowParams3 = false;
            f_dungeonWindowParams11 = false;
            f_dungeonMenuSwitchStr1 = false;
            f_dungeonWindowParams29 = false;
            f_dungeonWindowParams5 = false;
            f_dungeonWindowParams20 = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_dungeonWindowParams13;
        private WindowParams _dungeonWindowParams13;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DungeonWindowParams13
        {
            get
            {
                if (f_dungeonWindowParams13)
                    return _dungeonWindowParams13;
                long _pos = m_io.Pos;
                m_io.Seek(30544);
                _dungeonWindowParams13 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_dungeonWindowParams13 = true;
                return _dungeonWindowParams13;
            }
        }
        private bool f_dungeonWindowParams7;
        private WindowParams _dungeonWindowParams7;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DungeonWindowParams7
        {
            get
            {
                if (f_dungeonWindowParams7)
                    return _dungeonWindowParams7;
                long _pos = m_io.Pos;
                m_io.Seek(30308);
                _dungeonWindowParams7 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_dungeonWindowParams7 = true;
                return _dungeonWindowParams7;
            }
        }
        private bool f_dungeonWindowParams24;
        private WindowParams _dungeonWindowParams24;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DungeonWindowParams24
        {
            get
            {
                if (f_dungeonWindowParams24)
                    return _dungeonWindowParams24;
                long _pos = m_io.Pos;
                m_io.Seek(30776);
                _dungeonWindowParams24 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_dungeonWindowParams24 = true;
                return _dungeonWindowParams24;
            }
        }
        private bool f_dungeonWindowParams10;
        private WindowParams _dungeonWindowParams10;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DungeonWindowParams10
        {
            get
            {
                if (f_dungeonWindowParams10)
                    return _dungeonWindowParams10;
                long _pos = m_io.Pos;
                m_io.Seek(30496);
                _dungeonWindowParams10 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_dungeonWindowParams10 = true;
                return _dungeonWindowParams10;
            }
        }
        private bool f_dungeonWindowParams30;
        private WindowParams _dungeonWindowParams30;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DungeonWindowParams30
        {
            get
            {
                if (f_dungeonWindowParams30)
                    return _dungeonWindowParams30;
                long _pos = m_io.Pos;
                m_io.Seek(31228);
                _dungeonWindowParams30 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_dungeonWindowParams30 = true;
                return _dungeonWindowParams30;
            }
        }
        private bool f_dungeonWindowParams9;
        private WindowParams _dungeonWindowParams9;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DungeonWindowParams9
        {
            get
            {
                if (f_dungeonWindowParams9)
                    return _dungeonWindowParams9;
                long _pos = m_io.Pos;
                m_io.Seek(30480);
                _dungeonWindowParams9 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_dungeonWindowParams9 = true;
                return _dungeonWindowParams9;
            }
        }
        private bool f_dungeonWindowParams2;
        private WindowParams _dungeonWindowParams2;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DungeonWindowParams2
        {
            get
            {
                if (f_dungeonWindowParams2)
                    return _dungeonWindowParams2;
                long _pos = m_io.Pos;
                m_io.Seek(30120);
                _dungeonWindowParams2 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_dungeonWindowParams2 = true;
                return _dungeonWindowParams2;
            }
        }
        private bool f_dungeonWindowParams8;
        private WindowParams _dungeonWindowParams8;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DungeonWindowParams8
        {
            get
            {
                if (f_dungeonWindowParams8)
                    return _dungeonWindowParams8;
                long _pos = m_io.Pos;
                m_io.Seek(30464);
                _dungeonWindowParams8 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_dungeonWindowParams8 = true;
                return _dungeonWindowParams8;
            }
        }
        private bool f_dungeonWindowParams25;
        private WindowParams _dungeonWindowParams25;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DungeonWindowParams25
        {
            get
            {
                if (f_dungeonWindowParams25)
                    return _dungeonWindowParams25;
                long _pos = m_io.Pos;
                m_io.Seek(30992);
                _dungeonWindowParams25 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_dungeonWindowParams25 = true;
                return _dungeonWindowParams25;
            }
        }
        private bool f_dungeonWindowParams14;
        private WindowParams _dungeonWindowParams14;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DungeonWindowParams14
        {
            get
            {
                if (f_dungeonWindowParams14)
                    return _dungeonWindowParams14;
                long _pos = m_io.Pos;
                m_io.Seek(30604);
                _dungeonWindowParams14 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_dungeonWindowParams14 = true;
                return _dungeonWindowParams14;
            }
        }
        private bool f_dungeonWindowParams12;
        private WindowParams _dungeonWindowParams12;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DungeonWindowParams12
        {
            get
            {
                if (f_dungeonWindowParams12)
                    return _dungeonWindowParams12;
                long _pos = m_io.Pos;
                m_io.Seek(30528);
                _dungeonWindowParams12 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_dungeonWindowParams12 = true;
                return _dungeonWindowParams12;
            }
        }
        private bool f_dungeonWindowParams26;
        private WindowParams _dungeonWindowParams26;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DungeonWindowParams26
        {
            get
            {
                if (f_dungeonWindowParams26)
                    return _dungeonWindowParams26;
                long _pos = m_io.Pos;
                m_io.Seek(31032);
                _dungeonWindowParams26 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_dungeonWindowParams26 = true;
                return _dungeonWindowParams26;
            }
        }
        private bool f_dungeonWindowParams1;
        private WindowParams _dungeonWindowParams1;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DungeonWindowParams1
        {
            get
            {
                if (f_dungeonWindowParams1)
                    return _dungeonWindowParams1;
                long _pos = m_io.Pos;
                m_io.Seek(30104);
                _dungeonWindowParams1 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_dungeonWindowParams1 = true;
                return _dungeonWindowParams1;
            }
        }
        private bool f_dungeonSubmenuItems2;
        private DungeonSubmenuItems2Array _dungeonSubmenuItems2;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public DungeonSubmenuItems2Array DungeonSubmenuItems2
        {
            get
            {
                if (f_dungeonSubmenuItems2)
                    return _dungeonSubmenuItems2;
                long _pos = m_io.Pos;
                m_io.Seek(30356);
                _dungeonSubmenuItems2 = new DungeonSubmenuItems2Array(m_io);
                m_io.Seek(_pos);
                f_dungeonSubmenuItems2 = true;
                return _dungeonSubmenuItems2;
            }
        }
        private bool f_dungeonWindowParams17;
        private WindowParams _dungeonWindowParams17;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DungeonWindowParams17
        {
            get
            {
                if (f_dungeonWindowParams17)
                    return _dungeonWindowParams17;
                long _pos = m_io.Pos;
                m_io.Seek(30652);
                _dungeonWindowParams17 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_dungeonWindowParams17 = true;
                return _dungeonWindowParams17;
            }
        }
        private bool f_dungeonWindowParams4;
        private WindowParams _dungeonWindowParams4;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DungeonWindowParams4
        {
            get
            {
                if (f_dungeonWindowParams4)
                    return _dungeonWindowParams4;
                long _pos = m_io.Pos;
                m_io.Seek(30152);
                _dungeonWindowParams4 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_dungeonWindowParams4 = true;
                return _dungeonWindowParams4;
            }
        }
        private bool f_dungeonSubmenuItems3;
        private DungeonSubmenuItems3Array _dungeonSubmenuItems3;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public DungeonSubmenuItems3Array DungeonSubmenuItems3
        {
            get
            {
                if (f_dungeonSubmenuItems3)
                    return _dungeonSubmenuItems3;
                long _pos = m_io.Pos;
                m_io.Seek(30388);
                _dungeonSubmenuItems3 = new DungeonSubmenuItems3Array(m_io);
                m_io.Seek(_pos);
                f_dungeonSubmenuItems3 = true;
                return _dungeonSubmenuItems3;
            }
        }
        private bool f_dungeonWindowParams6;
        private WindowParams _dungeonWindowParams6;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DungeonWindowParams6
        {
            get
            {
                if (f_dungeonWindowParams6)
                    return _dungeonWindowParams6;
                long _pos = m_io.Pos;
                m_io.Seek(30292);
                _dungeonWindowParams6 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_dungeonWindowParams6 = true;
                return _dungeonWindowParams6;
            }
        }
        private bool f_dungeonWindowParams18;
        private WindowParams _dungeonWindowParams18;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DungeonWindowParams18
        {
            get
            {
                if (f_dungeonWindowParams18)
                    return _dungeonWindowParams18;
                long _pos = m_io.Pos;
                m_io.Seek(30668);
                _dungeonWindowParams18 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_dungeonWindowParams18 = true;
                return _dungeonWindowParams18;
            }
        }
        private bool f_dungeonWindowParams16;
        private WindowParams _dungeonWindowParams16;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DungeonWindowParams16
        {
            get
            {
                if (f_dungeonWindowParams16)
                    return _dungeonWindowParams16;
                long _pos = m_io.Pos;
                m_io.Seek(30636);
                _dungeonWindowParams16 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_dungeonWindowParams16 = true;
                return _dungeonWindowParams16;
            }
        }
        private bool f_dungeonWindowParams15;
        private WindowParams _dungeonWindowParams15;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DungeonWindowParams15
        {
            get
            {
                if (f_dungeonWindowParams15)
                    return _dungeonWindowParams15;
                long _pos = m_io.Pos;
                m_io.Seek(30620);
                _dungeonWindowParams15 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_dungeonWindowParams15 = true;
                return _dungeonWindowParams15;
            }
        }
        private bool f_dungeonWindowParams32;
        private WindowParams _dungeonWindowParams32;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DungeonWindowParams32
        {
            get
            {
                if (f_dungeonWindowParams32)
                    return _dungeonWindowParams32;
                long _pos = m_io.Pos;
                m_io.Seek(31260);
                _dungeonWindowParams32 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_dungeonWindowParams32 = true;
                return _dungeonWindowParams32;
            }
        }
        private bool f_dungeonSubmenuItems4;
        private DungeonSubmenuItems4Array _dungeonSubmenuItems4;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public DungeonSubmenuItems4Array DungeonSubmenuItems4
        {
            get
            {
                if (f_dungeonSubmenuItems4)
                    return _dungeonSubmenuItems4;
                long _pos = m_io.Pos;
                m_io.Seek(30420);
                _dungeonSubmenuItems4 = new DungeonSubmenuItems4Array(m_io);
                m_io.Seek(_pos);
                f_dungeonSubmenuItems4 = true;
                return _dungeonSubmenuItems4;
            }
        }
        private bool f_dungeonWindowParams22;
        private WindowParams _dungeonWindowParams22;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DungeonWindowParams22
        {
            get
            {
                if (f_dungeonWindowParams22)
                    return _dungeonWindowParams22;
                long _pos = m_io.Pos;
                m_io.Seek(30744);
                _dungeonWindowParams22 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_dungeonWindowParams22 = true;
                return _dungeonWindowParams22;
            }
        }
        private bool f_dungeonMainMenuItems;
        private DungeonMainMenuItemsArray _dungeonMainMenuItems;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public DungeonMainMenuItemsArray DungeonMainMenuItems
        {
            get
            {
                if (f_dungeonMainMenuItems)
                    return _dungeonMainMenuItems;
                long _pos = m_io.Pos;
                m_io.Seek(30168);
                _dungeonMainMenuItems = new DungeonMainMenuItemsArray(m_io);
                m_io.Seek(_pos);
                f_dungeonMainMenuItems = true;
                return _dungeonMainMenuItems;
            }
        }
        private bool f_dungeonWindowParams31;
        private WindowParams _dungeonWindowParams31;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DungeonWindowParams31
        {
            get
            {
                if (f_dungeonWindowParams31)
                    return _dungeonWindowParams31;
                long _pos = m_io.Pos;
                m_io.Seek(31244);
                _dungeonWindowParams31 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_dungeonWindowParams31 = true;
                return _dungeonWindowParams31;
            }
        }
        private bool f_dungeonWindowParams23;
        private WindowParams _dungeonWindowParams23;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DungeonWindowParams23
        {
            get
            {
                if (f_dungeonWindowParams23)
                    return _dungeonWindowParams23;
                long _pos = m_io.Pos;
                m_io.Seek(30760);
                _dungeonWindowParams23 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_dungeonWindowParams23 = true;
                return _dungeonWindowParams23;
            }
        }
        private bool f_dungeonSubmenuItems1;
        private DungeonSubmenuItems1Array _dungeonSubmenuItems1;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public DungeonSubmenuItems1Array DungeonSubmenuItems1
        {
            get
            {
                if (f_dungeonSubmenuItems1)
                    return _dungeonSubmenuItems1;
                long _pos = m_io.Pos;
                m_io.Seek(30324);
                _dungeonSubmenuItems1 = new DungeonSubmenuItems1Array(m_io);
                m_io.Seek(_pos);
                f_dungeonSubmenuItems1 = true;
                return _dungeonSubmenuItems1;
            }
        }
        private bool f_dungeonWindowParams27;
        private WindowParams _dungeonWindowParams27;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DungeonWindowParams27
        {
            get
            {
                if (f_dungeonWindowParams27)
                    return _dungeonWindowParams27;
                long _pos = m_io.Pos;
                m_io.Seek(31092);
                _dungeonWindowParams27 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_dungeonWindowParams27 = true;
                return _dungeonWindowParams27;
            }
        }
        private bool f_dungeonWindowParams28;
        private WindowParams _dungeonWindowParams28;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DungeonWindowParams28
        {
            get
            {
                if (f_dungeonWindowParams28)
                    return _dungeonWindowParams28;
                long _pos = m_io.Pos;
                m_io.Seek(31108);
                _dungeonWindowParams28 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_dungeonWindowParams28 = true;
                return _dungeonWindowParams28;
            }
        }
        private bool f_dungeonWindowParams19;
        private WindowParams _dungeonWindowParams19;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DungeonWindowParams19
        {
            get
            {
                if (f_dungeonWindowParams19)
                    return _dungeonWindowParams19;
                long _pos = m_io.Pos;
                m_io.Seek(30684);
                _dungeonWindowParams19 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_dungeonWindowParams19 = true;
                return _dungeonWindowParams19;
            }
        }
        private bool f_dungeonSubmenuItems6;
        private DungeonSubmenuItems6Array _dungeonSubmenuItems6;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public DungeonSubmenuItems6Array DungeonSubmenuItems6
        {
            get
            {
                if (f_dungeonSubmenuItems6)
                    return _dungeonSubmenuItems6;
                long _pos = m_io.Pos;
                m_io.Seek(31140);
                _dungeonSubmenuItems6 = new DungeonSubmenuItems6Array(m_io);
                m_io.Seek(_pos);
                f_dungeonSubmenuItems6 = true;
                return _dungeonSubmenuItems6;
            }
        }
        private bool f_dungeonWindowParams21;
        private WindowParams _dungeonWindowParams21;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DungeonWindowParams21
        {
            get
            {
                if (f_dungeonWindowParams21)
                    return _dungeonWindowParams21;
                long _pos = m_io.Pos;
                m_io.Seek(30728);
                _dungeonWindowParams21 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_dungeonWindowParams21 = true;
                return _dungeonWindowParams21;
            }
        }
        private bool f_dungeonSubmenuItems5;
        private DungeonSubmenuItems5Array _dungeonSubmenuItems5;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public DungeonSubmenuItems5Array DungeonSubmenuItems5
        {
            get
            {
                if (f_dungeonSubmenuItems5)
                    return _dungeonSubmenuItems5;
                long _pos = m_io.Pos;
                m_io.Seek(31008);
                _dungeonSubmenuItems5 = new DungeonSubmenuItems5Array(m_io);
                m_io.Seek(_pos);
                f_dungeonSubmenuItems5 = true;
                return _dungeonSubmenuItems5;
            }
        }
        private bool f_dungeonWindowParams3;
        private WindowParams _dungeonWindowParams3;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DungeonWindowParams3
        {
            get
            {
                if (f_dungeonWindowParams3)
                    return _dungeonWindowParams3;
                long _pos = m_io.Pos;
                m_io.Seek(30136);
                _dungeonWindowParams3 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_dungeonWindowParams3 = true;
                return _dungeonWindowParams3;
            }
        }
        private bool f_dungeonWindowParams11;
        private WindowParams _dungeonWindowParams11;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DungeonWindowParams11
        {
            get
            {
                if (f_dungeonWindowParams11)
                    return _dungeonWindowParams11;
                long _pos = m_io.Pos;
                m_io.Seek(30512);
                _dungeonWindowParams11 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_dungeonWindowParams11 = true;
                return _dungeonWindowParams11;
            }
        }
        private bool f_dungeonMenuSwitchStr1;
        private DungeonMenuSwitchStr1Array _dungeonMenuSwitchStr1;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public DungeonMenuSwitchStr1Array DungeonMenuSwitchStr1
        {
            get
            {
                if (f_dungeonMenuSwitchStr1)
                    return _dungeonMenuSwitchStr1;
                long _pos = m_io.Pos;
                m_io.Seek(30232);
                _dungeonMenuSwitchStr1 = new DungeonMenuSwitchStr1Array(m_io);
                m_io.Seek(_pos);
                f_dungeonMenuSwitchStr1 = true;
                return _dungeonMenuSwitchStr1;
            }
        }
        private bool f_dungeonWindowParams29;
        private WindowParams _dungeonWindowParams29;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DungeonWindowParams29
        {
            get
            {
                if (f_dungeonWindowParams29)
                    return _dungeonWindowParams29;
                long _pos = m_io.Pos;
                m_io.Seek(31212);
                _dungeonWindowParams29 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_dungeonWindowParams29 = true;
                return _dungeonWindowParams29;
            }
        }
        private bool f_dungeonWindowParams5;
        private WindowParams _dungeonWindowParams5;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DungeonWindowParams5
        {
            get
            {
                if (f_dungeonWindowParams5)
                    return _dungeonWindowParams5;
                long _pos = m_io.Pos;
                m_io.Seek(30276);
                _dungeonWindowParams5 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_dungeonWindowParams5 = true;
                return _dungeonWindowParams5;
            }
        }
        private bool f_dungeonWindowParams20;
        private WindowParams _dungeonWindowParams20;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DungeonWindowParams20
        {
            get
            {
                if (f_dungeonWindowParams20)
                    return _dungeonWindowParams20;
                long _pos = m_io.Pos;
                m_io.Seek(30712);
                _dungeonWindowParams20 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_dungeonWindowParams20 = true;
                return _dungeonWindowParams20;
            }
        }
        private Overlay31Data m_root;
        private KaitaiStruct m_parent;
        public Overlay31Data M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
