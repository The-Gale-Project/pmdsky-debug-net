// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{
    public partial class Overlay25Data : KaitaiStruct
    {
        public static Overlay25Data FromFile(string fileName)
        {
            return new Overlay25Data(new KaitaiStream(fileName));
        }

        public Overlay25Data(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay25Data p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_appraisalMainMenuItems = false;
            f_appraisalWindowParams1 = false;
            f_overlay25UnknownStringIds = false;
            f_appraisalWindowParams3 = false;
            f_appraisalSubmenuItems = false;
            f_appraisalWindowParams7 = false;
            f_overlay25UnknownPointerNa238b5e0 = false;
            f_overlay25UnknownStructNa238b498 = false;
            f_appraisalWindowParams6 = false;
            f_appraisalWindowParams8 = false;
            f_appraisalWindowParams5 = false;
            f_appraisalMenuItemsConfirm = false;
            f_overlay25ReservedSpace = false;
            f_appraisalWindowParams2 = false;
            f_appraisalWindowParams4 = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_appraisalMainMenuItems;
        private AppraisalMainMenuItemsArray _appraisalMainMenuItems;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public AppraisalMainMenuItemsArray AppraisalMainMenuItems
        {
            get
            {
                if (f_appraisalMainMenuItems)
                    return _appraisalMainMenuItems;
                long _pos = m_io.Pos;
                m_io.Seek(5004);
                _appraisalMainMenuItems = new AppraisalMainMenuItemsArray(m_io);
                m_io.Seek(_pos);
                f_appraisalMainMenuItems = true;
                return _appraisalMainMenuItems;
            }
        }
        private bool f_appraisalWindowParams1;
        private WindowParams _appraisalWindowParams1;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams AppraisalWindowParams1
        {
            get
            {
                if (f_appraisalWindowParams1)
                    return _appraisalWindowParams1;
                long _pos = m_io.Pos;
                m_io.Seek(4964);
                _appraisalWindowParams1 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_appraisalWindowParams1 = true;
                return _appraisalWindowParams1;
            }
        }
        private bool f_overlay25UnknownStringIds;
        private List<byte> _overlay25UnknownStringIds;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay25UnknownStringIds
        {
            get
            {
                if (f_overlay25UnknownStringIds)
                    return _overlay25UnknownStringIds;
                long _pos = m_io.Pos;
                m_io.Seek(5068);
                _overlay25UnknownStringIds = new List<byte>();
                for (var i = 0; i < 40; i++)
                {
                    _overlay25UnknownStringIds.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay25UnknownStringIds = true;
                return _overlay25UnknownStringIds;
            }
        }
        private bool f_appraisalWindowParams3;
        private WindowParams _appraisalWindowParams3;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams AppraisalWindowParams3
        {
            get
            {
                if (f_appraisalWindowParams3)
                    return _appraisalWindowParams3;
                long _pos = m_io.Pos;
                m_io.Seek(5124);
                _appraisalWindowParams3 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_appraisalWindowParams3 = true;
                return _appraisalWindowParams3;
            }
        }
        private bool f_appraisalSubmenuItems;
        private AppraisalSubmenuItemsArray _appraisalSubmenuItems;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public AppraisalSubmenuItemsArray AppraisalSubmenuItems
        {
            get
            {
                if (f_appraisalSubmenuItems)
                    return _appraisalSubmenuItems;
                long _pos = m_io.Pos;
                m_io.Seek(5036);
                _appraisalSubmenuItems = new AppraisalSubmenuItemsArray(m_io);
                m_io.Seek(_pos);
                f_appraisalSubmenuItems = true;
                return _appraisalSubmenuItems;
            }
        }
        private bool f_appraisalWindowParams7;
        private WindowParams _appraisalWindowParams7;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams AppraisalWindowParams7
        {
            get
            {
                if (f_appraisalWindowParams7)
                    return _appraisalWindowParams7;
                long _pos = m_io.Pos;
                m_io.Seek(5188);
                _appraisalWindowParams7 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_appraisalWindowParams7 = true;
                return _appraisalWindowParams7;
            }
        }
        private bool f_overlay25UnknownPointerNa238b5e0;
        private List<byte> _overlay25UnknownPointerNa238b5e0;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay25UnknownPointerNa238b5e0
        {
            get
            {
                if (f_overlay25UnknownPointerNa238b5e0)
                    return _overlay25UnknownPointerNa238b5e0;
                long _pos = m_io.Pos;
                m_io.Seek(5280);
                _overlay25UnknownPointerNa238b5e0 = new List<byte>();
                for (var i = 0; i < 4; i++)
                {
                    _overlay25UnknownPointerNa238b5e0.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay25UnknownPointerNa238b5e0 = true;
                return _overlay25UnknownPointerNa238b5e0;
            }
        }
        private bool f_overlay25UnknownStructNa238b498;
        private List<byte> _overlay25UnknownStructNa238b498;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay25UnknownStructNa238b498
        {
            get
            {
                if (f_overlay25UnknownStructNa238b498)
                    return _overlay25UnknownStructNa238b498;
                long _pos = m_io.Pos;
                m_io.Seek(4952);
                _overlay25UnknownStructNa238b498 = new List<byte>();
                for (var i = 0; i < 12; i++)
                {
                    _overlay25UnknownStructNa238b498.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay25UnknownStructNa238b498 = true;
                return _overlay25UnknownStructNa238b498;
            }
        }
        private bool f_appraisalWindowParams6;
        private WindowParams _appraisalWindowParams6;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams AppraisalWindowParams6
        {
            get
            {
                if (f_appraisalWindowParams6)
                    return _appraisalWindowParams6;
                long _pos = m_io.Pos;
                m_io.Seek(5172);
                _appraisalWindowParams6 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_appraisalWindowParams6 = true;
                return _appraisalWindowParams6;
            }
        }
        private bool f_appraisalWindowParams8;
        private WindowParams _appraisalWindowParams8;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams AppraisalWindowParams8
        {
            get
            {
                if (f_appraisalWindowParams8)
                    return _appraisalWindowParams8;
                long _pos = m_io.Pos;
                m_io.Seek(5204);
                _appraisalWindowParams8 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_appraisalWindowParams8 = true;
                return _appraisalWindowParams8;
            }
        }
        private bool f_appraisalWindowParams5;
        private WindowParams _appraisalWindowParams5;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams AppraisalWindowParams5
        {
            get
            {
                if (f_appraisalWindowParams5)
                    return _appraisalWindowParams5;
                long _pos = m_io.Pos;
                m_io.Seek(5156);
                _appraisalWindowParams5 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_appraisalWindowParams5 = true;
                return _appraisalWindowParams5;
            }
        }
        private bool f_appraisalMenuItemsConfirm;
        private AppraisalMenuItemsConfirmArray _appraisalMenuItemsConfirm;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public AppraisalMenuItemsConfirmArray AppraisalMenuItemsConfirm
        {
            get
            {
                if (f_appraisalMenuItemsConfirm)
                    return _appraisalMenuItemsConfirm;
                long _pos = m_io.Pos;
                m_io.Seek(4980);
                _appraisalMenuItemsConfirm = new AppraisalMenuItemsConfirmArray(m_io);
                m_io.Seek(_pos);
                f_appraisalMenuItemsConfirm = true;
                return _appraisalMenuItemsConfirm;
            }
        }
        private bool f_overlay25ReservedSpace;
        private List<byte> _overlay25ReservedSpace;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay25ReservedSpace
        {
            get
            {
                if (f_overlay25ReservedSpace)
                    return _overlay25ReservedSpace;
                long _pos = m_io.Pos;
                m_io.Seek(5252);
                _overlay25ReservedSpace = new List<byte>();
                for (var i = 0; i < 28; i++)
                {
                    _overlay25ReservedSpace.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay25ReservedSpace = true;
                return _overlay25ReservedSpace;
            }
        }
        private bool f_appraisalWindowParams2;
        private WindowParams _appraisalWindowParams2;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams AppraisalWindowParams2
        {
            get
            {
                if (f_appraisalWindowParams2)
                    return _appraisalWindowParams2;
                long _pos = m_io.Pos;
                m_io.Seek(5108);
                _appraisalWindowParams2 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_appraisalWindowParams2 = true;
                return _appraisalWindowParams2;
            }
        }
        private bool f_appraisalWindowParams4;
        private WindowParams _appraisalWindowParams4;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams AppraisalWindowParams4
        {
            get
            {
                if (f_appraisalWindowParams4)
                    return _appraisalWindowParams4;
                long _pos = m_io.Pos;
                m_io.Seek(5140);
                _appraisalWindowParams4 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_appraisalWindowParams4 = true;
                return _appraisalWindowParams4;
            }
        }
        private Overlay25Data m_root;
        private KaitaiStruct m_parent;
        public Overlay25Data M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
