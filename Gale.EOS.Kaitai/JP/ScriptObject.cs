// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents a struct or union script_object defined within pmdsky-debug.
    /// </summary>
    public partial class ScriptObject : KaitaiStruct
    {
        public static ScriptObject FromFile(string fileName)
        {
            return new ScriptObject(new KaitaiStream(fileName));
        }

        public ScriptObject(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptObject p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _field0x0 = m_io.ReadS2le();
            _field0x2 = m_io.ReadU1();
            _field0x3 = m_io.ReadU1();
            _name = new Pointer(m_io);
            _field0x8 = m_io.ReadU1();
            _unused = new ScriptObjectUnusedArray(m_io);
        }
        private short _field0x0;
        private byte _field0x2;
        private byte _field0x3;
        private Pointer _name;
        private byte _field0x8;
        private ScriptObjectUnusedArray _unused;
        private ScriptObject m_root;
        private KaitaiStruct m_parent;
        public short Field0x0 { get { return _field0x0; } }
        public byte Field0x2 { get { return _field0x2; } }
        public byte Field0x3 { get { return _field0x3; } }
        public Pointer Name { get { return _name; } }
        public byte Field0x8 { get { return _field0x8; } }
        public ScriptObjectUnusedArray Unused { get { return _unused; } }
        public ScriptObject M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
