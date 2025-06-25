// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union touchscreen_status defined within pmdsky-debug.
    /// </summary>
    public partial class TouchscreenStatus : KaitaiStruct
    {
        public static TouchscreenStatus FromFile(string fileName)
        {
            return new TouchscreenStatus(new KaitaiStream(fileName));
        }

        public TouchscreenStatus(KaitaiStream p__io, KaitaiStruct p__parent = null, TouchscreenStatus p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _currentPosition = new TouchscreenPosition(m_io);
            _field0xc = m_io.ReadU1();
            _field0xd = m_io.ReadU1();
            _field0xe = m_io.ReadU1();
            _field0xf = m_io.ReadU1();
            _pressedFrames = m_io.ReadS4le();
            _unpressedFrames = m_io.ReadS4le();
            _xPosMirror = m_io.ReadS4le();
            _yPosMirror = m_io.ReadS4le();
            _lastXPos = m_io.ReadS4le();
            _lastYPos = m_io.ReadS4le();
            _firstXPos = m_io.ReadS4le();
            _firstYPos = m_io.ReadS4le();
            _field0x30 = m_io.ReadU1();
            _field0x31 = m_io.ReadU1();
            _field0x32 = m_io.ReadU1();
            _field0x33 = m_io.ReadU1();
            _field0x34 = m_io.ReadU1();
            _field0x35 = m_io.ReadU1();
            _field0x36 = m_io.ReadU1();
            _field0x37 = m_io.ReadU1();
            _currentPositionMirror = new TouchscreenPosition(m_io);
            _currentPositionMirror1 = new TouchscreenPosition(m_io);
            _currentPositionMirror2 = new TouchscreenPosition(m_io);
            _currentPositionMirror3 = new TouchscreenPosition(m_io);
        }
        private TouchscreenPosition _currentPosition;
        private byte _field0xc;
        private byte _field0xd;
        private byte _field0xe;
        private byte _field0xf;
        private int _pressedFrames;
        private int _unpressedFrames;
        private int _xPosMirror;
        private int _yPosMirror;
        private int _lastXPos;
        private int _lastYPos;
        private int _firstXPos;
        private int _firstYPos;
        private byte _field0x30;
        private byte _field0x31;
        private byte _field0x32;
        private byte _field0x33;
        private byte _field0x34;
        private byte _field0x35;
        private byte _field0x36;
        private byte _field0x37;
        private TouchscreenPosition _currentPositionMirror;
        private TouchscreenPosition _currentPositionMirror1;
        private TouchscreenPosition _currentPositionMirror2;
        private TouchscreenPosition _currentPositionMirror3;
        private TouchscreenStatus m_root;
        private KaitaiStruct m_parent;
        public TouchscreenPosition CurrentPosition { get { return _currentPosition; } }
        public byte Field0xc { get { return _field0xc; } }
        public byte Field0xd { get { return _field0xd; } }
        public byte Field0xe { get { return _field0xe; } }
        public byte Field0xf { get { return _field0xf; } }
        public int PressedFrames { get { return _pressedFrames; } }
        public int UnpressedFrames { get { return _unpressedFrames; } }
        public int XPosMirror { get { return _xPosMirror; } }
        public int YPosMirror { get { return _yPosMirror; } }
        public int LastXPos { get { return _lastXPos; } }
        public int LastYPos { get { return _lastYPos; } }
        public int FirstXPos { get { return _firstXPos; } }
        public int FirstYPos { get { return _firstYPos; } }
        public byte Field0x30 { get { return _field0x30; } }
        public byte Field0x31 { get { return _field0x31; } }
        public byte Field0x32 { get { return _field0x32; } }
        public byte Field0x33 { get { return _field0x33; } }
        public byte Field0x34 { get { return _field0x34; } }
        public byte Field0x35 { get { return _field0x35; } }
        public byte Field0x36 { get { return _field0x36; } }
        public byte Field0x37 { get { return _field0x37; } }
        public TouchscreenPosition CurrentPositionMirror { get { return _currentPositionMirror; } }
        public TouchscreenPosition CurrentPositionMirror1 { get { return _currentPositionMirror1; } }
        public TouchscreenPosition CurrentPositionMirror2 { get { return _currentPositionMirror2; } }
        public TouchscreenPosition CurrentPositionMirror3 { get { return _currentPositionMirror3; } }
        public TouchscreenStatus M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
