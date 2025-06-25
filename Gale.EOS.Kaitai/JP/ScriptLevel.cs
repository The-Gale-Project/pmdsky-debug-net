// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents a struct or union script_level defined within pmdsky-debug.
    /// </summary>
    public partial class ScriptLevel : KaitaiStruct
    {
        public static ScriptLevel FromFile(string fileName)
        {
            return new ScriptLevel(new KaitaiStream(fileName));
        }

        public ScriptLevel(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptLevel p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _mapty = m_io.ReadU2le();
            _field0x2 = m_io.ReadU2le();
            _mapid = m_io.ReadU2le();
            _weatherId = new WeatherId(m_io);
            _name = new Pointer(m_io);
        }
        private ushort _mapty;
        private ushort _field0x2;
        private ushort _mapid;
        private WeatherId _weatherId;
        private Pointer _name;
        private ScriptLevel m_root;
        private KaitaiStruct m_parent;
        public ushort Mapty { get { return _mapty; } }
        public ushort Field0x2 { get { return _field0x2; } }
        public ushort Mapid { get { return _mapid; } }
        public WeatherId WeatherId { get { return _weatherId; } }
        public Pointer Name { get { return _name; } }
        public ScriptLevel M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
