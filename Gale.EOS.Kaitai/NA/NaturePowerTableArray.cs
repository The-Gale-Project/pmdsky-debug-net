// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array NATURE_POWER_TABLE defined within pmdsky.
    /// </summary>
    public partial class NaturePowerTableArray : KaitaiStruct
    {
        public static NaturePowerTableArray FromFile(string fileName)
        {
            return new NaturePowerTableArray(new KaitaiStream(fileName));
        }

        public NaturePowerTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, NaturePowerTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new NaturePowerTableArrayDim0(m_io, this, m_root);
        }
        public partial class NaturePowerTableArrayDim0 : KaitaiStruct
        {
            public static NaturePowerTableArrayDim0 FromFile(string fileName)
            {
                return new NaturePowerTableArrayDim0(new KaitaiStream(fileName));
            }

            public NaturePowerTableArrayDim0(KaitaiStream p__io, NaturePowerTableArray p__parent = null, NaturePowerTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<WildcardMoveDesc>();
                for (var i = 0; i < 15; i++)
                {
                    _entries.Add(new WildcardMoveDesc(m_io));
                }
            }
            private List<WildcardMoveDesc> _entries;
            private NaturePowerTableArray m_root;
            private NaturePowerTableArray m_parent;
            public List<WildcardMoveDesc> Entries { get { return _entries; } }
            public NaturePowerTableArray M_Root { get { return m_root; } }
            public NaturePowerTableArray M_Parent { get { return m_parent; } }
        }
        private NaturePowerTableArrayDim0 _entries;
        private NaturePowerTableArray m_root;
        private KaitaiStruct m_parent;
        public NaturePowerTableArrayDim0 Entries { get { return _entries; } }
        public NaturePowerTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
