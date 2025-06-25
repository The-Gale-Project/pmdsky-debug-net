// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
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
            f_barSubmenuItems2 = false;
            f_barRecruitableMonsterTable = false;
            f_barWindowParams2 = false;
            f_barSubmenuItems1 = false;
            f_barUnlockableDungeonsTable = false;
            f_barMenuItemsConfirm1 = false;
            f_barWindowParams1 = false;
            f_barAvailableItems = false;
            f_barMainMenuItems = false;
            f_barWindowParams3 = false;
            f_barMenuItemsConfirm2 = false;
            _read();
        }
        private void _read()
        {
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
                m_io.Seek(16708);
                _barSubmenuItems2 = new BarSubmenuItems2Array(m_io);
                m_io.Seek(_pos);
                f_barSubmenuItems2 = true;
                return _barSubmenuItems2;
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
                m_io.Seek(14760);
                _barRecruitableMonsterTable = new BarRecruitableMonsterTableArray(m_io);
                m_io.Seek(_pos);
                f_barRecruitableMonsterTable = true;
                return _barRecruitableMonsterTable;
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
                m_io.Seek(16540);
                _barWindowParams2 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_barWindowParams2 = true;
                return _barWindowParams2;
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
                m_io.Seek(16676);
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
                m_io.Seek(14748);
                _barUnlockableDungeonsTable = new BarUnlockableDungeonsTableArray(m_io);
                m_io.Seek(_pos);
                f_barUnlockableDungeonsTable = true;
                return _barUnlockableDungeonsTable;
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
                m_io.Seek(16572);
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
                m_io.Seek(16524);
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
                m_io.Seek(14976);
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
                m_io.Seek(16644);
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
                m_io.Seek(16556);
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
                m_io.Seek(16596);
                _barMenuItemsConfirm2 = new BarMenuItemsConfirm2Array(m_io);
                m_io.Seek(_pos);
                f_barMenuItemsConfirm2 = true;
                return _barMenuItemsConfirm2;
            }
        }
        private Overlay19Data m_root;
        private KaitaiStruct m_parent;
        public Overlay19Data M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
