// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array WEATHER_BALL_DAMAGE_MULT_TABLE defined within pmdsky.
    /// </summary>
    public partial class WeatherBallDamageMultTableArray : KaitaiStruct
    {
        public static WeatherBallDamageMultTableArray FromFile(string fileName)
        {
            return new WeatherBallDamageMultTableArray(new KaitaiStream(fileName));
        }

        public WeatherBallDamageMultTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, WeatherBallDamageMultTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new WeatherBallDamageMultTableArrayDim0(m_io, this, m_root);
        }
        public partial class WeatherBallDamageMultTableArrayDim0 : KaitaiStruct
        {
            public static WeatherBallDamageMultTableArrayDim0 FromFile(string fileName)
            {
                return new WeatherBallDamageMultTableArrayDim0(new KaitaiStream(fileName));
            }

            public WeatherBallDamageMultTableArrayDim0(KaitaiStream p__io, WeatherBallDamageMultTableArray p__parent = null, WeatherBallDamageMultTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<int>();
                for (var i = 0; i < 8; i++)
                {
                    _entries.Add(m_io.ReadS4le());
                }
            }
            private List<int> _entries;
            private WeatherBallDamageMultTableArray m_root;
            private WeatherBallDamageMultTableArray m_parent;
            public List<int> Entries { get { return _entries; } }
            public WeatherBallDamageMultTableArray M_Root { get { return m_root; } }
            public WeatherBallDamageMultTableArray M_Parent { get { return m_parent; } }
        }
        private WeatherBallDamageMultTableArrayDim0 _entries;
        private WeatherBallDamageMultTableArray m_root;
        private KaitaiStruct m_parent;
        public WeatherBallDamageMultTableArrayDim0 Entries { get { return _entries; } }
        public WeatherBallDamageMultTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
