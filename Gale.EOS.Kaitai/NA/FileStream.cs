// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union file_stream defined within pmdsky-debug.
    /// </summary>
    public partial class FileStream : KaitaiStruct
    {
        public static FileStream FromFile(string fileName)
        {
            return new FileStream(new KaitaiStream(fileName));
        }

        public FileStream(KaitaiStream p__io, KaitaiStruct p__parent = null, FileStream p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _field0x0 = m_io.ReadU4le();
            _field0x4 = m_io.ReadU4le();
            _field0x8 = m_io.ReadU4le();
            _field0xc = m_io.ReadU4le();
            _field0x10 = m_io.ReadU4le();
            _field0x14 = m_io.ReadU4le();
            _field0x18 = m_io.ReadU4le();
            _field0x1c = m_io.ReadU4le();
            _field0x20 = m_io.ReadU4le();
            _startAddress = new Pointer(m_io);
            _endAddress = new Pointer(m_io);
            _currentAddress = new Pointer(m_io);
            _field0x30 = m_io.ReadU4le();
            _field0x34 = m_io.ReadU4le();
            _field0x38 = m_io.ReadU4le();
            _field0x3c = m_io.ReadU4le();
            _field0x40 = m_io.ReadU4le();
            _field0x44 = m_io.ReadU4le();
        }
        private uint _field0x0;
        private uint _field0x4;
        private uint _field0x8;
        private uint _field0xc;
        private uint _field0x10;
        private uint _field0x14;
        private uint _field0x18;
        private uint _field0x1c;
        private uint _field0x20;
        private Pointer _startAddress;
        private Pointer _endAddress;
        private Pointer _currentAddress;
        private uint _field0x30;
        private uint _field0x34;
        private uint _field0x38;
        private uint _field0x3c;
        private uint _field0x40;
        private uint _field0x44;
        private FileStream m_root;
        private KaitaiStruct m_parent;
        public uint Field0x0 { get { return _field0x0; } }
        public uint Field0x4 { get { return _field0x4; } }
        public uint Field0x8 { get { return _field0x8; } }
        public uint Field0xc { get { return _field0xc; } }
        public uint Field0x10 { get { return _field0x10; } }
        public uint Field0x14 { get { return _field0x14; } }
        public uint Field0x18 { get { return _field0x18; } }
        public uint Field0x1c { get { return _field0x1c; } }
        public uint Field0x20 { get { return _field0x20; } }
        public Pointer StartAddress { get { return _startAddress; } }
        public Pointer EndAddress { get { return _endAddress; } }
        public Pointer CurrentAddress { get { return _currentAddress; } }
        public uint Field0x30 { get { return _field0x30; } }
        public uint Field0x34 { get { return _field0x34; } }
        public uint Field0x38 { get { return _field0x38; } }
        public uint Field0x3c { get { return _field0x3c; } }
        public uint Field0x40 { get { return _field0x40; } }
        public uint Field0x44 { get { return _field0x44; } }
        public FileStream M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
