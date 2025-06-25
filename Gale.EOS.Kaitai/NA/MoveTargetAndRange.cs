// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union move_target_and_range defined within pmdsky-debug.
    /// </summary>
    public partial class MoveTargetAndRange : KaitaiStruct
    {
        public static MoveTargetAndRange FromFile(string fileName)
        {
            return new MoveTargetAndRange(new KaitaiStream(fileName));
        }

        public MoveTargetAndRange(KaitaiStream p__io, KaitaiStruct p__parent = null, MoveTargetAndRange p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _target = new MoveTarget4(m_io);
            _range = new MoveRange4(m_io);
            _aiCondition = new MoveAiCondition4(m_io);
            _unused = m_io.ReadBitsIntLe(4);
        }
        private MoveTarget4 _target;
        private MoveRange4 _range;
        private MoveAiCondition4 _aiCondition;
        private ulong _unused;
        private MoveTargetAndRange m_root;
        private KaitaiStruct m_parent;
        public MoveTarget4 Target { get { return _target; } }
        public MoveRange4 Range { get { return _range; } }
        public MoveAiCondition4 AiCondition { get { return _aiCondition; } }
        public ulong Unused { get { return _unused; } }
        public MoveTargetAndRange M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
