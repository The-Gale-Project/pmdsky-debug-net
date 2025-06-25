// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents a struct or union monster_sprite_data_entry defined within pmdsky-debug.
    /// </summary>
    public partial class MonsterSpriteDataEntry : KaitaiStruct
    {
        public static MonsterSpriteDataEntry FromFile(string fileName)
        {
            return new MonsterSpriteDataEntry(new KaitaiStream(fileName));
        }

        public MonsterSpriteDataEntry(KaitaiStream p__io, KaitaiStruct p__parent = null, MonsterSpriteDataEntry p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _spriteSize = m_io.ReadU1();
            _spriteFileSize = m_io.ReadU1();
        }
        private byte _spriteSize;
        private byte _spriteFileSize;
        private MonsterSpriteDataEntry m_root;
        private KaitaiStruct m_parent;
        public byte SpriteSize { get { return _spriteSize; } }
        public byte SpriteFileSize { get { return _spriteFileSize; } }
        public MonsterSpriteDataEntry M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
