// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array animation_fields defined within pmdsky.
    /// </summary>
    public partial class AnimationFieldsArray : KaitaiStruct
    {
        public static AnimationFieldsArray FromFile(string fileName)
        {
            return new AnimationFieldsArray(new KaitaiStream(fileName));
        }

        public AnimationFieldsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, AnimationFieldsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new AnimationFieldsArrayDim0(m_io, this, m_root);
        }
        public partial class AnimationFieldsArrayDim0 : KaitaiStruct
        {
            public static AnimationFieldsArrayDim0 FromFile(string fileName)
            {
                return new AnimationFieldsArrayDim0(new KaitaiStream(fileName));
            }

            public AnimationFieldsArrayDim0(KaitaiStream p__io, AnimationFieldsArray p__parent = null, AnimationFieldsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<byte>();
                for (var i = 0; i < 60; i++)
                {
                    _entries.Add(m_io.ReadU1());
                }
            }
            private List<byte> _entries;
            private AnimationFieldsArray m_root;
            private AnimationFieldsArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public AnimationFieldsArray M_Root { get { return m_root; } }
            public AnimationFieldsArray M_Parent { get { return m_parent; } }
        }
        private AnimationFieldsArrayDim0 _entries;
        private AnimationFieldsArray m_root;
        private KaitaiStruct m_parent;
        public AnimationFieldsArrayDim0 Entries { get { return _entries; } }
        public AnimationFieldsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
