// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
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
            f_appraisalSubmenuItems = false;
            f_appraisalWindowParams7 = false;
            f_appraisalWindowParams6 = false;
            f_appraisalWindowParams8 = false;
            f_appraisalWindowParams5 = false;
            f_appraisalMenuItemsConfirm = false;
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
        private Overlay25Data m_root;
        private KaitaiStruct m_parent;
        public Overlay25Data M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
