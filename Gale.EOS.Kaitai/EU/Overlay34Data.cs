// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{
    public partial class Overlay34Data : KaitaiStruct
    {
        public static Overlay34Data FromFile(string fileName)
        {
            return new Overlay34Data(new KaitaiStream(fileName));
        }

        public Overlay34Data(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay34Data p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_startMenuItemsConfirm = false;
            f_dungeonDebugMenuItems = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_startMenuItemsConfirm;
        private StartMenuItemsConfirmArray _startMenuItemsConfirm;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public StartMenuItemsConfirmArray StartMenuItemsConfirm
        {
            get
            {
                if (f_startMenuItemsConfirm)
                    return _startMenuItemsConfirm;
                long _pos = m_io.Pos;
                m_io.Seek(3404);
                _startMenuItemsConfirm = new StartMenuItemsConfirmArray(m_io);
                m_io.Seek(_pos);
                f_startMenuItemsConfirm = true;
                return _startMenuItemsConfirm;
            }
        }
        private bool f_dungeonDebugMenuItems;
        private DungeonDebugMenuItemsArray _dungeonDebugMenuItems;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public DungeonDebugMenuItemsArray DungeonDebugMenuItems
        {
            get
            {
                if (f_dungeonDebugMenuItems)
                    return _dungeonDebugMenuItems;
                long _pos = m_io.Pos;
                m_io.Seek(3444);
                _dungeonDebugMenuItems = new DungeonDebugMenuItemsArray(m_io);
                m_io.Seek(_pos);
                f_dungeonDebugMenuItems = true;
                return _dungeonDebugMenuItems;
            }
        }
        private Overlay34Data m_root;
        private KaitaiStruct m_parent;
        public Overlay34Data M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
