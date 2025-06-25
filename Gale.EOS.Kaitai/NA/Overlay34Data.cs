// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
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
            f_overlay34UnknownStructNa22dd03c = false;
            f_overlay34UnknownPointerNa22dd084 = false;
            f_overlay34UnknownPointerNa22dd08c = false;
            f_overlay34ReservedSpace = false;
            f_overlay34UnknownStructNa22dd014 = false;
            f_overlay34UnknownPointerNa22dd088 = false;
            f_dungeonDebugMenuItems = false;
            f_overlay34UnknownPointerNa22dd080 = false;
            f_overlay34UnknownPointerNa22dd090 = false;
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
                m_io.Seek(3556);
                _startMenuItemsConfirm = new StartMenuItemsConfirmArray(m_io);
                m_io.Seek(_pos);
                f_startMenuItemsConfirm = true;
                return _startMenuItemsConfirm;
            }
        }
        private bool f_overlay34UnknownStructNa22dd03c;
        private List<byte> _overlay34UnknownStructNa22dd03c;

        /// <summary>
        /// 1*0x4 + 3*0x4
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay34UnknownStructNa22dd03c
        {
            get
            {
                if (f_overlay34UnknownStructNa22dd03c)
                    return _overlay34UnknownStructNa22dd03c;
                long _pos = m_io.Pos;
                m_io.Seek(3580);
                _overlay34UnknownStructNa22dd03c = new List<byte>();
                for (var i = 0; i < 16; i++)
                {
                    _overlay34UnknownStructNa22dd03c.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay34UnknownStructNa22dd03c = true;
                return _overlay34UnknownStructNa22dd03c;
            }
        }
        private bool f_overlay34UnknownPointerNa22dd084;
        private List<byte> _overlay34UnknownPointerNa22dd084;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay34UnknownPointerNa22dd084
        {
            get
            {
                if (f_overlay34UnknownPointerNa22dd084)
                    return _overlay34UnknownPointerNa22dd084;
                long _pos = m_io.Pos;
                m_io.Seek(3652);
                _overlay34UnknownPointerNa22dd084 = new List<byte>();
                for (var i = 0; i < 4; i++)
                {
                    _overlay34UnknownPointerNa22dd084.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay34UnknownPointerNa22dd084 = true;
                return _overlay34UnknownPointerNa22dd084;
            }
        }
        private bool f_overlay34UnknownPointerNa22dd08c;
        private List<byte> _overlay34UnknownPointerNa22dd08c;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay34UnknownPointerNa22dd08c
        {
            get
            {
                if (f_overlay34UnknownPointerNa22dd08c)
                    return _overlay34UnknownPointerNa22dd08c;
                long _pos = m_io.Pos;
                m_io.Seek(3660);
                _overlay34UnknownPointerNa22dd08c = new List<byte>();
                for (var i = 0; i < 4; i++)
                {
                    _overlay34UnknownPointerNa22dd08c.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay34UnknownPointerNa22dd08c = true;
                return _overlay34UnknownPointerNa22dd08c;
            }
        }
        private bool f_overlay34ReservedSpace;
        private List<byte> _overlay34ReservedSpace;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay34ReservedSpace
        {
            get
            {
                if (f_overlay34ReservedSpace)
                    return _overlay34ReservedSpace;
                long _pos = m_io.Pos;
                m_io.Seek(3636);
                _overlay34ReservedSpace = new List<byte>();
                for (var i = 0; i < 12; i++)
                {
                    _overlay34ReservedSpace.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay34ReservedSpace = true;
                return _overlay34ReservedSpace;
            }
        }
        private bool f_overlay34UnknownStructNa22dd014;
        private List<byte> _overlay34UnknownStructNa22dd014;

        /// <summary>
        /// 1*0x4 + 3*0x4
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay34UnknownStructNa22dd014
        {
            get
            {
                if (f_overlay34UnknownStructNa22dd014)
                    return _overlay34UnknownStructNa22dd014;
                long _pos = m_io.Pos;
                m_io.Seek(3540);
                _overlay34UnknownStructNa22dd014 = new List<byte>();
                for (var i = 0; i < 16; i++)
                {
                    _overlay34UnknownStructNa22dd014.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay34UnknownStructNa22dd014 = true;
                return _overlay34UnknownStructNa22dd014;
            }
        }
        private bool f_overlay34UnknownPointerNa22dd088;
        private List<byte> _overlay34UnknownPointerNa22dd088;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay34UnknownPointerNa22dd088
        {
            get
            {
                if (f_overlay34UnknownPointerNa22dd088)
                    return _overlay34UnknownPointerNa22dd088;
                long _pos = m_io.Pos;
                m_io.Seek(3656);
                _overlay34UnknownPointerNa22dd088 = new List<byte>();
                for (var i = 0; i < 4; i++)
                {
                    _overlay34UnknownPointerNa22dd088.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay34UnknownPointerNa22dd088 = true;
                return _overlay34UnknownPointerNa22dd088;
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
                m_io.Seek(3596);
                _dungeonDebugMenuItems = new DungeonDebugMenuItemsArray(m_io);
                m_io.Seek(_pos);
                f_dungeonDebugMenuItems = true;
                return _dungeonDebugMenuItems;
            }
        }
        private bool f_overlay34UnknownPointerNa22dd080;
        private List<byte> _overlay34UnknownPointerNa22dd080;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay34UnknownPointerNa22dd080
        {
            get
            {
                if (f_overlay34UnknownPointerNa22dd080)
                    return _overlay34UnknownPointerNa22dd080;
                long _pos = m_io.Pos;
                m_io.Seek(3648);
                _overlay34UnknownPointerNa22dd080 = new List<byte>();
                for (var i = 0; i < 4; i++)
                {
                    _overlay34UnknownPointerNa22dd080.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay34UnknownPointerNa22dd080 = true;
                return _overlay34UnknownPointerNa22dd080;
            }
        }
        private bool f_overlay34UnknownPointerNa22dd090;
        private List<byte> _overlay34UnknownPointerNa22dd090;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay34UnknownPointerNa22dd090
        {
            get
            {
                if (f_overlay34UnknownPointerNa22dd090)
                    return _overlay34UnknownPointerNa22dd090;
                long _pos = m_io.Pos;
                m_io.Seek(3664);
                _overlay34UnknownPointerNa22dd090 = new List<byte>();
                for (var i = 0; i < 4; i++)
                {
                    _overlay34UnknownPointerNa22dd090.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay34UnknownPointerNa22dd090 = true;
                return _overlay34UnknownPointerNa22dd090;
            }
        }
        private Overlay34Data m_root;
        private KaitaiStruct m_parent;
        public Overlay34Data M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
