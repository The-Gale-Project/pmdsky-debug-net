// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Holds bitsized data for the parent enum special_episode_type.
    /// </summary>
    public partial class SpecialEpisodeType8 : KaitaiStruct
    {
        public static SpecialEpisodeType8 FromFile(string fileName)
        {
            return new SpecialEpisodeType8(new KaitaiStream(fileName));
        }


        public enum SpecialEpisodeType8Enum
        {
            EpisodeBidoofsWish = 0,
            EpisodeIgglybuffTheProdigy = 1,
            EpisodeTodaysOhMyGosh = 2,
            EpisodeHereComesTeamCharm = 3,
            EpisodeInTheFutureOfDarkness = 4,
        }
        public SpecialEpisodeType8(KaitaiStream p__io, KaitaiStruct p__parent = null, SpecialEpisodeType8 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _specialEpisodeType8Value = ((SpecialEpisodeType8Enum) m_io.ReadBitsIntLe(8));
        }
        private SpecialEpisodeType8Enum _specialEpisodeType8Value;
        private SpecialEpisodeType8 m_root;
        private KaitaiStruct m_parent;
        public SpecialEpisodeType8Enum SpecialEpisodeType8Value { get { return _specialEpisodeType8Value; } }
        public SpecialEpisodeType8 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
