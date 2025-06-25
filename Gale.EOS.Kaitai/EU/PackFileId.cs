// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Holds the data for the enum pack_file_id.
    /// </summary>
    public partial class PackFileId : KaitaiStruct
    {
        public static PackFileId FromFile(string fileName)
        {
            return new PackFileId(new KaitaiStream(fileName));
        }


        public enum PackFileIdEnum
        {
            PackArchiveMonster = 0,
            PackArchiveMAttack = 1,
            PackArchiveMGround = 2,
            PackArchiveEffect = 3,
            PackArchiveDungeon = 4,
            PackArchiveMLevel = 5,
        }
        public PackFileId(KaitaiStream p__io, KaitaiStruct p__parent = null, PackFileId p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _packFileIdValue = ((PackFileIdEnum) m_io.ReadBitsIntLe(32));
        }
        private PackFileIdEnum _packFileIdValue;
        private PackFileId m_root;
        private KaitaiStruct m_parent;
        public PackFileIdEnum PackFileIdValue { get { return _packFileIdValue; } }
        public PackFileId M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
