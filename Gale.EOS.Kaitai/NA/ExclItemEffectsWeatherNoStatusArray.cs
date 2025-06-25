// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array EXCL_ITEM_EFFECTS_WEATHER_NO_STATUS defined within pmdsky.
    /// </summary>
    public partial class ExclItemEffectsWeatherNoStatusArray : KaitaiStruct
    {
        public static ExclItemEffectsWeatherNoStatusArray FromFile(string fileName)
        {
            return new ExclItemEffectsWeatherNoStatusArray(new KaitaiStream(fileName));
        }

        public ExclItemEffectsWeatherNoStatusArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ExclItemEffectsWeatherNoStatusArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ExclItemEffectsWeatherNoStatusArrayDim0(m_io, this, m_root);
        }
        public partial class ExclItemEffectsWeatherNoStatusArrayDim0 : KaitaiStruct
        {
            public static ExclItemEffectsWeatherNoStatusArrayDim0 FromFile(string fileName)
            {
                return new ExclItemEffectsWeatherNoStatusArrayDim0(new KaitaiStream(fileName));
            }

            public ExclItemEffectsWeatherNoStatusArrayDim0(KaitaiStream p__io, ExclItemEffectsWeatherNoStatusArray p__parent = null, ExclItemEffectsWeatherNoStatusArray p__root = null) : base(p__io)
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
            private ExclItemEffectsWeatherNoStatusArray m_root;
            private ExclItemEffectsWeatherNoStatusArray m_parent;
            public List<ExclusiveItemEffectId8> Entries { get { return _entries; } }
            public ExclItemEffectsWeatherNoStatusArray M_Root { get { return m_root; } }
            public ExclItemEffectsWeatherNoStatusArray M_Parent { get { return m_parent; } }
        }
        private ExclItemEffectsWeatherNoStatusArrayDim0 _entries;
        private ExclItemEffectsWeatherNoStatusArray m_root;
        private KaitaiStruct m_parent;
        public ExclItemEffectsWeatherNoStatusArrayDim0 Entries { get { return _entries; } }
        public ExclItemEffectsWeatherNoStatusArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
