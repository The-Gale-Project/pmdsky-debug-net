// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{
    public partial class Overlay15Data : KaitaiStruct
    {
        public static Overlay15Data FromFile(string fileName)
        {
            return new Overlay15Data(new KaitaiStream(fileName));
        }

        public Overlay15Data(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay15Data p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_bankWindowParams3 = false;
            f_overlay15UnknownPointerNa238b180 = false;
            f_bankWindowParams4 = false;
            f_overlay15ReservedSpace = false;
            f_bankWindowParams1 = false;
            f_bankMainMenuItems = false;
            f_bankWindowParams5 = false;
            f_bankWindowParams2 = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_bankWindowParams3;
        private WindowParams _bankWindowParams3;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams BankWindowParams3
        {
            get
            {
                if (f_bankWindowParams3)
                    return _bankWindowParams3;
                long _pos = m_io.Pos;
                m_io.Seek(3932);
                _bankWindowParams3 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_bankWindowParams3 = true;
                return _bankWindowParams3;
            }
        }
        private bool f_overlay15UnknownPointerNa238b180;
        private List<byte> _overlay15UnknownPointerNa238b180;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay15UnknownPointerNa238b180
        {
            get
            {
                if (f_overlay15UnknownPointerNa238b180)
                    return _overlay15UnknownPointerNa238b180;
                long _pos = m_io.Pos;
                m_io.Seek(4160);
                _overlay15UnknownPointerNa238b180 = new List<byte>();
                for (var i = 0; i < 4; i++)
                {
                    _overlay15UnknownPointerNa238b180.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay15UnknownPointerNa238b180 = true;
                return _overlay15UnknownPointerNa238b180;
            }
        }
        private bool f_bankWindowParams4;
        private WindowParams _bankWindowParams4;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams BankWindowParams4
        {
            get
            {
                if (f_bankWindowParams4)
                    return _bankWindowParams4;
                long _pos = m_io.Pos;
                m_io.Seek(3948);
                _bankWindowParams4 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_bankWindowParams4 = true;
                return _bankWindowParams4;
            }
        }
        private bool f_overlay15ReservedSpace;
        private List<byte> _overlay15ReservedSpace;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay15ReservedSpace
        {
            get
            {
                if (f_overlay15ReservedSpace)
                    return _overlay15ReservedSpace;
                long _pos = m_io.Pos;
                m_io.Seek(4132);
                _overlay15ReservedSpace = new List<byte>();
                for (var i = 0; i < 28; i++)
                {
                    _overlay15ReservedSpace.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay15ReservedSpace = true;
                return _overlay15ReservedSpace;
            }
        }
        private bool f_bankWindowParams1;
        private WindowParams _bankWindowParams1;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams BankWindowParams1
        {
            get
            {
                if (f_bankWindowParams1)
                    return _bankWindowParams1;
                long _pos = m_io.Pos;
                m_io.Seek(3900);
                _bankWindowParams1 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_bankWindowParams1 = true;
                return _bankWindowParams1;
            }
        }
        private bool f_bankMainMenuItems;
        private BankMainMenuItemsArray _bankMainMenuItems;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public BankMainMenuItemsArray BankMainMenuItems
        {
            get
            {
                if (f_bankMainMenuItems)
                    return _bankMainMenuItems;
                long _pos = m_io.Pos;
                m_io.Seek(3860);
                _bankMainMenuItems = new BankMainMenuItemsArray(m_io);
                m_io.Seek(_pos);
                f_bankMainMenuItems = true;
                return _bankMainMenuItems;
            }
        }
        private bool f_bankWindowParams5;
        private WindowParams _bankWindowParams5;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams BankWindowParams5
        {
            get
            {
                if (f_bankWindowParams5)
                    return _bankWindowParams5;
                long _pos = m_io.Pos;
                m_io.Seek(3964);
                _bankWindowParams5 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_bankWindowParams5 = true;
                return _bankWindowParams5;
            }
        }
        private bool f_bankWindowParams2;
        private WindowParams _bankWindowParams2;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams BankWindowParams2
        {
            get
            {
                if (f_bankWindowParams2)
                    return _bankWindowParams2;
                long _pos = m_io.Pos;
                m_io.Seek(3916);
                _bankWindowParams2 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_bankWindowParams2 = true;
                return _bankWindowParams2;
            }
        }
        private Overlay15Data m_root;
        private KaitaiStruct m_parent;
        public Overlay15Data M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
