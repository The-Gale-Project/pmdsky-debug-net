// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array dungeon_weather_turns defined within pmdsky.
    /// </summary>
    public partial class DungeonWeatherTurnsArray : KaitaiStruct
    {
        public static DungeonWeatherTurnsArray FromFile(string fileName)
        {
            return new DungeonWeatherTurnsArray(new KaitaiStream(fileName));
        }

        public DungeonWeatherTurnsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonWeatherTurnsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonWeatherTurnsArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonWeatherTurnsArrayDim0 : KaitaiStruct
        {
            public static DungeonWeatherTurnsArrayDim0 FromFile(string fileName)
            {
                return new DungeonWeatherTurnsArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonWeatherTurnsArrayDim0(KaitaiStream p__io, DungeonWeatherTurnsArray p__parent = null, DungeonWeatherTurnsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<ushort>();
                for (var i = 0; i < 8; i++)
                {
                    _entries.Add(m_io.ReadU2le());
                }
            }
            private List<ushort> _entries;
            private DungeonWeatherTurnsArray m_root;
            private DungeonWeatherTurnsArray m_parent;
            public List<ushort> Entries { get { return _entries; } }
            public DungeonWeatherTurnsArray M_Root { get { return m_root; } }
            public DungeonWeatherTurnsArray M_Parent { get { return m_parent; } }
        }
        private DungeonWeatherTurnsArrayDim0 _entries;
        private DungeonWeatherTurnsArray m_root;
        private KaitaiStruct m_parent;
        public DungeonWeatherTurnsArrayDim0 Entries { get { return _entries; } }
        public DungeonWeatherTurnsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
