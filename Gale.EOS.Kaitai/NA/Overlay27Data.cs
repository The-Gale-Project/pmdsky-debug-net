// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{
    public partial class Overlay27Data : KaitaiStruct
    {
        public static Overlay27Data FromFile(string fileName)
        {
            return new Overlay27Data(new KaitaiStream(fileName));
        }

        public Overlay27Data(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay27Data p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_discardItemsSubmenuItems1 = false;
            f_discardItemsSubmenuItems2 = false;
            f_discardWindowParams1 = false;
            f_overlay27UnknownValueNa238c948 = false;
            f_discardWindowParams2 = false;
            f_discardWindowParams4 = false;
            f_discardItemsMenuItemsConfirm = false;
            f_discardWindowParams8 = false;
            f_overlay27ReservedSpace = false;
            f_discardItemsMainMenuItems = false;
            f_discardWindowParams7 = false;
            f_overlay27UnknownPointerNa238ce84 = false;
            f_discardWindowParams6 = false;
            f_discardWindowParams5 = false;
            f_overlay27UnknownStringIds = false;
            f_overlay27UnknownPointerNa238ce80 = false;
            f_overlay27UnknownValueNa238c94c = false;
            f_discardWindowParams3 = false;
            f_overlay27UnknownStructNa238c950 = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_discardItemsSubmenuItems1;
        private DiscardItemsSubmenuItems1Array _discardItemsSubmenuItems1;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public DiscardItemsSubmenuItems1Array DiscardItemsSubmenuItems1
        {
            get
            {
                if (f_discardItemsSubmenuItems1)
                    return _discardItemsSubmenuItems1;
                long _pos = m_io.Pos;
                m_io.Seek(10292);
                _discardItemsSubmenuItems1 = new DiscardItemsSubmenuItems1Array(m_io);
                m_io.Seek(_pos);
                f_discardItemsSubmenuItems1 = true;
                return _discardItemsSubmenuItems1;
            }
        }
        private bool f_discardItemsSubmenuItems2;
        private DiscardItemsSubmenuItems2Array _discardItemsSubmenuItems2;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public DiscardItemsSubmenuItems2Array DiscardItemsSubmenuItems2
        {
            get
            {
                if (f_discardItemsSubmenuItems2)
                    return _discardItemsSubmenuItems2;
                long _pos = m_io.Pos;
                m_io.Seek(10324);
                _discardItemsSubmenuItems2 = new DiscardItemsSubmenuItems2Array(m_io);
                m_io.Seek(_pos);
                f_discardItemsSubmenuItems2 = true;
                return _discardItemsSubmenuItems2;
            }
        }
        private bool f_discardWindowParams1;
        private WindowParams _discardWindowParams1;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DiscardWindowParams1
        {
            get
            {
                if (f_discardWindowParams1)
                    return _discardWindowParams1;
                long _pos = m_io.Pos;
                m_io.Seek(10444);
                _discardWindowParams1 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_discardWindowParams1 = true;
                return _discardWindowParams1;
            }
        }
        private bool f_overlay27UnknownValueNa238c948;
        private List<byte> _overlay27UnknownValueNa238c948;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay27UnknownValueNa238c948
        {
            get
            {
                if (f_overlay27UnknownValueNa238c948)
                    return _overlay27UnknownValueNa238c948;
                long _pos = m_io.Pos;
                m_io.Seek(10248);
                _overlay27UnknownValueNa238c948 = new List<byte>();
                for (var i = 0; i < 4; i++)
                {
                    _overlay27UnknownValueNa238c948.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay27UnknownValueNa238c948 = true;
                return _overlay27UnknownValueNa238c948;
            }
        }
        private bool f_discardWindowParams2;
        private WindowParams _discardWindowParams2;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DiscardWindowParams2
        {
            get
            {
                if (f_discardWindowParams2)
                    return _discardWindowParams2;
                long _pos = m_io.Pos;
                m_io.Seek(10460);
                _discardWindowParams2 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_discardWindowParams2 = true;
                return _discardWindowParams2;
            }
        }
        private bool f_discardWindowParams4;
        private WindowParams _discardWindowParams4;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DiscardWindowParams4
        {
            get
            {
                if (f_discardWindowParams4)
                    return _discardWindowParams4;
                long _pos = m_io.Pos;
                m_io.Seek(10492);
                _discardWindowParams4 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_discardWindowParams4 = true;
                return _discardWindowParams4;
            }
        }
        private bool f_discardItemsMenuItemsConfirm;
        private DiscardItemsMenuItemsConfirmArray _discardItemsMenuItemsConfirm;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public DiscardItemsMenuItemsConfirmArray DiscardItemsMenuItemsConfirm
        {
            get
            {
                if (f_discardItemsMenuItemsConfirm)
                    return _discardItemsMenuItemsConfirm;
                long _pos = m_io.Pos;
                m_io.Seek(10268);
                _discardItemsMenuItemsConfirm = new DiscardItemsMenuItemsConfirmArray(m_io);
                m_io.Seek(_pos);
                f_discardItemsMenuItemsConfirm = true;
                return _discardItemsMenuItemsConfirm;
            }
        }
        private bool f_discardWindowParams8;
        private WindowParams _discardWindowParams8;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DiscardWindowParams8
        {
            get
            {
                if (f_discardWindowParams8)
                    return _discardWindowParams8;
                long _pos = m_io.Pos;
                m_io.Seek(10556);
                _discardWindowParams8 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_discardWindowParams8 = true;
                return _discardWindowParams8;
            }
        }
        private bool f_overlay27ReservedSpace;
        private List<byte> _overlay27ReservedSpace;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay27ReservedSpace
        {
            get
            {
                if (f_overlay27ReservedSpace)
                    return _overlay27ReservedSpace;
                long _pos = m_io.Pos;
                m_io.Seek(11568);
                _overlay27ReservedSpace = new List<byte>();
                for (var i = 0; i < 16; i++)
                {
                    _overlay27ReservedSpace.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay27ReservedSpace = true;
                return _overlay27ReservedSpace;
            }
        }
        private bool f_discardItemsMainMenuItems;
        private DiscardItemsMainMenuItemsArray _discardItemsMainMenuItems;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public DiscardItemsMainMenuItemsArray DiscardItemsMainMenuItems
        {
            get
            {
                if (f_discardItemsMainMenuItems)
                    return _discardItemsMainMenuItems;
                long _pos = m_io.Pos;
                m_io.Seek(10356);
                _discardItemsMainMenuItems = new DiscardItemsMainMenuItemsArray(m_io);
                m_io.Seek(_pos);
                f_discardItemsMainMenuItems = true;
                return _discardItemsMainMenuItems;
            }
        }
        private bool f_discardWindowParams7;
        private WindowParams _discardWindowParams7;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DiscardWindowParams7
        {
            get
            {
                if (f_discardWindowParams7)
                    return _discardWindowParams7;
                long _pos = m_io.Pos;
                m_io.Seek(10540);
                _discardWindowParams7 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_discardWindowParams7 = true;
                return _discardWindowParams7;
            }
        }
        private bool f_overlay27UnknownPointerNa238ce84;
        private List<byte> _overlay27UnknownPointerNa238ce84;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay27UnknownPointerNa238ce84
        {
            get
            {
                if (f_overlay27UnknownPointerNa238ce84)
                    return _overlay27UnknownPointerNa238ce84;
                long _pos = m_io.Pos;
                m_io.Seek(11588);
                _overlay27UnknownPointerNa238ce84 = new List<byte>();
                for (var i = 0; i < 4; i++)
                {
                    _overlay27UnknownPointerNa238ce84.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay27UnknownPointerNa238ce84 = true;
                return _overlay27UnknownPointerNa238ce84;
            }
        }
        private bool f_discardWindowParams6;
        private WindowParams _discardWindowParams6;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DiscardWindowParams6
        {
            get
            {
                if (f_discardWindowParams6)
                    return _discardWindowParams6;
                long _pos = m_io.Pos;
                m_io.Seek(10524);
                _discardWindowParams6 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_discardWindowParams6 = true;
                return _discardWindowParams6;
            }
        }
        private bool f_discardWindowParams5;
        private WindowParams _discardWindowParams5;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DiscardWindowParams5
        {
            get
            {
                if (f_discardWindowParams5)
                    return _discardWindowParams5;
                long _pos = m_io.Pos;
                m_io.Seek(10508);
                _discardWindowParams5 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_discardWindowParams5 = true;
                return _discardWindowParams5;
            }
        }
        private bool f_overlay27UnknownStringIds;
        private List<byte> _overlay27UnknownStringIds;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay27UnknownStringIds
        {
            get
            {
                if (f_overlay27UnknownStringIds)
                    return _overlay27UnknownStringIds;
                long _pos = m_io.Pos;
                m_io.Seek(10396);
                _overlay27UnknownStringIds = new List<byte>();
                for (var i = 0; i < 48; i++)
                {
                    _overlay27UnknownStringIds.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay27UnknownStringIds = true;
                return _overlay27UnknownStringIds;
            }
        }
        private bool f_overlay27UnknownPointerNa238ce80;
        private List<byte> _overlay27UnknownPointerNa238ce80;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay27UnknownPointerNa238ce80
        {
            get
            {
                if (f_overlay27UnknownPointerNa238ce80)
                    return _overlay27UnknownPointerNa238ce80;
                long _pos = m_io.Pos;
                m_io.Seek(11584);
                _overlay27UnknownPointerNa238ce80 = new List<byte>();
                for (var i = 0; i < 4; i++)
                {
                    _overlay27UnknownPointerNa238ce80.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay27UnknownPointerNa238ce80 = true;
                return _overlay27UnknownPointerNa238ce80;
            }
        }
        private bool f_overlay27UnknownValueNa238c94c;
        private List<byte> _overlay27UnknownValueNa238c94c;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay27UnknownValueNa238c94c
        {
            get
            {
                if (f_overlay27UnknownValueNa238c94c)
                    return _overlay27UnknownValueNa238c94c;
                long _pos = m_io.Pos;
                m_io.Seek(10252);
                _overlay27UnknownValueNa238c94c = new List<byte>();
                for (var i = 0; i < 4; i++)
                {
                    _overlay27UnknownValueNa238c94c.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay27UnknownValueNa238c94c = true;
                return _overlay27UnknownValueNa238c94c;
            }
        }
        private bool f_discardWindowParams3;
        private WindowParams _discardWindowParams3;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams DiscardWindowParams3
        {
            get
            {
                if (f_discardWindowParams3)
                    return _discardWindowParams3;
                long _pos = m_io.Pos;
                m_io.Seek(10476);
                _discardWindowParams3 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_discardWindowParams3 = true;
                return _discardWindowParams3;
            }
        }
        private bool f_overlay27UnknownStructNa238c950;
        private List<byte> _overlay27UnknownStructNa238c950;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay27UnknownStructNa238c950
        {
            get
            {
                if (f_overlay27UnknownStructNa238c950)
                    return _overlay27UnknownStructNa238c950;
                long _pos = m_io.Pos;
                m_io.Seek(10256);
                _overlay27UnknownStructNa238c950 = new List<byte>();
                for (var i = 0; i < 12; i++)
                {
                    _overlay27UnknownStructNa238c950.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay27UnknownStructNa238c950 = true;
                return _overlay27UnknownStructNa238c950;
            }
        }
        private Overlay27Data m_root;
        private KaitaiStruct m_parent;
        public Overlay27Data M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
