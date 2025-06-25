// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array WEATHER_BALL_TYPE_TABLE defined within pmdsky.
    /// </summary>
    public partial class WeatherBallTypeTableArray : KaitaiStruct
    {
        public static WeatherBallTypeTableArray FromFile(string fileName)
        {
            return new WeatherBallTypeTableArray(new KaitaiStream(fileName));
        }

        public WeatherBallTypeTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, WeatherBallTypeTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new WeatherBallTypeTableArrayDim0(m_io, this, m_root);
        }
        public partial class WeatherBallTypeTableArrayDim0 : KaitaiStruct
        {
            public static WeatherBallTypeTableArrayDim0 FromFile(string fileName)
            {
                return new WeatherBallTypeTableArrayDim0(new KaitaiStream(fileName));
            }

            public WeatherBallTypeTableArrayDim0(KaitaiStream p__io, WeatherBallTypeTableArray p__parent = null, WeatherBallTypeTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<TypeId8>();
                for (var i = 0; i < 8; i++)
                {
                    _entries.Add(new TypeId8(m_io));
                }
            }
            private List<TypeId8> _entries;
            private WeatherBallTypeTableArray m_root;
            private WeatherBallTypeTableArray m_parent;
            public List<TypeId8> Entries { get { return _entries; } }
            public WeatherBallTypeTableArray M_Root { get { return m_root; } }
            public WeatherBallTypeTableArray M_Parent { get { return m_parent; } }
        }
        private WeatherBallTypeTableArrayDim0 _entries;
        private WeatherBallTypeTableArray m_root;
        private KaitaiStruct m_parent;
        public WeatherBallTypeTableArrayDim0 Entries { get { return _entries; } }
        public WeatherBallTypeTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
