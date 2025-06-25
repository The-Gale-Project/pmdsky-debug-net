// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union move_data defined within pmdsky-debug.
    /// </summary>
    public partial class MoveData : KaitaiStruct
    {
        public static MoveData FromFile(string fileName)
        {
            return new MoveData(new KaitaiStream(fileName));
        }

        public MoveData(KaitaiStream p__io, KaitaiStruct p__parent = null, MoveData p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _basePower = m_io.ReadU2le();
            _type = new TypeId8(m_io);
            _category = new MoveCategory8(m_io);
            _targetRange = new MoveTargetAndRange(m_io);
            _aiTargetRange = new MoveTargetAndRange(m_io);
            _pp = m_io.ReadU1();
            _aiWeight = m_io.ReadU1();
            _accuracy1 = m_io.ReadU1();
            _accuracy2 = m_io.ReadU1();
            _aiConditionRandomChance = m_io.ReadU1();
            _strikes = m_io.ReadU1();
            _maxGinsengBoost = m_io.ReadU1();
            _critChance = m_io.ReadU1();
            _reflectedByMagicCoat = m_io.ReadU1();
            _canBeSnatched = m_io.ReadU1();
            _failsWhileMuzzled = m_io.ReadU1();
            _aiCanUseAgainstFrozen = m_io.ReadU1();
            _usableWhileTaunted = m_io.ReadU1();
            _rangeStringIdx = m_io.ReadU1();
            _id = new MoveId16(m_io);
            _messageStringIdx = m_io.ReadU2le();
        }
        private ushort _basePower;
        private TypeId8 _type;
        private MoveCategory8 _category;
        private MoveTargetAndRange _targetRange;
        private MoveTargetAndRange _aiTargetRange;
        private byte _pp;
        private byte _aiWeight;
        private byte _accuracy1;
        private byte _accuracy2;
        private byte _aiConditionRandomChance;
        private byte _strikes;
        private byte _maxGinsengBoost;
        private byte _critChance;
        private byte _reflectedByMagicCoat;
        private byte _canBeSnatched;
        private byte _failsWhileMuzzled;
        private byte _aiCanUseAgainstFrozen;
        private byte _usableWhileTaunted;
        private byte _rangeStringIdx;
        private MoveId16 _id;
        private ushort _messageStringIdx;
        private MoveData m_root;
        private KaitaiStruct m_parent;
        public ushort BasePower { get { return _basePower; } }
        public TypeId8 Type { get { return _type; } }
        public MoveCategory8 Category { get { return _category; } }
        public MoveTargetAndRange TargetRange { get { return _targetRange; } }
        public MoveTargetAndRange AiTargetRange { get { return _aiTargetRange; } }
        public byte Pp { get { return _pp; } }
        public byte AiWeight { get { return _aiWeight; } }
        public byte Accuracy1 { get { return _accuracy1; } }
        public byte Accuracy2 { get { return _accuracy2; } }
        public byte AiConditionRandomChance { get { return _aiConditionRandomChance; } }
        public byte Strikes { get { return _strikes; } }
        public byte MaxGinsengBoost { get { return _maxGinsengBoost; } }
        public byte CritChance { get { return _critChance; } }
        public byte ReflectedByMagicCoat { get { return _reflectedByMagicCoat; } }
        public byte CanBeSnatched { get { return _canBeSnatched; } }
        public byte FailsWhileMuzzled { get { return _failsWhileMuzzled; } }
        public byte AiCanUseAgainstFrozen { get { return _aiCanUseAgainstFrozen; } }
        public byte UsableWhileTaunted { get { return _usableWhileTaunted; } }
        public byte RangeStringIdx { get { return _rangeStringIdx; } }
        public MoveId16 Id { get { return _id; } }
        public ushort MessageStringIdx { get { return _messageStringIdx; } }
        public MoveData M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
