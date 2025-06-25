// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union entity_table_hdr defined within pmdsky-debug.
    /// </summary>
    public partial class EntityTableHdr : KaitaiStruct
    {
        public static EntityTableHdr FromFile(string fileName)
        {
            return new EntityTableHdr(new KaitaiStream(fileName));
        }

        public EntityTableHdr(KaitaiStream p__io, KaitaiStruct p__parent = null, EntityTableHdr p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _monsterSlotPtrs = new EntityTableHdrMonsterSlotPtrsArray(m_io);
            _activeMonsterPtrs = new EntityTableHdrActiveMonsterPtrsArray(m_io);
            _itemPtrs = new EntityTableHdrItemPtrsArray(m_io);
            _trapPtrs = new EntityTableHdrTrapPtrsArray(m_io);
            _hiddenStairsPtr = new Pointer(m_io);
        }
        private EntityTableHdrMonsterSlotPtrsArray _monsterSlotPtrs;
        private EntityTableHdrActiveMonsterPtrsArray _activeMonsterPtrs;
        private EntityTableHdrItemPtrsArray _itemPtrs;
        private EntityTableHdrTrapPtrsArray _trapPtrs;
        private Pointer _hiddenStairsPtr;
        private EntityTableHdr m_root;
        private KaitaiStruct m_parent;
        public EntityTableHdrMonsterSlotPtrsArray MonsterSlotPtrs { get { return _monsterSlotPtrs; } }
        public EntityTableHdrActiveMonsterPtrsArray ActiveMonsterPtrs { get { return _activeMonsterPtrs; } }
        public EntityTableHdrItemPtrsArray ItemPtrs { get { return _itemPtrs; } }
        public EntityTableHdrTrapPtrsArray TrapPtrs { get { return _trapPtrs; } }
        public Pointer HiddenStairsPtr { get { return _hiddenStairsPtr; } }
        public EntityTableHdr M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
