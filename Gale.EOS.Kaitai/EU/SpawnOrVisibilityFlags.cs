// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union spawn_or_visibility_flags defined within pmdsky-debug.
    /// </summary>
    public partial class SpawnOrVisibilityFlags : KaitaiStruct
    {
        public static SpawnOrVisibilityFlags FromFile(string fileName)
        {
            return new SpawnOrVisibilityFlags(new KaitaiStream(fileName));
        }

        public SpawnOrVisibilityFlags(KaitaiStream p__io, KaitaiStruct p__parent = null, SpawnOrVisibilityFlags p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _spawn = new SpawnFlags(m_io);
            _visibility = new VisibilityFlags(m_io);
        }
        private SpawnFlags _spawn;
        private VisibilityFlags _visibility;
        private SpawnOrVisibilityFlags m_root;
        private KaitaiStruct m_parent;
        public SpawnFlags Spawn { get { return _spawn; } }
        public VisibilityFlags Visibility { get { return _visibility; } }
        public SpawnOrVisibilityFlags M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
