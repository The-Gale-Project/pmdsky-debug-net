// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{
    public partial class MoveEffectsData : KaitaiStruct
    {
        public static MoveEffectsData FromFile(string fileName)
        {
            return new MoveEffectsData(new KaitaiStream(fileName));
        }

        public MoveEffectsData(KaitaiStream p__io, KaitaiStruct p__parent = null, MoveEffectsData p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_maxHpCapMoveEffects3 = false;
            f_maxHpCapMoveEffects0 = false;
            f_maxHpCapMoveEffects1 = false;
            f_lunarDancePpRestoration = false;
            f_maxHpCapMoveEffects2 = false;
            f_maxHpCapMoveEffects4 = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_maxHpCapMoveEffects3;
        private int _maxHpCapMoveEffects3;

        /// <summary>
        /// See overlay29.yml::MAX_HP_CAP
        /// </summary>
        public int MaxHpCapMoveEffects3
        {
            get
            {
                if (f_maxHpCapMoveEffects3)
                    return _maxHpCapMoveEffects3;
                long _pos = m_io.Pos;
                m_io.Seek(31092);
                _maxHpCapMoveEffects3 = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_maxHpCapMoveEffects3 = true;
                return _maxHpCapMoveEffects3;
            }
        }
        private bool f_maxHpCapMoveEffects0;
        private int _maxHpCapMoveEffects0;

        /// <summary>
        /// See overlay29.yml::MAX_HP_CAP
        /// </summary>
        public int MaxHpCapMoveEffects0
        {
            get
            {
                if (f_maxHpCapMoveEffects0)
                    return _maxHpCapMoveEffects0;
                long _pos = m_io.Pos;
                m_io.Seek(6276);
                _maxHpCapMoveEffects0 = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_maxHpCapMoveEffects0 = true;
                return _maxHpCapMoveEffects0;
            }
        }
        private bool f_maxHpCapMoveEffects1;
        private int _maxHpCapMoveEffects1;

        /// <summary>
        /// See overlay29.yml::MAX_HP_CAP
        /// </summary>
        public int MaxHpCapMoveEffects1
        {
            get
            {
                if (f_maxHpCapMoveEffects1)
                    return _maxHpCapMoveEffects1;
                long _pos = m_io.Pos;
                m_io.Seek(8396);
                _maxHpCapMoveEffects1 = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_maxHpCapMoveEffects1 = true;
                return _maxHpCapMoveEffects1;
            }
        }
        private bool f_lunarDancePpRestoration;
        private int _lunarDancePpRestoration;

        /// <summary>
        /// The amount of PP restored by Lunar Dance (999).
        /// </summary>
        public int LunarDancePpRestoration
        {
            get
            {
                if (f_lunarDancePpRestoration)
                    return _lunarDancePpRestoration;
                long _pos = m_io.Pos;
                m_io.Seek(34316);
                _lunarDancePpRestoration = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_lunarDancePpRestoration = true;
                return _lunarDancePpRestoration;
            }
        }
        private bool f_maxHpCapMoveEffects2;
        private int _maxHpCapMoveEffects2;

        /// <summary>
        /// See overlay29.yml::MAX_HP_CAP
        /// </summary>
        public int MaxHpCapMoveEffects2
        {
            get
            {
                if (f_maxHpCapMoveEffects2)
                    return _maxHpCapMoveEffects2;
                long _pos = m_io.Pos;
                m_io.Seek(22124);
                _maxHpCapMoveEffects2 = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_maxHpCapMoveEffects2 = true;
                return _maxHpCapMoveEffects2;
            }
        }
        private bool f_maxHpCapMoveEffects4;
        private int _maxHpCapMoveEffects4;

        /// <summary>
        /// See overlay29.yml::MAX_HP_CAP
        /// </summary>
        public int MaxHpCapMoveEffects4
        {
            get
            {
                if (f_maxHpCapMoveEffects4)
                    return _maxHpCapMoveEffects4;
                long _pos = m_io.Pos;
                m_io.Seek(33136);
                _maxHpCapMoveEffects4 = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_maxHpCapMoveEffects4 = true;
                return _maxHpCapMoveEffects4;
            }
        }
        private MoveEffectsData m_root;
        private KaitaiStruct m_parent;
        public MoveEffectsData M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
