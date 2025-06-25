// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array SETANIMATION_TABLE defined within pmdsky.
    /// </summary>
    public partial class SetanimationTableArray : KaitaiStruct
    {
        public static SetanimationTableArray FromFile(string fileName)
        {
            return new SetanimationTableArray(new KaitaiStream(fileName));
        }

        public SetanimationTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, SetanimationTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new SetanimationTableArrayDim0(m_io, this, m_root);
        }
        public partial class SetanimationTableArrayDim0 : KaitaiStruct
        {
            public static SetanimationTableArrayDim0 FromFile(string fileName)
            {
                return new SetanimationTableArrayDim0(new KaitaiStream(fileName));
            }

            public SetanimationTableArrayDim0(KaitaiStream p__io, SetanimationTableArray p__parent = null, SetanimationTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<AnimationData>();
                for (var i = 0; i < 84; i++)
                {
                    _entries.Add(new AnimationData(m_io));
                }
            }
            private List<AnimationData> _entries;
            private SetanimationTableArray m_root;
            private SetanimationTableArray m_parent;
            public List<AnimationData> Entries { get { return _entries; } }
            public SetanimationTableArray M_Root { get { return m_root; } }
            public SetanimationTableArray M_Parent { get { return m_parent; } }
        }
        private SetanimationTableArrayDim0 _entries;
        private SetanimationTableArray m_root;
        private KaitaiStruct m_parent;
        public SetanimationTableArrayDim0 Entries { get { return _entries; } }
        public SetanimationTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
