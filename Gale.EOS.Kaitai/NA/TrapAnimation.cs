// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union trap_animation defined within pmdsky-debug.
    /// </summary>
    public partial class TrapAnimation : KaitaiStruct
    {
        public static TrapAnimation FromFile(string fileName)
        {
            return new TrapAnimation(new KaitaiStream(fileName));
        }

        public TrapAnimation(KaitaiStream p__io, KaitaiStruct p__parent = null, TrapAnimation p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _field0x0 = m_io.ReadS2le();
        }
        private short _field0x0;
        private TrapAnimation m_root;
        private KaitaiStruct m_parent;
        public short Field0x0 { get { return _field0x0; } }
        public TrapAnimation M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
