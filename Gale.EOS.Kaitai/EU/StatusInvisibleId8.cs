// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Holds bitsized data for the parent enum status_invisible_id.
    /// </summary>
    public partial class StatusInvisibleId8 : KaitaiStruct
    {
        public static StatusInvisibleId8 FromFile(string fileName)
        {
            return new StatusInvisibleId8(new KaitaiStream(fileName));
        }


        public enum StatusInvisibleId8Enum
        {
            StatusInvisibleNone = 0,
            StatusInvisibleInvisible = 1,
            StatusInvisibleTransformed = 2,
            StatusInvisibleMobile = 3,
            StatusInvisibleSlip = 4,
        }
        public StatusInvisibleId8(KaitaiStream p__io, KaitaiStruct p__parent = null, StatusInvisibleId8 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _statusInvisibleId8Value = ((StatusInvisibleId8Enum) m_io.ReadBitsIntLe(8));
        }
        private StatusInvisibleId8Enum _statusInvisibleId8Value;
        private StatusInvisibleId8 m_root;
        private KaitaiStruct m_parent;
        public StatusInvisibleId8Enum StatusInvisibleId8Value { get { return _statusInvisibleId8Value; } }
        public StatusInvisibleId8 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
