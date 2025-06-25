// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union animation_data defined within pmdsky-debug.
    /// </summary>
    public partial class AnimationData : KaitaiStruct
    {
        public static AnimationData FromFile(string fileName)
        {
            return new AnimationData(new KaitaiStream(fileName));
        }

        public AnimationData(KaitaiStream p__io, KaitaiStruct p__parent = null, AnimationData p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _animationId = m_io.ReadU1();
            _animationSpeed = new AnimationSpeed2(m_io);
            _fUnk1 = m_io.ReadBitsIntLe(1) != 0;
            _loop = m_io.ReadBitsIntLe(1) != 0;
            _fUnk3 = m_io.ReadBitsIntLe(1) != 0;
            _fUnused = m_io.ReadBitsIntLe(3);
        }
        private byte _animationId;
        private AnimationSpeed2 _animationSpeed;
        private bool _fUnk1;
        private bool _loop;
        private bool _fUnk3;
        private ulong _fUnused;
        private AnimationData m_root;
        private KaitaiStruct m_parent;
        public byte AnimationId { get { return _animationId; } }
        public AnimationSpeed2 AnimationSpeed { get { return _animationSpeed; } }
        public bool FUnk1 { get { return _fUnk1; } }
        public bool Loop { get { return _loop; } }
        public bool FUnk3 { get { return _fUnk3; } }
        public ulong FUnused { get { return _fUnused; } }
        public AnimationData M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
