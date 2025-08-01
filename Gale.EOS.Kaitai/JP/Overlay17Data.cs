// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{
    public partial class Overlay17Data : KaitaiStruct
    {
        public static Overlay17Data FromFile(string fileName)
        {
            return new Overlay17Data(new KaitaiStream(fileName));
        }

        public Overlay17Data(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay17Data p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_assemblyMainMenuItems1 = false;
            f_assemblyMenuItemsConfirm = false;
            f_assemblyWindowParams4 = false;
            f_assemblySubmenuItems7 = false;
            f_assemblySubmenuItems3 = false;
            f_assemblySubmenuItems6 = false;
            f_assemblySubmenuItems2 = false;
            f_assemblyWindowParams1 = false;
            f_assemblyWindowParams2 = false;
            f_assemblySubmenuItems1 = false;
            f_assemblyWindowParams3 = false;
            f_assemblyWindowParams5 = false;
            f_overlay17FunctionPointerTable = false;
            f_assemblySubmenuItems5 = false;
            f_assemblyMainMenuItems2 = false;
            f_assemblySubmenuItems4 = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_assemblyMainMenuItems1;
        private AssemblyMainMenuItems1Array _assemblyMainMenuItems1;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public AssemblyMainMenuItems1Array AssemblyMainMenuItems1
        {
            get
            {
                if (f_assemblyMainMenuItems1)
                    return _assemblyMainMenuItems1;
                long _pos = m_io.Pos;
                m_io.Seek(6744);
                _assemblyMainMenuItems1 = new AssemblyMainMenuItems1Array(m_io);
                m_io.Seek(_pos);
                f_assemblyMainMenuItems1 = true;
                return _assemblyMainMenuItems1;
            }
        }
        private bool f_assemblyMenuItemsConfirm;
        private AssemblyMenuItemsConfirmArray _assemblyMenuItemsConfirm;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public AssemblyMenuItemsConfirmArray AssemblyMenuItemsConfirm
        {
            get
            {
                if (f_assemblyMenuItemsConfirm)
                    return _assemblyMenuItemsConfirm;
                long _pos = m_io.Pos;
                m_io.Seek(6720);
                _assemblyMenuItemsConfirm = new AssemblyMenuItemsConfirmArray(m_io);
                m_io.Seek(_pos);
                f_assemblyMenuItemsConfirm = true;
                return _assemblyMenuItemsConfirm;
            }
        }
        private bool f_assemblyWindowParams4;
        private WindowParams _assemblyWindowParams4;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams AssemblyWindowParams4
        {
            get
            {
                if (f_assemblyWindowParams4)
                    return _assemblyWindowParams4;
                long _pos = m_io.Pos;
                m_io.Seek(6688);
                _assemblyWindowParams4 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_assemblyWindowParams4 = true;
                return _assemblyWindowParams4;
            }
        }
        private bool f_assemblySubmenuItems7;
        private AssemblySubmenuItems7Array _assemblySubmenuItems7;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public AssemblySubmenuItems7Array AssemblySubmenuItems7
        {
            get
            {
                if (f_assemblySubmenuItems7)
                    return _assemblySubmenuItems7;
                long _pos = m_io.Pos;
                m_io.Seek(7104);
                _assemblySubmenuItems7 = new AssemblySubmenuItems7Array(m_io);
                m_io.Seek(_pos);
                f_assemblySubmenuItems7 = true;
                return _assemblySubmenuItems7;
            }
        }
        private bool f_assemblySubmenuItems3;
        private AssemblySubmenuItems3Array _assemblySubmenuItems3;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public AssemblySubmenuItems3Array AssemblySubmenuItems3
        {
            get
            {
                if (f_assemblySubmenuItems3)
                    return _assemblySubmenuItems3;
                long _pos = m_io.Pos;
                m_io.Seek(6888);
                _assemblySubmenuItems3 = new AssemblySubmenuItems3Array(m_io);
                m_io.Seek(_pos);
                f_assemblySubmenuItems3 = true;
                return _assemblySubmenuItems3;
            }
        }
        private bool f_assemblySubmenuItems6;
        private AssemblySubmenuItems6Array _assemblySubmenuItems6;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public AssemblySubmenuItems6Array AssemblySubmenuItems6
        {
            get
            {
                if (f_assemblySubmenuItems6)
                    return _assemblySubmenuItems6;
                long _pos = m_io.Pos;
                m_io.Seek(7048);
                _assemblySubmenuItems6 = new AssemblySubmenuItems6Array(m_io);
                m_io.Seek(_pos);
                f_assemblySubmenuItems6 = true;
                return _assemblySubmenuItems6;
            }
        }
        private bool f_assemblySubmenuItems2;
        private AssemblySubmenuItems2Array _assemblySubmenuItems2;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public AssemblySubmenuItems2Array AssemblySubmenuItems2
        {
            get
            {
                if (f_assemblySubmenuItems2)
                    return _assemblySubmenuItems2;
                long _pos = m_io.Pos;
                m_io.Seek(6840);
                _assemblySubmenuItems2 = new AssemblySubmenuItems2Array(m_io);
                m_io.Seek(_pos);
                f_assemblySubmenuItems2 = true;
                return _assemblySubmenuItems2;
            }
        }
        private bool f_assemblyWindowParams1;
        private WindowParams _assemblyWindowParams1;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams AssemblyWindowParams1
        {
            get
            {
                if (f_assemblyWindowParams1)
                    return _assemblyWindowParams1;
                long _pos = m_io.Pos;
                m_io.Seek(6640);
                _assemblyWindowParams1 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_assemblyWindowParams1 = true;
                return _assemblyWindowParams1;
            }
        }
        private bool f_assemblyWindowParams2;
        private WindowParams _assemblyWindowParams2;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams AssemblyWindowParams2
        {
            get
            {
                if (f_assemblyWindowParams2)
                    return _assemblyWindowParams2;
                long _pos = m_io.Pos;
                m_io.Seek(6656);
                _assemblyWindowParams2 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_assemblyWindowParams2 = true;
                return _assemblyWindowParams2;
            }
        }
        private bool f_assemblySubmenuItems1;
        private AssemblySubmenuItems1Array _assemblySubmenuItems1;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public AssemblySubmenuItems1Array AssemblySubmenuItems1
        {
            get
            {
                if (f_assemblySubmenuItems1)
                    return _assemblySubmenuItems1;
                long _pos = m_io.Pos;
                m_io.Seek(6800);
                _assemblySubmenuItems1 = new AssemblySubmenuItems1Array(m_io);
                m_io.Seek(_pos);
                f_assemblySubmenuItems1 = true;
                return _assemblySubmenuItems1;
            }
        }
        private bool f_assemblyWindowParams3;
        private WindowParams _assemblyWindowParams3;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams AssemblyWindowParams3
        {
            get
            {
                if (f_assemblyWindowParams3)
                    return _assemblyWindowParams3;
                long _pos = m_io.Pos;
                m_io.Seek(6672);
                _assemblyWindowParams3 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_assemblyWindowParams3 = true;
                return _assemblyWindowParams3;
            }
        }
        private bool f_assemblyWindowParams5;
        private WindowParams _assemblyWindowParams5;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams AssemblyWindowParams5
        {
            get
            {
                if (f_assemblyWindowParams5)
                    return _assemblyWindowParams5;
                long _pos = m_io.Pos;
                m_io.Seek(6704);
                _assemblyWindowParams5 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_assemblyWindowParams5 = true;
                return _assemblyWindowParams5;
            }
        }
        private bool f_overlay17FunctionPointerTable;
        private Overlay17FunctionPointerTableArray _overlay17FunctionPointerTable;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public Overlay17FunctionPointerTableArray Overlay17FunctionPointerTable
        {
            get
            {
                if (f_overlay17FunctionPointerTable)
                    return _overlay17FunctionPointerTable;
                long _pos = m_io.Pos;
                m_io.Seek(7168);
                _overlay17FunctionPointerTable = new Overlay17FunctionPointerTableArray(m_io);
                m_io.Seek(_pos);
                f_overlay17FunctionPointerTable = true;
                return _overlay17FunctionPointerTable;
            }
        }
        private bool f_assemblySubmenuItems5;
        private AssemblySubmenuItems5Array _assemblySubmenuItems5;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public AssemblySubmenuItems5Array AssemblySubmenuItems5
        {
            get
            {
                if (f_assemblySubmenuItems5)
                    return _assemblySubmenuItems5;
                long _pos = m_io.Pos;
                m_io.Seek(6992);
                _assemblySubmenuItems5 = new AssemblySubmenuItems5Array(m_io);
                m_io.Seek(_pos);
                f_assemblySubmenuItems5 = true;
                return _assemblySubmenuItems5;
            }
        }
        private bool f_assemblyMainMenuItems2;
        private AssemblyMainMenuItems2Array _assemblyMainMenuItems2;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public AssemblyMainMenuItems2Array AssemblyMainMenuItems2
        {
            get
            {
                if (f_assemblyMainMenuItems2)
                    return _assemblyMainMenuItems2;
                long _pos = m_io.Pos;
                m_io.Seek(6768);
                _assemblyMainMenuItems2 = new AssemblyMainMenuItems2Array(m_io);
                m_io.Seek(_pos);
                f_assemblyMainMenuItems2 = true;
                return _assemblyMainMenuItems2;
            }
        }
        private bool f_assemblySubmenuItems4;
        private AssemblySubmenuItems4Array _assemblySubmenuItems4;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public AssemblySubmenuItems4Array AssemblySubmenuItems4
        {
            get
            {
                if (f_assemblySubmenuItems4)
                    return _assemblySubmenuItems4;
                long _pos = m_io.Pos;
                m_io.Seek(6936);
                _assemblySubmenuItems4 = new AssemblySubmenuItems4Array(m_io);
                m_io.Seek(_pos);
                f_assemblySubmenuItems4 = true;
                return _assemblySubmenuItems4;
            }
        }
        private Overlay17Data m_root;
        private KaitaiStruct m_parent;
        public Overlay17Data M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
