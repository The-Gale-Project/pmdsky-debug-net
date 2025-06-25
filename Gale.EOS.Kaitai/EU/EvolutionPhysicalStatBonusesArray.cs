// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array EVOLUTION_PHYSICAL_STAT_BONUSES defined within pmdsky.
    /// </summary>
    public partial class EvolutionPhysicalStatBonusesArray : KaitaiStruct
    {
        public static EvolutionPhysicalStatBonusesArray FromFile(string fileName)
        {
            return new EvolutionPhysicalStatBonusesArray(new KaitaiStream(fileName));
        }

        public EvolutionPhysicalStatBonusesArray(KaitaiStream p__io, KaitaiStruct p__parent = null, EvolutionPhysicalStatBonusesArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new EvolutionPhysicalStatBonusesArrayDim0(m_io, this, m_root);
        }
        public partial class EvolutionPhysicalStatBonusesArrayDim0 : KaitaiStruct
        {
            public static EvolutionPhysicalStatBonusesArrayDim0 FromFile(string fileName)
            {
                return new EvolutionPhysicalStatBonusesArrayDim0(new KaitaiStream(fileName));
            }

            public EvolutionPhysicalStatBonusesArrayDim0(KaitaiStream p__io, EvolutionPhysicalStatBonusesArray p__parent = null, EvolutionPhysicalStatBonusesArray p__root = null) : base(p__io)
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
            private EvolutionPhysicalStatBonusesArray m_root;
            private EvolutionPhysicalStatBonusesArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public EvolutionPhysicalStatBonusesArray M_Root { get { return m_root; } }
            public EvolutionPhysicalStatBonusesArray M_Parent { get { return m_parent; } }
        }
        private EvolutionPhysicalStatBonusesArrayDim0 _entries;
        private EvolutionPhysicalStatBonusesArray m_root;
        private KaitaiStruct m_parent;
        public EvolutionPhysicalStatBonusesArrayDim0 Entries { get { return _entries; } }
        public EvolutionPhysicalStatBonusesArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
