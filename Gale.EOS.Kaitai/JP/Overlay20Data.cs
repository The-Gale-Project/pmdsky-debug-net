// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{
    public partial class Overlay20Data : KaitaiStruct
    {
        public static Overlay20Data FromFile(string fileName)
        {
            return new Overlay20Data(new KaitaiStream(fileName));
        }

        public Overlay20Data(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay20Data p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_recycleWindowParams11 = false;
            f_recycleSubmenuItems2 = false;
            f_recycleMainMenuItems1 = false;
            f_recycleWindowParams9 = false;
            f_recycleMenuItemsConfirm2 = false;
            f_overlay20UnknownPointerNa238d128 = false;
            f_recycleMainMenuItems3 = false;
            f_recycleMenuItemsConfirm1 = false;
            f_recycleWindowParams4 = false;
            f_recycleWindowParams5 = false;
            f_recycleWindowParams1 = false;
            f_recycleWindowParams6 = false;
            f_overlay20UnknownPointerNa238d124 = false;
            f_recycleWindowParams7 = false;
            f_recycleWindowParams2 = false;
            f_recycleWindowParams3 = false;
            f_overlay20UnknownPointerNa238d12c = false;
            f_recycleWindowParams8 = false;
            f_recycleMainMenuItems2 = false;
            f_recycleSubmenuItems1 = false;
            f_overlay20UnknownPointerNa238d120 = false;
            f_recycleWindowParams10 = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_recycleWindowParams11;
        private WindowParams _recycleWindowParams11;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams RecycleWindowParams11
        {
            get
            {
                if (f_recycleWindowParams11)
                    return _recycleWindowParams11;
                long _pos = m_io.Pos;
                m_io.Seek(12196);
                _recycleWindowParams11 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_recycleWindowParams11 = true;
                return _recycleWindowParams11;
            }
        }
        private bool f_recycleSubmenuItems2;
        private RecycleSubmenuItems2Array _recycleSubmenuItems2;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public RecycleSubmenuItems2Array RecycleSubmenuItems2
        {
            get
            {
                if (f_recycleSubmenuItems2)
                    return _recycleSubmenuItems2;
                long _pos = m_io.Pos;
                m_io.Seek(11912);
                _recycleSubmenuItems2 = new RecycleSubmenuItems2Array(m_io);
                m_io.Seek(_pos);
                f_recycleSubmenuItems2 = true;
                return _recycleSubmenuItems2;
            }
        }
        private bool f_recycleMainMenuItems1;
        private RecycleMainMenuItems1Array _recycleMainMenuItems1;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public RecycleMainMenuItems1Array RecycleMainMenuItems1
        {
            get
            {
                if (f_recycleMainMenuItems1)
                    return _recycleMainMenuItems1;
                long _pos = m_io.Pos;
                m_io.Seek(11944);
                _recycleMainMenuItems1 = new RecycleMainMenuItems1Array(m_io);
                m_io.Seek(_pos);
                f_recycleMainMenuItems1 = true;
                return _recycleMainMenuItems1;
            }
        }
        private bool f_recycleWindowParams9;
        private WindowParams _recycleWindowParams9;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams RecycleWindowParams9
        {
            get
            {
                if (f_recycleWindowParams9)
                    return _recycleWindowParams9;
                long _pos = m_io.Pos;
                m_io.Seek(12164);
                _recycleWindowParams9 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_recycleWindowParams9 = true;
                return _recycleWindowParams9;
            }
        }
        private bool f_recycleMenuItemsConfirm2;
        private RecycleMenuItemsConfirm2Array _recycleMenuItemsConfirm2;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public RecycleMenuItemsConfirm2Array RecycleMenuItemsConfirm2
        {
            get
            {
                if (f_recycleMenuItemsConfirm2)
                    return _recycleMenuItemsConfirm2;
                long _pos = m_io.Pos;
                m_io.Seek(11864);
                _recycleMenuItemsConfirm2 = new RecycleMenuItemsConfirm2Array(m_io);
                m_io.Seek(_pos);
                f_recycleMenuItemsConfirm2 = true;
                return _recycleMenuItemsConfirm2;
            }
        }
        private bool f_overlay20UnknownPointerNa238d128;
        private List<byte> _overlay20UnknownPointerNa238d128;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay20UnknownPointerNa238d128
        {
            get
            {
                if (f_overlay20UnknownPointerNa238d128)
                    return _overlay20UnknownPointerNa238d128;
                long _pos = m_io.Pos;
                m_io.Seek(12264);
                _overlay20UnknownPointerNa238d128 = new List<byte>();
                for (var i = 0; i < 4; i++)
                {
                    _overlay20UnknownPointerNa238d128.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay20UnknownPointerNa238d128 = true;
                return _overlay20UnknownPointerNa238d128;
            }
        }
        private bool f_recycleMainMenuItems3;
        private RecycleMainMenuItems3Array _recycleMainMenuItems3;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public RecycleMainMenuItems3Array RecycleMainMenuItems3
        {
            get
            {
                if (f_recycleMainMenuItems3)
                    return _recycleMainMenuItems3;
                long _pos = m_io.Pos;
                m_io.Seek(12212);
                _recycleMainMenuItems3 = new RecycleMainMenuItems3Array(m_io);
                m_io.Seek(_pos);
                f_recycleMainMenuItems3 = true;
                return _recycleMainMenuItems3;
            }
        }
        private bool f_recycleMenuItemsConfirm1;
        private RecycleMenuItemsConfirm1Array _recycleMenuItemsConfirm1;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public RecycleMenuItemsConfirm1Array RecycleMenuItemsConfirm1
        {
            get
            {
                if (f_recycleMenuItemsConfirm1)
                    return _recycleMenuItemsConfirm1;
                long _pos = m_io.Pos;
                m_io.Seek(11840);
                _recycleMenuItemsConfirm1 = new RecycleMenuItemsConfirm1Array(m_io);
                m_io.Seek(_pos);
                f_recycleMenuItemsConfirm1 = true;
                return _recycleMenuItemsConfirm1;
            }
        }
        private bool f_recycleWindowParams4;
        private WindowParams _recycleWindowParams4;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams RecycleWindowParams4
        {
            get
            {
                if (f_recycleWindowParams4)
                    return _recycleWindowParams4;
                long _pos = m_io.Pos;
                m_io.Seek(12052);
                _recycleWindowParams4 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_recycleWindowParams4 = true;
                return _recycleWindowParams4;
            }
        }
        private bool f_recycleWindowParams5;
        private WindowParams _recycleWindowParams5;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams RecycleWindowParams5
        {
            get
            {
                if (f_recycleWindowParams5)
                    return _recycleWindowParams5;
                long _pos = m_io.Pos;
                m_io.Seek(12068);
                _recycleWindowParams5 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_recycleWindowParams5 = true;
                return _recycleWindowParams5;
            }
        }
        private bool f_recycleWindowParams1;
        private WindowParams _recycleWindowParams1;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams RecycleWindowParams1
        {
            get
            {
                if (f_recycleWindowParams1)
                    return _recycleWindowParams1;
                long _pos = m_io.Pos;
                m_io.Seek(12004);
                _recycleWindowParams1 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_recycleWindowParams1 = true;
                return _recycleWindowParams1;
            }
        }
        private bool f_recycleWindowParams6;
        private WindowParams _recycleWindowParams6;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams RecycleWindowParams6
        {
            get
            {
                if (f_recycleWindowParams6)
                    return _recycleWindowParams6;
                long _pos = m_io.Pos;
                m_io.Seek(12084);
                _recycleWindowParams6 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_recycleWindowParams6 = true;
                return _recycleWindowParams6;
            }
        }
        private bool f_overlay20UnknownPointerNa238d124;
        private List<byte> _overlay20UnknownPointerNa238d124;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay20UnknownPointerNa238d124
        {
            get
            {
                if (f_overlay20UnknownPointerNa238d124)
                    return _overlay20UnknownPointerNa238d124;
                long _pos = m_io.Pos;
                m_io.Seek(12260);
                _overlay20UnknownPointerNa238d124 = new List<byte>();
                for (var i = 0; i < 4; i++)
                {
                    _overlay20UnknownPointerNa238d124.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay20UnknownPointerNa238d124 = true;
                return _overlay20UnknownPointerNa238d124;
            }
        }
        private bool f_recycleWindowParams7;
        private WindowParams _recycleWindowParams7;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams RecycleWindowParams7
        {
            get
            {
                if (f_recycleWindowParams7)
                    return _recycleWindowParams7;
                long _pos = m_io.Pos;
                m_io.Seek(12132);
                _recycleWindowParams7 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_recycleWindowParams7 = true;
                return _recycleWindowParams7;
            }
        }
        private bool f_recycleWindowParams2;
        private WindowParams _recycleWindowParams2;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams RecycleWindowParams2
        {
            get
            {
                if (f_recycleWindowParams2)
                    return _recycleWindowParams2;
                long _pos = m_io.Pos;
                m_io.Seek(12020);
                _recycleWindowParams2 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_recycleWindowParams2 = true;
                return _recycleWindowParams2;
            }
        }
        private bool f_recycleWindowParams3;
        private WindowParams _recycleWindowParams3;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams RecycleWindowParams3
        {
            get
            {
                if (f_recycleWindowParams3)
                    return _recycleWindowParams3;
                long _pos = m_io.Pos;
                m_io.Seek(12036);
                _recycleWindowParams3 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_recycleWindowParams3 = true;
                return _recycleWindowParams3;
            }
        }
        private bool f_overlay20UnknownPointerNa238d12c;
        private List<byte> _overlay20UnknownPointerNa238d12c;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay20UnknownPointerNa238d12c
        {
            get
            {
                if (f_overlay20UnknownPointerNa238d12c)
                    return _overlay20UnknownPointerNa238d12c;
                long _pos = m_io.Pos;
                m_io.Seek(12268);
                _overlay20UnknownPointerNa238d12c = new List<byte>();
                for (var i = 0; i < 4; i++)
                {
                    _overlay20UnknownPointerNa238d12c.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay20UnknownPointerNa238d12c = true;
                return _overlay20UnknownPointerNa238d12c;
            }
        }
        private bool f_recycleWindowParams8;
        private WindowParams _recycleWindowParams8;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams RecycleWindowParams8
        {
            get
            {
                if (f_recycleWindowParams8)
                    return _recycleWindowParams8;
                long _pos = m_io.Pos;
                m_io.Seek(12148);
                _recycleWindowParams8 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_recycleWindowParams8 = true;
                return _recycleWindowParams8;
            }
        }
        private bool f_recycleMainMenuItems2;
        private RecycleMainMenuItems2Array _recycleMainMenuItems2;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public RecycleMainMenuItems2Array RecycleMainMenuItems2
        {
            get
            {
                if (f_recycleMainMenuItems2)
                    return _recycleMainMenuItems2;
                long _pos = m_io.Pos;
                m_io.Seek(12100);
                _recycleMainMenuItems2 = new RecycleMainMenuItems2Array(m_io);
                m_io.Seek(_pos);
                f_recycleMainMenuItems2 = true;
                return _recycleMainMenuItems2;
            }
        }
        private bool f_recycleSubmenuItems1;
        private RecycleSubmenuItems1Array _recycleSubmenuItems1;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public RecycleSubmenuItems1Array RecycleSubmenuItems1
        {
            get
            {
                if (f_recycleSubmenuItems1)
                    return _recycleSubmenuItems1;
                long _pos = m_io.Pos;
                m_io.Seek(11888);
                _recycleSubmenuItems1 = new RecycleSubmenuItems1Array(m_io);
                m_io.Seek(_pos);
                f_recycleSubmenuItems1 = true;
                return _recycleSubmenuItems1;
            }
        }
        private bool f_overlay20UnknownPointerNa238d120;
        private List<byte> _overlay20UnknownPointerNa238d120;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay20UnknownPointerNa238d120
        {
            get
            {
                if (f_overlay20UnknownPointerNa238d120)
                    return _overlay20UnknownPointerNa238d120;
                long _pos = m_io.Pos;
                m_io.Seek(12256);
                _overlay20UnknownPointerNa238d120 = new List<byte>();
                for (var i = 0; i < 4; i++)
                {
                    _overlay20UnknownPointerNa238d120.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay20UnknownPointerNa238d120 = true;
                return _overlay20UnknownPointerNa238d120;
            }
        }
        private bool f_recycleWindowParams10;
        private WindowParams _recycleWindowParams10;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams RecycleWindowParams10
        {
            get
            {
                if (f_recycleWindowParams10)
                    return _recycleWindowParams10;
                long _pos = m_io.Pos;
                m_io.Seek(12180);
                _recycleWindowParams10 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_recycleWindowParams10 = true;
                return _recycleWindowParams10;
            }
        }
        private Overlay20Data m_root;
        private KaitaiStruct m_parent;
        public Overlay20Data M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
