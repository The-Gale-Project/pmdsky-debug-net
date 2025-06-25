// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{
    public partial class Overlay19Data : KaitaiStruct
    {
        public static Overlay19Data FromFile(string fileName)
        {
            return new Overlay19Data(new KaitaiStream(fileName));
        }

        public Overlay19Data(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay19Data p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_overlay19UnknownStringIdsNa238e1cc = false;
            f_barSubmenuItems2 = false;
            f_overlay19UnknownPointerNa238e364 = false;
            f_overlay19UnknownStructNa238e1a4 = false;
            f_barRecruitableMonsterTable = false;
            f_overlay19UnknownPointerNa238e360 = false;
            f_barWindowParams2 = false;
            f_overlay19UnknownStringIdsNa238e178 = false;
            f_barSubmenuItems1 = false;
            f_barUnlockableDungeonsTable = false;
            f_overlay19UnknownTableNa238dae0 = false;
            f_overlay19ReservedSpace = false;
            f_barMenuItemsConfirm1 = false;
            f_barWindowParams1 = false;
            f_barAvailableItems = false;
            f_barMainMenuItems = false;
            f_barWindowParams3 = false;
            f_barMenuItemsConfirm2 = false;
            f_overlay19UnknownStringIdsNa238e238 = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_overlay19UnknownStringIdsNa238e1cc;
        private List<byte> _overlay19UnknownStringIdsNa238e1cc;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay19UnknownStringIdsNa238e1cc
        {
            get
            {
                if (f_overlay19UnknownStringIdsNa238e1cc)
                    return _overlay19UnknownStringIdsNa238e1cc;
                long _pos = m_io.Pos;
                m_io.Seek(16524);
                _overlay19UnknownStringIdsNa238e1cc = new List<byte>();
                for (var i = 0; i < 12; i++)
                {
                    _overlay19UnknownStringIdsNa238e1cc.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay19UnknownStringIdsNa238e1cc = true;
                return _overlay19UnknownStringIdsNa238e1cc;
            }
        }
        private bool f_barSubmenuItems2;
        private BarSubmenuItems2Array _barSubmenuItems2;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public BarSubmenuItems2Array BarSubmenuItems2
        {
            get
            {
                if (f_barSubmenuItems2)
                    return _barSubmenuItems2;
                long _pos = m_io.Pos;
                m_io.Seek(16720);
                _barSubmenuItems2 = new BarSubmenuItems2Array(m_io);
                m_io.Seek(_pos);
                f_barSubmenuItems2 = true;
                return _barSubmenuItems2;
            }
        }
        private bool f_overlay19UnknownPointerNa238e364;
        private List<byte> _overlay19UnknownPointerNa238e364;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay19UnknownPointerNa238e364
        {
            get
            {
                if (f_overlay19UnknownPointerNa238e364)
                    return _overlay19UnknownPointerNa238e364;
                long _pos = m_io.Pos;
                m_io.Seek(16932);
                _overlay19UnknownPointerNa238e364 = new List<byte>();
                for (var i = 0; i < 4; i++)
                {
                    _overlay19UnknownPointerNa238e364.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay19UnknownPointerNa238e364 = true;
                return _overlay19UnknownPointerNa238e364;
            }
        }
        private bool f_overlay19UnknownStructNa238e1a4;
        private List<byte> _overlay19UnknownStructNa238e1a4;

        /// <summary>
        /// 5*0x8
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay19UnknownStructNa238e1a4
        {
            get
            {
                if (f_overlay19UnknownStructNa238e1a4)
                    return _overlay19UnknownStructNa238e1a4;
                long _pos = m_io.Pos;
                m_io.Seek(16484);
                _overlay19UnknownStructNa238e1a4 = new List<byte>();
                for (var i = 0; i < 40; i++)
                {
                    _overlay19UnknownStructNa238e1a4.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay19UnknownStructNa238e1a4 = true;
                return _overlay19UnknownStructNa238e1a4;
            }
        }
        private bool f_barRecruitableMonsterTable;
        private BarRecruitableMonsterTableArray _barRecruitableMonsterTable;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// type: struct monster_id_16[108]
        /// </summary>
        public BarRecruitableMonsterTableArray BarRecruitableMonsterTable
        {
            get
            {
                if (f_barRecruitableMonsterTable)
                    return _barRecruitableMonsterTable;
                long _pos = m_io.Pos;
                m_io.Seek(14772);
                _barRecruitableMonsterTable = new BarRecruitableMonsterTableArray(m_io);
                m_io.Seek(_pos);
                f_barRecruitableMonsterTable = true;
                return _barRecruitableMonsterTable;
            }
        }
        private bool f_overlay19UnknownPointerNa238e360;
        private List<byte> _overlay19UnknownPointerNa238e360;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay19UnknownPointerNa238e360
        {
            get
            {
                if (f_overlay19UnknownPointerNa238e360)
                    return _overlay19UnknownPointerNa238e360;
                long _pos = m_io.Pos;
                m_io.Seek(16928);
                _overlay19UnknownPointerNa238e360 = new List<byte>();
                for (var i = 0; i < 4; i++)
                {
                    _overlay19UnknownPointerNa238e360.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay19UnknownPointerNa238e360 = true;
                return _overlay19UnknownPointerNa238e360;
            }
        }
        private bool f_barWindowParams2;
        private WindowParams _barWindowParams2;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams BarWindowParams2
        {
            get
            {
                if (f_barWindowParams2)
                    return _barWindowParams2;
                long _pos = m_io.Pos;
                m_io.Seek(16552);
                _barWindowParams2 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_barWindowParams2 = true;
                return _barWindowParams2;
            }
        }
        private bool f_overlay19UnknownStringIdsNa238e178;
        private List<byte> _overlay19UnknownStringIdsNa238e178;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay19UnknownStringIdsNa238e178
        {
            get
            {
                if (f_overlay19UnknownStringIdsNa238e178)
                    return _overlay19UnknownStringIdsNa238e178;
                long _pos = m_io.Pos;
                m_io.Seek(16440);
                _overlay19UnknownStringIdsNa238e178 = new List<byte>();
                for (var i = 0; i < 44; i++)
                {
                    _overlay19UnknownStringIdsNa238e178.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay19UnknownStringIdsNa238e178 = true;
                return _overlay19UnknownStringIdsNa238e178;
            }
        }
        private bool f_barSubmenuItems1;
        private BarSubmenuItems1Array _barSubmenuItems1;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public BarSubmenuItems1Array BarSubmenuItems1
        {
            get
            {
                if (f_barSubmenuItems1)
                    return _barSubmenuItems1;
                long _pos = m_io.Pos;
                m_io.Seek(16688);
                _barSubmenuItems1 = new BarSubmenuItems1Array(m_io);
                m_io.Seek(_pos);
                f_barSubmenuItems1 = true;
                return _barSubmenuItems1;
            }
        }
        private bool f_barUnlockableDungeonsTable;
        private BarUnlockableDungeonsTableArray _barUnlockableDungeonsTable;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// type: struct dungeon_id_16[6]
        /// </summary>
        public BarUnlockableDungeonsTableArray BarUnlockableDungeonsTable
        {
            get
            {
                if (f_barUnlockableDungeonsTable)
                    return _barUnlockableDungeonsTable;
                long _pos = m_io.Pos;
                m_io.Seek(14760);
                _barUnlockableDungeonsTable = new BarUnlockableDungeonsTableArray(m_io);
                m_io.Seek(_pos);
                f_barUnlockableDungeonsTable = true;
                return _barUnlockableDungeonsTable;
            }
        }
        private bool f_overlay19UnknownTableNa238dae0;
        private List<byte> _overlay19UnknownTableNa238dae0;

        /// <summary>
        /// 4*0x2
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay19UnknownTableNa238dae0
        {
            get
            {
                if (f_overlay19UnknownTableNa238dae0)
                    return _overlay19UnknownTableNa238dae0;
                long _pos = m_io.Pos;
                m_io.Seek(14752);
                _overlay19UnknownTableNa238dae0 = new List<byte>();
                for (var i = 0; i < 8; i++)
                {
                    _overlay19UnknownTableNa238dae0.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay19UnknownTableNa238dae0 = true;
                return _overlay19UnknownTableNa238dae0;
            }
        }
        private bool f_overlay19ReservedSpace;
        private List<byte> _overlay19ReservedSpace;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay19ReservedSpace
        {
            get
            {
                if (f_overlay19ReservedSpace)
                    return _overlay19ReservedSpace;
                long _pos = m_io.Pos;
                m_io.Seek(16900);
                _overlay19ReservedSpace = new List<byte>();
                for (var i = 0; i < 28; i++)
                {
                    _overlay19ReservedSpace.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay19ReservedSpace = true;
                return _overlay19ReservedSpace;
            }
        }
        private bool f_barMenuItemsConfirm1;
        private BarMenuItemsConfirm1Array _barMenuItemsConfirm1;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public BarMenuItemsConfirm1Array BarMenuItemsConfirm1
        {
            get
            {
                if (f_barMenuItemsConfirm1)
                    return _barMenuItemsConfirm1;
                long _pos = m_io.Pos;
                m_io.Seek(16584);
                _barMenuItemsConfirm1 = new BarMenuItemsConfirm1Array(m_io);
                m_io.Seek(_pos);
                f_barMenuItemsConfirm1 = true;
                return _barMenuItemsConfirm1;
            }
        }
        private bool f_barWindowParams1;
        private WindowParams _barWindowParams1;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams BarWindowParams1
        {
            get
            {
                if (f_barWindowParams1)
                    return _barWindowParams1;
                long _pos = m_io.Pos;
                m_io.Seek(16536);
                _barWindowParams1 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_barWindowParams1 = true;
                return _barWindowParams1;
            }
        }
        private bool f_barAvailableItems;
        private BarAvailableItemsArray _barAvailableItems;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// type: struct bar_item[66]
        /// </summary>
        public BarAvailableItemsArray BarAvailableItems
        {
            get
            {
                if (f_barAvailableItems)
                    return _barAvailableItems;
                long _pos = m_io.Pos;
                m_io.Seek(14988);
                _barAvailableItems = new BarAvailableItemsArray(m_io);
                m_io.Seek(_pos);
                f_barAvailableItems = true;
                return _barAvailableItems;
            }
        }
        private bool f_barMainMenuItems;
        private BarMainMenuItemsArray _barMainMenuItems;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public BarMainMenuItemsArray BarMainMenuItems
        {
            get
            {
                if (f_barMainMenuItems)
                    return _barMainMenuItems;
                long _pos = m_io.Pos;
                m_io.Seek(16656);
                _barMainMenuItems = new BarMainMenuItemsArray(m_io);
                m_io.Seek(_pos);
                f_barMainMenuItems = true;
                return _barMainMenuItems;
            }
        }
        private bool f_barWindowParams3;
        private WindowParams _barWindowParams3;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams BarWindowParams3
        {
            get
            {
                if (f_barWindowParams3)
                    return _barWindowParams3;
                long _pos = m_io.Pos;
                m_io.Seek(16568);
                _barWindowParams3 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_barWindowParams3 = true;
                return _barWindowParams3;
            }
        }
        private bool f_barMenuItemsConfirm2;
        private BarMenuItemsConfirm2Array _barMenuItemsConfirm2;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public BarMenuItemsConfirm2Array BarMenuItemsConfirm2
        {
            get
            {
                if (f_barMenuItemsConfirm2)
                    return _barMenuItemsConfirm2;
                long _pos = m_io.Pos;
                m_io.Seek(16608);
                _barMenuItemsConfirm2 = new BarMenuItemsConfirm2Array(m_io);
                m_io.Seek(_pos);
                f_barMenuItemsConfirm2 = true;
                return _barMenuItemsConfirm2;
            }
        }
        private bool f_overlay19UnknownStringIdsNa238e238;
        private List<byte> _overlay19UnknownStringIdsNa238e238;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay19UnknownStringIdsNa238e238
        {
            get
            {
                if (f_overlay19UnknownStringIdsNa238e238)
                    return _overlay19UnknownStringIdsNa238e238;
                long _pos = m_io.Pos;
                m_io.Seek(16632);
                _overlay19UnknownStringIdsNa238e238 = new List<byte>();
                for (var i = 0; i < 24; i++)
                {
                    _overlay19UnknownStringIdsNa238e238.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay19UnknownStringIdsNa238e238 = true;
                return _overlay19UnknownStringIdsNa238e238;
            }
        }
        private Overlay19Data m_root;
        private KaitaiStruct m_parent;
        public Overlay19Data M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
