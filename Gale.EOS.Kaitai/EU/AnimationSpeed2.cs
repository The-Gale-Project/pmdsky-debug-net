// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Holds bitsized data for the parent enum animation_speed.
    /// </summary>
    public partial class AnimationSpeed2 : KaitaiStruct
    {
        public static AnimationSpeed2 FromFile(string fileName)
        {
            return new AnimationSpeed2(new KaitaiStream(fileName));
        }


        public enum AnimationSpeed2Enum
        {
            AnimationSpeedNormal = 0,
            AnimationSpeedSlow = 1,
            AnimationSpeedFast = 2,
            AnimationSpeedFreeze = 3,
        }
        public AnimationSpeed2(KaitaiStream p__io, KaitaiStruct p__parent = null, AnimationSpeed2 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _animationSpeed2Value = ((AnimationSpeed2Enum) m_io.ReadBitsIntLe(2));
        }
        private AnimationSpeed2Enum _animationSpeed2Value;
        private AnimationSpeed2 m_root;
        private KaitaiStruct m_parent;
        public AnimationSpeed2Enum AnimationSpeed2Value { get { return _animationSpeed2Value; } }
        public AnimationSpeed2 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
