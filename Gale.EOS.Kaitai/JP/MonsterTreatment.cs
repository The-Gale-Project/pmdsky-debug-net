// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Holds the data for the enum monster_treatment.
    /// </summary>
    public partial class MonsterTreatment : KaitaiStruct
    {
        public static MonsterTreatment FromFile(string fileName)
        {
            return new MonsterTreatment(new KaitaiStream(fileName));
        }


        public enum MonsterTreatmentEnum
        {
            TreatmentTreatAsAlly = 0,
            TreatmentTreatAsEnemy = 1,
            TreatmentIgnore = 2,
        }
        public MonsterTreatment(KaitaiStream p__io, KaitaiStruct p__parent = null, MonsterTreatment p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _monsterTreatmentValue = ((MonsterTreatmentEnum) m_io.ReadBitsIntLe(32));
        }
        private MonsterTreatmentEnum _monsterTreatmentValue;
        private MonsterTreatment m_root;
        private KaitaiStruct m_parent;
        public MonsterTreatmentEnum MonsterTreatmentValue { get { return _monsterTreatmentValue; } }
        public MonsterTreatment M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
