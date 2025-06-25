// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
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
            f_evoMainMenuItems = false;
            f_evoMenuItemsConfirm = false;
            f_evoWindowParams5 = false;
            f_evoSubmenuItems = false;
            f_evoWindowParams6 = false;
            f_evoWindowParams4 = false;
            _read();
        }
        private void _read()
        {
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
                m_io.Seek(11296);
                _evoMainMenuItems = new EvoMainMenuItemsArray(m_io);
                m_io.Seek(_pos);
                f_evoMainMenuItems = true;
                return _evoMainMenuItems;
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
                m_io.Seek(11240);
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
                m_io.Seek(11444);
                _evoWindowParams5 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_evoWindowParams5 = true;
                return _evoWindowParams5;
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
                m_io.Seek(11264);
                _evoSubmenuItems = new EvoSubmenuItemsArray(m_io);
                m_io.Seek(_pos);
                f_evoSubmenuItems = true;
                return _evoSubmenuItems;
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
                m_io.Seek(11460);
                _evoWindowParams6 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_evoWindowParams6 = true;
                return _evoWindowParams6;
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
                m_io.Seek(11428);
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
