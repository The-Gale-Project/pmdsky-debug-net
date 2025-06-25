// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array EXCLUSIVE_ITEM_STAT_BOOST_DATA defined within pmdsky.
    /// </summary>
    public partial class ExclusiveItemStatBoostDataArray : KaitaiStruct
    {
        public static ExclusiveItemStatBoostDataArray FromFile(string fileName)
        {
            return new ExclusiveItemStatBoostDataArray(new KaitaiStream(fileName));
        }

        public ExclusiveItemStatBoostDataArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ExclusiveItemStatBoostDataArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ExclusiveItemStatBoostDataArrayDim0(m_io, this, m_root);
        }
        public partial class ExclusiveItemStatBoostDataArrayDim0 : KaitaiStruct
        {
            public static ExclusiveItemStatBoostDataArrayDim0 FromFile(string fileName)
            {
                return new ExclusiveItemStatBoostDataArrayDim0(new KaitaiStream(fileName));
            }

            public ExclusiveItemStatBoostDataArrayDim0(KaitaiStream p__io, ExclusiveItemStatBoostDataArray p__parent = null, ExclusiveItemStatBoostDataArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<ExclusiveItemStatBoostEntry>();
                for (var i = 0; i < 15; i++)
                {
                    _entries.Add(new ExclusiveItemStatBoostEntry(m_io));
                }
            }
            private List<ExclusiveItemStatBoostEntry> _entries;
            private ExclusiveItemStatBoostDataArray m_root;
            private ExclusiveItemStatBoostDataArray m_parent;
            public List<ExclusiveItemStatBoostEntry> Entries { get { return _entries; } }
            public ExclusiveItemStatBoostDataArray M_Root { get { return m_root; } }
            public ExclusiveItemStatBoostDataArray M_Parent { get { return m_parent; } }
        }
        private ExclusiveItemStatBoostDataArrayDim0 _entries;
        private ExclusiveItemStatBoostDataArray m_root;
        private KaitaiStruct m_parent;
        public ExclusiveItemStatBoostDataArrayDim0 Entries { get { return _entries; } }
        public ExclusiveItemStatBoostDataArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
