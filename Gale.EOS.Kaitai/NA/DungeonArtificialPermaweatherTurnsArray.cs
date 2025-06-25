// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array dungeon_artificial_permaweather_turns defined within pmdsky.
    /// </summary>
    public partial class DungeonArtificialPermaweatherTurnsArray : KaitaiStruct
    {
        public static DungeonArtificialPermaweatherTurnsArray FromFile(string fileName)
        {
            return new DungeonArtificialPermaweatherTurnsArray(new KaitaiStream(fileName));
        }

        public DungeonArtificialPermaweatherTurnsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonArtificialPermaweatherTurnsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonArtificialPermaweatherTurnsArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonArtificialPermaweatherTurnsArrayDim0 : KaitaiStruct
        {
            public static DungeonArtificialPermaweatherTurnsArrayDim0 FromFile(string fileName)
            {
                return new DungeonArtificialPermaweatherTurnsArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonArtificialPermaweatherTurnsArrayDim0(KaitaiStream p__io, DungeonArtificialPermaweatherTurnsArray p__parent = null, DungeonArtificialPermaweatherTurnsArray p__root = null) : base(p__io)
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
            private DungeonArtificialPermaweatherTurnsArray m_root;
            private DungeonArtificialPermaweatherTurnsArray m_parent;
            public List<ushort> Entries { get { return _entries; } }
            public DungeonArtificialPermaweatherTurnsArray M_Root { get { return m_root; } }
            public DungeonArtificialPermaweatherTurnsArray M_Parent { get { return m_parent; } }
        }
        private DungeonArtificialPermaweatherTurnsArrayDim0 _entries;
        private DungeonArtificialPermaweatherTurnsArray m_root;
        private KaitaiStruct m_parent;
        public DungeonArtificialPermaweatherTurnsArrayDim0 Entries { get { return _entries; } }
        public DungeonArtificialPermaweatherTurnsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
