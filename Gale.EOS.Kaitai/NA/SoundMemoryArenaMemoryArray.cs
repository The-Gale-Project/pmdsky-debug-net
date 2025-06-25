// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array SOUND_MEMORY_ARENA_MEMORY defined within pmdsky.
    /// </summary>
    public partial class SoundMemoryArenaMemoryArray : KaitaiStruct
    {
        public static SoundMemoryArenaMemoryArray FromFile(string fileName)
        {
            return new SoundMemoryArenaMemoryArray(new KaitaiStream(fileName));
        }

        public SoundMemoryArenaMemoryArray(KaitaiStream p__io, KaitaiStruct p__parent = null, SoundMemoryArenaMemoryArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new SoundMemoryArenaMemoryArrayDim0(m_io, this, m_root);
        }
        public partial class SoundMemoryArenaMemoryArrayDim0 : KaitaiStruct
        {
            public static SoundMemoryArenaMemoryArrayDim0 FromFile(string fileName)
            {
                return new SoundMemoryArenaMemoryArrayDim0(new KaitaiStream(fileName));
            }

            public SoundMemoryArenaMemoryArrayDim0(KaitaiStream p__io, SoundMemoryArenaMemoryArray p__parent = null, SoundMemoryArenaMemoryArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<byte>();
                for (var i = 0; i < 245252; i++)
                {
                    _entries.Add(m_io.ReadU1());
                }
            }
            private List<byte> _entries;
            private SoundMemoryArenaMemoryArray m_root;
            private SoundMemoryArenaMemoryArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public SoundMemoryArenaMemoryArray M_Root { get { return m_root; } }
            public SoundMemoryArenaMemoryArray M_Parent { get { return m_parent; } }
        }
        private SoundMemoryArenaMemoryArrayDim0 _entries;
        private SoundMemoryArenaMemoryArray m_root;
        private KaitaiStruct m_parent;
        public SoundMemoryArenaMemoryArrayDim0 Entries { get { return _entries; } }
        public SoundMemoryArenaMemoryArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
