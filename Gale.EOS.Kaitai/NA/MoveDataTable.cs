// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union move_data_table defined within pmdsky-debug.
    /// </summary>
    public partial class MoveDataTable : KaitaiStruct
    {
        public static MoveDataTable FromFile(string fileName)
        {
            return new MoveDataTable(new KaitaiStream(fileName));
        }

        public MoveDataTable(KaitaiStream p__io, KaitaiStruct p__parent = null, MoveDataTable p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MoveDataTableEntriesArray(m_io);
        }
        private MoveDataTableEntriesArray _entries;
        private MoveDataTable m_root;
        private KaitaiStruct m_parent;
        public MoveDataTableEntriesArray Entries { get { return _entries; } }
        public MoveDataTable M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
