// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union exclusive_item_effect_entry defined within pmdsky-debug.
    /// </summary>
    public partial class ExclusiveItemEffectEntry : KaitaiStruct
    {
        public static ExclusiveItemEffectEntry FromFile(string fileName)
        {
            return new ExclusiveItemEffectEntry(new KaitaiStream(fileName));
        }

        public ExclusiveItemEffectEntry(KaitaiStream p__io, KaitaiStruct p__parent = null, ExclusiveItemEffectEntry p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _effectId = new ExclusiveItemEffectId8(m_io);
            _foreignIdx = m_io.ReadU1();
        }
        private ExclusiveItemEffectId8 _effectId;
        private byte _foreignIdx;
        private ExclusiveItemEffectEntry m_root;
        private KaitaiStruct m_parent;
        public ExclusiveItemEffectId8 EffectId { get { return _effectId; } }
        public byte ForeignIdx { get { return _foreignIdx; } }
        public ExclusiveItemEffectEntry M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
