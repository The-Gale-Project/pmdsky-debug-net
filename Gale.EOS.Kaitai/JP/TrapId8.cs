// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Holds bitsized data for the parent enum trap_id.
    /// </summary>
    public partial class TrapId8 : KaitaiStruct
    {
        public static TrapId8 FromFile(string fileName)
        {
            return new TrapId8(new KaitaiStream(fileName));
        }


        public enum TrapId8Enum
        {
            TrapNullTrap = 0,
            TrapMudTrap = 1,
            TrapStickyTrap = 2,
            TrapGrimyTrap = 3,
            TrapSummonTrap = 4,
            TrapPitfallTrap = 5,
            TrapWarpTrap = 6,
            TrapGustTrap = 7,
            TrapSpinTrap = 8,
            TrapSlumberTrap = 9,
            TrapSlowTrap = 10,
            TrapSealTrap = 11,
            TrapPoisonTrap = 12,
            TrapSelfdestructTrap = 13,
            TrapExplosionTrap = 14,
            TrapPpZeroTrap = 15,
            TrapChestnutTrap = 16,
            TrapWonderTile = 17,
            TrapPokemonTrap = 18,
            TrapSpikedTile = 19,
            TrapStealthRock = 20,
            TrapToxicSpikes = 21,
            TrapTripTrap = 22,
            TrapRandomTrap = 23,
            TrapGrudgeTrap = 24,
            TrapNone = 25,
            Trap0x1a = 26,
            Trap0x1b = 27,
            Trap0x1c = 28,
            Trap0x1d = 29,
            Trap0x1e = 30,
            Trap0x1f = 31,
            TrapBrokenPitfallTrap = 32,
        }
        public TrapId8(KaitaiStream p__io, KaitaiStruct p__parent = null, TrapId8 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _trapId8Value = ((TrapId8Enum) m_io.ReadBitsIntLe(8));
        }
        private TrapId8Enum _trapId8Value;
        private TrapId8 m_root;
        private KaitaiStruct m_parent;
        public TrapId8Enum TrapId8Value { get { return _trapId8Value; } }
        public TrapId8 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
