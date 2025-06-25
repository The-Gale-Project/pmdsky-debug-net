// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array CASTFORM_WEATHER_ATTRIBUTE_TABLE defined within pmdsky.
    /// </summary>
    public partial class CastformWeatherAttributeTableArray : KaitaiStruct
    {
        public static CastformWeatherAttributeTableArray FromFile(string fileName)
        {
            return new CastformWeatherAttributeTableArray(new KaitaiStream(fileName));
        }

        public CastformWeatherAttributeTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, CastformWeatherAttributeTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new CastformWeatherAttributeTableArrayDim0(m_io, this, m_root);
        }
        public partial class CastformWeatherAttributeTableArrayDim0 : KaitaiStruct
        {
            public static CastformWeatherAttributeTableArrayDim0 FromFile(string fileName)
            {
                return new CastformWeatherAttributeTableArrayDim0(new KaitaiStream(fileName));
            }

            public CastformWeatherAttributeTableArrayDim0(KaitaiStream p__io, CastformWeatherAttributeTableArray p__parent = null, CastformWeatherAttributeTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<CastformWeatherAttributes>();
                for (var i = 0; i < 8; i++)
                {
                    _entries.Add(new CastformWeatherAttributes(m_io));
                }
            }
            private List<CastformWeatherAttributes> _entries;
            private CastformWeatherAttributeTableArray m_root;
            private CastformWeatherAttributeTableArray m_parent;
            public List<CastformWeatherAttributes> Entries { get { return _entries; } }
            public CastformWeatherAttributeTableArray M_Root { get { return m_root; } }
            public CastformWeatherAttributeTableArray M_Parent { get { return m_parent; } }
        }
        private CastformWeatherAttributeTableArrayDim0 _entries;
        private CastformWeatherAttributeTableArray m_root;
        private KaitaiStruct m_parent;
        public CastformWeatherAttributeTableArrayDim0 Entries { get { return _entries; } }
        public CastformWeatherAttributeTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
