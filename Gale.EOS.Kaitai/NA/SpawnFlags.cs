// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union spawn_flags defined within pmdsky-debug.
    /// </summary>
    public partial class SpawnFlags : KaitaiStruct
    {
        public static SpawnFlags FromFile(string fileName)
        {
            return new SpawnFlags(new KaitaiStream(fileName));
        }

        public SpawnFlags(KaitaiStream p__io, KaitaiStruct p__parent = null, SpawnFlags p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _fStairs = m_io.ReadBitsIntLe(1) != 0;
            _fItem = m_io.ReadBitsIntLe(1) != 0;
            _fTrap = m_io.ReadBitsIntLe(1) != 0;
            _fMonster = m_io.ReadBitsIntLe(1) != 0;
            _spawnFlagsUnk4 = m_io.ReadBitsIntLe(12);
        }
        private bool _fStairs;
        private bool _fItem;
        private bool _fTrap;
        private bool _fMonster;
        private ulong _spawnFlagsUnk4;
        private SpawnFlags m_root;
        private KaitaiStruct m_parent;
        public bool FStairs { get { return _fStairs; } }
        public bool FItem { get { return _fItem; } }
        public bool FTrap { get { return _fTrap; } }
        public bool FMonster { get { return _fMonster; } }
        public ulong SpawnFlagsUnk4 { get { return _spawnFlagsUnk4; } }
        public SpawnFlags M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
