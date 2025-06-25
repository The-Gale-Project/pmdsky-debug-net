// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array move_data_table_entries defined within pmdsky.
    /// </summary>
    public partial class MoveDataTableEntriesArray : KaitaiStruct
    {
        public static MoveDataTableEntriesArray FromFile(string fileName)
        {
            return new MoveDataTableEntriesArray(new KaitaiStream(fileName));
        }

        public MoveDataTableEntriesArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MoveDataTableEntriesArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MoveDataTableEntriesArrayDim0(m_io, this, m_root);
        }
        public partial class MoveDataTableEntriesArrayDim0 : KaitaiStruct
        {
            public static MoveDataTableEntriesArrayDim0 FromFile(string fileName)
            {
                return new MoveDataTableEntriesArrayDim0(new KaitaiStream(fileName));
            }

            public MoveDataTableEntriesArrayDim0(KaitaiStream p__io, MoveDataTableEntriesArray p__parent = null, MoveDataTableEntriesArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<MoveData>();
                for (var i = 0; i < 559; i++)
                {
                    _entries.Add(new MoveData(m_io));
                }
            }
            private List<MoveData> _entries;
            private MoveDataTableEntriesArray m_root;
            private MoveDataTableEntriesArray m_parent;
            public List<MoveData> Entries { get { return _entries; } }
            public MoveDataTableEntriesArray M_Root { get { return m_root; } }
            public MoveDataTableEntriesArray M_Parent { get { return m_parent; } }
        }
        private MoveDataTableEntriesArrayDim0 _entries;
        private MoveDataTableEntriesArray m_root;
        private KaitaiStruct m_parent;
        public MoveDataTableEntriesArrayDim0 Entries { get { return _entries; } }
        public MoveDataTableEntriesArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
