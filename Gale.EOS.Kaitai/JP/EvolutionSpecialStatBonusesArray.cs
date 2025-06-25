// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array EVOLUTION_SPECIAL_STAT_BONUSES defined within pmdsky.
    /// </summary>
    public partial class EvolutionSpecialStatBonusesArray : KaitaiStruct
    {
        public static EvolutionSpecialStatBonusesArray FromFile(string fileName)
        {
            return new EvolutionSpecialStatBonusesArray(new KaitaiStream(fileName));
        }

        public EvolutionSpecialStatBonusesArray(KaitaiStream p__io, KaitaiStruct p__parent = null, EvolutionSpecialStatBonusesArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new EvolutionSpecialStatBonusesArrayDim0(m_io, this, m_root);
        }
        public partial class EvolutionSpecialStatBonusesArrayDim0 : KaitaiStruct
        {
            public static EvolutionSpecialStatBonusesArrayDim0 FromFile(string fileName)
            {
                return new EvolutionSpecialStatBonusesArrayDim0(new KaitaiStream(fileName));
            }

            public EvolutionSpecialStatBonusesArrayDim0(KaitaiStream p__io, EvolutionSpecialStatBonusesArray p__parent = null, EvolutionSpecialStatBonusesArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<short>();
                for (var i = 0; i < 2; i++)
                {
                    _entries.Add(m_io.ReadS2le());
                }
            }
            private List<short> _entries;
            private EvolutionSpecialStatBonusesArray m_root;
            private EvolutionSpecialStatBonusesArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public EvolutionSpecialStatBonusesArray M_Root { get { return m_root; } }
            public EvolutionSpecialStatBonusesArray M_Parent { get { return m_parent; } }
        }
        private EvolutionSpecialStatBonusesArrayDim0 _entries;
        private EvolutionSpecialStatBonusesArray m_root;
        private KaitaiStruct m_parent;
        public EvolutionSpecialStatBonusesArrayDim0 Entries { get { return _entries; } }
        public EvolutionSpecialStatBonusesArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
