// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array animation_field_0x0 defined within pmdsky.
    /// </summary>
    public partial class AnimationField0x0Array : KaitaiStruct
    {
        public static AnimationField0x0Array FromFile(string fileName)
        {
            return new AnimationField0x0Array(new KaitaiStream(fileName));
        }

        public AnimationField0x0Array(KaitaiStream p__io, KaitaiStruct p__parent = null, AnimationField0x0Array p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new AnimationField0x0ArrayDim0(m_io, this, m_root);
        }
        public partial class AnimationField0x0ArrayDim0 : KaitaiStruct
        {
            public static AnimationField0x0ArrayDim0 FromFile(string fileName)
            {
                return new AnimationField0x0ArrayDim0(new KaitaiStream(fileName));
            }

            public AnimationField0x0ArrayDim0(KaitaiStream p__io, AnimationField0x0Array p__parent = null, AnimationField0x0Array p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<ushort>();
                for (var i = 0; i < 6; i++)
                {
                    _entries.Add(m_io.ReadU2le());
                }
            }
            private List<ushort> _entries;
            private AnimationField0x0Array m_root;
            private AnimationField0x0Array m_parent;
            public List<ushort> Entries { get { return _entries; } }
            public AnimationField0x0Array M_Root { get { return m_root; } }
            public AnimationField0x0Array M_Parent { get { return m_parent; } }
        }
        private AnimationField0x0ArrayDim0 _entries;
        private AnimationField0x0Array m_root;
        private KaitaiStruct m_parent;
        public AnimationField0x0ArrayDim0 Entries { get { return _entries; } }
        public AnimationField0x0Array M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
