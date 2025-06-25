// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array LEVEL_UP_DATA_DECOMPRESS_BUFFER defined within pmdsky.
    /// </summary>
    public partial class LevelUpDataDecompressBufferArray : KaitaiStruct
    {
        public static LevelUpDataDecompressBufferArray FromFile(string fileName)
        {
            return new LevelUpDataDecompressBufferArray(new KaitaiStream(fileName));
        }

        public LevelUpDataDecompressBufferArray(KaitaiStream p__io, KaitaiStruct p__parent = null, LevelUpDataDecompressBufferArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new LevelUpDataDecompressBufferArrayDim0(m_io, this, m_root);
        }
        public partial class LevelUpDataDecompressBufferArrayDim0 : KaitaiStruct
        {
            public static LevelUpDataDecompressBufferArrayDim0 FromFile(string fileName)
            {
                return new LevelUpDataDecompressBufferArrayDim0(new KaitaiStream(fileName));
            }

            public LevelUpDataDecompressBufferArrayDim0(KaitaiStream p__io, LevelUpDataDecompressBufferArray p__parent = null, LevelUpDataDecompressBufferArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<LevelUpEntry>();
                for (var i = 0; i < 100; i++)
                {
                    _entries.Add(new LevelUpEntry(m_io));
                }
            }
            private List<LevelUpEntry> _entries;
            private LevelUpDataDecompressBufferArray m_root;
            private LevelUpDataDecompressBufferArray m_parent;
            public List<LevelUpEntry> Entries { get { return _entries; } }
            public LevelUpDataDecompressBufferArray M_Root { get { return m_root; } }
            public LevelUpDataDecompressBufferArray M_Parent { get { return m_parent; } }
        }
        private LevelUpDataDecompressBufferArrayDim0 _entries;
        private LevelUpDataDecompressBufferArray m_root;
        private KaitaiStruct m_parent;
        public LevelUpDataDecompressBufferArrayDim0 Entries { get { return _entries; } }
        public LevelUpDataDecompressBufferArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
