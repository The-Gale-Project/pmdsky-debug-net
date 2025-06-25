// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array monster_summary_active_statuses defined within pmdsky.
    /// </summary>
    public partial class MonsterSummaryActiveStatusesArray : KaitaiStruct
    {
        public static MonsterSummaryActiveStatusesArray FromFile(string fileName)
        {
            return new MonsterSummaryActiveStatusesArray(new KaitaiStream(fileName));
        }

        public MonsterSummaryActiveStatusesArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MonsterSummaryActiveStatusesArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MonsterSummaryActiveStatusesArrayDim0(m_io, this, m_root);
        }
        public partial class MonsterSummaryActiveStatusesArrayDim0 : KaitaiStruct
        {
            public static MonsterSummaryActiveStatusesArrayDim0 FromFile(string fileName)
            {
                return new MonsterSummaryActiveStatusesArrayDim0(new KaitaiStream(fileName));
            }

            public MonsterSummaryActiveStatusesArrayDim0(KaitaiStream p__io, MonsterSummaryActiveStatusesArray p__parent = null, MonsterSummaryActiveStatusesArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<StatusId8>();
                for (var i = 0; i < 30; i++)
                {
                    _entries.Add(new StatusId8(m_io));
                }
            }
            private List<StatusId8> _entries;
            private MonsterSummaryActiveStatusesArray m_root;
            private MonsterSummaryActiveStatusesArray m_parent;
            public List<StatusId8> Entries { get { return _entries; } }
            public MonsterSummaryActiveStatusesArray M_Root { get { return m_root; } }
            public MonsterSummaryActiveStatusesArray M_Parent { get { return m_parent; } }
        }
        private MonsterSummaryActiveStatusesArrayDim0 _entries;
        private MonsterSummaryActiveStatusesArray m_root;
        private KaitaiStruct m_parent;
        public MonsterSummaryActiveStatusesArrayDim0 Entries { get { return _entries; } }
        public MonsterSummaryActiveStatusesArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
