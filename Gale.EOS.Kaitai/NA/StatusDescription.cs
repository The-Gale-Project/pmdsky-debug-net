// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union status_description defined within pmdsky-debug.
    /// </summary>
    public partial class StatusDescription : KaitaiStruct
    {
        public static StatusDescription FromFile(string fileName)
        {
            return new StatusDescription(new KaitaiStream(fileName));
        }

        public StatusDescription(KaitaiStream p__io, KaitaiStruct p__parent = null, StatusDescription p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _nameStrId = m_io.ReadS2le();
            _descStrId = m_io.ReadS2le();
        }
        private short _nameStrId;
        private short _descStrId;
        private StatusDescription m_root;
        private KaitaiStruct m_parent;
        public short NameStrId { get { return _nameStrId; } }
        public short DescStrId { get { return _descStrId; } }
        public StatusDescription M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
