// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array SPECIAL_MONSTER_MOVE_ANIMATION_INFO defined within pmdsky.
    /// </summary>
    public partial class SpecialMonsterMoveAnimationInfoArray : KaitaiStruct
    {
        public static SpecialMonsterMoveAnimationInfoArray FromFile(string fileName)
        {
            return new SpecialMonsterMoveAnimationInfoArray(new KaitaiStream(fileName));
        }

        public SpecialMonsterMoveAnimationInfoArray(KaitaiStream p__io, KaitaiStruct p__parent = null, SpecialMonsterMoveAnimationInfoArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new SpecialMonsterMoveAnimationInfoArrayDim0(m_io, this, m_root);
        }
        public partial class SpecialMonsterMoveAnimationInfoArrayDim0 : KaitaiStruct
        {
            public static SpecialMonsterMoveAnimationInfoArrayDim0 FromFile(string fileName)
            {
                return new SpecialMonsterMoveAnimationInfoArrayDim0(new KaitaiStream(fileName));
            }

            public SpecialMonsterMoveAnimationInfoArrayDim0(KaitaiStream p__io, SpecialMonsterMoveAnimationInfoArray p__parent = null, SpecialMonsterMoveAnimationInfoArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<SpecialMonsterMoveAnimation>();
                for (var i = 0; i < 7422; i++)
                {
                    _entries.Add(new SpecialMonsterMoveAnimation(m_io));
                }
            }
            private List<SpecialMonsterMoveAnimation> _entries;
            private SpecialMonsterMoveAnimationInfoArray m_root;
            private SpecialMonsterMoveAnimationInfoArray m_parent;
            public List<SpecialMonsterMoveAnimation> Entries { get { return _entries; } }
            public SpecialMonsterMoveAnimationInfoArray M_Root { get { return m_root; } }
            public SpecialMonsterMoveAnimationInfoArray M_Parent { get { return m_parent; } }
        }
        private SpecialMonsterMoveAnimationInfoArrayDim0 _entries;
        private SpecialMonsterMoveAnimationInfoArray m_root;
        private KaitaiStruct m_parent;
        public SpecialMonsterMoveAnimationInfoArrayDim0 Entries { get { return _entries; } }
        public SpecialMonsterMoveAnimationInfoArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
