// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array ERUPTION_DAMAGE_MULT_TABLE defined within pmdsky.
    /// </summary>
    public partial class EruptionDamageMultTableArray : KaitaiStruct
    {
        public static EruptionDamageMultTableArray FromFile(string fileName)
        {
            return new EruptionDamageMultTableArray(new KaitaiStream(fileName));
        }

        public EruptionDamageMultTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, EruptionDamageMultTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new EruptionDamageMultTableArrayDim0(m_io, this, m_root);
        }
        public partial class EruptionDamageMultTableArrayDim0 : KaitaiStruct
        {
            public static EruptionDamageMultTableArrayDim0 FromFile(string fileName)
            {
                return new EruptionDamageMultTableArrayDim0(new KaitaiStream(fileName));
            }

            public EruptionDamageMultTableArrayDim0(KaitaiStream p__io, EruptionDamageMultTableArray p__parent = null, EruptionDamageMultTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<int>();
                for (var i = 0; i < 4; i++)
                {
                    _entries.Add(m_io.ReadS4le());
                }
            }
            private List<int> _entries;
            private EruptionDamageMultTableArray m_root;
            private EruptionDamageMultTableArray m_parent;
            public List<int> Entries { get { return _entries; } }
            public EruptionDamageMultTableArray M_Root { get { return m_root; } }
            public EruptionDamageMultTableArray M_Parent { get { return m_parent; } }
        }
        private EruptionDamageMultTableArrayDim0 _entries;
        private EruptionDamageMultTableArray m_root;
        private KaitaiStruct m_parent;
        public EruptionDamageMultTableArrayDim0 Entries { get { return _entries; } }
        public EruptionDamageMultTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
