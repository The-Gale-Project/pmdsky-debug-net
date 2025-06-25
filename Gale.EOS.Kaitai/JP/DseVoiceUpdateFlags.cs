// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents a struct or union dse_voice_update_flags defined within pmdsky-debug.
    /// </summary>
    public partial class DseVoiceUpdateFlags : KaitaiStruct
    {
        public static DseVoiceUpdateFlags FromFile(string fileName)
        {
            return new DseVoiceUpdateFlags(new KaitaiStream(fileName));
        }

        public DseVoiceUpdateFlags(KaitaiStream p__io, KaitaiStruct p__parent = null, DseVoiceUpdateFlags p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _flags = new DseVoiceUpdateFlagsFlagsArray(m_io);
        }
        private DseVoiceUpdateFlagsFlagsArray _flags;
        private DseVoiceUpdateFlags m_root;
        private KaitaiStruct m_parent;
        public DseVoiceUpdateFlagsFlagsArray Flags { get { return _flags; } }
        public DseVoiceUpdateFlags M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
