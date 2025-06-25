// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array AUDIO_COMMANDS_BUFFER defined within pmdsky.
    /// </summary>
    public partial class AudioCommandsBufferArray : KaitaiStruct
    {
        public static AudioCommandsBufferArray FromFile(string fileName)
        {
            return new AudioCommandsBufferArray(new KaitaiStream(fileName));
        }

        public AudioCommandsBufferArray(KaitaiStream p__io, KaitaiStruct p__parent = null, AudioCommandsBufferArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new AudioCommandsBufferArrayDim0(m_io, this, m_root);
        }
        public partial class AudioCommandsBufferArrayDim0 : KaitaiStruct
        {
            public static AudioCommandsBufferArrayDim0 FromFile(string fileName)
            {
                return new AudioCommandsBufferArrayDim0(new KaitaiStream(fileName));
            }

            public AudioCommandsBufferArrayDim0(KaitaiStream p__io, AudioCommandsBufferArray p__parent = null, AudioCommandsBufferArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<AudioCommand>();
                for (var i = 0; i < 16; i++)
                {
                    _entries.Add(new AudioCommand(m_io));
                }
            }
            private List<AudioCommand> _entries;
            private AudioCommandsBufferArray m_root;
            private AudioCommandsBufferArray m_parent;
            public List<AudioCommand> Entries { get { return _entries; } }
            public AudioCommandsBufferArray M_Root { get { return m_root; } }
            public AudioCommandsBufferArray M_Parent { get { return m_parent; } }
        }
        private AudioCommandsBufferArrayDim0 _entries;
        private AudioCommandsBufferArray m_root;
        private KaitaiStruct m_parent;
        public AudioCommandsBufferArrayDim0 Entries { get { return _entries; } }
        public AudioCommandsBufferArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
