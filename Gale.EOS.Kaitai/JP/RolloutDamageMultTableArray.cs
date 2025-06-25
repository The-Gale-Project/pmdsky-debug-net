// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array ROLLOUT_DAMAGE_MULT_TABLE defined within pmdsky.
    /// </summary>
    public partial class RolloutDamageMultTableArray : KaitaiStruct
    {
        public static RolloutDamageMultTableArray FromFile(string fileName)
        {
            return new RolloutDamageMultTableArray(new KaitaiStream(fileName));
        }

        public RolloutDamageMultTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, RolloutDamageMultTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new RolloutDamageMultTableArrayDim0(m_io, this, m_root);
        }
        public partial class RolloutDamageMultTableArrayDim0 : KaitaiStruct
        {
            public static RolloutDamageMultTableArrayDim0 FromFile(string fileName)
            {
                return new RolloutDamageMultTableArrayDim0(new KaitaiStream(fileName));
            }

            public RolloutDamageMultTableArrayDim0(KaitaiStream p__io, RolloutDamageMultTableArray p__parent = null, RolloutDamageMultTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<int>();
                for (var i = 0; i < 10; i++)
                {
                    _entries.Add(m_io.ReadS4le());
                }
            }
            private List<int> _entries;
            private RolloutDamageMultTableArray m_root;
            private RolloutDamageMultTableArray m_parent;
            public List<int> Entries { get { return _entries; } }
            public RolloutDamageMultTableArray M_Root { get { return m_root; } }
            public RolloutDamageMultTableArray M_Parent { get { return m_parent; } }
        }
        private RolloutDamageMultTableArrayDim0 _entries;
        private RolloutDamageMultTableArray m_root;
        private KaitaiStruct m_parent;
        public RolloutDamageMultTableArrayDim0 Entries { get { return _entries; } }
        public RolloutDamageMultTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
