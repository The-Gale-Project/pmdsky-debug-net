// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents a struct or union simple_menu_id_item defined within pmdsky-debug.
    /// </summary>
    public partial class SimpleMenuIdItem : KaitaiStruct
    {
        public static SimpleMenuIdItem FromFile(string fileName)
        {
            return new SimpleMenuIdItem(new KaitaiStream(fileName));
        }

        public SimpleMenuIdItem(KaitaiStream p__io, KaitaiStruct p__parent = null, SimpleMenuIdItem p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _stringId = m_io.ReadU2le();
            _padding = m_io.ReadU2le();
            _resultValue = m_io.ReadS4le();
        }
        private ushort _stringId;
        private ushort _padding;
        private int _resultValue;
        private SimpleMenuIdItem m_root;
        private KaitaiStruct m_parent;
        public ushort StringId { get { return _stringId; } }
        public ushort Padding { get { return _padding; } }
        public int ResultValue { get { return _resultValue; } }
        public SimpleMenuIdItem M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
