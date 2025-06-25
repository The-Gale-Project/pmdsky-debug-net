// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union effect_animation defined within pmdsky-debug.
    /// </summary>
    public partial class EffectAnimation : KaitaiStruct
    {
        public static EffectAnimation FromFile(string fileName)
        {
            return new EffectAnimation(new KaitaiStream(fileName));
        }

        public EffectAnimation(KaitaiStream p__io, KaitaiStruct p__parent = null, EffectAnimation p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _field0x0 = m_io.ReadS4le();
            _fileIndex = m_io.ReadS4le();
            _field0x8 = m_io.ReadS4le();
            _animationIndex = m_io.ReadS4le();
            _seId = m_io.ReadS4le();
            _field0x14 = m_io.ReadS4le();
            _field0x18 = m_io.ReadU1();
            _field0x19 = m_io.ReadS1();
            _isNonBlocking = m_io.ReadU1();
            _unkRepeat = m_io.ReadU1();
        }
        private int _field0x0;
        private int _fileIndex;
        private int _field0x8;
        private int _animationIndex;
        private int _seId;
        private int _field0x14;
        private byte _field0x18;
        private sbyte _field0x19;
        private byte _isNonBlocking;
        private byte _unkRepeat;
        private EffectAnimation m_root;
        private KaitaiStruct m_parent;
        public int Field0x0 { get { return _field0x0; } }
        public int FileIndex { get { return _fileIndex; } }
        public int Field0x8 { get { return _field0x8; } }
        public int AnimationIndex { get { return _animationIndex; } }
        public int SeId { get { return _seId; } }
        public int Field0x14 { get { return _field0x14; } }
        public byte Field0x18 { get { return _field0x18; } }
        public sbyte Field0x19 { get { return _field0x19; } }
        public byte IsNonBlocking { get { return _isNonBlocking; } }
        public byte UnkRepeat { get { return _unkRepeat; } }
        public EffectAnimation M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
