// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{
    public partial class Overlay21Data : KaitaiStruct
    {
        public static Overlay21Data FromFile(string fileName)
        {
            return new Overlay21Data(new KaitaiStream(fileName));
        }

        public Overlay21Data(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay21Data p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_overlay21UnknownPointerNa238cf44 = false;
            f_swapShopSubmenuItems3 = false;
            f_swapShopMainMenuItems2 = false;
            f_swapShopWindowParams9 = false;
            f_swapShopWindowParams5 = false;
            f_overlay21UnknownStringIds = false;
            f_swapShopMainMenuItems1 = false;
            f_overlay21JpString = false;
            f_swapShopWindowParams8 = false;
            f_swapShopWindowParams6 = false;
            f_overlay21UnknownPointerNa238cf40 = false;
            f_overlay21ReservedSpace = false;
            f_swapShopWindowParams4 = false;
            f_swapShopSubmenuItems2 = false;
            f_swapShopSubmenuItems1 = false;
            f_swapShopWindowParams2 = false;
            f_swapShopWindowParams3 = false;
            f_swapShopWindowParams7 = false;
            f_swapShopMenuItemsConfirm = false;
            f_swapShopWindowParams1 = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_overlay21UnknownPointerNa238cf44;
        private List<byte> _overlay21UnknownPointerNa238cf44;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay21UnknownPointerNa238cf44
        {
            get
            {
                if (f_overlay21UnknownPointerNa238cf44)
                    return _overlay21UnknownPointerNa238cf44;
                long _pos = m_io.Pos;
                m_io.Seek(11780);
                _overlay21UnknownPointerNa238cf44 = new List<byte>();
                for (var i = 0; i < 4; i++)
                {
                    _overlay21UnknownPointerNa238cf44.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay21UnknownPointerNa238cf44 = true;
                return _overlay21UnknownPointerNa238cf44;
            }
        }
        private bool f_swapShopSubmenuItems3;
        private SwapShopSubmenuItems3Array _swapShopSubmenuItems3;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public SwapShopSubmenuItems3Array SwapShopSubmenuItems3
        {
            get
            {
                if (f_swapShopSubmenuItems3)
                    return _swapShopSubmenuItems3;
                long _pos = m_io.Pos;
                m_io.Seek(10640);
                _swapShopSubmenuItems3 = new SwapShopSubmenuItems3Array(m_io);
                m_io.Seek(_pos);
                f_swapShopSubmenuItems3 = true;
                return _swapShopSubmenuItems3;
            }
        }
        private bool f_swapShopMainMenuItems2;
        private SwapShopMainMenuItems2Array _swapShopMainMenuItems2;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public SwapShopMainMenuItems2Array SwapShopMainMenuItems2
        {
            get
            {
                if (f_swapShopMainMenuItems2)
                    return _swapShopMainMenuItems2;
                long _pos = m_io.Pos;
                m_io.Seek(10600);
                _swapShopMainMenuItems2 = new SwapShopMainMenuItems2Array(m_io);
                m_io.Seek(_pos);
                f_swapShopMainMenuItems2 = true;
                return _swapShopMainMenuItems2;
            }
        }
        private bool f_swapShopWindowParams9;
        private WindowParams _swapShopWindowParams9;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams SwapShopWindowParams9
        {
            get
            {
                if (f_swapShopWindowParams9)
                    return _swapShopWindowParams9;
                long _pos = m_io.Pos;
                m_io.Seek(10856);
                _swapShopWindowParams9 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_swapShopWindowParams9 = true;
                return _swapShopWindowParams9;
            }
        }
        private bool f_swapShopWindowParams5;
        private WindowParams _swapShopWindowParams5;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams SwapShopWindowParams5
        {
            get
            {
                if (f_swapShopWindowParams5)
                    return _swapShopWindowParams5;
                long _pos = m_io.Pos;
                m_io.Seek(10792);
                _swapShopWindowParams5 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_swapShopWindowParams5 = true;
                return _swapShopWindowParams5;
            }
        }
        private bool f_overlay21UnknownStringIds;
        private List<byte> _overlay21UnknownStringIds;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay21UnknownStringIds
        {
            get
            {
                if (f_overlay21UnknownStringIds)
                    return _overlay21UnknownStringIds;
                long _pos = m_io.Pos;
                m_io.Seek(10688);
                _overlay21UnknownStringIds = new List<byte>();
                for (var i = 0; i < 56; i++)
                {
                    _overlay21UnknownStringIds.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay21UnknownStringIds = true;
                return _overlay21UnknownStringIds;
            }
        }
        private bool f_swapShopMainMenuItems1;
        private SwapShopMainMenuItems1Array _swapShopMainMenuItems1;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public SwapShopMainMenuItems1Array SwapShopMainMenuItems1
        {
            get
            {
                if (f_swapShopMainMenuItems1)
                    return _swapShopMainMenuItems1;
                long _pos = m_io.Pos;
                m_io.Seek(10568);
                _swapShopMainMenuItems1 = new SwapShopMainMenuItems1Array(m_io);
                m_io.Seek(_pos);
                f_swapShopMainMenuItems1 = true;
                return _swapShopMainMenuItems1;
            }
        }
        private bool f_overlay21JpString;
        private List<byte> _overlay21JpString;

        /// <summary>
        /// 合成：
        /// </summary>
        public List<byte> Overlay21JpString
        {
            get
            {
                if (f_overlay21JpString)
                    return _overlay21JpString;
                long _pos = m_io.Pos;
                m_io.Seek(11740);
                _overlay21JpString = new List<byte>();
                for (var i = 0; i < 8; i++)
                {
                    _overlay21JpString.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay21JpString = true;
                return _overlay21JpString;
            }
        }
        private bool f_swapShopWindowParams8;
        private WindowParams _swapShopWindowParams8;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams SwapShopWindowParams8
        {
            get
            {
                if (f_swapShopWindowParams8)
                    return _swapShopWindowParams8;
                long _pos = m_io.Pos;
                m_io.Seek(10840);
                _swapShopWindowParams8 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_swapShopWindowParams8 = true;
                return _swapShopWindowParams8;
            }
        }
        private bool f_swapShopWindowParams6;
        private WindowParams _swapShopWindowParams6;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams SwapShopWindowParams6
        {
            get
            {
                if (f_swapShopWindowParams6)
                    return _swapShopWindowParams6;
                long _pos = m_io.Pos;
                m_io.Seek(10808);
                _swapShopWindowParams6 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_swapShopWindowParams6 = true;
                return _swapShopWindowParams6;
            }
        }
        private bool f_overlay21UnknownPointerNa238cf40;
        private List<byte> _overlay21UnknownPointerNa238cf40;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay21UnknownPointerNa238cf40
        {
            get
            {
                if (f_overlay21UnknownPointerNa238cf40)
                    return _overlay21UnknownPointerNa238cf40;
                long _pos = m_io.Pos;
                m_io.Seek(11776);
                _overlay21UnknownPointerNa238cf40 = new List<byte>();
                for (var i = 0; i < 4; i++)
                {
                    _overlay21UnknownPointerNa238cf40.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay21UnknownPointerNa238cf40 = true;
                return _overlay21UnknownPointerNa238cf40;
            }
        }
        private bool f_overlay21ReservedSpace;
        private List<byte> _overlay21ReservedSpace;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay21ReservedSpace
        {
            get
            {
                if (f_overlay21ReservedSpace)
                    return _overlay21ReservedSpace;
                long _pos = m_io.Pos;
                m_io.Seek(11768);
                _overlay21ReservedSpace = new List<byte>();
                for (var i = 0; i < 8; i++)
                {
                    _overlay21ReservedSpace.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay21ReservedSpace = true;
                return _overlay21ReservedSpace;
            }
        }
        private bool f_swapShopWindowParams4;
        private WindowParams _swapShopWindowParams4;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams SwapShopWindowParams4
        {
            get
            {
                if (f_swapShopWindowParams4)
                    return _swapShopWindowParams4;
                long _pos = m_io.Pos;
                m_io.Seek(10776);
                _swapShopWindowParams4 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_swapShopWindowParams4 = true;
                return _swapShopWindowParams4;
            }
        }
        private bool f_swapShopSubmenuItems2;
        private SwapShopSubmenuItems2Array _swapShopSubmenuItems2;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public SwapShopSubmenuItems2Array SwapShopSubmenuItems2
        {
            get
            {
                if (f_swapShopSubmenuItems2)
                    return _swapShopSubmenuItems2;
                long _pos = m_io.Pos;
                m_io.Seek(10536);
                _swapShopSubmenuItems2 = new SwapShopSubmenuItems2Array(m_io);
                m_io.Seek(_pos);
                f_swapShopSubmenuItems2 = true;
                return _swapShopSubmenuItems2;
            }
        }
        private bool f_swapShopSubmenuItems1;
        private SwapShopSubmenuItems1Array _swapShopSubmenuItems1;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public SwapShopSubmenuItems1Array SwapShopSubmenuItems1
        {
            get
            {
                if (f_swapShopSubmenuItems1)
                    return _swapShopSubmenuItems1;
                long _pos = m_io.Pos;
                m_io.Seek(10512);
                _swapShopSubmenuItems1 = new SwapShopSubmenuItems1Array(m_io);
                m_io.Seek(_pos);
                f_swapShopSubmenuItems1 = true;
                return _swapShopSubmenuItems1;
            }
        }
        private bool f_swapShopWindowParams2;
        private WindowParams _swapShopWindowParams2;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams SwapShopWindowParams2
        {
            get
            {
                if (f_swapShopWindowParams2)
                    return _swapShopWindowParams2;
                long _pos = m_io.Pos;
                m_io.Seek(10744);
                _swapShopWindowParams2 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_swapShopWindowParams2 = true;
                return _swapShopWindowParams2;
            }
        }
        private bool f_swapShopWindowParams3;
        private WindowParams _swapShopWindowParams3;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams SwapShopWindowParams3
        {
            get
            {
                if (f_swapShopWindowParams3)
                    return _swapShopWindowParams3;
                long _pos = m_io.Pos;
                m_io.Seek(10760);
                _swapShopWindowParams3 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_swapShopWindowParams3 = true;
                return _swapShopWindowParams3;
            }
        }
        private bool f_swapShopWindowParams7;
        private WindowParams _swapShopWindowParams7;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams SwapShopWindowParams7
        {
            get
            {
                if (f_swapShopWindowParams7)
                    return _swapShopWindowParams7;
                long _pos = m_io.Pos;
                m_io.Seek(10824);
                _swapShopWindowParams7 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_swapShopWindowParams7 = true;
                return _swapShopWindowParams7;
            }
        }
        private bool f_swapShopMenuItemsConfirm;
        private SwapShopMenuItemsConfirmArray _swapShopMenuItemsConfirm;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public SwapShopMenuItemsConfirmArray SwapShopMenuItemsConfirm
        {
            get
            {
                if (f_swapShopMenuItemsConfirm)
                    return _swapShopMenuItemsConfirm;
                long _pos = m_io.Pos;
                m_io.Seek(10488);
                _swapShopMenuItemsConfirm = new SwapShopMenuItemsConfirmArray(m_io);
                m_io.Seek(_pos);
                f_swapShopMenuItemsConfirm = true;
                return _swapShopMenuItemsConfirm;
            }
        }
        private bool f_swapShopWindowParams1;
        private WindowParams _swapShopWindowParams1;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams SwapShopWindowParams1
        {
            get
            {
                if (f_swapShopWindowParams1)
                    return _swapShopWindowParams1;
                long _pos = m_io.Pos;
                m_io.Seek(10472);
                _swapShopWindowParams1 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_swapShopWindowParams1 = true;
                return _swapShopWindowParams1;
            }
        }
        private Overlay21Data m_root;
        private KaitaiStruct m_parent;
        public Overlay21Data M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
