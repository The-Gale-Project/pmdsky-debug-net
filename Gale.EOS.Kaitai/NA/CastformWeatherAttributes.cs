// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union castform_weather_attributes defined within pmdsky-debug.
    /// </summary>
    public partial class CastformWeatherAttributes : KaitaiStruct
    {
        public static CastformWeatherAttributes FromFile(string fileName)
        {
            return new CastformWeatherAttributes(new KaitaiStream(fileName));
        }

        public CastformWeatherAttributes(KaitaiStream p__io, KaitaiStruct p__parent = null, CastformWeatherAttributes p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _castformType = new TypeId8(m_io);
            _padding = m_io.ReadU1();
            _castformMaleId = new MonsterId16(m_io);
            _castformFemaleId = new MonsterId16(m_io);
        }
        private TypeId8 _castformType;
        private byte _padding;
        private MonsterId16 _castformMaleId;
        private MonsterId16 _castformFemaleId;
        private CastformWeatherAttributes m_root;
        private KaitaiStruct m_parent;
        public TypeId8 CastformType { get { return _castformType; } }
        public byte Padding { get { return _padding; } }
        public MonsterId16 CastformMaleId { get { return _castformMaleId; } }
        public MonsterId16 CastformFemaleId { get { return _castformFemaleId; } }
        public CastformWeatherAttributes M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
