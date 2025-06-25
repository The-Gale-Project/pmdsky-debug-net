// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{
    public partial class Overlay22Data : KaitaiStruct
    {
        public static Overlay22Data FromFile(string fileName)
        {
            return new Overlay22Data(new KaitaiStream(fileName));
        }

        public Overlay22Data(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay22Data p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_overlay22UnknownPointerNa238ec70 = false;
            f_overlay22UnknownPointerNa238ec68 = false;
            f_shopWindowParams2 = false;
            f_shopWindowParams5 = false;
            f_shopWindowParams9 = false;
            f_overlay22UnknownStringIds = false;
            f_shopMainMenuItems3 = false;
            f_overlay22UnknownPointerNa238ec6c = false;
            f_shopWindowParams4 = false;
            f_shopMainMenuItems2 = false;
            f_shopMainMenuItems1 = false;
            f_shopWindowParams3 = false;
            f_shopWindowParams7 = false;
            f_shopWindowParams1 = false;
            f_overlay22UnknownPointerNa238ec64 = false;
            f_shopMenuItemsConfirm = false;
            f_shopWindowParams6 = false;
            f_overlay22UnknownPointerNa238ec60 = false;
            f_overlay22ReservedSpace = false;
            f_shopWindowParams8 = false;
            f_overlay22UnknownStructNa238e85c = false;
            f_shopWindowParams10 = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_overlay22UnknownPointerNa238ec70;
        private List<byte> _overlay22UnknownPointerNa238ec70;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay22UnknownPointerNa238ec70
        {
            get
            {
                if (f_overlay22UnknownPointerNa238ec70)
                    return _overlay22UnknownPointerNa238ec70;
                long _pos = m_io.Pos;
                m_io.Seek(19248);
                _overlay22UnknownPointerNa238ec70 = new List<byte>();
                for (var i = 0; i < 4; i++)
                {
                    _overlay22UnknownPointerNa238ec70.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay22UnknownPointerNa238ec70 = true;
                return _overlay22UnknownPointerNa238ec70;
            }
        }
        private bool f_overlay22UnknownPointerNa238ec68;
        private List<byte> _overlay22UnknownPointerNa238ec68;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay22UnknownPointerNa238ec68
        {
            get
            {
                if (f_overlay22UnknownPointerNa238ec68)
                    return _overlay22UnknownPointerNa238ec68;
                long _pos = m_io.Pos;
                m_io.Seek(19240);
                _overlay22UnknownPointerNa238ec68 = new List<byte>();
                for (var i = 0; i < 4; i++)
                {
                    _overlay22UnknownPointerNa238ec68.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay22UnknownPointerNa238ec68 = true;
                return _overlay22UnknownPointerNa238ec68;
            }
        }
        private bool f_shopWindowParams2;
        private WindowParams _shopWindowParams2;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams ShopWindowParams2
        {
            get
            {
                if (f_shopWindowParams2)
                    return _shopWindowParams2;
                long _pos = m_io.Pos;
                m_io.Seek(18172);
                _shopWindowParams2 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_shopWindowParams2 = true;
                return _shopWindowParams2;
            }
        }
        private bool f_shopWindowParams5;
        private WindowParams _shopWindowParams5;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams ShopWindowParams5
        {
            get
            {
                if (f_shopWindowParams5)
                    return _shopWindowParams5;
                long _pos = m_io.Pos;
                m_io.Seek(18480);
                _shopWindowParams5 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_shopWindowParams5 = true;
                return _shopWindowParams5;
            }
        }
        private bool f_shopWindowParams9;
        private WindowParams _shopWindowParams9;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams ShopWindowParams9
        {
            get
            {
                if (f_shopWindowParams9)
                    return _shopWindowParams9;
                long _pos = m_io.Pos;
                m_io.Seek(18544);
                _shopWindowParams9 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_shopWindowParams9 = true;
                return _shopWindowParams9;
            }
        }
        private bool f_overlay22UnknownStringIds;
        private List<byte> _overlay22UnknownStringIds;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay22UnknownStringIds
        {
            get
            {
                if (f_overlay22UnknownStringIds)
                    return _overlay22UnknownStringIds;
                long _pos = m_io.Pos;
                m_io.Seek(18352);
                _overlay22UnknownStringIds = new List<byte>();
                for (var i = 0; i < 96; i++)
                {
                    _overlay22UnknownStringIds.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay22UnknownStringIds = true;
                return _overlay22UnknownStringIds;
            }
        }
        private bool f_shopMainMenuItems3;
        private ShopMainMenuItems3Array _shopMainMenuItems3;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public ShopMainMenuItems3Array ShopMainMenuItems3
        {
            get
            {
                if (f_shopMainMenuItems3)
                    return _shopMainMenuItems3;
                long _pos = m_io.Pos;
                m_io.Seek(18304);
                _shopMainMenuItems3 = new ShopMainMenuItems3Array(m_io);
                m_io.Seek(_pos);
                f_shopMainMenuItems3 = true;
                return _shopMainMenuItems3;
            }
        }
        private bool f_overlay22UnknownPointerNa238ec6c;
        private List<byte> _overlay22UnknownPointerNa238ec6c;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay22UnknownPointerNa238ec6c
        {
            get
            {
                if (f_overlay22UnknownPointerNa238ec6c)
                    return _overlay22UnknownPointerNa238ec6c;
                long _pos = m_io.Pos;
                m_io.Seek(19244);
                _overlay22UnknownPointerNa238ec6c = new List<byte>();
                for (var i = 0; i < 4; i++)
                {
                    _overlay22UnknownPointerNa238ec6c.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay22UnknownPointerNa238ec6c = true;
                return _overlay22UnknownPointerNa238ec6c;
            }
        }
        private bool f_shopWindowParams4;
        private WindowParams _shopWindowParams4;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams ShopWindowParams4
        {
            get
            {
                if (f_shopWindowParams4)
                    return _shopWindowParams4;
                long _pos = m_io.Pos;
                m_io.Seek(18464);
                _shopWindowParams4 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_shopWindowParams4 = true;
                return _shopWindowParams4;
            }
        }
        private bool f_shopMainMenuItems2;
        private ShopMainMenuItems2Array _shopMainMenuItems2;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public ShopMainMenuItems2Array ShopMainMenuItems2
        {
            get
            {
                if (f_shopMainMenuItems2)
                    return _shopMainMenuItems2;
                long _pos = m_io.Pos;
                m_io.Seek(18272);
                _shopMainMenuItems2 = new ShopMainMenuItems2Array(m_io);
                m_io.Seek(_pos);
                f_shopMainMenuItems2 = true;
                return _shopMainMenuItems2;
            }
        }
        private bool f_shopMainMenuItems1;
        private ShopMainMenuItems1Array _shopMainMenuItems1;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public ShopMainMenuItems1Array ShopMainMenuItems1
        {
            get
            {
                if (f_shopMainMenuItems1)
                    return _shopMainMenuItems1;
                long _pos = m_io.Pos;
                m_io.Seek(18240);
                _shopMainMenuItems1 = new ShopMainMenuItems1Array(m_io);
                m_io.Seek(_pos);
                f_shopMainMenuItems1 = true;
                return _shopMainMenuItems1;
            }
        }
        private bool f_shopWindowParams3;
        private WindowParams _shopWindowParams3;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams ShopWindowParams3
        {
            get
            {
                if (f_shopWindowParams3)
                    return _shopWindowParams3;
                long _pos = m_io.Pos;
                m_io.Seek(18448);
                _shopWindowParams3 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_shopWindowParams3 = true;
                return _shopWindowParams3;
            }
        }
        private bool f_shopWindowParams7;
        private WindowParams _shopWindowParams7;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams ShopWindowParams7
        {
            get
            {
                if (f_shopWindowParams7)
                    return _shopWindowParams7;
                long _pos = m_io.Pos;
                m_io.Seek(18512);
                _shopWindowParams7 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_shopWindowParams7 = true;
                return _shopWindowParams7;
            }
        }
        private bool f_shopWindowParams1;
        private WindowParams _shopWindowParams1;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams ShopWindowParams1
        {
            get
            {
                if (f_shopWindowParams1)
                    return _shopWindowParams1;
                long _pos = m_io.Pos;
                m_io.Seek(18140);
                _shopWindowParams1 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_shopWindowParams1 = true;
                return _shopWindowParams1;
            }
        }
        private bool f_overlay22UnknownPointerNa238ec64;
        private List<byte> _overlay22UnknownPointerNa238ec64;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay22UnknownPointerNa238ec64
        {
            get
            {
                if (f_overlay22UnknownPointerNa238ec64)
                    return _overlay22UnknownPointerNa238ec64;
                long _pos = m_io.Pos;
                m_io.Seek(19236);
                _overlay22UnknownPointerNa238ec64 = new List<byte>();
                for (var i = 0; i < 4; i++)
                {
                    _overlay22UnknownPointerNa238ec64.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay22UnknownPointerNa238ec64 = true;
                return _overlay22UnknownPointerNa238ec64;
            }
        }
        private bool f_shopMenuItemsConfirm;
        private ShopMenuItemsConfirmArray _shopMenuItemsConfirm;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public ShopMenuItemsConfirmArray ShopMenuItemsConfirm
        {
            get
            {
                if (f_shopMenuItemsConfirm)
                    return _shopMenuItemsConfirm;
                long _pos = m_io.Pos;
                m_io.Seek(18216);
                _shopMenuItemsConfirm = new ShopMenuItemsConfirmArray(m_io);
                m_io.Seek(_pos);
                f_shopMenuItemsConfirm = true;
                return _shopMenuItemsConfirm;
            }
        }
        private bool f_shopWindowParams6;
        private WindowParams _shopWindowParams6;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams ShopWindowParams6
        {
            get
            {
                if (f_shopWindowParams6)
                    return _shopWindowParams6;
                long _pos = m_io.Pos;
                m_io.Seek(18496);
                _shopWindowParams6 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_shopWindowParams6 = true;
                return _shopWindowParams6;
            }
        }
        private bool f_overlay22UnknownPointerNa238ec60;
        private List<byte> _overlay22UnknownPointerNa238ec60;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay22UnknownPointerNa238ec60
        {
            get
            {
                if (f_overlay22UnknownPointerNa238ec60)
                    return _overlay22UnknownPointerNa238ec60;
                long _pos = m_io.Pos;
                m_io.Seek(19232);
                _overlay22UnknownPointerNa238ec60 = new List<byte>();
                for (var i = 0; i < 4; i++)
                {
                    _overlay22UnknownPointerNa238ec60.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay22UnknownPointerNa238ec60 = true;
                return _overlay22UnknownPointerNa238ec60;
            }
        }
        private bool f_overlay22ReservedSpace;
        private List<byte> _overlay22ReservedSpace;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay22ReservedSpace
        {
            get
            {
                if (f_overlay22ReservedSpace)
                    return _overlay22ReservedSpace;
                long _pos = m_io.Pos;
                m_io.Seek(19224);
                _overlay22ReservedSpace = new List<byte>();
                for (var i = 0; i < 8; i++)
                {
                    _overlay22ReservedSpace.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay22ReservedSpace = true;
                return _overlay22ReservedSpace;
            }
        }
        private bool f_shopWindowParams8;
        private WindowParams _shopWindowParams8;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams ShopWindowParams8
        {
            get
            {
                if (f_shopWindowParams8)
                    return _shopWindowParams8;
                long _pos = m_io.Pos;
                m_io.Seek(18528);
                _shopWindowParams8 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_shopWindowParams8 = true;
                return _shopWindowParams8;
            }
        }
        private bool f_overlay22UnknownStructNa238e85c;
        private List<byte> _overlay22UnknownStructNa238e85c;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay22UnknownStructNa238e85c
        {
            get
            {
                if (f_overlay22UnknownStructNa238e85c)
                    return _overlay22UnknownStructNa238e85c;
                long _pos = m_io.Pos;
                m_io.Seek(18204);
                _overlay22UnknownStructNa238e85c = new List<byte>();
                for (var i = 0; i < 12; i++)
                {
                    _overlay22UnknownStructNa238e85c.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay22UnknownStructNa238e85c = true;
                return _overlay22UnknownStructNa238e85c;
            }
        }
        private bool f_shopWindowParams10;
        private WindowParams _shopWindowParams10;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams ShopWindowParams10
        {
            get
            {
                if (f_shopWindowParams10)
                    return _shopWindowParams10;
                long _pos = m_io.Pos;
                m_io.Seek(18560);
                _shopWindowParams10 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_shopWindowParams10 = true;
                return _shopWindowParams10;
            }
        }
        private Overlay22Data m_root;
        private KaitaiStruct m_parent;
        public Overlay22Data M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
