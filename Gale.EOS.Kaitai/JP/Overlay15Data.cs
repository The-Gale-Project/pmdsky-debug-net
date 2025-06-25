// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
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
            f_bankMainMenuItems = false;
            f_bankWindowParams2 = false;
            f_bankWindowParams3 = false;
            f_bankWindowParams4 = false;
            _read();
        }
        private void _read()
        {
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
                m_io.Seek(3884);
                _bankMainMenuItems = new BankMainMenuItemsArray(m_io);
                m_io.Seek(_pos);
                f_bankMainMenuItems = true;
                return _bankMainMenuItems;
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
                m_io.Seek(3940);
                _bankWindowParams2 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_bankWindowParams2 = true;
                return _bankWindowParams2;
            }
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
                m_io.Seek(3956);
                _bankWindowParams3 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_bankWindowParams3 = true;
                return _bankWindowParams3;
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
                m_io.Seek(3972);
                _bankWindowParams4 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_bankWindowParams4 = true;
                return _bankWindowParams4;
            }
        }
        private Overlay15Data m_root;
        private KaitaiStruct m_parent;
        public Overlay15Data M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
