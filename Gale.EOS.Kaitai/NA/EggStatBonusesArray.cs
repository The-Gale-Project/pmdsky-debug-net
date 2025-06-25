// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array EGG_STAT_BONUSES defined within pmdsky.
    /// </summary>
    public partial class EggStatBonusesArray : KaitaiStruct
    {
        public static EggStatBonusesArray FromFile(string fileName)
        {
            return new EggStatBonusesArray(new KaitaiStream(fileName));
        }

        public EggStatBonusesArray(KaitaiStream p__io, KaitaiStruct p__parent = null, EggStatBonusesArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new EggStatBonusesArrayDim0(m_io, this, m_root);
        }
        public partial class EggStatBonusesArrayDim0 : KaitaiStruct
        {
            public static EggStatBonusesArrayDim0 FromFile(string fileName)
            {
                return new EggStatBonusesArrayDim0(new KaitaiStream(fileName));
            }

            public EggStatBonusesArrayDim0(KaitaiStream p__io, EggStatBonusesArray p__parent = null, EggStatBonusesArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<short>();
                for (var i = 0; i < 4; i++)
                {
                    _entries.Add(m_io.ReadS2le());
                }
            }
            private List<short> _entries;
            private EggStatBonusesArray m_root;
            private EggStatBonusesArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public EggStatBonusesArray M_Root { get { return m_root; } }
            public EggStatBonusesArray M_Parent { get { return m_parent; } }
        }
        private EggStatBonusesArrayDim0 _entries;
        private EggStatBonusesArray m_root;
        private KaitaiStruct m_parent;
        public EggStatBonusesArrayDim0 Entries { get { return _entries; } }
        public EggStatBonusesArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
