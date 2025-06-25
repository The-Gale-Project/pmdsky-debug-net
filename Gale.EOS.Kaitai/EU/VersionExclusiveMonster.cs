// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union version_exclusive_monster defined within pmdsky-debug.
    /// </summary>
    public partial class VersionExclusiveMonster : KaitaiStruct
    {
        public static VersionExclusiveMonster FromFile(string fileName)
        {
            return new VersionExclusiveMonster(new KaitaiStream(fileName));
        }

        public VersionExclusiveMonster(KaitaiStream p__io, KaitaiStruct p__parent = null, VersionExclusiveMonster p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _id = new MonsterId16(m_io);
            _inEot = m_io.ReadU1();
            _inEod = m_io.ReadU1();
        }
        private MonsterId16 _id;
        private byte _inEot;
        private byte _inEod;
        private VersionExclusiveMonster m_root;
        private KaitaiStruct m_parent;
        public MonsterId16 Id { get { return _id; } }
        public byte InEot { get { return _inEot; } }
        public byte InEod { get { return _inEod; } }
        public VersionExclusiveMonster M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
