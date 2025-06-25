// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents a struct or union special_monster_move_animation defined within pmdsky-debug.
    /// </summary>
    public partial class SpecialMonsterMoveAnimation : KaitaiStruct
    {
        public static SpecialMonsterMoveAnimation FromFile(string fileName)
        {
            return new SpecialMonsterMoveAnimation(new KaitaiStream(fileName));
        }

        public SpecialMonsterMoveAnimation(KaitaiStream p__io, KaitaiStruct p__parent = null, SpecialMonsterMoveAnimation p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _field0x0 = m_io.ReadS2le();
            _field0x2 = m_io.ReadU1();
            _field0x3 = m_io.ReadS1();
            _field0x4 = m_io.ReadS2le();
        }
        private short _field0x0;
        private byte _field0x2;
        private sbyte _field0x3;
        private short _field0x4;
        private SpecialMonsterMoveAnimation m_root;
        private KaitaiStruct m_parent;
        public short Field0x0 { get { return _field0x0; } }
        public byte Field0x2 { get { return _field0x2; } }
        public sbyte Field0x3 { get { return _field0x3; } }
        public short Field0x4 { get { return _field0x4; } }
        public SpecialMonsterMoveAnimation M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
