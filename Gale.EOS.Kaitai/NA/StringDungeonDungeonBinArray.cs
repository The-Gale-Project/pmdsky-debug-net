// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array STRING_DUNGEON_DUNGEON_BIN defined within pmdsky.
    /// </summary>
    public partial class StringDungeonDungeonBinArray : KaitaiStruct
    {
        public static StringDungeonDungeonBinArray FromFile(string fileName)
        {
            return new StringDungeonDungeonBinArray(new KaitaiStream(fileName));
        }

        public StringDungeonDungeonBinArray(KaitaiStream p__io, KaitaiStruct p__parent = null, StringDungeonDungeonBinArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StringDungeonDungeonBinArrayDim0(m_io, this, m_root);
        }
        public partial class StringDungeonDungeonBinArrayDim0 : KaitaiStruct
        {
            public static StringDungeonDungeonBinArrayDim0 FromFile(string fileName)
            {
                return new StringDungeonDungeonBinArrayDim0(new KaitaiStream(fileName));
            }

            public StringDungeonDungeonBinArrayDim0(KaitaiStream p__io, StringDungeonDungeonBinArray p__parent = null, StringDungeonDungeonBinArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<sbyte>();
                for (var i = 0; i < 20; i++)
                {
                    _entries.Add(m_io.ReadS1());
                }
            }
            private List<sbyte> _entries;
            private StringDungeonDungeonBinArray m_root;
            private StringDungeonDungeonBinArray m_parent;
            public List<sbyte> Entries { get { return _entries; } }
            public StringDungeonDungeonBinArray M_Root { get { return m_root; } }
            public StringDungeonDungeonBinArray M_Parent { get { return m_parent; } }
        }
        private StringDungeonDungeonBinArrayDim0 _entries;
        private StringDungeonDungeonBinArray m_root;
        private KaitaiStruct m_parent;
        public StringDungeonDungeonBinArrayDim0 Entries { get { return _entries; } }
        public StringDungeonDungeonBinArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
