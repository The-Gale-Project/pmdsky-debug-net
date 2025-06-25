// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array MOVE_ANIMATION_INFO defined within pmdsky.
    /// </summary>
    public partial class MoveAnimationInfoArray : KaitaiStruct
    {
        public static MoveAnimationInfoArray FromFile(string fileName)
        {
            return new MoveAnimationInfoArray(new KaitaiStream(fileName));
        }

        public MoveAnimationInfoArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MoveAnimationInfoArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MoveAnimationInfoArrayDim0(m_io, this, m_root);
        }
        public partial class MoveAnimationInfoArrayDim0 : KaitaiStruct
        {
            public static MoveAnimationInfoArrayDim0 FromFile(string fileName)
            {
                return new MoveAnimationInfoArrayDim0(new KaitaiStream(fileName));
            }

            public MoveAnimationInfoArrayDim0(KaitaiStream p__io, MoveAnimationInfoArray p__parent = null, MoveAnimationInfoArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<MoveAnimation>();
                for (var i = 0; i < 563; i++)
                {
                    _entries.Add(new MoveAnimation(m_io));
                }
            }
            private List<MoveAnimation> _entries;
            private MoveAnimationInfoArray m_root;
            private MoveAnimationInfoArray m_parent;
            public List<MoveAnimation> Entries { get { return _entries; } }
            public MoveAnimationInfoArray M_Root { get { return m_root; } }
            public MoveAnimationInfoArray M_Parent { get { return m_parent; } }
        }
        private MoveAnimationInfoArrayDim0 _entries;
        private MoveAnimationInfoArray m_root;
        private KaitaiStruct m_parent;
        public MoveAnimationInfoArrayDim0 Entries { get { return _entries; } }
        public MoveAnimationInfoArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
