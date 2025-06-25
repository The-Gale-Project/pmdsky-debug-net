// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Holds the data for the enum game_id.
    /// </summary>
    public partial class GameId : KaitaiStruct
    {
        public static GameId FromFile(string fileName)
        {
            return new GameId(new KaitaiStream(fileName));
        }


        public enum GameIdEnum
        {
            GameSky = 0,
            GameTime = 1,
            GameDarkness = 2,
        }
        public GameId(KaitaiStream p__io, KaitaiStruct p__parent = null, GameId p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _gameIdValue = ((GameIdEnum) m_io.ReadBitsIntLe(32));
        }
        private GameIdEnum _gameIdValue;
        private GameId m_root;
        private KaitaiStruct m_parent;
        public GameIdEnum GameIdValue { get { return _gameIdValue; } }
        public GameId M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
