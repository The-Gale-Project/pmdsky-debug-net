// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Holds the data for the enum special_episode_type.
    /// </summary>
    public partial class SpecialEpisodeType : KaitaiStruct
    {
        public static SpecialEpisodeType FromFile(string fileName)
        {
            return new SpecialEpisodeType(new KaitaiStream(fileName));
        }


        public enum SpecialEpisodeTypeEnum
        {
            EpisodeBidoofsWish = 0,
            EpisodeIgglybuffTheProdigy = 1,
            EpisodeTodaysOhMyGosh = 2,
            EpisodeHereComesTeamCharm = 3,
            EpisodeInTheFutureOfDarkness = 4,
        }
        public SpecialEpisodeType(KaitaiStream p__io, KaitaiStruct p__parent = null, SpecialEpisodeType p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _specialEpisodeTypeValue = ((SpecialEpisodeTypeEnum) m_io.ReadBitsIntLe(32));
        }
        private SpecialEpisodeTypeEnum _specialEpisodeTypeValue;
        private SpecialEpisodeType m_root;
        private KaitaiStruct m_parent;
        public SpecialEpisodeTypeEnum SpecialEpisodeTypeValue { get { return _specialEpisodeTypeValue; } }
        public SpecialEpisodeType M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
