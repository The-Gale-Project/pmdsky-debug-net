// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents a struct or union main_ground_data defined within pmdsky-debug.
    /// </summary>
    public partial class MainGroundData : KaitaiStruct
    {
        public static MainGroundData FromFile(string fileName)
        {
            return new MainGroundData(new KaitaiStream(fileName));
        }

        public MainGroundData(KaitaiStream p__io, KaitaiStruct p__parent = null, MainGroundData p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _mainRoutine = new Pointer(m_io);
            _partnerFollowData = new Pointer(m_io);
            _actors = new Pointer(m_io);
            _objects = new Pointer(m_io);
            _performers = new Pointer(m_io);
            _events = new Pointer(m_io);
        }
        private Pointer _mainRoutine;
        private Pointer _partnerFollowData;
        private Pointer _actors;
        private Pointer _objects;
        private Pointer _performers;
        private Pointer _events;
        private MainGroundData m_root;
        private KaitaiStruct m_parent;
        public Pointer MainRoutine { get { return _mainRoutine; } }
        public Pointer PartnerFollowData { get { return _partnerFollowData; } }
        public Pointer Actors { get { return _actors; } }
        public Pointer Objects { get { return _objects; } }
        public Pointer Performers { get { return _performers; } }
        public Pointer Events { get { return _events; } }
        public MainGroundData M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
