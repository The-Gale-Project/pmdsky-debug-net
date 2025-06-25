// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array dse_voice_update_flags_flags defined within pmdsky.
    /// </summary>
    public partial class DseVoiceUpdateFlagsFlagsArray : KaitaiStruct
    {
        public static DseVoiceUpdateFlagsFlagsArray FromFile(string fileName)
        {
            return new DseVoiceUpdateFlagsFlagsArray(new KaitaiStream(fileName));
        }

        public DseVoiceUpdateFlagsFlagsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DseVoiceUpdateFlagsFlagsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DseVoiceUpdateFlagsFlagsArrayDim0(m_io, this, m_root);
        }
        public partial class DseVoiceUpdateFlagsFlagsArrayDim0 : KaitaiStruct
        {
            public static DseVoiceUpdateFlagsFlagsArrayDim0 FromFile(string fileName)
            {
                return new DseVoiceUpdateFlagsFlagsArrayDim0(new KaitaiStream(fileName));
            }

            public DseVoiceUpdateFlagsFlagsArrayDim0(KaitaiStream p__io, DseVoiceUpdateFlagsFlagsArray p__parent = null, DseVoiceUpdateFlagsFlagsArray p__root = null) : base(p__io)
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
            private DseVoiceUpdateFlagsFlagsArray m_root;
            private DseVoiceUpdateFlagsFlagsArray m_parent;
            public List<ushort> Entries { get { return _entries; } }
            public DseVoiceUpdateFlagsFlagsArray M_Root { get { return m_root; } }
            public DseVoiceUpdateFlagsFlagsArray M_Parent { get { return m_parent; } }
        }
        private DseVoiceUpdateFlagsFlagsArrayDim0 _entries;
        private DseVoiceUpdateFlagsFlagsArray m_root;
        private KaitaiStruct m_parent;
        public DseVoiceUpdateFlagsFlagsArrayDim0 Entries { get { return _entries; } }
        public DseVoiceUpdateFlagsFlagsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
