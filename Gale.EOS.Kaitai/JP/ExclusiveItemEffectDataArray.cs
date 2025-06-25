// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array EXCLUSIVE_ITEM_EFFECT_DATA defined within pmdsky.
    /// </summary>
    public partial class ExclusiveItemEffectDataArray : KaitaiStruct
    {
        public static ExclusiveItemEffectDataArray FromFile(string fileName)
        {
            return new ExclusiveItemEffectDataArray(new KaitaiStream(fileName));
        }

        public ExclusiveItemEffectDataArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ExclusiveItemEffectDataArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ExclusiveItemEffectDataArrayDim0(m_io, this, m_root);
        }
        public partial class ExclusiveItemEffectDataArrayDim0 : KaitaiStruct
        {
            public static ExclusiveItemEffectDataArrayDim0 FromFile(string fileName)
            {
                return new ExclusiveItemEffectDataArrayDim0(new KaitaiStream(fileName));
            }

            public ExclusiveItemEffectDataArrayDim0(KaitaiStream p__io, ExclusiveItemEffectDataArray p__parent = null, ExclusiveItemEffectDataArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<ExclusiveItemEffectEntry>();
                for (var i = 0; i < 956; i++)
                {
                    _entries.Add(new ExclusiveItemEffectEntry(m_io));
                }
            }
            private List<ExclusiveItemEffectEntry> _entries;
            private ExclusiveItemEffectDataArray m_root;
            private ExclusiveItemEffectDataArray m_parent;
            public List<ExclusiveItemEffectEntry> Entries { get { return _entries; } }
            public ExclusiveItemEffectDataArray M_Root { get { return m_root; } }
            public ExclusiveItemEffectDataArray M_Parent { get { return m_parent; } }
        }
        private ExclusiveItemEffectDataArrayDim0 _entries;
        private ExclusiveItemEffectDataArray m_root;
        private KaitaiStruct m_parent;
        public ExclusiveItemEffectDataArrayDim0 Entries { get { return _entries; } }
        public ExclusiveItemEffectDataArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
