// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array TRAP_ANIMATION_INFO defined within pmdsky.
    /// </summary>
    public partial class TrapAnimationInfoArray : KaitaiStruct
    {
        public static TrapAnimationInfoArray FromFile(string fileName)
        {
            return new TrapAnimationInfoArray(new KaitaiStream(fileName));
        }

        public TrapAnimationInfoArray(KaitaiStream p__io, KaitaiStruct p__parent = null, TrapAnimationInfoArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new TrapAnimationInfoArrayDim0(m_io, this, m_root);
        }
        public partial class TrapAnimationInfoArrayDim0 : KaitaiStruct
        {
            public static TrapAnimationInfoArrayDim0 FromFile(string fileName)
            {
                return new TrapAnimationInfoArrayDim0(new KaitaiStream(fileName));
            }

            public TrapAnimationInfoArrayDim0(KaitaiStream p__io, TrapAnimationInfoArray p__parent = null, TrapAnimationInfoArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<TrapAnimation>();
                for (var i = 0; i < 26; i++)
                {
                    _entries.Add(new TrapAnimation(m_io));
                }
            }
            private List<TrapAnimation> _entries;
            private TrapAnimationInfoArray m_root;
            private TrapAnimationInfoArray m_parent;
            public List<TrapAnimation> Entries { get { return _entries; } }
            public TrapAnimationInfoArray M_Root { get { return m_root; } }
            public TrapAnimationInfoArray M_Parent { get { return m_parent; } }
        }
        private TrapAnimationInfoArrayDim0 _entries;
        private TrapAnimationInfoArray m_root;
        private KaitaiStruct m_parent;
        public TrapAnimationInfoArrayDim0 Entries { get { return _entries; } }
        public TrapAnimationInfoArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
