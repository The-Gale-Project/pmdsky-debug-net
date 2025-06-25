// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Holds the data for the enum weather_id.
    /// </summary>
    public partial class WeatherId : KaitaiStruct
    {
        public static WeatherId FromFile(string fileName)
        {
            return new WeatherId(new KaitaiStream(fileName));
        }


        public enum WeatherIdEnum
        {
            WeatherClear = 0,
            WeatherSunny = 1,
            WeatherSandstorm = 2,
            WeatherCloudy = 3,
            WeatherRain = 4,
            WeatherHail = 5,
            WeatherFog = 6,
            WeatherSnow = 7,
            WeatherRandom = 8,
        }
        public WeatherId(KaitaiStream p__io, KaitaiStruct p__parent = null, WeatherId p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _weatherIdValue = ((WeatherIdEnum) m_io.ReadBitsIntLe(32));
        }
        private WeatherIdEnum _weatherIdValue;
        private WeatherId m_root;
        private KaitaiStruct m_parent;
        public WeatherIdEnum WeatherIdValue { get { return _weatherIdValue; } }
        public WeatherId M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
