// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Holds bitsized data for the parent enum weather_id.
    /// </summary>
    public partial class WeatherId8 : KaitaiStruct
    {
        public static WeatherId8 FromFile(string fileName)
        {
            return new WeatherId8(new KaitaiStream(fileName));
        }


        public enum WeatherId8Enum
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
        public WeatherId8(KaitaiStream p__io, KaitaiStruct p__parent = null, WeatherId8 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _weatherId8Value = ((WeatherId8Enum) m_io.ReadBitsIntLe(8));
        }
        private WeatherId8Enum _weatherId8Value;
        private WeatherId8 m_root;
        private KaitaiStruct m_parent;
        public WeatherId8Enum WeatherId8Value { get { return _weatherId8Value; } }
        public WeatherId8 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
