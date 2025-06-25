// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{
    public partial class Overlay16Data : KaitaiStruct
    {
        public static Overlay16Data FromFile(string fileName)
        {
            return new Overlay16Data(new KaitaiStream(fileName));
        }

        public Overlay16Data(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay16Data p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_evoWindowParams2 = false;
            f_evoMainMenuItems = false;
            f_evoWindowParams1 = false;
            f_overlay16ReservedSpace = false;
            f_evoMenuItemsConfirm = false;
            f_evoWindowParams5 = false;
            f_overlay16UnknownPointerNa238ce40 = false;
            f_evoSubmenuItems = false;
            f_overlay16UnknownPointerNa238ce58 = false;
            f_evoMenuStringIds = false;
            f_evoWindowParams6 = false;
            f_evoWindowParams3 = false;
            f_evoWindowParams7 = false;
            f_evoWindowParams4 = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_evoWindowParams2;
        private WindowParams _evoWindowParams2;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams EvoWindowParams2
        {
            get
            {
                if (f_evoWindowParams2)
                    return _evoWindowParams2;
                long _pos = m_io.Pos;
                m_io.Seek(11364);
                _evoWindowParams2 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_evoWindowParams2 = true;
                return _evoWindowParams2;
            }
        }
        private bool f_evoMainMenuItems;
        private EvoMainMenuItemsArray _evoMainMenuItems;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public EvoMainMenuItemsArray EvoMainMenuItems
        {
            get
            {
                if (f_evoMainMenuItems)
                    return _evoMainMenuItems;
                long _pos = m_io.Pos;
                m_io.Seek(11264);
                _evoMainMenuItems = new EvoMainMenuItemsArray(m_io);
                m_io.Seek(_pos);
                f_evoMainMenuItems = true;
                return _evoMainMenuItems;
            }
        }
        private bool f_evoWindowParams1;
        private WindowParams _evoWindowParams1;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams EvoWindowParams1
        {
            get
            {
                if (f_evoWindowParams1)
                    return _evoWindowParams1;
                long _pos = m_io.Pos;
                m_io.Seek(11348);
                _evoWindowParams1 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_evoWindowParams1 = true;
                return _evoWindowParams1;
            }
        }
        private bool f_overlay16ReservedSpace;
        private List<byte> _overlay16ReservedSpace;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay16ReservedSpace
        {
            get
            {
                if (f_overlay16ReservedSpace)
                    return _overlay16ReservedSpace;
                long _pos = m_io.Pos;
                m_io.Seek(11508);
                _overlay16ReservedSpace = new List<byte>();
                for (var i = 0; i < 12; i++)
                {
                    _overlay16ReservedSpace.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay16ReservedSpace = true;
                return _overlay16ReservedSpace;
            }
        }
        private bool f_evoMenuItemsConfirm;
        private EvoMenuItemsConfirmArray _evoMenuItemsConfirm;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public EvoMenuItemsConfirmArray EvoMenuItemsConfirm
        {
            get
            {
                if (f_evoMenuItemsConfirm)
                    return _evoMenuItemsConfirm;
                long _pos = m_io.Pos;
                m_io.Seek(11208);
                _evoMenuItemsConfirm = new EvoMenuItemsConfirmArray(m_io);
                m_io.Seek(_pos);
                f_evoMenuItemsConfirm = true;
                return _evoMenuItemsConfirm;
            }
        }
        private bool f_evoWindowParams5;
        private WindowParams _evoWindowParams5;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams EvoWindowParams5
        {
            get
            {
                if (f_evoWindowParams5)
                    return _evoWindowParams5;
                long _pos = m_io.Pos;
                m_io.Seek(11412);
                _evoWindowParams5 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_evoWindowParams5 = true;
                return _evoWindowParams5;
            }
        }
        private bool f_overlay16UnknownPointerNa238ce40;
        private List<byte> _overlay16UnknownPointerNa238ce40;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay16UnknownPointerNa238ce40
        {
            get
            {
                if (f_overlay16UnknownPointerNa238ce40)
                    return _overlay16UnknownPointerNa238ce40;
                long _pos = m_io.Pos;
                m_io.Seek(11520);
                _overlay16UnknownPointerNa238ce40 = new List<byte>();
                for (var i = 0; i < 4; i++)
                {
                    _overlay16UnknownPointerNa238ce40.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay16UnknownPointerNa238ce40 = true;
                return _overlay16UnknownPointerNa238ce40;
            }
        }
        private bool f_evoSubmenuItems;
        private EvoSubmenuItemsArray _evoSubmenuItems;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public EvoSubmenuItemsArray EvoSubmenuItems
        {
            get
            {
                if (f_evoSubmenuItems)
                    return _evoSubmenuItems;
                long _pos = m_io.Pos;
                m_io.Seek(11232);
                _evoSubmenuItems = new EvoSubmenuItemsArray(m_io);
                m_io.Seek(_pos);
                f_evoSubmenuItems = true;
                return _evoSubmenuItems;
            }
        }
        private bool f_overlay16UnknownPointerNa238ce58;
        private List<byte> _overlay16UnknownPointerNa238ce58;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay16UnknownPointerNa238ce58
        {
            get
            {
                if (f_overlay16UnknownPointerNa238ce58)
                    return _overlay16UnknownPointerNa238ce58;
                long _pos = m_io.Pos;
                m_io.Seek(11544);
                _overlay16UnknownPointerNa238ce58 = new List<byte>();
                for (var i = 0; i < 4; i++)
                {
                    _overlay16UnknownPointerNa238ce58.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay16UnknownPointerNa238ce58 = true;
                return _overlay16UnknownPointerNa238ce58;
            }
        }
        private bool f_evoMenuStringIds;
        private EvoMenuStringIdsArray _evoMenuStringIds;

        /// <summary>
        /// 26*0x2
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public EvoMenuStringIdsArray EvoMenuStringIds
        {
            get
            {
                if (f_evoMenuStringIds)
                    return _evoMenuStringIds;
                long _pos = m_io.Pos;
                m_io.Seek(11296);
                _evoMenuStringIds = new EvoMenuStringIdsArray(m_io);
                m_io.Seek(_pos);
                f_evoMenuStringIds = true;
                return _evoMenuStringIds;
            }
        }
        private bool f_evoWindowParams6;
        private WindowParams _evoWindowParams6;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams EvoWindowParams6
        {
            get
            {
                if (f_evoWindowParams6)
                    return _evoWindowParams6;
                long _pos = m_io.Pos;
                m_io.Seek(11428);
                _evoWindowParams6 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_evoWindowParams6 = true;
                return _evoWindowParams6;
            }
        }
        private bool f_evoWindowParams3;
        private WindowParams _evoWindowParams3;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams EvoWindowParams3
        {
            get
            {
                if (f_evoWindowParams3)
                    return _evoWindowParams3;
                long _pos = m_io.Pos;
                m_io.Seek(11380);
                _evoWindowParams3 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_evoWindowParams3 = true;
                return _evoWindowParams3;
            }
        }
        private bool f_evoWindowParams7;
        private WindowParams _evoWindowParams7;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams EvoWindowParams7
        {
            get
            {
                if (f_evoWindowParams7)
                    return _evoWindowParams7;
                long _pos = m_io.Pos;
                m_io.Seek(11444);
                _evoWindowParams7 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_evoWindowParams7 = true;
                return _evoWindowParams7;
            }
        }
        private bool f_evoWindowParams4;
        private WindowParams _evoWindowParams4;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams EvoWindowParams4
        {
            get
            {
                if (f_evoWindowParams4)
                    return _evoWindowParams4;
                long _pos = m_io.Pos;
                m_io.Seek(11396);
                _evoWindowParams4 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_evoWindowParams4 = true;
                return _evoWindowParams4;
            }
        }
        private Overlay16Data m_root;
        private KaitaiStruct m_parent;
        public Overlay16Data M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
