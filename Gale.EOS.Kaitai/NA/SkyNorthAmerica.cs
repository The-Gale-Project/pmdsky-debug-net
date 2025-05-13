// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Mapping for the North American edition of Pokémon Mystery Dungeon: Explorers of Sky.
    /// </summary>
    public partial class SkyNorthAmerica : KaitaiStruct
    {
        public static SkyNorthAmerica FromFile(string fileName)
        {
            return new SkyNorthAmerica(new KaitaiStream(fileName));
        }

        public SkyNorthAmerica(KaitaiStream p__io, KaitaiStruct p__parent = null, SkyNorthAmerica p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_arm7 = false;
            f_arm9 = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_arm7;
        private Arm7 _arm7;
        public Arm7 Arm7
        {
            get
            {
                if (f_arm7)
                    return _arm7;
                long _pos = m_io.Pos;
                m_io.Seek(37224448);
                __raw_arm7 = m_io.ReadBytes(159872);
                var io___raw_arm7 = new KaitaiStream(__raw_arm7);
                _arm7 = new Arm7(io___raw_arm7);
                m_io.Seek(_pos);
                f_arm7 = true;
                return _arm7;
            }
        }
        private bool f_arm9;
        private Arm9 _arm9;
        public Arm9 Arm9
        {
            get
            {
                if (f_arm9)
                    return _arm9;
                long _pos = m_io.Pos;
                m_io.Seek(33554432);
                __raw_arm9 = m_io.ReadBytes(750584);
                var io___raw_arm9 = new KaitaiStream(__raw_arm9);
                _arm9 = new Arm9(io___raw_arm9);
                m_io.Seek(_pos);
                f_arm9 = true;
                return _arm9;
            }
        }
        private SkyNorthAmerica m_root;
        private KaitaiStruct m_parent;
        private byte[] __raw_arm7;
        private byte[] __raw_arm9;
        public SkyNorthAmerica M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
        public byte[] M_RawArm7 { get { return __raw_arm7; } }
        public byte[] M_RawArm9 { get { return __raw_arm9; } }
    }
}
