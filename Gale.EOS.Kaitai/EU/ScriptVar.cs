// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union script_var defined within pmdsky-debug.
    /// </summary>
    public partial class ScriptVar : KaitaiStruct
    {
        public static ScriptVar FromFile(string fileName)
        {
            return new ScriptVar(new KaitaiStream(fileName));
        }

        public ScriptVar(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVar p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _type = new ScriptVarType16(m_io);
            _field0x1 = m_io.ReadU2le();
            _memOffset = m_io.ReadU2le();
            _bitshift = m_io.ReadU2le();
            _nValues = m_io.ReadU2le();
            _defaultVal = m_io.ReadS2le();
            _name = new Pointer(m_io);
        }
        private ScriptVarType16 _type;
        private ushort _field0x1;
        private ushort _memOffset;
        private ushort _bitshift;
        private ushort _nValues;
        private short _defaultVal;
        private Pointer _name;
        private ScriptVar m_root;
        private KaitaiStruct m_parent;
        public ScriptVarType16 Type { get { return _type; } }
        public ushort Field0x1 { get { return _field0x1; } }
        public ushort MemOffset { get { return _memOffset; } }
        public ushort Bitshift { get { return _bitshift; } }
        public ushort NValues { get { return _nValues; } }
        public short DefaultVal { get { return _defaultVal; } }
        public Pointer Name { get { return _name; } }
        public ScriptVar M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
