// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array EXCL_ITEM_EFFECTS_EVASION_BOOST defined within pmdsky.
    /// </summary>
    public partial class ExclItemEffectsEvasionBoostArray : KaitaiStruct
    {
        public static ExclItemEffectsEvasionBoostArray FromFile(string fileName)
        {
            return new ExclItemEffectsEvasionBoostArray(new KaitaiStream(fileName));
        }

        public ExclItemEffectsEvasionBoostArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ExclItemEffectsEvasionBoostArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ExclItemEffectsEvasionBoostArrayDim0(m_io, this, m_root);
        }
        public partial class ExclItemEffectsEvasionBoostArrayDim0 : KaitaiStruct
        {
            public static ExclItemEffectsEvasionBoostArrayDim0 FromFile(string fileName)
            {
                return new ExclItemEffectsEvasionBoostArrayDim0(new KaitaiStream(fileName));
            }

            public ExclItemEffectsEvasionBoostArrayDim0(KaitaiStream p__io, ExclItemEffectsEvasionBoostArray p__parent = null, ExclItemEffectsEvasionBoostArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<ExclusiveItemEffectId8>();
                for (var i = 0; i < 8; i++)
                {
                    _entries.Add(new ExclusiveItemEffectId8(m_io));
                }
            }
            private List<ExclusiveItemEffectId8> _entries;
            private ExclItemEffectsEvasionBoostArray m_root;
            private ExclItemEffectsEvasionBoostArray m_parent;
            public List<ExclusiveItemEffectId8> Entries { get { return _entries; } }
            public ExclItemEffectsEvasionBoostArray M_Root { get { return m_root; } }
            public ExclItemEffectsEvasionBoostArray M_Parent { get { return m_parent; } }
        }
        private ExclItemEffectsEvasionBoostArrayDim0 _entries;
        private ExclItemEffectsEvasionBoostArray m_root;
        private KaitaiStruct m_parent;
        public ExclItemEffectsEvasionBoostArrayDim0 Entries { get { return _entries; } }
        public ExclItemEffectsEvasionBoostArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
