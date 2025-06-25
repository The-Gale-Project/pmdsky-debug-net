// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array EFFECT_ANIMATION_INFO defined within pmdsky.
    /// </summary>
    public partial class EffectAnimationInfoArray : KaitaiStruct
    {
        public static EffectAnimationInfoArray FromFile(string fileName)
        {
            return new EffectAnimationInfoArray(new KaitaiStream(fileName));
        }

        public EffectAnimationInfoArray(KaitaiStream p__io, KaitaiStruct p__parent = null, EffectAnimationInfoArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new EffectAnimationInfoArrayDim0(m_io, this, m_root);
        }
        public partial class EffectAnimationInfoArrayDim0 : KaitaiStruct
        {
            public static EffectAnimationInfoArrayDim0 FromFile(string fileName)
            {
                return new EffectAnimationInfoArrayDim0(new KaitaiStream(fileName));
            }

            public EffectAnimationInfoArrayDim0(KaitaiStream p__io, EffectAnimationInfoArray p__parent = null, EffectAnimationInfoArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<EffectAnimation>();
                for (var i = 0; i < 700; i++)
                {
                    _entries.Add(new EffectAnimation(m_io));
                }
            }
            private List<EffectAnimation> _entries;
            private EffectAnimationInfoArray m_root;
            private EffectAnimationInfoArray m_parent;
            public List<EffectAnimation> Entries { get { return _entries; } }
            public EffectAnimationInfoArray M_Root { get { return m_root; } }
            public EffectAnimationInfoArray M_Parent { get { return m_parent; } }
        }
        private EffectAnimationInfoArrayDim0 _entries;
        private EffectAnimationInfoArray m_root;
        private KaitaiStruct m_parent;
        public EffectAnimationInfoArrayDim0 Entries { get { return _entries; } }
        public EffectAnimationInfoArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
