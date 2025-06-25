// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array GROUND_WEATHER_TABLE defined within pmdsky.
    /// </summary>
    public partial class GroundWeatherTableArray : KaitaiStruct
    {
        public static GroundWeatherTableArray FromFile(string fileName)
        {
            return new GroundWeatherTableArray(new KaitaiStream(fileName));
        }

        public GroundWeatherTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, GroundWeatherTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new GroundWeatherTableArrayDim0(m_io, this, m_root);
        }
        public partial class GroundWeatherTableArrayDim0 : KaitaiStruct
        {
            public static GroundWeatherTableArrayDim0 FromFile(string fileName)
            {
                return new GroundWeatherTableArrayDim0(new KaitaiStream(fileName));
            }

            public GroundWeatherTableArrayDim0(KaitaiStream p__io, GroundWeatherTableArray p__parent = null, GroundWeatherTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<GroundWeatherEntry>();
                for (var i = 0; i < 12; i++)
                {
                    _entries.Add(new GroundWeatherEntry(m_io));
                }
            }
            private List<GroundWeatherEntry> _entries;
            private GroundWeatherTableArray m_root;
            private GroundWeatherTableArray m_parent;
            public List<GroundWeatherEntry> Entries { get { return _entries; } }
            public GroundWeatherTableArray M_Root { get { return m_root; } }
            public GroundWeatherTableArray M_Parent { get { return m_parent; } }
        }
        private GroundWeatherTableArrayDim0 _entries;
        private GroundWeatherTableArray m_root;
        private KaitaiStruct m_parent;
        public GroundWeatherTableArrayDim0 Entries { get { return _entries; } }
        public GroundWeatherTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
