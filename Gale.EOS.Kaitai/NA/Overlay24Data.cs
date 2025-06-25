// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{
    public partial class Overlay24Data : KaitaiStruct
    {
        public static Overlay24Data FromFile(string fileName)
        {
            return new Overlay24Data(new KaitaiStream(fileName));
        }

        public Overlay24Data(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay24Data p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_overlay24ReservedSpace = false;
            f_overlay24UnknownStringIds = false;
            f_daycareWindowParams4 = false;
            f_daycareWindowParams3 = false;
            f_daycareWindowParams2 = false;
            f_daycareMenuItemsConfirm = false;
            f_overlay24UnknownStructNa238c508 = false;
            f_overlay24UnknownPointerNa238c600 = false;
            f_overlay24UnknownStructNa238c514 = false;
            f_daycareWindowParams5 = false;
            f_daycareMainMenuItems = false;
            f_daycareWindowParams1 = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_overlay24ReservedSpace;
        private List<byte> _overlay24ReservedSpace;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay24ReservedSpace
        {
            get
            {
                if (f_overlay24ReservedSpace)
                    return _overlay24ReservedSpace;
                long _pos = m_io.Pos;
                m_io.Seek(9376);
                _overlay24ReservedSpace = new List<byte>();
                for (var i = 0; i < 32; i++)
                {
                    _overlay24ReservedSpace.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay24ReservedSpace = true;
                return _overlay24ReservedSpace;
            }
        }
        private bool f_overlay24UnknownStringIds;
        private List<byte> _overlay24UnknownStringIds;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay24UnknownStringIds
        {
            get
            {
                if (f_overlay24UnknownStringIds)
                    return _overlay24UnknownStringIds;
                long _pos = m_io.Pos;
                m_io.Seek(9240);
                _overlay24UnknownStringIds = new List<byte>();
                for (var i = 0; i < 56; i++)
                {
                    _overlay24UnknownStringIds.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay24UnknownStringIds = true;
                return _overlay24UnknownStringIds;
            }
        }
        private bool f_daycareWindowParams4;
        private WindowParams _daycareWindowParams4;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DaycareWindowParams4
        {
            get
            {
                if (f_daycareWindowParams4)
                    return _daycareWindowParams4;
                long _pos = m_io.Pos;
                m_io.Seek(9344);
                _daycareWindowParams4 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_daycareWindowParams4 = true;
                return _daycareWindowParams4;
            }
        }
        private bool f_daycareWindowParams3;
        private WindowParams _daycareWindowParams3;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DaycareWindowParams3
        {
            get
            {
                if (f_daycareWindowParams3)
                    return _daycareWindowParams3;
                long _pos = m_io.Pos;
                m_io.Seek(9328);
                _daycareWindowParams3 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_daycareWindowParams3 = true;
                return _daycareWindowParams3;
            }
        }
        private bool f_daycareWindowParams2;
        private WindowParams _daycareWindowParams2;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DaycareWindowParams2
        {
            get
            {
                if (f_daycareWindowParams2)
                    return _daycareWindowParams2;
                long _pos = m_io.Pos;
                m_io.Seek(9312);
                _daycareWindowParams2 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_daycareWindowParams2 = true;
                return _daycareWindowParams2;
            }
        }
        private bool f_daycareMenuItemsConfirm;
        private DaycareMenuItemsConfirmArray _daycareMenuItemsConfirm;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public DaycareMenuItemsConfirmArray DaycareMenuItemsConfirm
        {
            get
            {
                if (f_daycareMenuItemsConfirm)
                    return _daycareMenuItemsConfirm;
                long _pos = m_io.Pos;
                m_io.Seek(9184);
                _daycareMenuItemsConfirm = new DaycareMenuItemsConfirmArray(m_io);
                m_io.Seek(_pos);
                f_daycareMenuItemsConfirm = true;
                return _daycareMenuItemsConfirm;
            }
        }
        private bool f_overlay24UnknownStructNa238c508;
        private List<byte> _overlay24UnknownStructNa238c508;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay24UnknownStructNa238c508
        {
            get
            {
                if (f_overlay24UnknownStructNa238c508)
                    return _overlay24UnknownStructNa238c508;
                long _pos = m_io.Pos;
                m_io.Seek(9160);
                _overlay24UnknownStructNa238c508 = new List<byte>();
                for (var i = 0; i < 12; i++)
                {
                    _overlay24UnknownStructNa238c508.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay24UnknownStructNa238c508 = true;
                return _overlay24UnknownStructNa238c508;
            }
        }
        private bool f_overlay24UnknownPointerNa238c600;
        private List<byte> _overlay24UnknownPointerNa238c600;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay24UnknownPointerNa238c600
        {
            get
            {
                if (f_overlay24UnknownPointerNa238c600)
                    return _overlay24UnknownPointerNa238c600;
                long _pos = m_io.Pos;
                m_io.Seek(9408);
                _overlay24UnknownPointerNa238c600 = new List<byte>();
                for (var i = 0; i < 4; i++)
                {
                    _overlay24UnknownPointerNa238c600.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay24UnknownPointerNa238c600 = true;
                return _overlay24UnknownPointerNa238c600;
            }
        }
        private bool f_overlay24UnknownStructNa238c514;
        private List<byte> _overlay24UnknownStructNa238c514;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay24UnknownStructNa238c514
        {
            get
            {
                if (f_overlay24UnknownStructNa238c514)
                    return _overlay24UnknownStructNa238c514;
                long _pos = m_io.Pos;
                m_io.Seek(9172);
                _overlay24UnknownStructNa238c514 = new List<byte>();
                for (var i = 0; i < 12; i++)
                {
                    _overlay24UnknownStructNa238c514.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay24UnknownStructNa238c514 = true;
                return _overlay24UnknownStructNa238c514;
            }
        }
        private bool f_daycareWindowParams5;
        private WindowParams _daycareWindowParams5;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DaycareWindowParams5
        {
            get
            {
                if (f_daycareWindowParams5)
                    return _daycareWindowParams5;
                long _pos = m_io.Pos;
                m_io.Seek(9360);
                _daycareWindowParams5 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_daycareWindowParams5 = true;
                return _daycareWindowParams5;
            }
        }
        private bool f_daycareMainMenuItems;
        private DaycareMainMenuItemsArray _daycareMainMenuItems;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public DaycareMainMenuItemsArray DaycareMainMenuItems
        {
            get
            {
                if (f_daycareMainMenuItems)
                    return _daycareMainMenuItems;
                long _pos = m_io.Pos;
                m_io.Seek(9208);
                _daycareMainMenuItems = new DaycareMainMenuItemsArray(m_io);
                m_io.Seek(_pos);
                f_daycareMainMenuItems = true;
                return _daycareMainMenuItems;
            }
        }
        private bool f_daycareWindowParams1;
        private WindowParams _daycareWindowParams1;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DaycareWindowParams1
        {
            get
            {
                if (f_daycareWindowParams1)
                    return _daycareWindowParams1;
                long _pos = m_io.Pos;
                m_io.Seek(9296);
                _daycareWindowParams1 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_daycareWindowParams1 = true;
                return _daycareWindowParams1;
            }
        }
        private Overlay24Data m_root;
        private KaitaiStruct m_parent;
        public Overlay24Data M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
