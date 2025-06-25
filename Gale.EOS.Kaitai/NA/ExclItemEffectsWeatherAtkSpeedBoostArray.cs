// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array EXCL_ITEM_EFFECTS_WEATHER_ATK_SPEED_BOOST defined within pmdsky.
    /// </summary>
    public partial class ExclItemEffectsWeatherAtkSpeedBoostArray : KaitaiStruct
    {
        public static ExclItemEffectsWeatherAtkSpeedBoostArray FromFile(string fileName)
        {
            return new ExclItemEffectsWeatherAtkSpeedBoostArray(new KaitaiStream(fileName));
        }

        public ExclItemEffectsWeatherAtkSpeedBoostArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ExclItemEffectsWeatherAtkSpeedBoostArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ExclItemEffectsWeatherAtkSpeedBoostArrayDim0(m_io, this, m_root);
        }
        public partial class ExclItemEffectsWeatherAtkSpeedBoostArrayDim0 : KaitaiStruct
        {
            public static ExclItemEffectsWeatherAtkSpeedBoostArrayDim0 FromFile(string fileName)
            {
                return new ExclItemEffectsWeatherAtkSpeedBoostArrayDim0(new KaitaiStream(fileName));
            }

            public ExclItemEffectsWeatherAtkSpeedBoostArrayDim0(KaitaiStream p__io, ExclItemEffectsWeatherAtkSpeedBoostArray p__parent = null, ExclItemEffectsWeatherAtkSpeedBoostArray p__root = null) : base(p__io)
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
            private ExclItemEffectsWeatherAtkSpeedBoostArray m_root;
            private ExclItemEffectsWeatherAtkSpeedBoostArray m_parent;
            public List<ExclusiveItemEffectId8> Entries { get { return _entries; } }
            public ExclItemEffectsWeatherAtkSpeedBoostArray M_Root { get { return m_root; } }
            public ExclItemEffectsWeatherAtkSpeedBoostArray M_Parent { get { return m_parent; } }
        }
        private ExclItemEffectsWeatherAtkSpeedBoostArrayDim0 _entries;
        private ExclItemEffectsWeatherAtkSpeedBoostArray m_root;
        private KaitaiStruct m_parent;
        public ExclItemEffectsWeatherAtkSpeedBoostArrayDim0 Entries { get { return _entries; } }
        public ExclItemEffectsWeatherAtkSpeedBoostArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
