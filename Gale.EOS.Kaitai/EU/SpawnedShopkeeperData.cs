// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union spawned_shopkeeper_data defined within pmdsky-debug.
    /// </summary>
    public partial class SpawnedShopkeeperData : KaitaiStruct
    {
        public static SpawnedShopkeeperData FromFile(string fileName)
        {
            return new SpawnedShopkeeperData(new KaitaiStream(fileName));
        }

        public SpawnedShopkeeperData(KaitaiStream p__io, KaitaiStruct p__parent = null, SpawnedShopkeeperData p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _monsterId = new MonsterId16(m_io);
            _behavior = new MonsterBehavior8(m_io);
            _valid = m_io.ReadU1();
            _posX = m_io.ReadU1();
            _posY = m_io.ReadU1();
        }
        private MonsterId16 _monsterId;
        private MonsterBehavior8 _behavior;
        private byte _valid;
        private byte _posX;
        private byte _posY;
        private SpawnedShopkeeperData m_root;
        private KaitaiStruct m_parent;
        public MonsterId16 MonsterId { get { return _monsterId; } }
        public MonsterBehavior8 Behavior { get { return _behavior; } }
        public byte Valid { get { return _valid; } }
        public byte PosX { get { return _posX; } }
        public byte PosY { get { return _posY; } }
        public SpawnedShopkeeperData M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
