// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union bulk_item defined within pmdsky-debug.
    /// </summary>
    public partial class BulkItem : KaitaiStruct
    {
        public static BulkItem FromFile(string fileName)
        {
            return new BulkItem(new KaitaiStream(fileName));
        }

        public BulkItem(KaitaiStream p__io, KaitaiStruct p__parent = null, BulkItem p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _id = new ItemId16(m_io);
            _quantity = m_io.ReadU2le();
        }
        private ItemId16 _id;
        private ushort _quantity;
        private BulkItem m_root;
        private KaitaiStruct m_parent;
        public ItemId16 Id { get { return _id; } }
        public ushort Quantity { get { return _quantity; } }
        public BulkItem M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
