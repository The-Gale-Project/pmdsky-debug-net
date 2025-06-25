// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array EXCL_ITEM_EFFECTS_WEATHER_MOVE_SPEED_BOOST defined within pmdsky.
    /// </summary>
    public partial class ExclItemEffectsWeatherMoveSpeedBoostArray : KaitaiStruct
    {
        public static ExclItemEffectsWeatherMoveSpeedBoostArray FromFile(string fileName)
        {
            return new ExclItemEffectsWeatherMoveSpeedBoostArray(new KaitaiStream(fileName));
        }

        public ExclItemEffectsWeatherMoveSpeedBoostArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ExclItemEffectsWeatherMoveSpeedBoostArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ExclItemEffectsWeatherMoveSpeedBoostArrayDim0(m_io, this, m_root);
        }
        public partial class ExclItemEffectsWeatherMoveSpeedBoostArrayDim0 : KaitaiStruct
        {
            public static ExclItemEffectsWeatherMoveSpeedBoostArrayDim0 FromFile(string fileName)
            {
                return new ExclItemEffectsWeatherMoveSpeedBoostArrayDim0(new KaitaiStream(fileName));
            }

            public ExclItemEffectsWeatherMoveSpeedBoostArrayDim0(KaitaiStream p__io, ExclItemEffectsWeatherMoveSpeedBoostArray p__parent = null, ExclItemEffectsWeatherMoveSpeedBoostArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<ExclusiveItemEffectId8>();
                for (var i = 0; i < 8; i++)
                {
                    _entries.Add(new ExclusiveItemEffectId8(m_io));
                }
            }
            private List<ExclusiveItemEffectId8> _entries;
            private ExclItemEffectsWeatherMoveSpeedBoostArray m_root;
            private ExclItemEffectsWeatherMoveSpeedBoostArray m_parent;
            public List<ExclusiveItemEffectId8> Entries { get { return _entries; } }
            public ExclItemEffectsWeatherMoveSpeedBoostArray M_Root { get { return m_root; } }
            public ExclItemEffectsWeatherMoveSpeedBoostArray M_Parent { get { return m_parent; } }
        }
        private ExclItemEffectsWeatherMoveSpeedBoostArrayDim0 _entries;
        private ExclItemEffectsWeatherMoveSpeedBoostArray m_root;
        private KaitaiStruct m_parent;
        public ExclItemEffectsWeatherMoveSpeedBoostArrayDim0 Entries { get { return _entries; } }
        public ExclItemEffectsWeatherMoveSpeedBoostArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
