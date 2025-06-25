// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// List of functions within OVERLAY19 with relative address locations as their values.
    /// </summary>
    public partial class Overlay19Functions : KaitaiStruct
    {
        public static Overlay19Functions FromFile(string fileName)
        {
            return new Overlay19Functions(new KaitaiStream(fileName));
        }

        public Overlay19Functions(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay19Functions p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_getBarItem = false;
            f_getRecruitableMonsterAll = false;
            f_getRecruitableMonsterList = false;
            f_getRecruitableMonsterListRestricted = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_getBarItem;
        private sbyte _getBarItem;

        /// <summary>
        /// Gets the struct bar_item from BAR_AVAILABLE_ITEMS with the specified item ID.
        /// 
        /// r0: item ID
        /// return: struct bar_item*
        /// </summary>
        public sbyte GetBarItem
        {
            get
            {
                if (f_getBarItem)
                    return _getBarItem;
                _getBarItem = (sbyte) (0);
                f_getBarItem = true;
                return _getBarItem;
            }
        }
        private bool f_getRecruitableMonsterAll;
        private byte _getRecruitableMonsterAll;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// return: int?
        /// </summary>
        public byte GetRecruitableMonsterAll
        {
            get
            {
                if (f_getRecruitableMonsterAll)
                    return _getRecruitableMonsterAll;
                _getRecruitableMonsterAll = (byte) (132);
                f_getRecruitableMonsterAll = true;
                return _getRecruitableMonsterAll;
            }
        }
        private bool f_getRecruitableMonsterList;
        private int _getRecruitableMonsterList;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// return: int?
        /// </summary>
        public int GetRecruitableMonsterList
        {
            get
            {
                if (f_getRecruitableMonsterList)
                    return _getRecruitableMonsterList;
                _getRecruitableMonsterList = (int) (308);
                f_getRecruitableMonsterList = true;
                return _getRecruitableMonsterList;
            }
        }
        private bool f_getRecruitableMonsterListRestricted;
        private int _getRecruitableMonsterListRestricted;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// return: int?
        /// </summary>
        public int GetRecruitableMonsterListRestricted
        {
            get
            {
                if (f_getRecruitableMonsterListRestricted)
                    return _getRecruitableMonsterListRestricted;
                _getRecruitableMonsterListRestricted = (int) (476);
                f_getRecruitableMonsterListRestricted = true;
                return _getRecruitableMonsterListRestricted;
            }
        }
        private Overlay19Functions m_root;
        private KaitaiStruct m_parent;
        public Overlay19Functions M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
