// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union trig_values defined within pmdsky-debug.
    /// </summary>
    public partial class TrigValues : KaitaiStruct
    {
        public static TrigValues FromFile(string fileName)
        {
            return new TrigValues(new KaitaiStream(fileName));
        }

        public TrigValues(KaitaiStream p__io, KaitaiStruct p__parent = null, TrigValues p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _sin = m_io.ReadS2le();
            _cos = m_io.ReadS2le();
        }
        private short _sin;
        private short _cos;
        private TrigValues m_root;
        private KaitaiStruct m_parent;
        public short Sin { get { return _sin; } }
        public short Cos { get { return _cos; } }
        public TrigValues M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
