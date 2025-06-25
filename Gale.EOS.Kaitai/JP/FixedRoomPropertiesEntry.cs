// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents a struct or union fixed_room_properties_entry defined within pmdsky-debug.
    /// </summary>
    public partial class FixedRoomPropertiesEntry : KaitaiStruct
    {
        public static FixedRoomPropertiesEntry FromFile(string fileName)
        {
            return new FixedRoomPropertiesEntry(new KaitaiStream(fileName));
        }

        public FixedRoomPropertiesEntry(KaitaiStream p__io, KaitaiStruct p__parent = null, FixedRoomPropertiesEntry p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _music = new MusicId16(m_io);
            _field0x2 = m_io.ReadU1();
            _field0x3 = m_io.ReadU1();
            _illuminated = m_io.ReadU1();
            _enableLategameTraps = m_io.ReadU1();
            _movesEnabled = m_io.ReadU1();
            _orbsAllowed = m_io.ReadU1();
            _tileJumpsAllowed = m_io.ReadU1();
            _trawlOrbsAllowed = m_io.ReadU1();
            _exitAfterEnemiesDefeated = m_io.ReadU1();
            _field0xb = m_io.ReadU1();
        }
        private MusicId16 _music;
        private byte _field0x2;
        private byte _field0x3;
        private byte _illuminated;
        private byte _enableLategameTraps;
        private byte _movesEnabled;
        private byte _orbsAllowed;
        private byte _tileJumpsAllowed;
        private byte _trawlOrbsAllowed;
        private byte _exitAfterEnemiesDefeated;
        private byte _field0xb;
        private FixedRoomPropertiesEntry m_root;
        private KaitaiStruct m_parent;
        public MusicId16 Music { get { return _music; } }
        public byte Field0x2 { get { return _field0x2; } }
        public byte Field0x3 { get { return _field0x3; } }
        public byte Illuminated { get { return _illuminated; } }
        public byte EnableLategameTraps { get { return _enableLategameTraps; } }
        public byte MovesEnabled { get { return _movesEnabled; } }
        public byte OrbsAllowed { get { return _orbsAllowed; } }
        public byte TileJumpsAllowed { get { return _tileJumpsAllowed; } }
        public byte TrawlOrbsAllowed { get { return _trawlOrbsAllowed; } }
        public byte ExitAfterEnemiesDefeated { get { return _exitAfterEnemiesDefeated; } }
        public byte Field0xb { get { return _field0xb; } }
        public FixedRoomPropertiesEntry M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
