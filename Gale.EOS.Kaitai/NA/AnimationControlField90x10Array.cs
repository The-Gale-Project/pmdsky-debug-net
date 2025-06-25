// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array animation_control_field9_0x10 defined within pmdsky.
    /// </summary>
    public partial class AnimationControlField90x10Array : KaitaiStruct
    {
        public static AnimationControlField90x10Array FromFile(string fileName)
        {
            return new AnimationControlField90x10Array(new KaitaiStream(fileName));
        }

        public AnimationControlField90x10Array(KaitaiStream p__io, KaitaiStruct p__parent = null, AnimationControlField90x10Array p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new AnimationControlField90x10ArrayDim0(m_io, this, m_root);
        }
        public partial class AnimationControlField90x10ArrayDim0 : KaitaiStruct
        {
            public static AnimationControlField90x10ArrayDim0 FromFile(string fileName)
            {
                return new AnimationControlField90x10ArrayDim0(new KaitaiStream(fileName));
            }

            public AnimationControlField90x10ArrayDim0(KaitaiStream p__io, AnimationControlField90x10Array p__parent = null, AnimationControlField90x10Array p__root = null) : base(p__io)
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
            private AnimationControlField90x10Array m_root;
            private AnimationControlField90x10Array m_parent;
            public List<ushort> Entries { get { return _entries; } }
            public AnimationControlField90x10Array M_Root { get { return m_root; } }
            public AnimationControlField90x10Array M_Parent { get { return m_parent; } }
        }
        private AnimationControlField90x10ArrayDim0 _entries;
        private AnimationControlField90x10Array m_root;
        private KaitaiStruct m_parent;
        public AnimationControlField90x10ArrayDim0 Entries { get { return _entries; } }
        public AnimationControlField90x10Array M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
