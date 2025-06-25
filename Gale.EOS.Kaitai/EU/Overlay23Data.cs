// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{
    public partial class Overlay23Data : KaitaiStruct
    {
        public static Overlay23Data FromFile(string fileName)
        {
            return new Overlay23Data(new KaitaiStream(fileName));
        }

        public Overlay23Data(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay23Data p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_storageMainMenuItems3 = false;
            f_storageWindowParams6 = false;
            f_storageMainMenuItems4 = false;
            f_storageMainMenuItems1 = false;
            f_storageWindowParams5 = false;
            f_storageMenuItemsConfirm = false;
            f_storageWindowParams4 = false;
            f_storageMainMenuItems2 = false;
            f_storageWindowParams8 = false;
            f_storageWindowParams7 = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_storageMainMenuItems3;
        private StorageMainMenuItems3Array _storageMainMenuItems3;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public StorageMainMenuItems3Array StorageMainMenuItems3
        {
            get
            {
                if (f_storageMainMenuItems3)
                    return _storageMainMenuItems3;
                long _pos = m_io.Pos;
                m_io.Seek(12820);
                _storageMainMenuItems3 = new StorageMainMenuItems3Array(m_io);
                m_io.Seek(_pos);
                f_storageMainMenuItems3 = true;
                return _storageMainMenuItems3;
            }
        }
        private bool f_storageWindowParams6;
        private WindowParams _storageWindowParams6;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams StorageWindowParams6
        {
            get
            {
                if (f_storageWindowParams6)
                    return _storageWindowParams6;
                long _pos = m_io.Pos;
                m_io.Seek(13016);
                _storageWindowParams6 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_storageWindowParams6 = true;
                return _storageWindowParams6;
            }
        }
        private bool f_storageMainMenuItems4;
        private StorageMainMenuItems4Array _storageMainMenuItems4;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public StorageMainMenuItems4Array StorageMainMenuItems4
        {
            get
            {
                if (f_storageMainMenuItems4)
                    return _storageMainMenuItems4;
                long _pos = m_io.Pos;
                m_io.Seek(12852);
                _storageMainMenuItems4 = new StorageMainMenuItems4Array(m_io);
                m_io.Seek(_pos);
                f_storageMainMenuItems4 = true;
                return _storageMainMenuItems4;
            }
        }
        private bool f_storageMainMenuItems1;
        private StorageMainMenuItems1Array _storageMainMenuItems1;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public StorageMainMenuItems1Array StorageMainMenuItems1
        {
            get
            {
                if (f_storageMainMenuItems1)
                    return _storageMainMenuItems1;
                long _pos = m_io.Pos;
                m_io.Seek(12756);
                _storageMainMenuItems1 = new StorageMainMenuItems1Array(m_io);
                m_io.Seek(_pos);
                f_storageMainMenuItems1 = true;
                return _storageMainMenuItems1;
            }
        }
        private bool f_storageWindowParams5;
        private WindowParams _storageWindowParams5;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams StorageWindowParams5
        {
            get
            {
                if (f_storageWindowParams5)
                    return _storageWindowParams5;
                long _pos = m_io.Pos;
                m_io.Seek(13000);
                _storageWindowParams5 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_storageWindowParams5 = true;
                return _storageWindowParams5;
            }
        }
        private bool f_storageMenuItemsConfirm;
        private StorageMenuItemsConfirmArray _storageMenuItemsConfirm;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public StorageMenuItemsConfirmArray StorageMenuItemsConfirm
        {
            get
            {
                if (f_storageMenuItemsConfirm)
                    return _storageMenuItemsConfirm;
                long _pos = m_io.Pos;
                m_io.Seek(12732);
                _storageMenuItemsConfirm = new StorageMenuItemsConfirmArray(m_io);
                m_io.Seek(_pos);
                f_storageMenuItemsConfirm = true;
                return _storageMenuItemsConfirm;
            }
        }
        private bool f_storageWindowParams4;
        private WindowParams _storageWindowParams4;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams StorageWindowParams4
        {
            get
            {
                if (f_storageWindowParams4)
                    return _storageWindowParams4;
                long _pos = m_io.Pos;
                m_io.Seek(12984);
                _storageWindowParams4 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_storageWindowParams4 = true;
                return _storageWindowParams4;
            }
        }
        private bool f_storageMainMenuItems2;
        private StorageMainMenuItems2Array _storageMainMenuItems2;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public StorageMainMenuItems2Array StorageMainMenuItems2
        {
            get
            {
                if (f_storageMainMenuItems2)
                    return _storageMainMenuItems2;
                long _pos = m_io.Pos;
                m_io.Seek(12788);
                _storageMainMenuItems2 = new StorageMainMenuItems2Array(m_io);
                m_io.Seek(_pos);
                f_storageMainMenuItems2 = true;
                return _storageMainMenuItems2;
            }
        }
        private bool f_storageWindowParams8;
        private WindowParams _storageWindowParams8;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams StorageWindowParams8
        {
            get
            {
                if (f_storageWindowParams8)
                    return _storageWindowParams8;
                long _pos = m_io.Pos;
                m_io.Seek(13048);
                _storageWindowParams8 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_storageWindowParams8 = true;
                return _storageWindowParams8;
            }
        }
        private bool f_storageWindowParams7;
        private WindowParams _storageWindowParams7;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams StorageWindowParams7
        {
            get
            {
                if (f_storageWindowParams7)
                    return _storageWindowParams7;
                long _pos = m_io.Pos;
                m_io.Seek(13032);
                _storageWindowParams7 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_storageWindowParams7 = true;
                return _storageWindowParams7;
            }
        }
        private Overlay23Data m_root;
        private KaitaiStruct m_parent;
        public Overlay23Data M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
