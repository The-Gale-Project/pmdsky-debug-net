// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union portrait_layout defined within pmdsky-debug.
    /// </summary>
    public partial class PortraitLayout : KaitaiStruct
    {
        public static PortraitLayout FromFile(string fileName)
        {
            return new PortraitLayout(new KaitaiStream(fileName));
        }

        public PortraitLayout(KaitaiStream p__io, KaitaiStruct p__parent = null, PortraitLayout p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _offsetX = m_io.ReadS2le();
            _offsetY = m_io.ReadS2le();
            _tryFlip = m_io.ReadU1();
            _padding = m_io.ReadU1();
        }
        private short _offsetX;
        private short _offsetY;
        private byte _tryFlip;
        private byte _padding;
        private PortraitLayout m_root;
        private KaitaiStruct m_parent;
        public short OffsetX { get { return _offsetX; } }
        public short OffsetY { get { return _offsetY; } }
        public byte TryFlip { get { return _tryFlip; } }
        public byte Padding { get { return _padding; } }
        public PortraitLayout M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
