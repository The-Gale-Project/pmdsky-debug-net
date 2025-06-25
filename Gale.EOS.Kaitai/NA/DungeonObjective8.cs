// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Holds bitsized data for the parent enum dungeon_objective.
    /// </summary>
    public partial class DungeonObjective8 : KaitaiStruct
    {
        public static DungeonObjective8 FromFile(string fileName)
        {
            return new DungeonObjective8(new KaitaiStream(fileName));
        }


        public enum DungeonObjective8Enum
        {
            ObjectiveStory = 0,
            ObjectiveNormal = 1,
            ObjectiveRescue = 2,
            ObjectiveUnkGameMode5 = 3,
        }
        public DungeonObjective8(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonObjective8 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _dungeonObjective8Value = ((DungeonObjective8Enum) m_io.ReadBitsIntLe(8));
        }
        private DungeonObjective8Enum _dungeonObjective8Value;
        private DungeonObjective8 m_root;
        private KaitaiStruct m_parent;
        public DungeonObjective8Enum DungeonObjective8Value { get { return _dungeonObjective8Value; } }
        public DungeonObjective8 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
