// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union overlay_load_entry defined within pmdsky-debug.
    /// </summary>
    public partial class OverlayLoadEntry : KaitaiStruct
    {
        public static OverlayLoadEntry FromFile(string fileName)
        {
            return new OverlayLoadEntry(new KaitaiStream(fileName));
        }

        public OverlayLoadEntry(KaitaiStream p__io, KaitaiStruct p__parent = null, OverlayLoadEntry p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _group = new OverlayGroupId(m_io);
            _entrypoint = new Pointer(m_io);
            _destructor = new Pointer(m_io);
            _frameUpdate = new Pointer(m_io);
        }
        private OverlayGroupId _group;
        private Pointer _entrypoint;
        private Pointer _destructor;
        private Pointer _frameUpdate;
        private OverlayLoadEntry m_root;
        private KaitaiStruct m_parent;
        public OverlayGroupId Group { get { return _group; } }
        public Pointer Entrypoint { get { return _entrypoint; } }
        public Pointer Destructor { get { return _destructor; } }
        public Pointer FrameUpdate { get { return _frameUpdate; } }
        public OverlayLoadEntry M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
