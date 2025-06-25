// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents a struct or union visibility_flags defined within pmdsky-debug.
    /// </summary>
    public partial class VisibilityFlags : KaitaiStruct
    {
        public static VisibilityFlags FromFile(string fileName)
        {
            return new VisibilityFlags(new KaitaiStream(fileName));
        }

        public VisibilityFlags(KaitaiStream p__io, KaitaiStruct p__parent = null, VisibilityFlags p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _fRevealed = m_io.ReadBitsIntLe(1) != 0;
            _fVisited = m_io.ReadBitsIntLe(1) != 0;
            _visibilityFlagsUnk2 = m_io.ReadBitsIntLe(14);
        }
        private bool _fRevealed;
        private bool _fVisited;
        private ulong _visibilityFlagsUnk2;
        private VisibilityFlags m_root;
        private KaitaiStruct m_parent;
        public bool FRevealed { get { return _fRevealed; } }
        public bool FVisited { get { return _fVisited; } }
        public ulong VisibilityFlagsUnk2 { get { return _visibilityFlagsUnk2; } }
        public VisibilityFlags M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
